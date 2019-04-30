using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_lab_student
{
    partial class Program
    {
        private static void SearchAllFivesAndUpgradeItScholarship(Student[] studs)
        {
            List<int> IndOfGreatStudents = new List<int>();
            for (int i = 0; i < studs.Length; i++)
            {
                if (studs[i].mathematicsMark == '5' && studs[i].informaticsMark == '5' && studs[i].physicsMark == '5')
                {
                    IndOfGreatStudents.Add(i);
                }
            }
            for (int i = 0; i < IndOfGreatStudents.Count; i++)
            {
                studs[IndOfGreatStudents[i]].scholarship = 1600;
            }
            if (IndOfGreatStudents.Count > 0)
            {
                Console.WriteLine("Cписок відмінників:");
                for (int i = 0; i < IndOfGreatStudents.Count; i++)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", studs[IndOfGreatStudents[i]].surName, studs[IndOfGreatStudents[i]].firstName, studs[IndOfGreatStudents[i]].patronymic
                    ,studs[IndOfGreatStudents[i]].dateOfBirth
                    , studs[IndOfGreatStudents[i]].informaticsMark,studs[IndOfGreatStudents[i]].mathematicsMark,studs[IndOfGreatStudents[i]].physicsMark, studs[IndOfGreatStudents[i]].scholarship);
                }
                string[] newData = new string[IndOfGreatStudents.Count];
                for (int i = 0; i < IndOfGreatStudents.Count; i++)
                {
                    Student student = studs[IndOfGreatStudents[i]];

                    newData[i] = student.surName + " " + student.firstName + " " + student.patronymic + " " +
                                 student.dateOfBirth + " " +
                                 student.mathematicsMark + " " +
                                 student.physicsMark + " " +
                                 student.informaticsMark + " " +
                                 student.scholarship;
                }
                File.WriteAllText(Environment.CurrentDirectory + "\\data_new.txt", string.Join(Environment.NewLine, newData));
            }
            else
            {
                Console.WriteLine("Немає студентів з усіма п'ятірками");
            }
            
        }
    }
}
