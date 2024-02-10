using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Simulation.Employee_Management
{

    public class Department : Common
    {
        public string Remarks { get; set; }
        public Department(int id, string name, string remarks)
        {
            Id = id;
            Name = name;
            Remarks = remarks;
        }
    }

    public interface IDepartment_Service
    {
        int Create(string name, string remarks);
        bool Delete(int id);
        bool Update(int id, string name, string remarks);
        Tuple<int, string, string> Read(int id);
        Department Get_Object(int id);
        List<int> Filter_By_Name(string query, int mode);
    }

    public class Department_Service : IDepartment_Service
    {
        public List<Department> Departments { get; } = new List<Department>();
        private int _sequence = 1;
        public Department_Service()
        {
            // First thing First. Failsafe department.
            Departments.Add(new Department(0, "<Insert Registered Name>", "<Insert Remarks>"));
        }
        public int Create(string name, string remarks)
        {
            // Creates a new department
            // Adds it to list
            // increase sequence by 1 for upcomming department
            // displays information of new department in console.
            // returns id of new department
            Department department = new Department(_sequence, name, remarks);
            Departments.Add(department);
            _sequence++;
            Console.WriteLine($"Successfully registered new Department.");
            Console.WriteLine($"\tDepartment Id: {department.Id}");
            Console.WriteLine($"\tDepartment Name: {department.Name}");
            return department.Id;
        }
        public bool Delete(int id)
        {
            // if department id is the one of "FailSafe" department,
            //   Error message is displayed in console.
            //   returns false.
            // Removes department.
            // Success message is dispayed in console.
            // returns true.
            var department = Get_Object(id);
            if (department.Id == 0) 
            {
                Console.WriteLine($"Error: Cannot Delete Department ID: {id}");
                return false; 
            }
            Departments.Remove(department);
            Console.WriteLine($"Successfully removed {department.Id}: {department.Name}");

            return true;
        }
        public bool Update(int id,  string name = "", string remarks = "")
        {
            // if department id is the one of "FailSafe" department,
            //   Error message is displayed in console.
            //   return false
            // Updates fields if requested to.
            // Success message is printed in console.
            // returns true
            var department = Get_Object(id);
            if (department.Id == 0)
            {
                Console.WriteLine($"Error: Cannot Edit Department ID: {id}");
                return false;
            }
            department.Name = (name == "") ? department.Name : name;
            department.Remarks = (remarks == "") ? department.Remarks : remarks;
            Console.WriteLine($"Successfully applied changes to {department.Id}: {department.Name}");
            return true;
        }
        public Tuple<int, string, string> Read(int id)
        {
            // Returns detail of department id even if it is "FailSafe"
            var department = Get_Object(id);
            Console.WriteLine($"Info:");
            Console.WriteLine($"\tId: {department.Id}");
            Console.WriteLine($"\tName: {department.Name}");
            Console.WriteLine($"\tRemarks: {department.Remarks}");
            return new Tuple<int, string, string> (department.Id, department.Name, department.Remarks);
        }
        public Department Get_Object(int id)
        {
            // If id is found, returns that object
            // Otherwise return default department
            foreach (Department department in Departments)
            {
                if (department.Id == id) { return department; }
            }
            return Departments[0];
        }
    
        public List<int> Filter_By_Name(string query, int mode = (int)Filter_Mode.All) 
        { 
            List<int> result = new List<int>();

            if (mode == (int)Filter_Mode.Left)
            {
                foreach (var department in Departments)
                {
                    if (department.Id == 0) { continue; }
                    if (department.Name.StartsWith(query, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add (department.Id);
                    }
                }
            }
            if (mode == (int)Filter_Mode.Right)
            {
                foreach (var department in Departments)
                {
                    if (department.Id == 0) { continue; }
                    if (department.Name.EndsWith(query, StringComparison.OrdinalIgnoreCase))
                    {
                        result.Add(department.Id);
                    }
                }
            }
            if (mode == (int)Filter_Mode.All)
            {
                foreach (var department in Departments)
                {
                    if (department.Id == 0) { continue; }
                    if (department.Name.ToUpper().Contains(query.ToUpper()))
                    {
                        result.Add(department.Id);
                    }
                }
            }

            return result;
        }
    
    }

}
