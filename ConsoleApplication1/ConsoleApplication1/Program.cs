using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling the salary calculator method


            SalaryCalculator();
            Console.Write("\nWould you like to play the game again?");
            string ReplayAnswer = Console.ReadLine();
            while (ReplayAnswer == "yes")
            {
                SalaryCalculator();
            }


        }

        public static void SalaryCalculator()
        {


            Console.Write("\nWhat's your annual salary?");
            double Customer_salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("Do you have a student loan that was taken between ...?");
            string Student_loan_answer = Console.ReadLine();
            double tax_free_amount = 10600;
            double first_tax_band = 42385;
            double NI_free = 8060;
            double Student_Loan_free = 17335;
            double taxable_salary = Customer_salary - tax_free_amount;
            double NIable_salary = Customer_salary - NI_free;
            double SLable_salary = Customer_salary - Student_Loan_free;




            if (Customer_salary < tax_free_amount && Customer_salary <= NI_free)
            {
                double Take_home_salary = Customer_salary;

                Console.WriteLine("\nYour salary is: " + Customer_salary);
                Console.WriteLine("You pay £0 towards tax");
                Console.WriteLine("You pay £0 towards National Insurance");

                if (Student_loan_answer == "yes")
                {
                    Console.WriteLine("You pay £0 towards Student Loan");
                }
                Console.WriteLine("Your take home salary is £" + Take_home_salary);
            }

            else if (Customer_salary < tax_free_amount && Customer_salary >= NI_free)
            {
                double NI_contribution = NIable_salary * 0.12;
                double Take_home_salary = Customer_salary - NI_contribution;

                Console.WriteLine("\nYour salary is: " + Customer_salary);
                Console.WriteLine("You pay £0 towards tax");
                Console.WriteLine("You pay £" + NI_contribution + " towards National Insurance");

                if (Student_loan_answer == "yes")
                {
                    Console.WriteLine("You pay £0 towards Student Loan");
                }
                Console.WriteLine("Your take home salary is £" + Take_home_salary);
            }

            else if (Customer_salary >= tax_free_amount && Customer_salary < first_tax_band)
            {
                double Tax_Contribution = taxable_salary * 0.2;
                double NI_contribution = NIable_salary * 0.12;

                if (Customer_salary >= Student_Loan_free && Student_loan_answer == "yes")
                {
                    double SL_contribution = SLable_salary * 0.09;
                    double Take_home_salary = Customer_salary - (Tax_Contribution + NI_contribution + SL_contribution);

                    Console.WriteLine("\nYour salary is: " + Customer_salary);
                    Console.WriteLine("You pay £" + Tax_Contribution + " towards tax");
                    Console.WriteLine("You pay £" + NI_contribution + " towards National Insurance");
                    Console.WriteLine("You pay £" + SL_contribution + " towards Student Loan");
                    Console.WriteLine("Your take home salary is £" + Take_home_salary);
                }
                else
                {
                    double Take_home_salary = Customer_salary - (Tax_Contribution + NI_contribution);

                    Console.WriteLine("\nYour salary is: " + Customer_salary);
                    Console.WriteLine("You pay £" + Tax_Contribution + " towards tax");
                    Console.WriteLine("You pay £" + NI_contribution + " towards National Insurance");
                    Console.WriteLine("Your take home salary is £" + Take_home_salary);
                }

            }







        }



    }
}






