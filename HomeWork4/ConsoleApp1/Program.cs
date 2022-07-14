using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Леонов Алексей Николаевич

//Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
//*б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.
//**в) Обработать возможные исключительные ситуации при работе с файлами.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Verify(@"D:\test.txt"));
            Console.ReadKey();
        }

        /// <summary>
        /// Читает с текстового файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        static bool Verify(string filename)
        {
            if (File.Exists(filename))
            {
                StreamReader sr = new StreamReader(filename);
                string[] a = new string[2];
                a[0] = sr.ReadLine();
                a[1] = sr.ReadLine();
                sr.Close();

                if (a[0] == "root" && a[1] == "GeekBrains")
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
                Console.WriteLine("Error load file");
                return false;
            }            
        }
    }
}
