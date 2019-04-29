using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
        }

        static void RunMenu(Student[] studs)
        {
            // TODO   implement this method
            // It should call method(s) for concrete variant(s)
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }
    }
}
