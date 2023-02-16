using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Personelin TC Kimlik numarası alınırken yapılması gereken şartlar
 
 * SET şartları
 * 1- TC Kimlik no'su 11 karakter olmalı
 * 2- Tüm karakterleri sayısal karakter olmalı
 
 * GET şartları
 * 1- TC Kimlik no'sunun sadece ilk 5 karakteri alınacak
 
 */


namespace EncapsulationEmployeeTC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.TCNO = "12345678920";
            Console.WriteLine("TC Kimlik Numaranız: " + employee.TCNO);
            Console.ReadLine();
        }
    }
}
