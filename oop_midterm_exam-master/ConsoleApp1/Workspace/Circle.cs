namespace ConsoleApp1.Exam
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetArea()
        {   
            Radius = double.Pi*(Radius*Radius);
            return Radius;
        }

        public double GetPerimeter() { 
            
            Radius = Radius/double.Pi/5;
            Radius = 2*double.Pi*(Radius);
            return Radius;
        }
    }

}
