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
            List<int> indexGreatStudent = new List<int>();
            for (int i = 0; i < studs.Length; i++)
            {
                bool isGreatStudent = true;
                if(studs[i].mathematicsMark!='5')
                {
                    isGreatStudent = false;
                }
                if (studs[i].informaticsMark != '5')
                {
                    isGreatStudent = false;
                }
                if (studs[i].physicsMark != '5')
                {
                    isGreatStudent = false;
                }
                if(isGreatStudent)
                {
                    indexGreatStudent.Add(i);
                }
            }
            Console.WriteLine("Кількість відмінників : {0}", indexGreatStudent.Count);
            Console.WriteLine("Cписок відмінників і їх стипендії :");
            for (int i = 0; i < indexGreatStudent.Count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", studs[indexGreatStudent[i]].surName, studs[indexGreatStudent[i]].firstName, studs[indexGreatStudent[i]].patronymic, studs[indexGreatStudent[i]].scholarship);
            }
        }
    }
}
