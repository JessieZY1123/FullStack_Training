using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;
using DapperTutorial.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperTutorial.UI
{
    public class ManageEmployees
    {
        EmployeeRepository employeeRepository = new EmployeeRepository();

        private void AddEmployee()
        {
            Employee e = new Employee();

            //Console.Write("Enter Employee ID: ");
            //e.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            e.Name= Console.ReadLine();

            Console.Write("Enter Age:");
            e.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Department Id: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());

            if (employeeRepository.Insert(e) > 0)
            {
                Console.WriteLine("Successfully Inserted\n");
            }
            else
            {
                Console.WriteLine("Error\n");
            }

        }
        private void GetAllEmployees()
        {
            IEnumerable<Employee> employees = employeeRepository.GetAll();
            foreach (var item in employees)
            {
                Console.WriteLine($"{item.Id} \t {item.Name} \t {item.Age} \t {item.Dept.Name}");
            }
        }
        private void UpdateEmployees()
        {
            Employee e = new Employee();

            //Console.Write("Enter Employee ID: ");
            //e.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            e.Name = Console.ReadLine();

            Console.Write("Enter Age:");
            e.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Department Id: ");
            e.DeptId = Convert.ToInt32(Console.ReadLine());

            if (employeeRepository.Insert(e) > 0)
            {
                Console.WriteLine("Successfully Inserted\n");
            }
            else
            {
                Console.WriteLine("Error\n");
            }
        }
        private void RemoveEmployee()
        {
            Console.Write("Enter Id Number to Delete: ");
            int id = Convert.ToInt32(Console.ReadLine());
            employeeRepository.DeleteById(id);
            Console.WriteLine("Successfully delete\n");
        }

        public void Run()
        {
            bool Flag = true;
            do
            {
                Console.WriteLine("Menu options.");
                Console.WriteLine("1 to add new Employee, 2 to update a Employee, 3 to delete a Employee, 4 to read all Employees, 5 to exit.\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case (int)OptionsEmp.Add:
                        AddEmployee();
                        Flag = true;
                        break;
                    case (int)OptionsEmp.Update:
                        UpdateEmployees();
                        Flag = true;
                        break;
                    case (int)OptionsEmp.Delete:
                        RemoveEmployee();
                        Flag = true;
                        break;
                    case (int)OptionsEmp.Read:
                        GetAllEmployees();
                        Flag = true;
                        break;
                    case (int)OptionsEmp.Exit:
                        Flag = false;
                        break;
                }
            } while (Flag);
        }
    }
}