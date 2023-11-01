using ChalengeApp_21c;

namespace ChalengeApp_21c
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zadanie Domowe Dzien 21 ");
            Console.WriteLine(" ");


            Console.WriteLine("Program analizuje czas wykonywania różnych czynności lub prac w czasie dnia");
            Console.WriteLine("");
            Console.WriteLine("1 - Różne bierzące zajęcia, obowiązki i prace w domu - Podaj czas wykonywania w Minutach");
            Console.WriteLine("     - Różne bierzące zajęcia i prace w domu");
            Console.WriteLine("     - koszenie trawy, sprzątanie porządkowanie ");
            Console.WriteLine("2 - Zakupy czas spędzony na zakupach w sklepach - Podaj czas wykonywania w Minutach");
            Console.WriteLine("3 - Praca przy budowie garażu ");
            Console.WriteLine("4 - Aktualna Praca Zarobkowa - Podaj czas wykonywania w Minutach");
            Console.WriteLine("    - Plus 60 minut na dojazd do pracy i przyjazd z pracy do domu");
            Console.WriteLine("5 - Nauka - Czas spędzany na nauke C# z kursu A. Kamizelich");
            Console.WriteLine("6 - Oglądanie filmów teledysków i odpoczynek w czasie dnia");
            Console.WriteLine(" ");
            Console.WriteLine("Zostaje wyświetlana informacja - przez delegat że została dodana Wartość ");

            Console.WriteLine("====================================================== ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");



            while (true)
            {
                Console.WriteLine(" Zapis do Pamieci PC Wybierz litere - p ");
                Console.WriteLine(" Zapis danych do Pliku grades.TXT Wybierz Inna litere alfabetu niż p: ");
                Console.WriteLine(" Wyjście z Programu Wybierz litere - q : ");
                var input = Console.ReadLine();
                if (input == "q")
                {

                    break;
                }

                if (input == "p")
                {
                    var employee = new TimePersonInMemory("Wxxx", "Wxxx");

                    void EmployeeGradeAdded(object sender, EventArgs args)
                    {
                        Console.WriteLine("Dodano nową wartość - Zadziałał event");
                    }
                    employee.GradeAdded += EmployeeGradeAdded;

                    Console.WriteLine("1 - Różne bierzące zajęcia, Obowiązki i prace w domu - Podaj czas wykonywania w Minutach");
                    Console.WriteLine("     - Różne bierzące zajęcia i prace w domu");
                    Console.WriteLine("       - koszenie trawy, sprzątanie porządkowanie - Podaj czas wykonywania w Minutach ");
                    var a = float.Parse(Console.ReadLine());
                    employee.AddGrade(a);
                    Console.WriteLine("2 - Zakupy czas spędzony na zakupach w sklepach - Podaj czas wykonywania w Minutach");
                    var a2 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a2);
                    Console.WriteLine("3 - Praca przy budowie garażu - Podaj czas wykonywania w Minutach ");
                    var a3 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a3);
                    Console.WriteLine("4 - Aktualna Praca Zarobkowa - Podaj czas wykonywania w Minutach");
                    Console.WriteLine("    - Plus 60 minut na dojazd do pracy i przyjazd z pracy do domu");
                    var a4 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a4);
                    Console.WriteLine("5 - Nauka - Czas spędzony na nauke C# z kursu Adam Kamizelich - Podaj czas wykonywania w Minutach");
                    var a5 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a5);
                    Console.WriteLine("6 - Oglądanie filmów teledysków i odpoczynek w czasie dnia - Podaj czas wykonywania w Minutach");
                    var a6 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a6);


                    Console.WriteLine("Osoba : " + employee.Name + " " + employee.Surname);

                    if (input == "q")
                    {
                        break;
                    }

                    try
                    {
                        employee.AddGrade(input);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"exception catched: {e.Message}");
                        {

                        }
                    }


                    Statistics statistics = employee.GetStatistics();

                    Console.WriteLine("");
                    Console.WriteLine(" Dane są zapisywane w Liście w - Pamięci PC - TimePersonInMemory");
                    Console.WriteLine("");

                    Console.WriteLine(" Minimalny czas Wykonywanej Pracy lub Czynności w czasie dnia - Czas podany w minutach");
                    Console.WriteLine(statistics.Min);
                    Console.WriteLine("");
                    Console.WriteLine(" Maksymalny czas Wykonywanej Pracy lub Czynności w czasie dnia - Czas podany w minutach");
                    Console.WriteLine(statistics.Max);
                    Console.WriteLine("");
                    Console.WriteLine(" Średni czas Wykonywania Prac lub Czynności w czasie dnia - Czas podany w minutach");
                    Console.WriteLine(statistics.Average);

                }
                else
                {
                    var employee = new TimePersonInFile("Wxxx", "Wxxx");


                    void EmployeeGradeAdded(object sender, EventArgs args)
                    {
                        Console.WriteLine("Dodano nową wartość - Zadziałał event");
                    }
                    employee.GradeAdded += EmployeeGradeAdded;

                    Console.WriteLine("1 - Różne bierzące zajęcia, Obowiązki i prace w domu - Podaj czas wykonywania w Minutach");
                    Console.WriteLine("     - Różne bierzące zajęcia i prace w domu");
                    Console.WriteLine("       - koszenie trawy, sprzątanie porządkowanie - Podaj czas wykonywania w Minutach ");
                    Console.WriteLine("");
                    var a = float.Parse(Console.ReadLine());
                    employee.AddGrade(a);
                    Console.WriteLine("2 - Zakupy czas spędzony na zakupach w sklepach - Podaj czas wykonywania w Minutach");
                    var a2 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a2);
                    Console.WriteLine("3 - Praca przy budowie garażu - Podaj czas wykonywania w Minutach ");
                    var a3 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a3);
                    Console.WriteLine("4 - Aktualna Praca Zarobkowa - Podaj czas wykonywania w Minutach");
                    Console.WriteLine("    - Plus 60 minut na dojazd do pracy i przyjazd z pracy do domu");
                    var a4 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a4);
                    Console.WriteLine("5 - Nauka - Czas spędzony na nauke C# z kursu A. Kamizelich - Podaj czas wykonywania w Minutach");
                    var a5 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a5);
                    Console.WriteLine("6 - Oglądanie filmów teledysków i odpoczynek w czasie dnia - Podaj czas wykonywania w Minutach");
                    var a6 = float.Parse(Console.ReadLine());
                    employee.AddGrade(a6);


                    Console.WriteLine("Osoba : " + employee.Name + " " + employee.Surname);

                    if (input == "q")
                    {
                        break;
                    }

                    try
                    {
                        employee.AddGrade(input);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"exception catched: {e.Message}");
                        {

                        }
                    }

                    Statistics statistics = employee.GetStatistics();

                    Console.WriteLine("");
                    Console.WriteLine(" Dane są zapisywane w Pliku grades.TXT - TimePersonInFile");
                    Console.WriteLine("");

                    Console.WriteLine("");
                    Console.WriteLine("Czynności lub Praca którą najkrócej wykonywałeś w czasie dnia - Czas podany w minutach");
                    Console.WriteLine(statistics.Min);
                    Console.WriteLine("");
                    Console.WriteLine("Czynności lub Praca którą najdłużej wykonywałeś w czasie dnia - Czas podany w minutach");
                    Console.WriteLine(statistics.Max);
                    Console.WriteLine("");
                    Console.WriteLine("Średni Czas wykonywania Czynności lub Prac w czasie dnia - Czas podany w minutach");
                    Console.WriteLine(statistics.Average);
                }
            }
        }
    }
}