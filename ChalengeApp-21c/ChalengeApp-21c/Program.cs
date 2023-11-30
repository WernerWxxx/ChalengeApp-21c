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

            bool CloseApp = false;

            while (!CloseApp)
            {

                Console.WriteLine(" Zapis do Pamieci PC Wybierz litere - 1 ");
                Console.WriteLine(" Zapis danych do Pliku grades.TXT Wybierz litere - 2 ");
                Console.WriteLine(" Wyjście z Programu Wybierz litere - 2 x q : ");

                var Input = Console.ReadLine().ToUpper();

                switch (Input)
                {
                    case "1":
                        TimePersonInMemory();
                        break;

                    case "2":
                        TimePersonInFile();
                        break;

                    case "Q":
                        CloseApp = true;
                        break;
                }
            }

            static void TimePersonInMemory()
            {
                var employee = new TimePersonInMemory("Wxxx", "Wxxx");
                void EmployeeGradeAdded(object sender, EventArgs args)
                {
                    Console.WriteLine("Dodano nową wartość - Zadziałał event");
                }
                employee.GradeAdded += EmployeeGradeAdded;

                AddGrade(employee);

                Console.WriteLine("Osoba : " + employee.Name + " " + employee.Surname);

                employee.Calculation();

            }

            static void TimePersonInFile()
            {
                var employee = new TimePersonInFile("Wxxx", "Wxxx");
                void EmployeeGradeAdded(object sender, EventArgs args)
                {
                    Console.WriteLine("Dodano nową wartość - Zadziałał event");
                }
                employee.GradeAdded += EmployeeGradeAdded;

                AddGrade(employee);

                Console.WriteLine("Osoba : " + employee.Name + " " + employee.Surname);

                employee.Calculation();
            }

            static void AddGrade(ITimePerson employee)
            {
                while (true)
                {
                    Console.WriteLine(" Czas wykonywanej czynności: - Podaj czas w minutach ");


                    var input = Console.ReadLine();
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
                        Console.WriteLine($"Exception catched: {e.Message}");
                    }
                }
            }
        }

    }
}