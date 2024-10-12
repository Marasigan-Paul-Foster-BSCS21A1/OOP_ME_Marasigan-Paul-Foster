namespace ConsoleApp1.Exam
{
    public interface IShape 
    {
        double GetArea();
        double GetPerimeter();
    }

    public class Rectangle : IShape
    {
        private double _length;
        private double _width;

        public double Length { get; set; }
        public double Width { get; set; }

        public double Area {  get; set; }
        public double Perimeter { get; set; }   

        public double GetArea()
        {
            _length = Length;
            _width = Width;

            Area = Width * Length;
            return Area;
        }

        public double GetPerimeter()
        {
            _length = Length;
            _width = Width;

            Perimeter = 2*(_length + _width);
            return Perimeter;
        }
    }

    public class Triangle : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double Perimeter { get; set;}

        public double Area { get; set;}

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideC = sideC;
            SideA = sideA;  
            SideB = sideB;
        }

        public double GetArea()
        {
            // Heron's formula: Area = sqrt(s * (s - a) * (s - b) * (s - c))
            double semiPerimeter = GetPerimeter() / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
        public double GetPerimeter()
        {
            Perimeter = SideA + SideB + SideC;
            return Perimeter ;
        }
    }


}
