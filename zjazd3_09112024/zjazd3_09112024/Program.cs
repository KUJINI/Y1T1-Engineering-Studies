using System;
using System.Diagnostics.CodeAnalysis;

namespace zjazd3_09112024
{
    internal class Program
    {
        static void zad1()
        {
            int i = 0;
            while (i != 10)
            {
                Console.WriteLine("Antoni Eryk Osial");
                i++;
            }
        }

        static void zad2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Antoni Eryk Osial");
            }
        }

        static void zad3(int n)
        {
            int i = 0;
            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void zad4(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void zad5(int a, int b)
        {
            if (a < b)
            {
                while (a <= b)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
            else if (b < a)
            {
                while (b <= a)
                {
                    Console.WriteLine(b);
                    b++;
                }
            }
        }

        static void zad6(int a, int b)
        {
            if (a < b)
            {
                for (int x = a; x <= b; x++)
                {
                    Console.WriteLine(x);
                }
            } else if (b < a)
            {
                for (int x = b; x <= a; x++)
                {
                    Console.WriteLine(x);
                }
            }
        }
        static int zad7(int x)
        {
            int sum = 0;
            for (int i = 0; i != x; x--)
            {
                sum = sum + x;
            }
            return sum;
        }

        static int zad8(int x, int y)
        {
            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
        static int zad9(int x, int y)
        {
            int sum = 0;
            for (int i = x; i <= y; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        static int zad10(int[] table)
        {
            return table[0];
        }

        static int zad11(int[] table)
        {
            return table[table.Length - 1];
        }

        static int zad12(int[] table)
        {
            int sum = 0;
            sum = sum + table[0];
            sum = sum + table[table.Length-1];
            return sum;
        }

        static int zad13(int[] table)
        {
            return table.Length;
        }

        static void zad14(int[] table)
        {
            for (int i = 0; i<table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
        }

        static int zad15(int[] table)
        {
            int sum = 0;
            for (int i = 0; i < table.Length; i++)
            {
                sum = sum + table[i];
            }
            return sum;
        }

        static bool zad16(int[] table)
        {
            if (table.Length % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        static int zad17(int[] table)
        {
            int sum = 0;
            for (int i = 0; i < table.Length; i++)
            {
                sum = sum + table[i];
            }
            return sum;
        }

        static void zad18(int[] table)
        {
            for (int i = 0; i < table.Length ; i = i + 2)
            {
                Console.WriteLine(table[i]);
            }
        }

        static int zad19(int[] table)
        {
            int sum = 0;
            for (int i = 0; i < table.Length; i = i + 2)
            {
                sum = sum + table[i];
            }
            return sum;
        }

        static void zad20(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static int zad21(int[,] table)
        {
            int sum = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    sum = sum + table[i, j];
                }
            }
            return sum;
        }

        static bool zad22(int[,] table, int a)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (a == table[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static int zad23(int[,] table, int a)
        {
            int ileRazy = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (a == table[i, j])
                    {
                        ileRazy++;
                    }
                }
            }
            return ileRazy;
        }

        static void zad24(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        static void zad25(int a, string b)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(b);
                }
                Console.WriteLine("");
            }
        }

        static void kontrolna(int[,] table0)
        {
            Console.WriteLine(table0.GetLength(0));
            Console.WriteLine(table0.GetLength(1));
            Console.WriteLine(table0[0, 1]);
        }

        static void zadDod1(int[,] table, int a)
        {
            for (int i =0; i<table.GetLength(0); i++)
            {
                for (int j = 0;j < table.GetLength(1); j++)
                {
                    table[i,j] = table[i, j] * a;
                }
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static void zadDod2(int[,] table1, int[,] table2)
        {
            if (table1.GetLength(1) != table2.GetLength(0))
            {
                Console.WriteLine("Tych manierzy nie da się pomnożyć");
                return;
            }

            int liczbaWierszy = table1.GetLength(0);
            int liczbaKolumn = table2.GetLength(1);
            int[,] table3 = new int[liczbaWierszy, liczbaKolumn];

            for (int x = 0; x < liczbaWierszy; x++) {
                for (int y = 0; y < liczbaKolumn; y++)
                {
                    int sum = 0;
                    for (int k = 0; k < table1.GetLength(1); k++)
                    {
                        sum = sum + table1[x, k] * table2[k, y];
                    }
                    table3[x, y] = sum;
                }
            }

            for (int i = 0; i < table3.GetLength(0); i++)
            {
                for (int j = 0; j < table3.GetLength(1); j++)
                {
                    Console.Write($"{table3[i, j]} ");
                }
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
            {
            /*
            Console.WriteLine("Zadanie 1:");
            zad1();

            Console.WriteLine("Zadanie 2:");
            zad2();

            Console.WriteLine("Zadanie 3:");
            zad3(5);

            Console.WriteLine("Zadanie 4:");
            zad4(5);

            Console.WriteLine("Zadanie 5:");
            zad5(3, 13);
            
            Console.WriteLine("Zadanie 6:");
            zad6(3, 13);
            
            Console.WriteLine("Zadanie 7:");
            Console.WriteLine(zad7(10));
            
            Console.WriteLine("Zadanie 8:");
            Console.WriteLine(zad8(3, 5));
            
            Console.WriteLine("Zadanie 9:");
            Console.WriteLine(zad9(3, 5));
            
            Console.WriteLine("Zadanie 10:");
            int[] table = { 1, 3, 5 };
            Console.WriteLine(zad10(table));
            
            Console.WriteLine("Zadanie 11:");
            int[] table = {1, 3, 5 };
            Console.WriteLine(zad11(table));
            
            Console.WriteLine("Zadanie 12:");
            int[] table = { 1, 3, 5 };
            Console.WriteLine(zad12(table));
            
            Console.WriteLine("Zadanie 13:");
            int[] table = { 1, 3, 5 };
            Console.WriteLine(zad13(table));
            
            Console.WriteLine("Zadanie 14:");
            int[] table = { 1, 3, 5 };
            zad14(table);
            
            Console.WriteLine("Zadanie 15:");
            int[] table = { 1, 3, 5 };
            Console.WriteLine(zad15(table));
            
            Console.WriteLine("Zadanie 16:");
            int[] table1 = { 1, 3, 5 };
            int[] table2 = { 1, 3, 5, 7};
            Console.WriteLine(zad16(table1));
            Console.WriteLine(zad16(table2));
            
            Console.WriteLine("Zadanie 17:");
            int[] table = { 1, 3, 7 };
            Console.WriteLine(zad17(table));
            
            Console.WriteLine("Zadanie 18:");
            int[] table = { 1, 3, 5, 7, 9 };
            zad18(table);
            
            Console.WriteLine("Zadanie 19:");
            int[] table = { 1, 3, 5, 7, 9 };
            Console.WriteLine(zad19(table));
            
            Console.WriteLine("Zadanie 20");
            int[,] table =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            zad20(table);
            
            Console.WriteLine("Zadanie 21:");
            int[,] table =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            Console.WriteLine(zad21(table));
            
            Console.WriteLine("Zadanie 22:");
            int[,] table =
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };
            Console.WriteLine(zad22(table, 0));
            Console.WriteLine(zad22(table, 1));
            
            Console.WriteLine("Zadanie 23:");
            int[,] table =
            {
                {1, 2, 2},
                {4, 5, 6},
                {7, 8, 9}
            };
            Console.WriteLine(zad23(table, 0));
            Console.WriteLine(zad23(table, 2));
            
            Console.WriteLine("Zadanie 24:");
            zad24(4);
            
            Console.WriteLine("Zadanie 25:");
            zad25(4, "z");

            int[,] tableKontrolna =
            {
                {-1, -2, 3, 1},
                {0, 2, -1, 1},
                {-1, 3, 0, 1}
            };
            kontrolna(tableKontrolna);

            Console.WriteLine("Zadanie dodatkowe 1:");
            Console.WriteLine("Mnożenie macierzy przez pojedyńcza liczbę");
            int[,] table =
            {
                {2, 2, 2},
                {4, 5, 6},
                {7, 8, 9}
            };
            zadDod1(table, 4);
            */
            Console.WriteLine("Zadanie dodatkowe 2");
            Console.WriteLine("Mnożenie macierzy przez macierz");
            int[,] table1 =
            {
                {-1, -2, 3},
                {0, 2, -1},
                {-1, 3, 0}
            };
            int[,] table2 =
            {
                {1, 5, 1},
                {2, 1, 2},
                {3, 2, 3}
            };
            zadDod2(table1, table2);
        }
    }
}