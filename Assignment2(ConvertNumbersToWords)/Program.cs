namespace Assignment2_ConvertNumbersToWords_
{


    public class Program
    {
        

        public static void Main()
        {
            Console.Write("Enter a four-digit number maximum: "); //entering a console to type a 4-digit number max
            int number = int.Parse(Console.ReadLine()); //add "Parse" to convert the string data into another data type

            if (number < 0 || number > 9999) //if the values are smaller than 0 or greater than 9999, display invalid 4-digit number
            {
                Console.WriteLine("Please enter a valid four-digit number.");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero"); //add else if our number is zero, display "zero"
            }
            else
            {
                Console.WriteLine(NumbersToWords.ConvertToWords(number)); //call the code back from the class
            }
        }

        
    }
}
