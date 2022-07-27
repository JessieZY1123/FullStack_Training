using DapperTutorial.UI;

//ManageDepartment m = new ManageDepartment();

//m.Run();
bool Flag = true;
do
{
    Console.WriteLine("Menu options:");
    Console.WriteLine("1 to Department Menu, 2 to enter Employee Menu, 3 to exit.\n");

    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            ManageDepartment manageDepartment = new ManageDepartment();
            manageDepartment.Run();
            Flag = true;
            break;
        case 2:
            ManageEmployees manageEmployee = new ManageEmployees();
            manageEmployee.Run();
            Flag = true;
            break;
        case 3:
            Flag = false;
            break;
    }
} while (Flag);