namespace OperatorExercise
{
    public class Program
    {
        /************ Exercise Two ***********/
        
        //AreaOfCircle
        static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
        static void Main(string[] args)
        {
            /************ Exercise One ***********/
            
            //intiallize variables
            int a = 17;
            int b = 4;
            
            //Perform Arithmetic Operations
            
                //Addition
                int sum = a + b;
                
                //Subtraction
                int difference = a - b;

                //Multiplication
                int product = a * b;

            //Division and Modulus Operations

                //Division
                int quotient = a / b;

                //Modulus
                int remainder = a % b;
                
            //Print Output To The Console
            Console.WriteLine($"{a}+{b} is {sum}.");
            Console.WriteLine($"{a}-{b} is {difference}.");
            Console.WriteLine($"{a}*{b} is {product}.");
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            
            /************ Exercise Two Input ***********/
            
            //define radius
            Console.WriteLine("What is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            
            double areaOfCircle = AreaOfCircle(radius);
            
            Console.WriteLine($"The area of the circle with a radius of {radius} is {areaOfCircle}");
            
        }
    }
}
