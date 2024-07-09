using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace курсовая_работа
{
    internal class Group
    {
        int numStudents { get; set; }
        string nameGroup { get; set; }
        int KollihestoMest { get; set; }
        int WWW { get; set; }
        List<TStudent> students;
        public TStudent this[int f]
        {
            get { return students[f]; }
            set { students[f] = value; }
        }

        public Group()
        {
            try
            {
                int o = 0;
                Console.Write("Введите наименование направления : ");
                nameGroup = Console.ReadLine();
                while (o == 0)
                {
                    Console.Write("Введите количество абитуриентов подавших заявления  : ");
                    try
                    {
                        numStudents = int.Parse(Console.ReadLine());
                        o = 1;
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Ошибка формата данных");
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("Ошибка ввода данных");
                    }
                }
                o = 0;
                while (o == 0)
                {
                    Console.Write("Введите количество мест  : ");
                    try
                    {
                        KollihestoMest = int.Parse(Console.ReadLine());
                        o = 1;
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Ошибка формата данных");
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("Ошибка ввода данных");
                    }

                }
            
            students = new List<TStudent>();
            Console.WriteLine();
            if (KollihestoMest > numStudents) { WWW = 0; }
            else { WWW = numStudents - KollihestoMest; }
            for (int i = 0; i < numStudents; i++)
            {
                students.Add(new TStudent());
            }
            students = students.OrderByDescending(s => s.Ege).ToList();
        }
            catch { Console.WriteLine("Ошибка"); throw new Exception(); };
        }

        public void ShowGroup()
        {
            Console.WriteLine($"Список студентов группы: {nameGroup}");
            for (int i = 0; i < students.Count - WWW; i++)
            {
                students[i].ShowStudent();
                Console.WriteLine();
            }
            Console.WriteLine($"Список не поступивших абитуриентов: {nameGroup}");
            for (int i = KollihestoMest; i < students.Count; i++)
            {
                students[i].ShowStudent();
                Console.WriteLine();
            }
        }
    }
}
