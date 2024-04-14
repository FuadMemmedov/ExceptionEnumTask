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
            string answer;
            bool check;
            string className;
            do
            {
                Console.Write("Sinfin adin daxil edin: ");
                className = Console.ReadLine();
                check = className.CheckClassName();

            } while (!check) ;

            Console.WriteLine("1.BackEnd\n" +
                "2.FrontEnd");
            Console.Write("Bir type secin: ");
            string chocie = Console.ReadLine();
            byte typeChoice = byte.Parse(chocie);
            ClassRoom classRoom1 = new ClassRoom(className, (ClassType)typeChoice);


            do
            {
                Console.WriteLine("1.Student yarat\n" +
                    "2.Butun Telebeleri ekrana cixart\n" +
                    "3.Secilmis telebeleri ekrana cixart\n" +
                    "4.Telebe sil\n" +
                    "0.Programdan cixin");
                Console.Write("Bir secim edin: ");
                answer = Console.ReadLine();
                
                if(answer == "1")
                {
                    
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



                }
                if(answer == "2")
                {
                    foreach(Student student in classRoom1.GetAllStudents())
                    {
                        Console.WriteLine(student);
                    }
                       
                    
                    
                }
                if(answer == "3")
                {
                    int id;
                    do
                    {
                        Console.Write("Tapmaq istediyiniz telebenin id daxil edin: ");

                    } while (!int.TryParse(Console.ReadLine(), out id));

                    Console.WriteLine(classRoom1.FindId(id));


                }
                if (answer == "4")
                {
                    foreach (Student student in classRoom1.GetAllStudents())
                    {
                        Console.WriteLine(student);
                    }
                    int id;
                    do
                    {
                        Console.Write(" Silmek istediyiniz telebenin idsini daxil edin: ");

                    } while (!int.TryParse(Console.ReadLine(), out id));

                   classRoom1.Delete(id);



                }

               

            } while (answer != "0");
        }
    }
}
