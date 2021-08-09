using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {12.7,10.3,6.11,4.1}; 
            // numbers[0] = 12.7; 
            // numbers[1] = 10.3; 
            // numbers[2] = 6.11; 
            
            var result = 0.0; 

            foreach(double number in numbers)
            {
                result += number;
            }
            result = result + numbers[1]; 
            result = result + numbers[2]; 
            Console.WriteLine(result); 

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}"); 
            }
            else
            {
                Console.WriteLine("Hello!"); 
            }
        }
    }
}
