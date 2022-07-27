using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperTutorial.Core.Entities;
using DapperTutorial.Infrastructure.Repositories;
using DapperTutorial.Menus;

namespace DapperTutorial.UI
{
    public class ManageDepartment
    {
        // Dependancy Injection
        DepartmentRepository department;
        public ManageDepartment()
        {
            department = new DepartmentRepository();
        }

        private void AddDepartment()
        {
            Department d = new Department();
            Console.Write("Enter Name of Department: ");
            d.Name = Console.ReadLine();
            Console.Write("Enter Location of Department: ");
            d.Location = Console.ReadLine();

            if (department.Insert(d) > 0)
            {
                Console.WriteLine("Successfully Inserted");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void UpdateDepartment()
        {
            Department d = new Department();
            Console.Write("Enter Id of Department: ");
            d.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name of Department: ");
            d.Name = Console.ReadLine();
            Console.Write("Enter Location of Department: ");
            d.Location = Console.ReadLine();

            if (department.Update(d) > 0)
            {
                Console.WriteLine("Successfully Updated");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        private void RemoveDepartment()
        {
            Console.Write("Enter Id of Department: ");
            int Idontknowwhattocallthis = Convert.ToInt32(Console.ReadLine());

            department.DeleteById(Idontknowwhattocallthis);
        }

        private void GetAllDepartment()
        {
            IEnumerable<Department> departments = department.GetAll();
            foreach (var dep in departments)
            {
                Console.WriteLine(dep.Id + "\t" + dep.Name + "\t" + dep.Location);
            }
        }

        private void GetDepartment()
        {
            Console.Write("Enter Id of Department: ");
            int getDept = Convert.ToInt32(Console.ReadLine());

            Department d = department.GetById(getDept);
            Console.WriteLine(d.Id + "\t" + d.Name + "\t" + d.Location);
        }

        public void Run()
        {

            bool Flag = true;
            do
            {
                Console.WriteLine("Menu options:");
                Console.WriteLine("Enter 1: add a new department\n 2 : update a department\n 3 : delete a department\n 4 : read all department\n 5 : read one department\n 6 : exit.\n");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case (int)Options.Add:
                        AddDepartment();
                        Flag = true;
                        break;
                    case (int)Options.Update:
                        UpdateDepartment();
                        Flag = true;
                        break;
                    case (int)Options.Delete:
                        RemoveDepartment();
                        Flag = true;
                        break;
                    case (int)Options.Read:
                        GetAllDepartment();
                        Flag = true;
                        break;
                    case (int)Options.ReadOne:
                        GetDepartment();
                        Flag = false;
                        break;
                    case (int)Options.Exit:
                        Flag = false;
                        break;
                }

            } while (Flag);
        }
    }
}
