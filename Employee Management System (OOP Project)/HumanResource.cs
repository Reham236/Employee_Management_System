using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System__OOP_Project_
{
    internal class HumanResource:Employee
    {
        public HumanResource(int id, string name, int age, decimal salary) 
        : base(id, name, age, salary, "Human Resource") { }

       
        public override void Print_Employee_Details()
        {
            base.Print_Employee_Details();
          
        }


           

            


        }
        
    }

