using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace курсовая_работа
{
    internal class TStudent
    {
        string surname { get; set; }
        string name { get; set; }
        char pol { get; set; }
        DateTime date { get; set; }
        int A { get; set; }
        int B { get; set; }
        int C { get; set; }
        public int Ege { get; set; }


        public TStudent()
        {
            bool r = false;
            int d=0,o = 0;
            try
            {
                while (r==false)
                {
                    try
                    {
                        Console.Write("Введите фамилию: "); surname = Console.ReadLine();
                        r = Regex.IsMatch(surname, @"^[a-zA-Zа-яА-Я]+$");
                        if (r == false) { throw new Exception(); }
                    }
                    catch (Exception ) { Console.WriteLine("Есть недопустимые знаки ");d++; }
                    finally { if (d == 7) { throw new Exception(); } }
                }
                while (r == false)
                {
                    try
                    {
                        Console.Write("Введите имя: "); name = Console.ReadLine();
                        r = Regex.IsMatch(surname, @"^[a-zA-Zа-яА-Я]+$");
                        if (r == false) { throw new Exception(); }
                    }
                    catch (Exception ) { Console.WriteLine("Есть недопустимые знаки "); d++; }
                    finally { if (d == 7) { throw new Exception(); } }
                }
                
                o = 0;
                while (o == 0)
                {
                    try
                    {
                        Console.Write("Введите пол: "); pol = char.Parse(Console.ReadLine());
                        if (pol != 'М' & pol != 'Ж') { throw new Exception(); }
                        o = 1;
                    }
                    catch (FormatException ) { Console.WriteLine("Ввдите М или Ж "); }
                    catch (Exception ) { Console.WriteLine("Ошибка Ввода."); d++; }
                    finally { if (d == 7) { throw new Exception(); } }
                }
                int monthBirthday = 0;
                int yearBirthday = 0;
                int dayBirthday = 0;
                int t = 0;
                o = 0;
                while (t == 0)
                {
                    try
                    {
                        Console.WriteLine("Введите день,месяц и год рождения");
                        o = 0;
                        while (o == 0)
                        {
                            try
                            {
                                Console.Write("День: ");
                                dayBirthday = int.Parse(Console.ReadLine());
                                if (dayBirthday < 0 | dayBirthday > 30) { throw new Exception(); }
                                o = 1;
                            }
                            catch (FormatException )
                            {
                                Console.WriteLine("Ошибка формата данных"); d++;
                            }
                            catch (Exception ) { Console.WriteLine("Ошибка : дни от 1 до 30 "); d++; }
                            finally { if (d == 7) { throw new Exception(); } }

                            try
                            {
                                Console.Write("месяц: ");
                                monthBirthday = int.Parse(Console.ReadLine());
                                if (monthBirthday < 0 | monthBirthday > 12) { throw new Exception(); }
                                o = 1;
                            }
                            catch (FormatException )
                            {
                                Console.WriteLine("Ошибка формата данных"); d++;
                            }
                            catch (Exception ) { Console.WriteLine("Ошибка : месяц от 1 до 12 "); d++; }
                            finally { if (d == 7) { throw new Exception(); } }
                            try
                            {
                                Console.Write("Год: ");
                                yearBirthday = int.Parse(Console.ReadLine());
                                DateTime dat = DateTime.Today;
                                int date = dat.Year - 16;
                                if (yearBirthday < 1970 | yearBirthday > date) { throw new Exception(); }
                                o = 1;
                            }
                            catch (FormatException )
                            {
                                Console.WriteLine("Ошибка формата данных"); d++;
                            }
                            catch (Exception ) { Console.WriteLine("Ошибка : года от 1970 до " + date); d++; }
                            finally { if (d == 7) { throw new Exception(); } }
                        }  
                            date = new DateTime(yearBirthday, monthBirthday, dayBirthday);t++;
                        
                    }
                    catch { Console.WriteLine("Ошибка неправельное количество дней в месяце" + "\n введите дату заново "); d++; }
                }
                o = 0;
                while (o == 0)
                {
                    try
                    {
                        Console.Write("Введите результат ЕГЭ по математике: ");
                        A = int.Parse(Console.ReadLine());
                        if (A < 0 | A > 100) { throw new Exception(); }
                        o = 1;
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Ошибка формата данных"); d++;
                    }
                    catch (Exception ) { Console.WriteLine("Ошибка колличество боллов не привышает 100 и не меньше 0 "); d++; }
                    finally { if (d == 7) { throw new Exception(); } }

                }
                o = 0;
                while (o == 0)
                {
                    try
                    {
                        Console.Write("Введите результат ЕГЭ по русскому языку ");
                        B = int.Parse(Console.ReadLine());
                        if (B < 0 |B > 100) { throw new Exception(); }
                        o = 1;
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Ошибка формата данных"); d++;
                    }
                    catch (Exception ) { Console.WriteLine("Ошибка колличество боллов не привышает 100 и не меньше 0 "); d++; }
                    finally { if (d == 7) { throw new Exception(); } }

                }
                o = 0;
                while (o == 0)
                {
                    try
                    {
                        Console.Write("Введите результат ЕГЭ по информатике: ");
                        C = int.Parse(Console.ReadLine());
                        if (C < 0 | C > 100) { throw new Exception(); }
                        o = 1;
                    }
                    catch (FormatException )
                    {
                        Console.WriteLine("Ошибка формата данных"); d++;
                    }
                    catch (Exception ) { Console.WriteLine("Ошибка колличество боллов не привышает 100 и не меньше 0 "); d++; }
                    finally { if (d == 7) { throw new Exception(); } }

                }
                
            }
            catch (Exception )
            { throw new Exception(); }

            Ege = A + B + C;
            Console.WriteLine();
        }
        public int Age()
        {
            DateTime now = DateTime.Today;
            int Age = now.Year - date.Year;
            now = now.AddYears(-Age);
            if (date > now) Age--;
            return Age;
        }

        public void ShowStudent()
        {
            Console.WriteLine($"Фамилия {surname}");
            Console.WriteLine($"Имя {name}");
            Console.WriteLine($"Пол {pol}");
            Console.WriteLine($"Дата рождения {date.Day}.{date.Month}.{date.Year}");
            Console.WriteLine($"Сумарный результат ЕГЭ " + Ege);
            Console.WriteLine($"Возраст {Age()}");
        }
    }
}
