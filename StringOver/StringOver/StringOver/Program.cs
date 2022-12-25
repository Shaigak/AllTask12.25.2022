// See https://aka.ms/new-console-template for more information
using StringOver;
using StringOver.Constants;
using StringOver.Enums;

//Console.WriteLine("Hello, World!");

//Employee employee = new Employee("Shaiq","Kazimov",25,"Sedmoy");
//Console.WriteLine(employee);

//static Employee GetEmployee(Employee employee)
//{
//    return employee;
//}

//Console.WriteLine(GetEmployee(employee));
//string email = "ff@gmail.com";
//if (email != "ft@gmail.com")
//{
//    Console.WriteLine(Erorrs.NotFount);
//}

//int roleId = 2;

////if(roleId == (int)Roles.SuperAdmin)
////{
////    Console.WriteLine("SuperAdmindir");
////}
//switch (roleId)
//{
//    case (int)Roles.SuperAdmin:
//        Console.WriteLine("Super admindir");
//        break;
//    case (int)Roles.Admin:
//        Console.WriteLine("Admindir");
//        break;
//    case (int)Roles.Member:
//        Console.WriteLine("Memberdir");
//        break ;
//    default:
//        Console.WriteLine("Role Tapilmadi");
//        break;
//}

string[] names = Enum.GetNames(typeof(Roles));
string inputData = "Admin";
foreach (var item in names)
{
    if (inputData == item)
    {
        Console.WriteLine($"User role is-{item}");
        break;
    }
}
