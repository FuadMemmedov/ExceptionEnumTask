using Core.Enums;
using Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class ClassRoom
    {
        static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        private ClassType _type;
        public  int StudentLimit { get; set; }

        Student[] Students = new Student[] {};

        public ClassType Type 
        {
            get 
            { 
                return _type; 
            }
            set
            {
                if(value == ClassType.Backend)
                {
                    StudentLimit = 20;
                }
                else if(value == ClassType.Frontend)
                {
                    StudentLimit = 15;

                }
                _type = value;
            }
        }
        

        public ClassRoom(string name, ClassType type)
        {
            _id++;
            Id = _id;
            Name = name;
            Type = type;
           
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Type: {Type}";
        }

       
        public void StudentAdd(Student student)
        {
            if(Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;

            }

            
        }

        public object FindId(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    return student;
                }

            }
            return null;
        }
        public Student[] Delete(int id)
        {
            bool check = false;
            
            Student[] newStudents = new Student[0];

            foreach (Student student in Students)
            {
                if (student.Id != id)
                {

                    Array.Resize(ref newStudents, newStudents.Length + 1);
                    newStudents[newStudents.Length - 1] = student;
                    check = true;
                }



            }
            if (!check)
            {
                throw new StudentNotFoundException("Telebe tapilmadi");
            }


            Students = newStudents;
            return Students;
        }

        public Student[] GetAllStudents()
        {
            return Students;
        }







    }
}
