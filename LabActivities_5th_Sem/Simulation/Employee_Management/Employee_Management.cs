using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Simulation.Employee_Management
{
    internal class Employee_Management
    {
        static Company NeruxCorp = new Company();
        public static void Entry_Point()
        {
            Dictionary<string, Tuple<string, Action>> options = new Dictionary<string, Tuple<string, Action>>
            {
                {"11",  new Tuple<string, Action>("List all departments",      NeruxCorp.Display_Departments                  ) },
                {"12",  new Tuple<string, Action>("Create new department",     NeruxCorp.Create_Department                    ) },
                {"13",  new Tuple<string, Action>("Read department",           NeruxCorp.Read_Department                      ) },
                {"14",  new Tuple<string, Action>("Update department",         NeruxCorp.Edit_Department                      ) },
                {"15",  new Tuple<string, Action>("Delete department",         NeruxCorp.Delete_Department                    ) },
                {"16",  new Tuple<string, Action>("Search department (start)", NeruxCorp.Search_Starting_Substring_Department ) },
                {"17",  new Tuple<string, Action>("Search department (end)",   NeruxCorp.Search_Ending_Substring_Department   ) },
                {"18",  new Tuple<string, Action>("Search department",         NeruxCorp.Search_Substring_Department          ) },
                {"21",  new Tuple<string, Action>("List all employees",        NeruxCorp.Display_Employee                     ) },
                {"22",  new Tuple<string, Action>("Create employee",           NeruxCorp.Create_Employee                      ) },
                {"23",  new Tuple<string, Action>("Read employee",             NeruxCorp.Read_Employee                      ) },
                {"24",  new Tuple<string, Action>("Update employee",           NeruxCorp.Edit_Employee                      ) },
                {"25",  new Tuple<string, Action>("Delete employee",           NeruxCorp.Delete_Employee                      ) },
                {"26",  new Tuple<string, Action>("Search employee (start)",   NeruxCorp.Search_Starting_Substring_Employee   ) },
                {"27",  new Tuple<string, Action>("Search employee (end)",     NeruxCorp.Search_Ending_Substring_Employee     ) },
                {"28",  new Tuple<string, Action>("Search employee",           NeruxCorp.Search_Substring_Employee            ) },
                {"0",   new Tuple<string, Action>("Exit",                       Kill                                           ) },
            };

            while (true)
            {
                Console.WriteLine("What you want to do? ");
                foreach (var option in options)
                {
                    Console.WriteLine($"{option.Key}\t:\t{option.Value.Item1}");
                }

                Console.Write("Choose a option: ");
                string choosen_option = Console.ReadLine();

                if (!options.Keys.Contains(choosen_option)) 
                {
                    Console.WriteLine("Invalid Option."); continue;
                }
                options[choosen_option].Item2.Invoke();
            }
        }
        static void Kill() { Environment.Exit(0); }

    }

    class Company
    {
        private Department_Service _company_Departments = new Department_Service();
        private Employee_Service _company_Employees = new Employee_Service();

        public void Display_Departments()
        {
            Console.WriteLine("Following are the registered departments:");
            Console.WriteLine("Department ID\tDepartment Name");
            foreach (Department department in _company_Departments.Departments)
            {
                if (department.Id == 0) { continue; }

                Console.WriteLine($"{department.Id}:\t\t{department.Name}");
            }
        }
        public void Create_Department()
        {
            Display_Departments();
            Console.Write("Enter Department Name: ");
            string department_name = Console.ReadLine();
            Console.Write("Enter Remarks: ");
            string department_remarks = Console.ReadLine();

            _company_Departments.Create(department_name, department_remarks);
        }
        public void Read_Department()
        {
            Display_Departments();
            Console.Write("Enter the Department Id you want to view: ");
            Int32.TryParse(Console.ReadLine(), out int department_id);

            _company_Departments.Read(department_id);
        }
        public void Edit_Department()
        {
            Display_Departments();
            Console.Write("Enter the id of department to edit: ");
            Int32.TryParse(Console.ReadLine(), out int department_id);
            Console.Write("Enter Department Name: ");
            string department_name = Console.ReadLine();
            Console.Write("Enter Remarks: ");
            string department_remarks = Console.ReadLine();

            _company_Departments.Update(department_id, department_name, department_remarks);
        }
        public void Delete_Department()
        {
            Display_Departments();
            Console.Write("Enter the Department Id you want to delete: ");
            Int32.TryParse(Console.ReadLine(), out int department_id);

            _company_Departments.Delete(department_id);
        }
        public void Search_Starting_Substring_Department()
        {
            Console.Write("Enter Search Query (Starting Characters): ");
            string query = Console.ReadLine();
            List<int> departments = _company_Departments.Filter_By_Name(query, (int)Filter_Mode.Left);
            if (departments.Count == 0)
            {
                Console.WriteLine($"No Departments found matching query: {query}~");
                return;
            }
            foreach (int department_id in departments)
            {
                _company_Departments.Read(department_id);
            }
        }
        public void Search_Ending_Substring_Department()
        {
            Console.Write("Enter Search Query (Ending Characters): ");
            string query = Console.ReadLine();
            List<int> departments = _company_Departments.Filter_By_Name(query, (int)Filter_Mode.Right);
            if (departments.Count == 0)
            {
                Console.WriteLine($"No Departments found matching query: ~{query}");
                return;
            }
            foreach (int department_id in departments)
            {
                _company_Departments.Read(department_id);
            }
        }
        public void Search_Substring_Department()
        {
            Console.Write("Enter Search Query: ");
            string query = Console.ReadLine();
            List<int> departments = _company_Departments.Filter_By_Name(query, (int)Filter_Mode.All);
            if (departments.Count == 0)
            {
                Console.WriteLine($"No Departments found matching query: ~{query}~");
                return;
            }
            foreach (int department_id in departments)
            {
                _company_Departments.Read(department_id);
            }
        }

        public void Display_Employee()
        {
            Console.WriteLine("Following are the registered employees:");
            Console.WriteLine("Employee ID\tEmployee Name");
            foreach (Employee employee in _company_Employees.Employees)
            {
                if (employee.Id == 0) { continue; }

                Console.WriteLine($"{employee.Id}:\t\t{employee.Name}");
            }
        }
        public void Create_Employee()
        {
            Display_Departments();
            Console.Write("Enter Employee Name: ");
            string employee_name = Console.ReadLine();
            Console.Write("Enter Department Id: ");
            Int32.TryParse(Console.ReadLine(), out int department_id);
            Console.Write("Enter Salary: ");
            Decimal.TryParse(Console.ReadLine(), out decimal salary);

            _company_Employees.Create(employee_name, department_id, salary);
        }
        public void Read_Employee()
        {
            Display_Employee();
            Console.Write("Enter the Employee Id you want to view: ");
            Int32.TryParse(Console.ReadLine(), out int employee_id);

            _company_Employees.Read(employee_id);
        }
        public void Edit_Employee()
        {
            Display_Employee();
            Display_Departments();

            Console.Write("Enter the id of employee to edit: ");
            Int32.TryParse(Console.ReadLine(), out int employee_id);

            Console.Write("Enter Employee Name: ");
            string employee_name = Console.ReadLine();

            Console.Write("Enter the department id: ");
            bool department_id_passed = Int32.TryParse(Console.ReadLine(), out int department_id);
            if (!department_id_passed) { department_id = -1; }

            Console.Write("Enter the salary: ");
            bool salary_passed = Decimal.TryParse(Console.ReadLine(), out decimal salary);
            if (!salary_passed) { salary = -1.0M; }

            _company_Employees.Update(employee_id, employee_name, department_id, salary);
        }
        public void Delete_Employee()
        {
            Display_Employee();
            Console.Write("Enter the Employee Id you want to delete: ");
            Int32.TryParse(Console.ReadLine(), out int employee_id);

            _company_Employees.Delete(employee_id);
        }
        public void Search_Starting_Substring_Employee()
        {
            Console.Write("Enter Search Query (Starting Characters): ");
            string query = Console.ReadLine();
            List<int> employees = _company_Employees.Filter_By_Name(query, (int)Filter_Mode.Left);
            if (employees.Count == 0) 
            {
                Console.WriteLine($"No employees found matching query: {query}~");
                return;
            }
            foreach (int employee_id in employees)
            {
                _company_Employees.Read(employee_id);
            }
        }
        public void Search_Ending_Substring_Employee()
        {
            Console.Write("Enter Search Query (Ending Characters): ");
            string query = Console.ReadLine();
            List<int> employees = _company_Employees.Filter_By_Name(query, (int)Filter_Mode.Right);
            if (employees.Count == 0)
            {
                Console.WriteLine($"No employees found matching query: ~{query}");
                return;
            }
            foreach (int employee_id in employees)
            {
                _company_Employees.Read(employee_id);
            }
        }
        public void Search_Substring_Employee()
        {
            Console.Write("Enter Search Query: ");
            string query = Console.ReadLine();
            List<int> employees = _company_Employees.Filter_By_Name(query, (int)Filter_Mode.All);
            if (employees.Count == 0)
            {
                Console.WriteLine($"No employees found matching query: ~{query}~");
                return;
            }
            foreach (int employee_id in employees)
            {
                _company_Employees.Read(employee_id);
            }
        }

    }
}
