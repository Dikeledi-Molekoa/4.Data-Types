namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration
            string name = "John";
            int age = 35;
            bool isTall = false;
            double weight = 80.2;

            /*For the smallest least precise decimal use float,
             *For more precise use decimal eg for money,
             *In moast cases double will do just fine
             */

            Console.WriteLine(name + " is " + age + " and he weighs " + weight + "kg");
            
            //freeze console
            Console.ReadLine();
        }
    }
}
