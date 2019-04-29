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
        private static void HandleIneffectiveStudents(Student[] students)
        {
            var ineffectiveStudentIndexes = new List<int>();

            for (var i = 0; i < students.Length; i++)
            {
                var student = students[i];

                if (IsMarkUnacceptable(student.mathematicsMark)
                    || IsMarkUnacceptable(student.physicsMark)
                    || IsMarkUnacceptable(student.informaticsMark))
                {
                    ineffectiveStudentIndexes.Add(i);
                }
            }

            var newData = new string[students.Length];
            for (var i = 0; i < students.Length; i++)
            {
                var student = students[i];
                var newScholarship = student.scholarship;
                if (ineffectiveStudentIndexes.Contains(i))
                {
                    newScholarship = 0;
                }

                newData[i] = student.surName + " " +
                             student.firstName + " " +
                             student.patronymic + " " +
                             student.sex + " " +
                             student.dateOfBirth + " " +
                             student.mathematicsMark + " " +
                             student.physicsMark + " " +
                             student.informaticsMark + " " +
                             newScholarship;
            }

            File.WriteAllText(Environment.CurrentDirectory + "\\new_data.txt", string.Join(Environment.NewLine, newData));

            foreach (var index in ineffectiveStudentIndexes)
            {
                var student = students[index];
                Console.WriteLine(
                    student.surName + " " +
                    student.mathematicsMark + " " +
                    student.physicsMark + " " +
                    student.informaticsMark
                );
            }
        }

        private static bool IsMarkUnacceptable(char mark)
        {
            return mark == '-' || Convert.ToInt32(mark) <= 2;
        }
    }
}