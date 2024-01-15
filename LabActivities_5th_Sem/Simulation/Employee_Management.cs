using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivities_5th_Sem.Simulation
{
    public class Employee_Management
    {
        public static void Entry_Point()
        {
            // म गरूँ त के गरूँ ?
            // म गरूँ त कसरी गरूँ ?
            // म गरूँ त किन गरूँ ?
            //
            // किन छु म यहाँ, बिर्सिसकेँ...
            // सोच्ने तरीका सक्किसके...
            // दिमाग सबै NULL इसाके...
            // अब भन्नुस्,
            // म गरूँ त के गरूँ,

            // Code: Work in Progress
        }
    }
    public class Department: CRUDDepartment
    {
        private int id = 0;
        private string name = "";
        private string remarks = "";
        public Department(int id, string name, string remarks)
        {
            this.id = id;
            this.name = name;
            this.remarks = remarks;
        }
        public override int GetId() { return this.id; }
        public override string GetName() { return this.name; }
        public override string GetRemarks() { return this.remarks; }
        public override void SetName(string name) { this.name = name; }
        public override void SetRemarks(string remarks) { this.remarks = remarks; }
    }
    public class Employee : CRUDEmployee
    {
        private int id = 0;
        private string name = "";
        private Department department;
        private decimal salary = 0.0M;

        public Employee(int id, string name, Department department, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
        public override int GetId() { return this.id; }
        public override string GetName() { return this.name; }
        public override string GetDepartment() { return this.department.GetName(); }
        public override decimal GetSalary() { return this.salary; }
        public override void SetName(string name) { this.name = name; }
        public override void SetDepartment(Department department) { this.department= department; }
        public override void SetSalary(decimal salary) { this.salary = salary; }

    }

    public abstract class CRUDEmployee
    {
        public abstract int GetId();
        public abstract string GetName();
        public abstract string GetDepartment();
        public abstract decimal GetSalary();
        public abstract void SetName(string name);
        public abstract void SetDepartment(Department department);
        public abstract void SetSalary(decimal salary);
    }
    public abstract class CRUDDepartment
    {
        public abstract int GetId();
        public abstract string GetName();
        public abstract string GetRemarks();
        public abstract void SetName(string name);
        public abstract void SetRemarks(string remarks);
    }
}
