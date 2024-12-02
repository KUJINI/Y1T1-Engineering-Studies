using System;
using System.Security.Principal;

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
        static char[,] tworzeniePustychPlanszPoz()
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
            char[,] tab = tworzeniePustychPlanszPoz();
            int[] dlugosciStatkow = wariantGry(wariant);
            
            Random rnd = new Random();
            int aktualnyStatek = 0;

            while (aktualnyStatek < dlugosciStatkow.Length)
            {
                int pos1 = rnd.Next(0, 10);
                int pos2 = rnd.Next(0, 10);
                int orient = rnd.Next(0, 2);

                int sumaKontrolna = 0;
                char[] znakiStatkow = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

                //
                if (orient == 0)
                {
                    if (pos2 + dlugosciStatkow[aktualnyStatek] <= 10)
                    {
                        for (int i = 0; i < dlugosciStatkow[aktualnyStatek]; i++)
                        {
                            if (tab[pos1, pos2 + i] != 'w')
                            {
                                sumaKontrolna++;
                            }
                        }
                        if (sumaKontrolna == 0)
                        {
                            tab[pos1, pos2] = znakiStatkow[aktualnyStatek];
                            for (int i = 0; i < dlugosciStatkow[aktualnyStatek]; i++)
                            {
                                tab[pos1, pos2 + i] = znakiStatkow[aktualnyStatek];
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
                            if (tab[pos1 + i, pos2] != 'w')
                            {
                                sumaKontrolna++;
                            }
                        }
                        if (sumaKontrolna == 0)
                        {
                            tab[pos1, pos2] = znakiStatkow[aktualnyStatek];
                            for (int i = 0; i < dlugosciStatkow[aktualnyStatek]; i++)
                            {
                                tab[pos1 + i, pos2] = znakiStatkow[aktualnyStatek];
                            }
                            aktualnyStatek++;
                        }
                    }
                }
                //

                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (tab[i, j] != 'w' && tab[i, j] != 'Z')
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

        static char[,] usuniecieZ(char[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    if (tab[i, j] == 'Z')
                    {
                        tab[i, j] = 'w';
                    }
                }
            }

            return tab;
        }

        static char[,] tworzeniePustychPlanszWid()
        {
            char[,] tab = new char[10, 10];
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = 'o';
                }
            }
            return tab;
        }

        static void wydruk(char[,] tab, int wariant)
        {
            if (wariant == 1)
            {
                int counterx = 0;
                int pWiersz = 0;
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (pWiersz == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" - A B C D E F G H I J");
                            Console.ResetColor();
                            pWiersz++;
                        }

                        if (j == 0 && i != 9)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($" {i + 1} ");
                            Console.ResetColor();
                        }

                        if (j == 0 && i == 9)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"{i + 1} ");
                            Console.ResetColor();
                        }

                        if (tab[i, j] == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
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
                        else if (tab[i, j] == 'T')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{tab[i, j]} ");
                            Console.ResetColor();
                        }
                        else if (tab[i, j] == 'N')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{tab[i, j]} ");
                            Console.ResetColor();
                        }
                        else if (tab[i, j] == 'w')
                        {
                            Console.Write($"{tab[i, j]} ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"T ");
                            Console.ResetColor();
                        }

                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            } else if (wariant == 2)
            {
                int counterx = 0;
                int pWiersz = 0;
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (pWiersz == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(" - A B C D E F G H I J");
                            Console.ResetColor();
                            pWiersz++;
                        }

                        if (j == 0 && i != 9)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($" {i + 1} ");
                            Console.ResetColor();
                        }

                        if (j == 0 && i == 9)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write($"{i + 1} ");
                            Console.ResetColor();
                        }

                        if (tab[i, j] == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
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
                        else if (tab[i, j] == 'T')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{tab[i, j]} ");
                            Console.ResetColor();
                        }
                        else if (tab[i, j] == 'N')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write($"{tab[i, j]} ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write($"{tab[i, j]} ");
                        }

                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            
        }

        static int[] konwertowanieWspolrzednych(string target)
        {
            int[] wsp = new int[2];

            int targetCyfra = 0;
            int targetLitera = 0;
            if ((char)target[0] < 96)
            {
                wsp[1] = (char)target[0] - 65;
            }
            else if ((char)target[0] > 96)
            {
                wsp[1] = (char)target[0] - 97;
            }

            if (target.Length == 2)
            {
                wsp[0] = target[1] - 49;
            }
            else if (target.Length == 3)
            {
                wsp[0] = 9;
            }

            return wsp;
        }

        static char[,] poczatekGryWyborPlansz(char[,] tab, int nrGracza)
        {
            Console.WriteLine($"Proszę wyłącznie gracza {nrGracza} by patrzył na ekran (nacisnij cokolwiek by kontynuowac)");
            Console.ReadLine();
            Console.Clear();

            int kontrolna = 0;
            while (kontrolna == 0)
            {
                wydruk(tab, 1);
                Console.WriteLine($"Gracz {nrGracza} - Czy odpowiada Ci takie ustawienie statków? [t/n]");
                string takNie = Console.ReadLine();
                if (takNie == "t")
                {
                    kontrolna++;
                    Console.Clear();
                }
                else if (takNie == "n")
                {
                    tab = wypelnianiePlansz(1);
                    tab = usuniecieZ(tab);
                    Console.Clear();
                } else
                {
                    Console.Clear();
                }
            }
            return tab;
        }



        static void Main(string[] args)
        {
            char[,] tab1poz = wypelnianiePlansz(1);
            char[,] tab2poz = wypelnianiePlansz(1);

            tab1poz = usuniecieZ(tab1poz);
            tab2poz = usuniecieZ(tab2poz);

            char[,] tab1wid = tworzeniePustychPlanszWid();
            char[,] tab2wid = tworzeniePustychPlanszWid();

            tab1poz = poczatekGryWyborPlansz(tab1poz, 1);
            tab2poz = poczatekGryWyborPlansz(tab2poz, 2);

            

            int nieTrafione = 0;
            int trafienie = 0;
            while (nieTrafione == 0)
            {
                Console.Clear();
                string target = "";
                if (trafienie > 0)
                {
                    Console.WriteLine("Trafienie!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                wydruk(tab1wid, 2);
                Console.WriteLine("Podaj koordynaty gdzie oddać strzał:");
                target = Console.ReadLine();
                Console.WriteLine("");


                int[] wsp = konwertowanieWspolrzednych(target);
                if (tab2poz[wsp[0], wsp[1]] != 'w')
                {
                    tab1wid[wsp[0], wsp[1]] = 'T';
                    if (wsp[0] + 1 < 10 && wsp[1] + 1 < 10)
                    {
                        tab1wid[wsp[0] + 1, wsp[1] + 1] = 'N';
                    }
                    if (wsp[0] - 1 >= 0 && wsp[1] + 1 < 10)
                    {
                        tab1wid[wsp[0] - 1, wsp[1] + 1] = 'N';
                    }
                    if (wsp[0] + 1 < 10 && wsp[1] - 1 >= 0)
                    {
                        tab1wid[wsp[0] + 1, wsp[1] - 1] = 'N';
                    }
                    if (wsp[0] - 1 >= 0 && wsp[1] - 1 >= 0)
                    {
                        tab1wid[wsp[0] - 1, wsp[1] - 1] = 'N';
                    }

                    //Przeniesienie na tabele pozycje trafienia
                    char[] znakiStatkow = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
                    char[] znakiStatkowM = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
                    int[] znakiStatkowD = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };
                    
                    for (int i = 0; i < znakiStatkowM.Length; i++)
                    {
                        if (tab2poz[wsp[0], wsp[1]] == znakiStatkow[i])
                        {
                            tab2poz[wsp[0], wsp[1]] = znakiStatkowM[i];
                        }
                    }

                    //Sprawdzenie czy zniszczono cały statek
                    for (int k = 0; k < znakiStatkow.Length; k++)
                    {
                        int counter = 0;
                        for (int i = 0; i < tab2poz.GetLength(0); i++)
                        {
                            for (int j = 0; j < tab2poz.GetLength(1); j++)
                            {
                                if (tab2poz[i, j] == znakiStatkowM[k]){
                                    counter++;
                                }
                            }
                        }
                        if(counter == znakiStatkowD[k])
                        {
                            //oznaczanie obszaru do okoła zniszczonego statku - 'N'
                            for (int i = 0; i < tab2poz.GetLength(0); i++)
                            {
                                for (int j = 0; j < tab2poz.GetLength(1); j++)
                                {
                                    if (tab2poz[i, j] == znakiStatkowM[k])
                                    {
                                        if(i - 1 >= 0 && j - 1 >= 0 && tab1wid[i - 1, j - 1] != 'T')
{
                                            tab1wid[i - 1, j - 1] = 'N';
                                        }
                                        if (i - 1 >= 0 && tab1wid[i - 1, j] != 'T')
                                        {
                                            tab1wid[i - 1, j] = 'N';
                                        }
                                        if (i - 1 >= 0 && j + 1 < 10 && tab1wid[i - 1, j + 1] != 'T')
                                        {
                                            tab1wid[i - 1, j + 1] = 'N';
                                        }
                                        if (j - 1 >= 0 && tab1wid[i, j - 1] != 'T')
                                        {
                                            tab1wid[i, j - 1] = 'N';
                                        }
                                        if (j + 1 < 10 && tab1wid[i, j + 1] != 'T')
                                        {
                                            tab1wid[i, j + 1] = 'N';
                                        }
                                        if (i + 1 < 10 && j - 1 >= 0 && tab1wid[i + 1, j - 1] != 'T')
                                        {
                                            tab1wid[i + 1, j - 1] = 'N';
                                        }
                                        if (i + 1 < 10 && tab1wid[i + 1, j] != 'T')
                                        {
                                            tab1wid[i + 1, j] = 'N';
                                        }
                                        if (i + 1 < 10 && j + 1 < 10 && tab1wid[i + 1, j + 1] != 'T')
                                        {
                                            tab1wid[i + 1, j + 1] = 'N';
                                        }
                                    }
                                }
                            }
                        }
                    }

                    trafienie++;
                }
                else
                {
                    tab1wid[wsp[0], wsp[1]] = 'N';
                    nieTrafione++;
                    Console.Clear();
                    Console.WriteLine("Niestety nie trafiłeś, pora na przeciwnika");
                    Console.ReadLine();
                }
            }
        }
    }
}
