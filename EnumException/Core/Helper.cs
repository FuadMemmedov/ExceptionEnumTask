using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Helper
    {

        public static bool CheckName(this string name)
        {
            bool checkSpace = true;
            bool checkFirsLetter = false;
            if (name.Length >= 3)
            {
                if (name[0].ToString() == name[0].ToString().ToUpper())
                {
                    checkFirsLetter = true;
                }
                for (int i = 1; i < name.Length; i++)
                {
                    if (name[i] == ' ')
                    {
                        checkSpace = false;
                        break;
                    }
                }
            }

            if (checkFirsLetter && checkSpace)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool CheckSurname(this string surname)
        {
            bool CheckSpace = true;
            bool CheckFirsLetter = false;
            if (surname.Length >= 3)
            {
                if (surname[0].ToString() == surname[0].ToString().ToUpper())
                {
                    CheckFirsLetter = true;
                }
                for (int i = 1; i < surname.Length; i++)
                {
                    if (surname[i] == ' ')
                    {
                        CheckSpace = false;
                        break;
                    }
                }
            }

            if (CheckFirsLetter && CheckSpace)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckClassName(this string classroom)
        {

            bool checkLetter = false;
            bool checkDigit = false;

            if (classroom.Length == 5)
            {
                
                
                    if (char.IsUpper(classroom[0]) && char.IsLetter(classroom[1]))
                    {
                        checkLetter = true;
                    }
                    else
                    {
                        checkLetter = false;
                    
                    }
                

                for (int i = classroom.Length - 3; i < classroom.Length; i++)
                {
                    if (char.IsDigit(classroom[i]))
                    {
                        checkDigit = true;
                    }
                    else
                    {
                        checkDigit = false;
                        break;
                    }
                }

                if (checkLetter && checkDigit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }




    }


}

