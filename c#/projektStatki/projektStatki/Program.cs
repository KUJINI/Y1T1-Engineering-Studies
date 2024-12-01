using System;

namespace projektStatki
{
    internal class Program
    {
        static int[] wariantGry (int i)
        {
            if (i == 1)
            {
                int[] dlugosciStatkow = new int[10];

                dlugosciStatkow[0] = 4;
                dlugosciStatkow[1] = 3;
                dlugosciStatkow[2] = 3;
                dlugosciStatkow[3] = 2;
                dlugosciStatkow[4] = 2;
                dlugosciStatkow[5] = 2;
                dlugosciStatkow[6] = 1;
                dlugosciStatkow[7] = 1;
                dlugosciStatkow[8] = 1;
                dlugosciStatkow[9] = 1;
                return dlugosciStatkow;
            } else if (i == 2) 
            {
                int[] dlugosciStatkow = new int[5];

                dlugosciStatkow[0] = 5;
                dlugosciStatkow[1] = 4;
                dlugosciStatkow[2] = 3;
                dlugosciStatkow[3] = 3;
                dlugosciStatkow[4] = 2;
                return dlugosciStatkow;
            } else
            {
                return null;
            }
        }
        static char[,] tworzeniePustychPlansz()
        {
            char[,] tab = new char[10, 10];

            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = 'w';
                }
            }

            return tab;
        }

        static char[,] wypelnianiePlansz(int wariant)
        {
            char[,] tab = tworzeniePustychPlansz();
            int[] dlugosciStatkow = wariantGry(wariant);
            
            Random rnd = new Random();
            int aktualnyStatek = 0;

            while (aktualnyStatek < dlugosciStatkow.Length)
            {
                int pos1 = rnd.Next(0, 10);
                int pos2 = rnd.Next(0, 10);
                int orient = rnd.Next(0, 2);

                int sumaKontrolna = 0;
                if (orient == 0)
                {
                    if (pos2 + dlugosciStatkow[aktualnyStatek] <= 10)
                    {
                        for (int i = 0; i < dlugosciStatkow[aktualnyStatek]; i++)
                        {
                            if (tab[pos1, pos2 + i] == 'X' || tab[pos1, pos2 + i] == 'Z')
                            {
                                sumaKontrolna++;
                            }
                        }
                        if (sumaKontrolna == 0)
                        {
                            tab[pos1, pos2] = 'X';
                            for (int i = 0; i < dlugosciStatkow[aktualnyStatek]; i++)
                            {
                                tab[pos1, pos2 + i] = 'X';
                            }
                            aktualnyStatek++;
                        }
                    }
                }
                else if (orient == 1)
                {
                    if (pos1 + dlugosciStatkow[aktualnyStatek] <= 10)
                    {
                        for (int i = 0; i < dlugosciStatkow[aktualnyStatek]; i++)
                        {
                            if (tab[pos1 + i, pos2] == 'X' || tab[pos1 + i, pos2] == 'Z')
                            {
                                sumaKontrolna++;
                            }
                        }
                        if (sumaKontrolna == 0)
                        {
                            tab[pos1, pos2] = 'X';
                            for (int i = 0; i < dlugosciStatkow[aktualnyStatek]; i++)
                            {
                                tab[pos1 + i, pos2] = 'X';
                            }
                            aktualnyStatek++;
                        }
                    }
                }

                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (tab[i, j] == 'X')
                        {
                            if (i + 1 <= 9 && tab[i + 1, j] == 'w')
                            {
                                tab[i + 1, j] = 'Z';
                            }
                            if (j + 1 <= 9 && tab[i, j + 1] == 'w')
                            {
                                tab[i, j + 1] = 'Z';
                            }
                            if (i - 1 >= 0 && tab[i - 1, j] == 'w')
                            {
                                tab[i - 1, j] = 'Z';
                            }
                            if (j - 1 >= 0 && tab[i, j - 1] == 'w')
                            {
                                tab[i, j - 1] = 'Z';
                            }

                            if (i + 1 <= 9 && j + 1 <= 9 && tab[i + 1, j + 1] == 'w')
                            {
                                tab[i + 1, j + 1] = 'Z';
                            }
                            if (i - 1 >= 0 && j - 1 >= 0 && tab[i - 1, j - 1] == 'w')
                            {
                                tab[i - 1, j - 1] = 'Z';
                            }
                            if (i + 1 <= 9 && j - 1 >= 0 && tab[i + 1, j - 1] == 'w')
                            {
                                tab[i + 1, j - 1] = 'Z';
                            }
                            if (i - 1 >= 0 && j + 1 <= 9 && tab[i - 1, j + 1] == 'w')
                            {
                                tab[i - 1, j + 1] = 'Z';
                            }
                        }
                    }
                }
            }


            return tab;
        }

        static void wydruk(char[,] tab)
        {
            int counterx = 0;
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] == 'X')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{tab[i, j]} ");
                        Console.ResetColor();
                        counterx++;
                    }
                    else if (tab[i, j] == 'Z')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{tab[i, j]} ");
                        Console.ResetColor();
                    }
                    else if (tab[i, j] == 'w')
                    {
                        Console.Write($"{tab[i, j]} ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            char[,] tab1poz = wypelnianiePlansz(1);
            char[,] tab2poz = wypelnianiePlansz(1);



            wydruk(tab1poz);
            wydruk(tab2poz);
        }
    }
}
