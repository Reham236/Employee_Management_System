﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System__OOP_Project_
{
    internal class Manager :Employee  
    {
        public Manager(int id, string name, int age, decimal salary)
       : base(id, name, age, salary, "Manager") { }
    }
}
