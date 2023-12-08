using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_ConvertNumbersToWords_
{
    public static class NumbersToWords
    {
        public static string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" }; //string of names for the one digit numbers
        public static string[] teens = { "", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" }; //string of names for the teens
        public static string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" }; //string of numbers for the tens
         

        public static string ConvertToWords(int number) //start from biggest number down (thousands-single digits)
        {
            if (number >= 1000) //if the number is greater than and equal to 1000, divide by 1000 to get my single digit first, add "thousand", and convert the rest into words using my units, teens and tens
            {
                return $"{units[number / 1000]} Thousand {ConvertToWords(number % 1000)}"; 
            }
            else if (number >= 100)
            { 
                return $"{units[number / 100]} Hundred {ConvertToWords(number % 100)}"; //do the same as "thousand" but change it into hundred, then add the units, teens and tens
            }
            else if (number >= 20)
            {
                return $"{tens[number / 10]} {units[number % 10]}"; //add the tens values in (0-90)
            }
            else if (number >= 11)
            {
                return $"{teens[number - 10]}"; //add the teen values (10-19)
            }
            else
            {
                return $"{units[number]}"; //add the units values (single digit) (0-9)
            }
        }

    }
}
