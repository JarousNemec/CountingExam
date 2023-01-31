using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using CountingExam.Models;

namespace CountingExam.Servicies
{
    public class MathService
    {
        public static double Operate(CountingAction action, double actualResult)
        {
            switch (action.Operation)
            {
                case Operations.Plus:
                    return actualResult + action.Number;
                case Operations.Minus:
                    return actualResult - action.Number;
                case Operations.Divide:
                    return actualResult / action.Number;
                case Operations.Times:
                    return actualResult * action.Number;
                case Operations.Power:
                    return Math.Pow(actualResult, 2);
                case Operations.SquareRoot:
                    return Math.Sqrt(actualResult);
                case Operations.Modulo:
                    return actualResult % 2;
                default:
                    return actualResult;
            }
        }

        private Operations GenerateOperation(Difficulties difficulty, Random r, double tempRes)
        {
            Operations op;
            switch (difficulty)
            {
                case Difficulties.Kindergarten:
                    op = (Operations)r.Next((int)Operations.Plus, (int)Operations.Divide);
                    break;
                case Difficulties.PrimarySchool:
                {
                    op = ChosseOperationByWeight(r, new[] { 1, 1, 2, 2, 0, 0, 0 });
                    break;
                }

                case Difficulties.HighSchool:
                {
                    op = ChosseOperationByWeight(r, new[] { 1, 1, 1, 1, 25, 25, 0 });
                    break;
                }

                case Difficulties.University:
                {
                    op = ChosseOperationByWeight(r, new[] { 1, 1, 2, 2, 25, 15, 1 });
                    break;
                }
                default:
                    op = (Operations)r.Next((int)Operations.Plus, (int)Operations.Divide);
                    break;
            }

            return op;
        }

        private Operations ChosseOperationByWeight(Random r, int[] weights)
        {
            int sum = weights.Sum();
            int[] chances = new int[sum];
            int index = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                for (int j = 0; j < weights[i]; j++)
                {
                    chances[index] = i;
                    index++;
                }
            }

            return (Operations)chances[r.Next(0, sum)];
        }

        private bool _lastSqrt = false;
        private bool _lastPow = false;

        private CountingAction GenerateAction(Random r, int top, Difficulties difficulty, double tempRes)
        {
            againOperation:
            var operation = GenerateOperation(difficulty, r, tempRes);
            double num;
            var tries = 0;
            const int maxTries = 50;
            switch (operation)
            {
                case Operations.Plus:
                    againPlus:
                    num = r.Next(0, top + 1);
                    break;
                case Operations.Minus:
                    againMinus:
                    num = r.Next(3, top + 1);
                    if (tempRes - num < -50)
                    {
                        if (tries > maxTries)
                        {
                            goto againPlus;
                        }

                        tries++;
                        goto againMinus;
                    }

                    break;
                case Operations.Divide:
                    againDivide:
                    num = r.Next(2, 11);
                    if ((tempRes / num) % 1 != 0 || tempRes == 0)
                    {
                        if (tries > maxTries)
                        {
                            difficulty = Difficulties.Kindergarten;
                            goto againOperation;
                        }

                        tries++;
                        goto againDivide;
                    }

                    break;
                case Operations.Times:
                    againTimes:
                    num = r.Next(2, 11);
                    if (tempRes * num > 1000 || tempRes * num < 150 || tempRes == 1 || tempRes == 0)
                    {
                        if (tries > maxTries)
                        {
                            difficulty = Difficulties.Kindergarten;
                            goto againOperation;
                        }

                        tries++;
                        goto againTimes;
                    }

                    break;
                case Operations.Power:
                    num = -1;
                    if (tempRes > 25 || tempRes < -25 || _lastSqrt || tempRes == 1 || tempRes == 0)
                        goto againOperation;
                    break;
                case Operations.SquareRoot:
                    num = -1;
                    if (Math.Sqrt(tempRes) % 1 != 0 || _lastPow || tempRes == 1 || tempRes == 0)
                        goto againOperation;
                    break;
                case Operations.Modulo:
                    num = -1;
                    if (tempRes == 1)
                        goto againOperation;
                    break;
                default:
                    num = r.Next(0, top);
                    break;
            }

            _lastSqrt = operation == Operations.SquareRoot;
            _lastPow = operation == Operations.Power;
            return new CountingAction(num, operation) { temp = tempRes };
        }


        public List<CountingAction> GenerateActions(Difficulties diff, int top, int count)
        {
            var r = new Random();
            var actions = new List<CountingAction>();

            double tempRes = 0;

            for (var i = 0; i < count; i++)
            {
                var action = GenerateAction(r, top, diff, tempRes);
                tempRes = Operate(action, tempRes);
                actions.Add(action);
            }

            return actions;
        }
    }
}