// See https://aka.ms/new-console-template for more information
using employee_details;

public class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee("pravin", 50000,Dept.Development);
        emp1.CalculateSalary();
        Console.WriteLine(emp1.PrintDetails());

        Employee emp2 = new Employee("pawan", 60000,Dept.Admin);
        emp2.CalculateSalary();
        Console.WriteLine(emp2.PrintDetails());

        SalesManager salesManager = new SalesManager("Rohan", 28000, 3500);
        salesManager.CalculateSalary();

        Console.WriteLine(salesManager.PrintDetails());// ToString() get called implicitly 



        Employee employee = new Employee("Suraj", 28000, Dept.Sales);
        employee.CalculateSalary();

        Console.WriteLine(employee.PrintDetails());

        //Console.WriteLine(emp1.PrintDetails());
        //Console.WriteLine(emp2.PrintDetails());
        //Console.WriteLine(Employee.GetCount());


        //CLASS CALCULATION

        //Calculation task1 = new Calculation();

        //int result1 = task1.Addition(1, 2);
        //int result2 = task1.Addition(1, 2,3);
        //double result3 = task1.Addition(55.78, 22.34);

        //int result4 = task1.Subtraction(1, 2);
        //int result5 = task1.Subtraction(1, 2 ,3);
        //double result6 = task1.Subtraction(55.78, 22.34);

        //int res1 = task1.Multiplication(1, 2);
        //int res2 =  task1.Multiplication(1, 2 , 3);
        //double res3 = task1.Multiplication(55.78, 22.34);

        //Console.WriteLine($"{result1}\n{result2}\n{result3}\n{result4}\n{result5}\n{result6}\n{res1}\n{res2}\n{res3}\n");



    }
}

