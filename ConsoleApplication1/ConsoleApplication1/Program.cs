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
            Console.Write("\nWould you like to do another calculation? ");
            string ReplayAnswer = Console.ReadLine();
            while (ReplayAnswer == "yes")
            {
                SalaryCalculator();
            }


        }

        public static void SalaryCalculator()
        {


            Console.Write("\nWhat's your annual salary? £");
            double Customer_salary = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nDo you have a student loan ?");
            string Student_loan_answer = Console.ReadLine();
            Console.Write("\nWhen was your student loan taken? ");
            int Year_of_SL = Int32.Parse(Console.ReadLine());
            double tax_free_amount = 10600;
            double first_tax_band = 42385;
            double NI_free = 8060;
            double Student_Loan_free = 17335;
            double taxable_salary = Customer_salary - tax_free_amount;
            double NIable_salary = Customer_salary - NI_free;
            double SLable_salary = Customer_salary - Student_Loan_free;
            string Your_annual_salary = "Your annual salary before tax is: £ ";
            string Towards_tax_you_pay = "Towards tax you anually pay £";
            string Towards_NI_you_pay = "Towards NI you anually pay £";
            string Towards_SL_you_pay = "Towards SL you anually pay £";
            
       
            if (Customer_salary < tax_free_amount && Customer_salary <= NI_free)
            {
                double Take_home_salary = Customer_salary;

                Console.WriteLine(Your_annual_salary + Customer_salary);
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

                Console.WriteLine(Your_annual_salary + Customer_salary);
                Console.WriteLine("You pay £0 towards tax");
                Console.WriteLine(Towards_NI_you_pay + NI_contribution);

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

                    Console.WriteLine(Your_annual_salary + Customer_salary);
                    Console.WriteLine(Towards_tax_you_pay + Tax_Contribution);
                    Console.WriteLine(Towards_NI_you_pay + NI_contribution);
                    Console.WriteLine(Towards_SL_you_pay + SL_contribution);
                    Console.WriteLine("Your take home salary is £" + Take_home_salary);
                }
                else
                {
                    double Take_home_salary = Customer_salary - (Tax_Contribution + NI_contribution);

                    Console.WriteLine(Your_annual_salary + Customer_salary);
                    Console.WriteLine(Towards_tax_you_pay + Tax_Contribution);
                    Console.WriteLine(Towards_NI_you_pay + NI_contribution);
                    Console.WriteLine("Your take home salary is £" + Take_home_salary);
                }

                // projects notes
               // how much Student loan left, when will it be paid off, how much interest will you pay by the end of the year
                // change student loan year question to when did you start university
                // how many years where you at university

            }
        }                
    }
}






