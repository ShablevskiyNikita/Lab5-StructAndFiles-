using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        private static void SearchAllFives(Student[] studs)
        {
            List<int> greatStudentIndexes = new List<int>();
            for (int i = 0; i < studs.Length; i++)
            {
                if(studs[i].mathematicsMark == '5' && studs[i].informaticsMark == '5'&& studs[i].physicsMark == '5')
                {
                    greatStudentIndexes.Add(i);
                }
            }
            Console.WriteLine("Кількість відмінників : {0}", greatStudentIndexes.Count);
            if(greatStudentIndexes.Count > 0)
            {
                Console.WriteLine("Cписок відмінників і їх стипендії :");
                for (int i = 0; i < greatStudentIndexes.Count; i++)
                {
                    Console.WriteLine("{0} {1} {2} {3}", studs[greatStudentIndexes[i]].surName, studs[greatStudentIndexes[i]].firstName, studs[greatStudentIndexes[i]].patronymic, studs[greatStudentIndexes[i]].scholarship);
                }
            }
            else
            {
                Console.WriteLine("Немає студентів з усіма п'ятірками");
            }
        }
    }
}
