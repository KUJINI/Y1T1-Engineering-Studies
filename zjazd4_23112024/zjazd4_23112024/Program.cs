using System;
using System.Diagnostics.Tracing;
using System.Threading;
using System.Transactions;

namespace zjazd4_23112024
{
    internal class Program
    {
        static void TimeKeeper(int n)
        {
            Random r = new Random();
            while (n > 0)
            {
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                Console.WriteLine(n);
                n--;
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Time is up!");
        }

        static void KolorowaTablica(int[,] tab)
        {
            Random rnd = new Random();
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.ForegroundColor = (ConsoleColor)rnd.Next(0, 16);
                    Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void IleParzystychSum(int[,] tab)
        {
            int counter = 0;
            int sum;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (j + 1 < tab.GetLength(1))
                    {
                        sum = tab[i, j] + tab[i, j + 1];
                        if (sum % 2 == 0)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }

        static char[,] SlowoNaDiagonali(string slowo)
        {
            int dlugosc = slowo.Length;
            char[,] tabRobocza = new char[dlugosc, dlugosc];

            for (int i = 0; i < dlugosc; i++)
            {
                for (int j = 0; j < dlugosc; j++)
                {
                    if (i == j)
                    {
                        tabRobocza[i, j] = slowo[i];
                    }
                    else
                    {
                        tabRobocza[i, j] = '?';
                    }
                }
            }

            for (int i = 0; i < tabRobocza.GetLength(0); i++)
            {
                for (int j = 0; j < tabRobocza.GetLength(1); j++)
                {
                    Console.Write(tabRobocza[i, j]);
                }
                Console.WriteLine("");
            }
            return tabRobocza;
        }

        static double SredniaWybranych(int[,] tab2)
        {
            double var = 0;
            int counter = 0;

            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                    if ((i + j) % 3 == 0)
                    {
                        var = var + tab2[i, j];
                        counter++;
                    }
                }
            }
            Console.WriteLine(var / counter);
            return var / counter;
        }

        static int[,] Szachownica(int rozmiar, int liczba1, int liczba2)
        {
            int[,] robocza = new int[rozmiar, rozmiar];
            int counter = 0;

            for (int i = 0; i < robocza.GetLength(0); i++)
            {
                for (int j = 0; j < robocza.GetLength(1); j++)
                {
                    if (i % 2 == 0)
                    {
                        if (counter == 0)
                        {
                            robocza[i, j] = liczba1;
                            counter++;
                        }
                        else
                        {
                            robocza[i, j] = liczba2;
                            counter--;
                        }
                    }
                    else
                    {
                        if (counter == 0)
                        {
                            robocza[i, j] = liczba2;
                            counter++;
                        }
                        else
                        {
                            robocza[i, j] = liczba1;
                            counter--;
                        }
                    }
                    Console.Write(robocza[i, j]);
                }
                Console.WriteLine("");
            }
            return robocza;
        }

        static int[,] Rosnace1(int rozmiar1, int rozmiar2)
        {
            int[,] robocza = new int[rozmiar1, rozmiar2];
            int counter = 1;

            for (int i = 0; i < robocza.GetLength(0); i++)
            {
                for (int j = 0; j < robocza.GetLength(1); j++)
                {
                    robocza[i, j] = counter;
                    counter++;
                    Console.Write(robocza[i, j]);
                }
                Console.WriteLine("");
            }
            return robocza;
        }

        static int[,] Rosnace2(int rozmiar1, int rozmiar2)
        {
            int[,] robocza = new int[rozmiar1, rozmiar2];
            int counter = 1;

            for (int i = 0; i < robocza.GetLength(0); i++)
            {
                counter = i + 1;
                for (int j = 0; j < robocza.GetLength(1); j++)
                {
                    robocza[i, j] = counter;
                    counter = counter + rozmiar1;
                    Console.Write(robocza[i, j]);
                }
                Console.WriteLine("");
            }
            return robocza;
        }

        static bool CzyPalindrom(string zdanie)
        {
            int dlugosc = zdanie.Length;

            char[] zdanieList = new char[dlugosc];
            int x = dlugosc - 1;
            for (int i = 0; i <= x; i++)
            {
                zdanieList[i] = zdanie[i];
            }

            string za = "";
            for (int i = 0; i < zdanieList.Length; i++)
            {

                if (zdanieList.Length % 2 != 0)
                {
                    if (zdanieList[i] != ' ' & zdanieList[i] != '-' & zdanieList[i] != ',' & i != ((zdanieList.Length + 1) / 2) - 1)
                    {
                        za = za + zdanieList[i];
                    }
                }
                else
                {
                    if (zdanieList[i] != ' ' & zdanieList[i] != '-' & zdanieList[i] != ',')
                    {
                        za = za + zdanieList[i];
                    }
                }
            }

            Console.WriteLine(za);

            x = za.Length - 1;
            for (int i = 0; i < za.Length; i++)
            {
                if (za[i] != za[x])
                {
                    Console.WriteLine("false");
                    return false;
                }
                else
                {
                    x--;
                }
            }
            Console.WriteLine("true");
            return true;
        }

        static int[,] WygenerowanaTablica(int rozmiar, int a, int b)
        {
            int[,] robocza = new int[rozmiar, rozmiar];
            Random r = new Random();

            for (int i = 0; i < robocza.GetLength(0); i++)
            {
                for (int j = 0; j < robocza.GetLength(1); j++)
                {
                    robocza[i, j] = r.Next(a, b);
                    Console.Write(robocza[i, j]);
                }
                Console.WriteLine("");
            }
            return robocza;
        }

        static int[,] Transpozycja(int[,] tab2)
        {
            int[,] robocza = new int[tab2.GetLength(1), tab2.GetLength(0)];

            for (int i = 0; i < robocza.GetLength(0); i++)
            {
                for (int j = 0; j < robocza.GetLength(1); j++)
                {
                    robocza[i, j] = tab2[j, i];
                    Console.Write(robocza[i, j] + " ");
                }
                Console.WriteLine("");
            }
            return robocza;
        }

        static int IleRazySlowo(char[,] tab, string slowo)
        {
            int counter = 0;
            int x = 0;
            int xDlugosc = slowo.Length;
            int control = 0;

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    x = 0;
                    if (xDlugosc + j <= tab.GetLength(1))
                    {
                        while (x < xDlugosc)
                        {
                            if (slowo[x] == tab[i, j + x])
                            {
                                control = control + 1;
                            }
                            x++;
                        }
                    }
                    if (control == xDlugosc)
                    {
                        counter++;
                    }
                    control = 0;
                    //
                    x = 0;
                    if (xDlugosc + i <= tab.GetLength(0))
                    {
                        while (x < xDlugosc)
                        {
                            if (slowo[x] == tab[i + x, j])
                            {
                                control = control + 1;
                            }
                            x++;
                        }
                    }
                    if (control == xDlugosc)
                    {
                        counter++;
                    }
                    control = 0;
                }
            }
            Console.WriteLine(counter);
            return counter;
        }

        static int[,] MaxPooling(int[,] a, int size)
        {
            int iloscTabelekLacznie = 0;
            int iloscTabelekPoziomo = 0;
            int iloscTabelekPionowo = 0;

            iloscTabelekPoziomo = a.GetLength(0) / size;
            iloscTabelekPionowo = a.GetLength(1) / size;
            iloscTabelekLacznie = iloscTabelekPionowo * iloscTabelekPoziomo;

            int[,] wspolrzedne = new int[iloscTabelekLacznie, 2];

            int k = 0;
            for (int x = 0; x < iloscTabelekPoziomo; x++)
            {
                int z = 0;
                while (z + size <= a.GetLength(1))
                {
                    wspolrzedne[k, 0] = x * size;
                    wspolrzedne[k, 1] = z;
                    z = z + size;
                    k++;
                }   
            }

            int[] maxyList = new int[iloscTabelekLacznie];

            for (int q = 0; q < iloscTabelekLacznie; q++)
            {
                int wspI = wspolrzedne[q, 0];
                int wspJ = wspolrzedne[q, 1];
                int maxLok = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (maxLok < a[wspI + i, wspJ + j]){
                            maxLok = a[wspI + i, wspJ + j];
                        }
                    }
                }
                maxyList[q] = maxLok;
            }

            int[,] maxy = new int[iloscTabelekPoziomo, iloscTabelekPionowo];

            int counter = 0;
            for (int i = 0; i < iloscTabelekPoziomo; i++)
            {
                for (int j = 0;j < iloscTabelekPionowo; j++)
                {
                    maxy[i, j] = maxyList[counter];
                    counter++;
                    Console.Write($"{maxy[i, j]} ");
                }
                Console.WriteLine("");
            }

            return maxy;
        }

        static int[,] MnozenieMacierzy( int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                Console.WriteLine("Tych manierzy nie da się pomnożyć");
                return a;
            }

            int[,] robocza = new int[a.GetLength(0), b.GetLength(1)];
            int sum = 0;

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    int suma = 0;
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        suma = suma + a[i, k] * b[k, j];

                    }
                    robocza[i, j] = suma;
                    
                }
            }

            for (int i = 0; i < robocza.GetLength(0); i++)
            {
                for(int j = 0; j < robocza.GetLength(1); j++)
                {
                    Console.Write(robocza[i, j]+ " ");
                }
                Console.WriteLine("");
            }

            return robocza;
        }

        static int[,] Rosnace3(int rozmiar)
        {
            int[,] robocza = new int[rozmiar, rozmiar];

            if (rozmiar == 0)
            {
                return robocza;
            }

            int najwyzszaLiczba;
            if (rozmiar % 2 == 1)
            {
                najwyzszaLiczba = ((rozmiar + 1) / 2) - 1;
            } else
            {
                najwyzszaLiczba = (rozmiar / 2) - 1;
            }



            int z = najwyzszaLiczba;
            int counter = 0;
            for (int k = 0; k < najwyzszaLiczba; k++)
            {

                int jCounter = 0;
                int iCounter = 0;
                for (int i = k; i < rozmiar; i++)
                {
                    for (int j = k; j < rozmiar; j++)
                    {
                        if (i * j == 0)
                        {
                            robocza[i, j] = z;
                        }
                        else if ((i - counter) * j == 0 && j < rozmiar - counter)
                        {
                            robocza[i, j] = z;
                        }
                        else if (i * (j - counter) == 0 && i < rozmiar - counter)
                        {
                            robocza[i, j] = z;
                        }
                    }
                }
                
                for (int i = rozmiar - 1; i > 0; i--)
                {
                    jCounter = 0;
                    for (int j = rozmiar - 1; j > 0; j--)
                    {
                        if (robocza[iCounter, jCounter] == z)
                        {
                            robocza[i, j] = robocza[iCounter, jCounter];
                        }

                        jCounter++;
                    }
                    iCounter++;
                }
                

                counter++;
                z--;
            }

            for (int i = 0; i < rozmiar; i++)
            {
                for(int j = 0; j < rozmiar; j++)
                {
                    Console.Write(robocza[i, j]);
                }
                Console.WriteLine("");
            }

            return robocza;
        }

        static void Main(string[] args)
        {
            int[,] tab = { { 1, 2, 2 }, { 4, 6, 6 } };
            int[,] tab2 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            int[,] tab3 = { { 5, 3, -2, 4 }, { 0, 10, 3, 8 }, { 2, -1, 9, 2 } };
            char[,] tab4 = { { 'b', 'a', 'b', 'a', 'k', 'z' }, { 'a', 'b', 'a', 'b', 'a', 'k' }, { 'b', 'a', 'b', 'a', 'b', 'a' }, { 'a', 's', 'i', 'l', 's', 'z' }, { 'n', 'e', 'n', 'o', 'a', 's' } };
            int[,] tab5 = { { 1, 2, 2, 4 }, { 2, 4, 3, 3 }, { 5, 4, 2, 4 }, { 3, 5, 3, 3 } };
            int[,] table1 ={ {-1, -2, 3}, {0, 2, -1}, {-1, 3, 0} };
            int[,] table2 ={ {1, 5, 1}, {2, 1, 2}, {3, 2, 3} };
            //TimeKeeper(10);
            //KolorowaTablica(tab);
            //IleParzystychSum(tab);
            //SlowoNaDiagonali("inglisz");
            //SredniaWybranych(tab2);
            //Szachownica(4, 5, 3);
            //Rosnace1(3, 4);
            //Rosnace2(3, 4);
            //CzyPalindrom("kamil slimak");
            //WygenerowanaTablica(5, 1, 7);
            //Transpozycja(tab2);[
            //IleRazySlowo(tab4, "baba");
            //MaxPooling(tab5, 2);
            //MnozenieMacierzy(table1, table2);
            Rosnace3(19);
        }
    }
}

