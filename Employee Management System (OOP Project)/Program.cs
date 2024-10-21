using System.Xml.Linq;

namespace Employee_Management_System__OOP_Project_
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Employee> employees = new List<Employee>();
            while (true)
            {

                IntroMethod();
                int Choice;
                int.TryParse(Console.ReadLine(), out Choice);
                if (Choice == 1) /// ADD new Employee
                {
                    AddEmployee(employees);
                }
                else if (Choice == 2)  ///SHOW Employees Details
                {
                    ShowEmployeeDetails(employees);

                }
                else if (Choice == 3)   ///UPDATE an Employee using his ID and his Position
                {
                    UpdateEmployee(employees);

                }
                else if (Choice == 4)   ///CALCULATE Employee Bonus using his ID and Position
                {
                    CalculateEmployeeBonus(employees);
                }
                else
                {
                    return;
                }
            }
        }
        // Intro Function
        public static void IntroMethod()
        {
            Console.Write(" 1-Add new Employee. \n" +
                         " 2-Show Employee Details.\n" +
                         " 3-Update Employee Details.\n" +
                         " 4-Calculate Bonus based on Employee Position.\n" +
                         " 5-Finish.\n\n ");

        }
        //Select new Employee Position
        public static void EmployeePositionMethod()
        {
            Console.WriteLine("Please choose the new Employee Position\n" +
                                "  1- Human Resources.\n" +
                                "  2-Manger.\n" +
                                "  3-Engineer.\n");
        }
        public static void AddEmployee(List<Employee> employees)
        {
            Console.WriteLine("Enter Employee Information:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            EmployeePositionMethod();
            int positionChoice = int.Parse(Console.ReadLine());

            Employee newEmployee = null;
            if (positionChoice == 1)
            {
                newEmployee = new HumanResource(id, name, age, salary);
            }
            else if (positionChoice == 2)
            {
                newEmployee = new Manager(id, name, age, salary);
            }
            else if (positionChoice == 3)
            {
                newEmployee = new Engineer(id, name, age, salary);
            }

            if (newEmployee != null)
            {
                employees.Add(newEmployee);
            }
        }
        public static void ShowEmployeeDetails(List<Employee> employees)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("{0,-10} | {1,-20} | {2,-5} | {3,-10} | {4,-10} | {5,-15}", "ID", "Name", "Age", "Salary", "Bonus", "Position");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");

            foreach (var employee in employees)
            {
                employee.Print_Employee_Details();
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------");
        }
        public static void UpdateEmployee(List<Employee> employees)
        {
            Console.Write("Enter Employee ID to update: ");
            int id = int.Parse(Console.ReadLine());

            Employee employeeToUpdate = employees.FirstOrDefault(e => e.ID == id);
            if (employeeToUpdate != null)
            {
                Console.Write("New Name: ");
                employeeToUpdate.Name = Console.ReadLine();
                Console.Write("New Age: ");
                employeeToUpdate.Age = int.Parse(Console.ReadLine());
                Console.Write("New Salary: ");
                employeeToUpdate.Salary = decimal.Parse(Console.ReadLine());
            }
        }
        public static void CalculateEmployeeBonus(List<Employee> employees)
        {
            Console.Write("Enter Employee ID to calculate bonus: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Bonus Percentage: ");
            decimal bonusPercent = decimal.Parse(Console.ReadLine());

            Employee employeeToCalculate = employees.FirstOrDefault(e => e.ID == id);
            if (employeeToCalculate != null)
            {
                employeeToCalculate.CalculateBonus(bonusPercent);
                Console.WriteLine("Bonus calculated: {0}", employeeToCalculate.Bonus);
            }
        }

    }
}
