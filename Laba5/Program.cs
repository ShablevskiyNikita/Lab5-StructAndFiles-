using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill
            StreamReader reader = new StreamReader("input.txt");
            //We might use the line below
            //int count = System.IO.File.ReadAllLines("file.txt").Length
            List<Student> students = new List<Student>() ;
            while (!reader.EndOfStream)
            {
                students.Add(new Student(reader.ReadLine()));
            }
            reader.Close();
            return students.ToArray();
        }
        static void RunMenu(Student[] studs)
        {
            bool shouldContinue = true;
            while(shouldContinue)
            {
                Console.WriteLine("Щоб запустити виконання варіанту 4(виконавець Липоватий), введіть 1");
                Console.WriteLine("Щоб запустити виконання варіанту 5(виконавець Пахаренко), введіть 2");
                Console.WriteLine("Щоб запустити виконання варіанту 16(виконавець Шаблевський), введіть 3");
                Console.WriteLine("Для виходу введіть 0");
                switch (Console.ReadLine())
                {
                    case "0":
                        //exit
                        shouldContinue = false;
                        break;
                    case "1":
                        //Nikita`s method
                        break;
                    case "2":
                        Program.HandleIneffectiveStudents(studs);
                        break;
                    case "3":
                        //Mikitka`s method
                        SearchAllFives(studs);
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            RunMenu(studs);
            Console.ReadKey();
        }
    }
}
