using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_details
{
    public  interface IPrint
    {
        string PrintDetails();
    }

    public class Employee : IPrint
    {
        protected int id;
        protected string name;
        protected int salary;
        protected double gross_salary, total_salary;
        private static int count; 

        public Employee(string name,int salary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.salary = salary;
        }

        public static int GetCount()
        {
            return count;
        }

        public virtual void CalculateSalary()
        {
          double  hra = 40.00 / 100 * salary;
          double ta = 20.00 / 100 * salary;
          double  da = 10.00 / 100 * salary;
          double pf = 12.00 / 100 * salary;

            total_salary = salary + hra  + ta + da;
           gross_salary =total_salary - (pf);
        }


        public string PrintDetails()
        {
            return $"Employee ID = {id}\n Name = {name}\n Total Salary{total_salary}\n Gross Salary = {gross_salary}";
        }
    }

    public class SalesManager :Employee, IPrint
    {
        private double comm;
        public SalesManager(string name, int salary, double comm):base (name,salary)
        {
            this.comm = comm;
        }

        public override void CalculateSalary()
        {
            double hra = 40.00 / 100 * salary;
            double ta = 20.00 / 100 * salary;
            double da = 10.00 / 100 * salary;
            double pf = 12.00 / 100 * salary;

            total_salary = salary + hra + ta + da +comm;
            gross_salary = total_salary - (pf);
        }
    
        public string PrintDetails()
        {
            return $"Employee ID = {id}\n Name = {name}\n Total Salary{total_salary}\n Gross Salary = {gross_salary}";
        }
    }
}
