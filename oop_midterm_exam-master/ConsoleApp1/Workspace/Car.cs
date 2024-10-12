namespace ConsoleApp1.Exam
{
    public class Car
    {
        private readonly Engine _engine;

        public bool IsEngineStarted { get; private set; } = false;

        public Car(Engine engine)
        {
            _engine = engine;
            IsEngineStarted = false;
        }


        public void StartCar()
        {
            _engine.Start();
            IsEngineStarted = true;
        }

    }

    // Car and Engine (Composition example)
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine Started");
        }
    }

}


