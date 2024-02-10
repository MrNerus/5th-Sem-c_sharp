using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Simulation.Employee_Management
{

    public class Employee : Common
    {
        public int Department_Id { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, int department_Id, decimal salary)
        {
            Id = id;
            Name = name;
            Department_Id = department_Id;
            Salary = salary;
        }

    }

    public interface IEmployee_Service
    {
        int Create(string name, int department_Id, decimal salary);
        bool Delete(int id);
        bool Update(int id, string name, int department_Id, decimal salary);
        Tuple<int, string, int, decimal> Read(int id);
        Employee Get_Object(int id);
        List<int> Filter_By_Name(string query, int mode);
    }

    public class Employee_Service : IEmployee_Service
    {
        public List<Employee> Employees{ get; } = new List<Employee>();
        private int _sequence = 1;
        public Employee_Service()
        {
            // First thing First. Failsafe Employee.
            Employees.Add(new Employee(0, "<Insert Registered Name>", 0, 0.0M));
        }
        public int Create(string name, int department_Id, decimal salary)
        {
            // Creates a new Employee
            // Adds it to list
            // increase sequence by 1 for upcomming Employee
            // displays information of new Employee in console.
            // returns id of new Employee
            Employee employee = new Employee(_sequence, name, department_Id, salary);
            Employees.Add(employee);
            _sequence++;
            Console.WriteLine($"Successfully registered new Employee.");
            Console.WriteLine($"\tEmployee Id: {employee.Id}");
            Console.WriteLine($"\tEmployee Name: {employee.Name}");
            return employee.Id;
        }
        public bool Delete(int id)
        {
            // if Employee id is the one of "FailSafe" Employee,
            //   Error message is displayed in console.
            //   returns false.
            // Removes Employee.
            // Success message is dispayed in console.
            // returns true.
            Employee employee = Get_Object(id);
            if (employee.Id == 0)
            {
                Console.WriteLine($"Error: Cannot Delete Employee ID: {id}");
                return false;
            }
            Employees.Remove(employee);
            Console.WriteLine($"Successfully removed {employee.Id}: {employee.Name}");

            return true;
        }
        public bool Update(int id, string name="", int department_Id=-1, decimal salary=-1.0M)
        {
            // if Employee id is the one of "FailSafe" Employee,
            //   Error message is displayed in console.
            //   return false
            // Updates all fields if requested to.
            // Success message is printed in console.
            // returns true
            var employee = Get_Object(id);
            if (employee.Id == 0)
            {
                Console.WriteLine($"Error: Cannot Edit Employee ID: {id}");
                return false;
            }
            employee.Name = (name == "") ? employee.Name : name;
            employee.Department_Id = (department_Id == -1) ? employee.Department_Id : department_Id;
            employee.Salary = (salary == -1.0M) ? employee.Salary : salary;
            Console.WriteLine($"Successfully applied changes to {employee.Id}: {employee.Name}");
            return true;
        }
        public Tuple<int, string, int, decimal> Read(int id)
        {
            // Returns detail of Employee id even if it is "FailSafe"
            var employee = Get_Object(id);
            Console.WriteLine($"Info:");
            Console.WriteLine($"\tId: {employee.Id}");
            Console.WriteLine($"\tName: {employee.Name}");
            Console.WriteLine($"\tDepartment_id: {employee.Department_Id}");
            Console.WriteLine($"\tSalary: {employee.Salary}");
            return new Tuple<int, string, int, decimal>(employee.Id, employee.Name, employee.Department_Id, employee.Salary);
        }
        public Employee Get_Object(int id)
        {
            // If id is found, returns that object
            // Otherwise return default Employee
            foreach (Employee employee in Employees)
            {
                if (employee.Id == id) { return employee; }
            }
            return Employees[0];
        }

        public List<int> Filter_By_Name(string query, int mode = (int)Filter_Mode.All)
        {
            List<int> result = new List<int>();

            if (mode == (int)Filter_Mode.Left)
            {
                foreach (var employee in Employees)
                {
                    if (employee.Id == 0) { continue; }
                    if (employee.Name.StartsWith(query, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(employee.Id);
                    }
                }
            }
            if (mode == (int)Filter_Mode.Right)
            {
                foreach (var employee in Employees)
                {
                    if (employee.Id == 0) { continue; }
                    if (employee.Name.EndsWith(query, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(employee.Id);
                    }
                }
            }
            if (mode == (int)Filter_Mode.All)
            {
                foreach (var employee in Employees)
                {
                    if (employee.Id == 0) { continue; }
                    if (employee.Name.ToUpper().Contains(query.ToUpper()))
                    {
                        result.Add(employee.Id);
                    }
                }
            }

            return result;
        }

    }

}
