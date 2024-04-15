using Core;
using Core.Enums;
using Core.Models;
using System;

namespace EnumException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte choice;
            bool check;
            string className;
            do
            {
                Console.Write("Sinfin adin daxil edin: ");
                className = Console.ReadLine();
                check = className.CheckClassName();

            } while (!check) ;

            byte typeChoice;
            do
            {
                Console.WriteLine("1.BackEnd\n" +
               "2.FrontEnd");
                Console.Write("Bir type secin: ");

            } while (!byte.TryParse(Console.ReadLine(),out typeChoice));
           
            
            
            ClassRoom classRoom1 = new ClassRoom(className, (ClassType)typeChoice);


            do
            {
                Console.WriteLine("1.Student yarat\n" +
                    "2.Butun Telebeleri ekrana cixart\n" +
                    "3.Secilmis telebeleri ekrana cixart\n" +
                    "4.Telebe sil\n" +
                    "0.Programdan cixin");
               do
                {
                    Console.Write("Bir secim edin: ");

                } while (!byte.TryParse(Console.ReadLine(),out choice));

                switch (choice)
                {
                    case (byte)Menu.Studentyarat:
                        string name;
                        string surname;
                        do
                        {
                            Console.Write("Telebenin adini daxil edin: ");
                            name = Console.ReadLine();
                            check = name.CheckName();

                        } while (!check);

                        do
                        {
                            Console.Write("Telebenin soyadini  daxil edin: ");
                            surname = Console.ReadLine();
                            check = surname.CheckSurname();

                        } while (!check);


                        Student student = new Student(name, surname);

                        classRoom1.StudentAdd(student);
                        break;
                        case (byte)Menu.ButunTelebeleriekranacixart:

                        foreach (Student item in classRoom1.GetAllStudents())
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case (byte)Menu.Secilmistelebeleriekranacixart:

                        int findId;
                        do
                        {
                            Console.Write("Tapmaq istediyiniz telebenin id daxil edin: ");

                        } while (!int.TryParse(Console.ReadLine(), out findId));

                        Console.WriteLine(classRoom1.FindId(findId));
                        break;
                    case (byte)Menu.Telebesil:

                        foreach (Student item in classRoom1.GetAllStudents())
                        {
                            Console.WriteLine(item);
                        }
                        int removeId;
                        do
                        {
                            Console.Write(" Silmek istediyiniz telebenin idsini daxil edin: ");

                        } while (!int.TryParse(Console.ReadLine(), out removeId));

                        classRoom1.Delete(removeId);
                        break;





                    default:
                        break;
                }




            } while (choice != 0);



        }
        
    }
    
}

