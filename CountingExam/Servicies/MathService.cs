using System;
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
                default:
                    return actualResult;
            }
        }

        public static double GenerateNumberForAction(Operations operation, Random r, int top)
        {
            switch (operation)
            {
                case Operations.Plus:
                    return r.Next(0,top);
                case Operations.Minus:
                    return r.Next(0,top);
                case Operations.Divide:
                    return r.Next(0,10);
                case Operations.Times:
                    return r.Next(0,10);
                default:
                    return r.Next(0,top);
            }
        }
    }
}