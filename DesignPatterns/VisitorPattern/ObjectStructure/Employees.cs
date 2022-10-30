using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.ConcreteElement;
using VisitorPattern.Visitor;

namespace VisitorPattern.ObjectStructure
{
    /// <summary>
    /// The 'ObjectStructure' class
    /// </summary>
    public class Employees
    {
        private List<Employee> employees = new List<Employee>();
        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }
        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }
        public void Accept(IVisitor visitor)
        {
            foreach (Employee employee in employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
    // Three employee types
    public class Clerk : Employee
    {
        // Constructor
        public Clerk()
            : base("Kevin", 25000.0, 14)
        {
        }
    }
    public class Director : Employee
    {
        // Constructor
        public Director()
            : base("Elly", 35000.0, 16)
        {
        }
    }
    public class President : Employee
    {
        // Constructor
        public President()
            : base("Eric", 45000.0, 21)
        {
        }
    }
}
