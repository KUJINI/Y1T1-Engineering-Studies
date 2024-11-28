using System;
using System.Threading.Channels;

namespace zjazd2_26102024
{
    internal class Program
    {
        static void MyFirstFunction()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Programming is fun!");
            Console.WriteLine("I like that!");
        }

        static void AddNumbers()
        {
            int a = 5;
            int b = 6;
            int c = 7;
            Console.WriteLine($"When we add {a} and {b} the result is {a + b + c}");
        }

        static void AddNumbers(int a, int b, int c)
        {
            Console.WriteLine($"When we add {a} and {b} and {c} the result is {a + b + c}");
        }

        static int AddNumbers2(int a, int b, int c)
        {
            return a + b + c;
        }

        static int Volume(int a, int b, int c)
        {
            return a * b * c;
        }

        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }
        static double circleArea(double r)
        {
            return 3.14 * r * r;
        }

        static string ConcatenateStrings(string a, string b)
        {
            return a + b;
        }

        static void Function()
        {
            Console.WriteLine("Hi");
            return;
            Console.WriteLine("Hello");
        }

        static void ChangeAndDisplay(int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        static double objetoscProstopadloscianu(int a, int b, int c)
        {
            int obj = a * b * c;
            return obj;
        }

        static bool czyBokTrojkata(int a, int b, int c)
        {
            bool odp;
            if (a * a + b * b == c * c)
            {
                odp = true;
            } else
            {
                odp = false;
            }
            return odp;
        }

        static double kalkulator(string a, double b, double c)
        {
            if (a == "+")
            {
                Console.WriteLine($"{b} + {c} = {b + c}");
                return b + c;
            } else if (a == "-")
            {
                Console.WriteLine($"{b} - {c} = {b - c}");
                return b - c;
            } else if (a == "*")
            {
                Console.WriteLine($"{b} * {c} = {b * c}");
                return b * c;
            } else if (a == "/")
            {
                Console.WriteLine($"{b} / {c} = {b / c}");
                return b / c;
            } else
            {
                return 0;
            }
        }

        static double bmi(double wzrost, double waga)
        {
            double bmi = waga / (wzrost * wzrost);
            if (bmi < 18.5)
            {
                Console.WriteLine($"Wzrost {wzrost}m, waga {waga}kg, BMI = {bmi}, niedowaga");
                return bmi;
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine($"Wzrost {wzrost}m, waga {waga}kg, BMI = {bmi}, optimum");
                return bmi;
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine($"Wzrost {wzrost}m, waga {waga}kg, BMI = {bmi}, nadwaga");
                return bmi;
            }
            else
            {
                Console.WriteLine($"Wzrost {wzrost}m, waga {waga}kg, BMI = {bmi}, otyłość");
                return bmi;
            }
        }

        static bool czyPodzielna(double a, double b)
        {
            if (a % b == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool czyPodzielnaNaTrzy(int a)
        {
            if (a % 3 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool czyPodzielnaNaDwa(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool czyLub(int a)
        {
            if (czyPodzielnaNaTrzy(a) == false || czyPodzielnaNaDwa(a) == true)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static bool zgodaNaZjazd(string imie, string nazwisko, double wzrost, double waga, int rokUrodzenia)
        {
            int iloscBrakuWymagan = 0;
            if (wzrost > 1.9)
            {
                iloscBrakuWymagan++;
            }

            if (waga / (wzrost * wzrost) >= 30)
            {
                iloscBrakuWymagan++;
            }

            if (2024 - rokUrodzenia < 18)
            {
                iloscBrakuWymagan++;
            }

            if (iloscBrakuWymagan != 0)
            {
                Console.WriteLine(iloscBrakuWymagan);
                return false;
            } else
            {
                Console.WriteLine($"{imie} {nazwisko} {wzrost}m, waga {waga} - prawidłowa, {2024-rokUrodzenia} lat - zgoda na zjazd");
                return true;
            }
        }

        static double maksymalnaWaga(double wzrost)
        {
            double maxWaga = 25 * wzrost * wzrost;
            return maxWaga;
        }

        static double konwert(double stopnie, string jednostka)
        {
            if (jednostka == "F")
            {
                return (5.0 / 9.0) * (stopnie - 32);
            } else if (jednostka == "C")
            {
                return (32 + ((9.0/5.0) * stopnie));
            } else
            {
                return 0;
            }
        }

        static void wspolczynnikKierunkowyProstej(double x1, double x2, double y1, double y2)
        {
            double a1 = (y2-y1)/(x2-x1);
            double b1 = y1 - (a1 * x1);

            string a = "";
            if (a1 == 0)
            {
                a = "";
            } else if (a1 == 1)
            {
                a = "x";
            } else if (a1 > 0)
            {
                a = a1.ToString() + "x";
            } else if (a1 == -1)
            {
                a = "-x";
            } else if (a1 < 0)
            {
                a = a1.ToString() + "x";
            }

            string b = "";
            if (b1 > 0)
            {
                b = " + " + b1.ToString();
            } if (b1 < 0)
            {
                b = " - " + (b1*-1);
            } if (b1 == 0)
            {
                b = "";
            }

            Console.WriteLine($"y = {a}{b}");
            
        }

        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Zadanie 1:");

            Console.WriteLine("Funkcja 1:");
            MyFirstFunction();
            MyFirstFunction();
            MyFirstFunction();

            Console.WriteLine("Funkcja 2:");
            AddNumbers();
            
            Console.WriteLine("Funkcja 3:");
            AddNumbers(1, 2, 3);

            Console.WriteLine("Funkcja 4:");
            Console.WriteLine(AddNumbers2(2, 3, 4));
            
            Console.WriteLine("Funkcja 5:");
            Console.WriteLine(Volume(4, 3, 4) - Volume(2, 3, 4));
            
            Console.WriteLine("Funkcja 6:");
            Console.WriteLine(IsEven(1));
            Console.WriteLine(IsEven(2));
            
            Console.WriteLine("Funkcja 7:");
            Console.WriteLine(circleArea(2));
            
            Console.WriteLine("Funkcja 8:");
            Console.WriteLine(ConcatenateStrings("Hello", " students"));
            
            Console.WriteLine("Funkcja 9:");
            Function();

            Console.WriteLine("Funkcja 10:");
            int a = 4;
            ChangeAndDisplay(a);
            Console.WriteLine(a);
            
            Console.WriteLine("Zadanie 2:");
            Console.WriteLine(objetoscProstopadloscianu(2, 3, 4));
            
            Console.WriteLine("Zadanie 3:");
            Console.WriteLine(czyBokTrojkata(3, 4, 5));
            
            Console.WriteLine("Zadanie 4:");
            kalkulator("+", 2, 3);
            
            Console.WriteLine("Zadanie 5:");
            Console.WriteLine(bmi(1.77, 65));
            
            Console.WriteLine("Zadanie 6:");
            Console.WriteLine(czyPodzielna(4, 3));
            
            Console.WriteLine("Zadanie 7:");
            Console.WriteLine(czyLub(6));
            
            Console.WriteLine("Zadanie 8:");
            Console.WriteLine(zgodaNaZjazd("Antoni", "Osial", 1.77, 65, 2005));
            
            Console.WriteLine("Zadanie 8.5:");
            Console.WriteLine(maksymalnaWaga(1.77));
            
            Console.WriteLine("Zadanie 9:");
            Console.WriteLine(konwert(212, "F"));
            */
            Console.WriteLine("Zadanie 10:");
            double x1 = 0;
            double y1 = -1;
            double x2 = 1;
            double y2 = 1;
            wspolczynnikKierunkowyProstej(x1, x2, y1, y2);
        }
    }
}
