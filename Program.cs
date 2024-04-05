namespace CW23_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            int number = 0;

            do
            {
                Console.WriteLine("Enter number from 1 to 100: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number < 1 && number > 100)
                    Console.WriteLine("Wrong value ");
            } while (number < 1 || number > 100);

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }


            //task 2 
            Console.WriteLine("Enter the first number:");
            if (double.TryParse(Console.ReadLine(), out double number1))
            {
                Console.WriteLine("Enter the second number (percentage):");
                if (double.TryParse(Console.ReadLine(), out double percent))
                {
                    double result = (number1 * percent) / 100;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Invalid value for percentage entered.");
                }
            }
            else
            {
                Console.WriteLine("Mistake: entered incorrect value for the first number.");
            }
            //task 3
            string num_str = "";

            int temp = 0;
            do
            {
                Console.WriteLine("Enter numbers");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == -1)
                    break;
                num_str += number;
            } while (true);
            Console.WriteLine("Number: " + num_str + "\n");

            //task 4 
            int range_start, range_end;
            do
            {
                Console.WriteLine("Enter range1 :");
                range_start = Convert.ToInt32(Console.ReadLine());
            } while (range_start < 1 || range_start > num_str.Length);

            do
            {
                Console.WriteLine("Enter range2 :");
                range_end = Convert.ToInt32(Console.ReadLine());
            } while (range_end < 1 || range_end > num_str.Length);

            if (range_end < range_start)
            {
                int temp_num = range_end;
                range_end = range_start;
                range_start = temp_num;
            }
            range_end--;
            range_start--;

            char[] charArray = num_str.ToCharArray();
            char temp_str = num_str[range_start];

            charArray[range_start] = charArray[range_end];
            charArray[range_end] = temp_str;
            num_str = new string(charArray);

            Console.WriteLine($"Result: {num_str}\n");

            //task 5 
            int day, month, year;

            Console.WriteLine("Enter day:");

            day = Convert.ToInt32(Console.ReadLine());
            while (day < 1 || day > 31)
            {
                Console.WriteLine("Pomilka: entered incorrect day.");
                Console.WriteLine("Enter the day again:");
                day = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("Enter the month:");
            month = Convert.ToInt32(Console.ReadLine());

            while (month < 1 || month > 12)
            {
                Console.WriteLine("Error: Invalid month entered.");
                Console.WriteLine("Enter the month again:");
                month = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the year:");
            year = Convert.ToInt32(Console.ReadLine());
            while ( year < 1)
            {
                Console.WriteLine("Error: Invalid year entered.");
                Console.WriteLine("Enter the year again:");
                year = Convert.ToInt32(Console.ReadLine());
            }

            DateTime date = new DateTime(year, month, day);
            string season = GetSeason(date.Month);
            string dayOfWeek = date.DayOfWeek.ToString();

            Console.WriteLine($"{season} {dayOfWeek}");

            //task 6 (°F − 32) × 5 / 9
            Console.WriteLine("Enter the temperature:");
            double temperature;
            temperature = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Select the conversion option:");
            Console.WriteLine("1. Fahrenheit to Celsius");
            Console.WriteLine("2. Celsius to Fahrenheit");

            int option;

            do
            {
                option = Convert.ToInt32(Console.ReadLine());
                if (option != 1 && option != 2) Console.WriteLine("Error: select 1 or 2.");
            } while (option != 1 && option != 2);


            switch (option)
            {
                case 1:
                    {
                        double celsius = (temperature - 32) * 5 / 9;
                        Console.WriteLine($"Temperature in Celsius: {celsius}");
                        break;
                    }
                case 2:
                    {
                        double fahrenheit = (temperature * 9 / 5) + 32;
                        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
                        break;
                    }
            }

            //task 7
            Console.WriteLine("Enter two numbers to form a range:");
            Console.Write("First number: ");
            int number_s = Convert.ToInt32(Console.ReadLine());

            Console.Write("Other number: ");
            int number_e = Convert.ToInt32(Console.ReadLine());

            if (number_s > number_e)
            {
                int temp_1 = number_s; // cuz of in 1 file 
                number_s = number_e;
                number_e = temp;
            }

            Console.WriteLine($"Even numbers in the range from {number_s} to {number_e}:");
            for (int i = number_s; i <= number_e; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static string GetSeason(int month)
        {
            if (month == 12 || month == 1 || month == 2)
                return "Winter";
            else if (month >= 3 && month <= 5)
                return "Spring";
            else if (month >= 6 && month <= 8)
                return "Summer";
            else
                return "Autumn";
        }
    }
}