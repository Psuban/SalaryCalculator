using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args){

            //Exercise 1
            Console.WriteLine("\nBob\n");
            Console.WriteLine("ST1001\n");
            Console.WriteLine("bob@gmail.com\n");

            //Exercise 2
            int number_1 = 14;
            int number_2 = 7;

            Console.WriteLine("14 + 7 = " + (number_1 + number_2) + "\n");

            Console.WriteLine("14 * 7 = " + (number_1 * number_2) + "\n");

            Console.WriteLine("14 - 7 = " + (number_1 - number_2) + "\n");

            Console.WriteLine("14 / 7 = " + (number_1 / number_2) + "\n");


            //Exercise 3
            int number_3 = 1;

            Console.WriteLine(number_3);
        
            Console.WriteLine("  " + (number_3 + 1));

            Console.WriteLine("    " + (number_3 + 2));

            Console.WriteLine("      " + (number_3 + 3));

            Console.WriteLine("        " + (number_3 + 4)+"\n");


            //Exercise 4
            Console.WriteLine("\"SDK\" stands for \"Software Development Kit\", whereas\n\"IDE\" stands for \"Integrated  Development Environment\"");

            //Exercise 5
            Console.WriteLine("\nWhat year were you born?");
            int year_born = Int32.Parse(Console.ReadLine());

            Console.WriteLine("In 2020, you will be " + (2020 - year_born) + " years old.\n");

            //Exercise 6
            Console.Write("\nPlease enter your name: ");
            string your_name = Console.ReadLine();

            Console.WriteLine("Hi " + your_name + ", welcome to C# programming :)\n");

            //Exercise 7
            Console.Write("Please enter amount in pounds: £");
            int amount_in_pounds = Int32.Parse(Console.ReadLine());
            Console.WriteLine("£" + amount_in_pounds + " are $" + (amount_in_pounds * 1.5)+"\n\n");

            //Exercise 8
            Console.Write("Enter your name: ");
           String student_name = Console.ReadLine();
            Console.Write("\nEnter your student number: ");
           String student_number = Console.ReadLine();
            Console.Write("\nEnter your email address: ");
           String student_email = Console.ReadLine();

           Console.WriteLine("\nHello " + student_name + ", thanks for entering your details. We will send you an email on " + student_email + " with subject id: " + student_number + " about further informtation.\n\n");

            //Exercise 10

           Console.Write("\nScore for fitness test 1? ");
          int Score_test_1 = Int32.Parse(Console.ReadLine());
           Console.Write("\nScore for fitness test 2? ");
          int Score_test_2 =Int32.Parse(Console.ReadLine());
            int Average_score = (Score_test_1 +Score_test_2) / 2 ;
          Console.WriteLine("\nYour average score is " + Average_score);
            int PC_Fit_Age = ((Average_score * 8)/5)+10;
          Console.WriteLine("Your PC Fit age is " + PC_Fit_Age + " years old.");
          Console.Write("What is your actual age");
          int Actual_age = Int32.Parse(Console.ReadLine());
          Console.WriteLine("You are " + (Actual_age - PC_Fit_Age) + " years away from your PC fit age");

            //Exercise 12
            
            Console.Write("\nEnter the month number: ");
            int Month_Number = Int32.Parse(Console.ReadLine());
             if (Month_Number==1)
             {
             Console.WriteLine("Month " + Month_Number + " is January");
             }
             else if (Month_Number==2)
             {
             Console.WriteLine("Month " + Month_Number + " is Febuary ");
             }
             else if (Month_Number==3)
             {
             Console.WriteLine("Month " + Month_Number + " is March ");
             }
             else if (Month_Number==4)
             {
             Console.WriteLine("Month " + Month_Number + " is April ");
             }
             else if (Month_Number == 5)
             {
                 Console.WriteLine("Month " + Month_Number + " is May ");
             }
             else if (Month_Number == 6)
             {
                 Console.WriteLine("Month " + Month_Number + " is June ");
             }
             else if (Month_Number == 7)
             {
                 Console.WriteLine("Month " + Month_Number + " is July ");
             }
             else if (Month_Number == 8)
             {
                 Console.WriteLine("Month " + Month_Number + " is August ");
             }
             else if (Month_Number == 9)
             {
                 Console.WriteLine("Month " + Month_Number + " is September ");
             }
             else if (Month_Number == 10)
             {
                 Console.WriteLine("Month " + Month_Number + " is October ");
             }
             else if (Month_Number == 11)
             {
                 Console.WriteLine("Month " + Month_Number + " is November ");
             }
             else if (Month_Number == 12)
             {
                 Console.WriteLine("Month " + Month_Number + " is December ");
             }
             else
             {
                 Console.WriteLine("\nYou have entered an invalid month");
             }
            
            //Exercise 13

             Console.Write("\nPlease enter any non-zero number: ");
             int Random_number = Int32.Parse(Console.ReadLine());
             if (Random_number % 2 == 0)
             {
                 Console.WriteLine("\nThe number you entered is even");
             }
             else
             {
                 Console.WriteLine("\nThe number you entered is odd");
             }

            //Exercise 14






        }
    }
}
