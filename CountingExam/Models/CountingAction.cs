using System;

namespace CountingExam.Models
{
    public class CountingAction
    {
        public CountingAction(double number, Operations operations)
        {
            Number = number;
            Operation = operations;
        }

        public double temp { get; set; }
        public Operations Operation { get; set; } = Operations.Plus;
        public double Number { get; set; }
        public override string ToString()
        {
            string operation;
            switch (Operation)
            {
                case Operations.Plus:
                    operation = "+ ";
                    break;
                case Operations.Minus:
                    operation = "- ";
                    break;
                case Operations.Divide:
                    operation = "/ ";
                    break;
                case Operations.Times:
                    operation = "* ";
                    break;
                case Operations.Power:
                    operation = "n²";
                    break;
                case Operations.SquareRoot:
                    operation = "√n";
                    break;
                case Operations.Modulo:
                    operation = "mod(2)";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            // return $"{operation} {(Number == -1 ? "" : Number.ToString())} : {temp}";
            return $"{operation} {(Number == -1 ? "" : Number.ToString())}";
        }

        public string ToSpeech()
        {
            string operation;
            switch (Operation)
            {
                case Operations.Plus:
                    operation = "plus ";
                    break;
                case Operations.Minus:
                    operation = "minus ";
                    break;
                case Operations.Divide:
                    operation = "divided by ";
                    break;
                case Operations.Times:
                    operation = "times ";
                    break;
                case Operations.Power:
                    operation = "squared ";
                    break;
                case Operations.SquareRoot:
                    operation = "unsquared ";
                    break;
                case Operations.Modulo:
                    operation = "mod(2) ";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return $"{operation} {(Number == -1 ? "" : Number.ToString())}";
        }
    }
}