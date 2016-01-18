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
            if (Student_loan_answer == "yes")
            {
                Console.Write("\nWhen was your student loan taken? ");
                int Year_of_SL = Int32.Parse(Console.ReadLine());
            }
            double tax_free_amount = 10599.99;
            double first_tax_band = 42384.99;
            double primary_NI_free = 8059.99;
            double secondary_NI_free = 42383.99;
            double Student_Loan_free = 17334.99;
            double primary_taxable_salary = Customer_salary - tax_free_amount;
            double secondary_taxable_salary = Customer_salary - first_tax_band;
            double NIable_salary = Customer_salary - primary_NI_free;
            double SLable_salary = Customer_salary - Student_Loan_free;
            string Your_annual_salary = "Your annual salary before tax is: £ ";
            string Towards_tax_you_pay = "Towards tax you anually pay £";
            string Towards_NI_you_pay = "Towards NI you anually pay £";
            string Towards_SL_you_pay = "Towards SL you anually pay £";
            
       
            if (Customer_salary <= tax_free_amount && Customer_salary <= primary_NI_free)
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

            else if (Customer_salary <= tax_free_amount && Customer_salary > primary_NI_free)
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

            else if (Customer_salary > tax_free_amount && Customer_salary <= first_tax_band)
            {
                double Tax_Contribution = primary_taxable_salary * 0.2;
                double NI_contribution = NIable_salary * 0.12;

                if (Customer_salary > Student_Loan_free && Student_loan_answer == "yes")
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
            }

                else if (Customer_salary > first_tax_band )
                {
                   double Primary_tax_Contrbution = (first_tax_band - tax_free_amount) * 0.2;
                   double Secondary_tax_Contribution = secondary_taxable_salary * 0.4;
                   double Total_tax_contribution = Primary_tax_Contrbution + Secondary_tax_Contribution;
                   double Primary_NI_contribution = (secondary_NI_free - primary_NI_free) * 0.12;
                   double Secondary_NI_contribution  = (Customer_salary - secondary_NI_free) * 0.02;
                   double Total_NI_contribution = Primary_NI_contribution + Secondary_NI_contribution;
                   double Take_home_salary = Customer_salary - (Total_NI_contribution + Total_tax_contribution);
                   

                    Console.WriteLine(Your_annual_salary + Customer_salary);
                    Console.WriteLine(Towards_tax_you_pay + Total_tax_contribution);
                    Console.WriteLine(Towards_NI_you_pay + Total_NI_contribution);

                    if (Student_loan_answer == "yes")
                    {
                        double SL_contribution = SLable_salary * 0.09;
                        double Take_home_salary_SL = Customer_salary - (Total_NI_contribution + Total_tax_contribution + SL_contribution);


                        Console.WriteLine(Towards_SL_you_pay + SL_contribution);
                        Console.WriteLine("Your take home salary is £" + Take_home_salary_SL);
                    }
                    else
                    {
                        Console.WriteLine("Your take home salary is £" + Take_home_salary);

                    }

                }

                // projects notes
                // how much Student loan left, when will it be paid off, how much interest will you pay by the end of the year
                // change student loan year question to when did you start university
                // how many years where you at university
                // bonuses
            // 2 bands for NI

            }
        }                
    }








