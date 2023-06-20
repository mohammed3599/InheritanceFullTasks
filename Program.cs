namespace InheritanceFullTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d  = new Dog();
            d.Eat();
            d.MakeNoise();

            Cat cat = new Cat();
            cat.Eat();
            cat.MakeNoise();

            Console.WriteLine("____________________________");

            Circle circle = new Circle();
            circle.GetPerimeter();
            circle.GetArea();

            Rectangle rectangle = new Rectangle();
            rectangle.GetPerimeter();
            rectangle.GetArea();

            Console.WriteLine("____________________________");

            Manager manager = new Manager("Mohammed", 2000, "IT", 200);
            manager.CalculatePay();
            
            Secretary secretary = new Secretary("Saeed", 1000, "IT", 35);
            secretary.CalculatePay();

            Console.WriteLine("____________________________");

            Car c = new Car("Toyota", "Japan", "Corolla", 2017, 4);
            c.GetInfo();

            Truck t = new Truck("Mercedes", "German", "G500", 2012, 12);
            t.GetInfo();

            Console.WriteLine("____________________________");


        }
    }
}