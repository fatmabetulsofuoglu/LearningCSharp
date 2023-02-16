using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationEmployeeTC
{
    public class Employee
    {
        private string TCNo;
        public string TCNO
        {
            get
            {
                if (TCNo == null)
                {
                    return TCNo + "Hatalı!";
                }
                else
                {
                    return TCNo.Substring(0, 5) + "******";
                }
            }
            set
            {
                bool control = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool isNumber = char.IsNumber(value[i]); // Girilen karakter sayı mı? kontrolü yapılıyor.

                        if (!isNumber)
                        {
                            control = true;
                            break;
                        }
                    }

                    if (control)
                    {
                        Console.WriteLine("Geçersiz karakter!");
                    }
                    else
                    {
                        TCNo = value;
                    }
                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC Kimlik No 11 karakter olmalı!");
                }
            }
        }
    }
}
