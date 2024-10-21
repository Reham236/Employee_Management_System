using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System__OOP_Project_
{
    internal abstract class Employee
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
        public string Position { get; set; }


        protected Employee(int id, string name, int age, decimal salary, string position)
        {
            ID = id;
            Name = name;
            Age = age;
            Salary = salary;
            Position = position;
            Bonus = 0;
        }
        public virtual void Print_Employee_Details()
        {
            Console.WriteLine("{0,-10} | {1,-20} | {2,-5} | {3,-10} | {4,-10} | {5,-15}",
              ID, Name, Age, Salary, Bonus, Position);
        }
        public virtual void CalculateBonus(decimal bonusPercent)
        {
            Bonus = (Salary * bonusPercent) / 100;
        }

    }
}
