using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var arrayNumber = new List<int> { 20, 10, 2, 34, 33, 12, 35 };

            var task1 = arrayNumber.Where(x => x % 2 == 0).Sum();
            Console.WriteLine(task1);
            

            var modelsOfStudents = new List<InformationOnStudent>
            {
                new InformationOnStudent {FirstName = "Алексей", LastName = "Иванов", Age = 25, Course = 4, Gpa = 3},
                new InformationOnStudent {FirstName = "Николай", LastName = "Петров", Age = 24, Course = 3, Gpa = 2},
                new InformationOnStudent {FirstName = "Максим", LastName = "Сидоров", Age = 23, Course = 2, Gpa = 4},
                new InformationOnStudent {FirstName = "Валерий", LastName = "Савелов", Age = 25, Course = 4, Gpa = 4.34},
                new InformationOnStudent {FirstName = "Евгений", LastName = "Давыдов", Age = 25, Course = 4, Gpa = 3},
                new InformationOnStudent {FirstName = "Инокентий", LastName = "Пукин", Age = 22, Course = 1, Gpa = 5},
                new InformationOnStudent {FirstName = "Андрей", LastName = "Засранов", Age = 25, Course = 4, Gpa = 3},
                new InformationOnStudent {FirstName = "Евклид", LastName = "Кощунский", Age = 24, Course = 3, Gpa = 3},
            };

            var task2 = modelsOfStudents.Where(x => x.Gpa == 3).Select(y => $"{y.FirstName} {y.LastName} {y.Course} {y.Age}").ToList();
            var task21 = modelsOfStudents.GroupBy(x => x.Course).ToList();

            OutList(task2);
            Console.WriteLine(task21);




        }

       public class InformationOnStudent
       {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public int Course { get; set; }
            public double Gpa { get; set; }
       }
        public static void OutList(List<string> outModel)
        {
            for (int i = 0; i < outModel.Count; i++)
            {
                Console.WriteLine(outModel[i]);
            }
        }

        public static void OutList(List<IGrouping<int, InformationOnStudent>> groppingInformation)
        {

        }




    }
}
