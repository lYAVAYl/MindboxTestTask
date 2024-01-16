namespace FigureLib
{
    public class Triangle : FigureBase
    {
        private double catheter1;
        public double Сatheter1
        {
            get => catheter1;
            set
            {
                if(IsPositiveNum(value))
                {
                    catheter1 = value;
                }
            }
        }

        private double catheter2;
        public double Сatheter2
        {
            get => catheter2;
            set
            {
                if (IsPositiveNum(value))
                {
                    catheter2 = value;
                }
            }
        }

        private double hypotenuse;
        public double Hypotenuse
        {
            get => hypotenuse;
            set
            {
                if (IsPositiveNum(value))
                {
                    hypotenuse = value;
                }
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA > (sideB + sideC) || sideB > (sideA + sideC) || sideC > (sideA + sideB)) 
                throw new ArgumentException($"Error: Incorrect input. One of sides is greater than summary of two other sides");

            var arr = new double[3] { sideA, sideB, sideC }.OrderBy(x => x).ToArray();

            Сatheter1 = arr[0];
            Сatheter2 = arr[1];
            Hypotenuse = arr[2];
        }

        public bool IsRightAngled => Сatheter1 * Сatheter1 + Сatheter2 * Сatheter2 == Hypotenuse * Hypotenuse;

        public override double GetSquare()
        {
            double result;
            if (IsRightAngled)
            {
                result = Сatheter1 * Сatheter2 / 2;
            }
            else
            {
                double p = (Сatheter1 + Сatheter2 + Hypotenuse) / 2;
                result = Math.Sqrt(p * (p - Сatheter1) * (p - Сatheter2) * (p - Hypotenuse));
            }

            return result;
        }

        private bool IsPositiveNum(double num)
        {
            if(!double.IsPositive(num) || num <= 0)
            {
                throw new ArgumentException("Error: Value must be greater than 0!");
            }
            return true;
        }
    }
}
