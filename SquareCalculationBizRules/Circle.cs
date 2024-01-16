namespace FigureLib
{
    public class Circle : FigureBase
    {
        private double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if (IsPositiveNum(value))
                {
                    radius = value;
                }
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        private bool IsPositiveNum(double num)
        {
            if (!double.IsPositive(num) || num <= 0)
            {
                throw new ArgumentException("Error: Side lenght must be greater than 0!");
            }
            return true;
        }
    }
}
