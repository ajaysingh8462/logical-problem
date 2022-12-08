// See https://aka.ms/new-console-template for more information


using logical_problem;

public class Program
{
    public static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Welcome to Logical Programming Problems");
            Console.WriteLine("1. Fibonacci Number Generator" + "\n" + "2. Check Perfect Number" + "\n" + "3. PrimeNumber" + "\n" + "4. Reverse a number" + "\n" + "5. Coupon Number" + "\n" + "6.to Stimulate Stop watch.");
            Console.WriteLine("Enter The Above Mention Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibonacci_Series fibo = new Fibonacci_Series();
                    fibo.print(); 
                    break;
                case 2:
                    Perfect_Number enter = new Perfect_Number();
                    enter.Check();
                    break;
                case 3:
                    Prime_Number pri = new Prime_Number();
                    pri.prime(); 
                    break;
                    case 4:
                    Reverse_a_number reverse= new Reverse_a_number();   
                    reverse.reverse();  
                    break;
                case 5:
                    Coupon_Numbers.GenerateCoupon(10);
                    break;
                case 6:
                    Stopwatch stopwatch= new Stopwatch();
                    stopwatch.StimulateStopWatch();
                    break;


            }
        }
    }
}