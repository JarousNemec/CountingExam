namespace CountingExam.Models
{
    public class CountingAction
    {
        public CountingAction(double number, Operations operations)
        {
            Number = number;
            Operation = operations;
        }

        public Operations Operation { get; set; }
        public double Number { get; set; }

        public override string ToString()
        {
            var operation = string.Empty;
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
            }
            return operation+Number;
        }
    }
}