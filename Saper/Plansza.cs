using System;
using System.Collections.Generic;
using System.Text;

namespace Saper
{
    class Plansza
    {

        public pole[,] TablicaPol;

        public Plansza()
        {
            TablicaPol = new pole[8, 12];
            //nadanie wspolrzednych
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    TablicaPol[i, j] = new pole();
                    TablicaPol[i, j].x = i;
                    TablicaPol[i, j].y = j;
                }
            }


            //wypełnienie bombami
            for (int i = 0; i<10; i++)
            {
                Random r = new Random();
                int rx = r.Next(0, 8);
                int ry = r.Next(0, 12);

                while (TablicaPol[rx, ry].val == -1)
                {
                    rx = r.Next(0, 8);
                    ry = r.Next(0, 12);
                }
                TablicaPol[rx, ry].val = -1;

            }

            //dodanie wartosci
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (TablicaPol[i, j].val != -1)
                    {
                        int s = 0;
                        if (i > 0 && j > 0)
                            if (TablicaPol[i - 1, j - 1].val == -1)
                            {
                                s++;
                            }
                        if (j > 0)
                            if (TablicaPol[i, j - 1].val == -1)
                            {
                                s++;
                            }
                        if (i < 7 && j > 0)
                            if (TablicaPol[i + 1, j - 1].val == -1)
                            {
                                s++;
                            }
                        if (i > 0)
                            if (TablicaPol[i - 1, j].val == -1)
                            {
                                s++;
                            }
                        if (i < 7)
                            if (TablicaPol[i + 1, j].val == -1)
                            {
                                s++;
                            }
                        if (i > 0 && j < 11)
                            if (TablicaPol[i - 1, j + 1].val == -1)
                            {
                                s++;
                            }
                        if (j < 11)
                            if (TablicaPol[i, j + 1].val == -1)
                            {
                                s++;
                            }
                        if (i < 7 && j < 11)
                            if (TablicaPol[i + 1, j + 1].val == -1)
                            {
                                s++;
                            }
                        TablicaPol[i, j].val = s;
                    }
                }
            }

        }

        public int liczWidoczne()
        {
            int l = 0;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (TablicaPol[j, i].widoczne)
                    {
                        l++;
                    }
                }
            }
            return l;
        }

        public void PokazPlansze()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (TablicaPol[j, i].widoczne)
                    {
                        if (TablicaPol[j, i].val == -1)
                            Console.Write("B\t");
                        else if (TablicaPol[j, i].val == 0)
                            Console.Write(".\t");
                        else
                            Console.Write(TablicaPol[j, i].val + "\t");
                    }
                    else
                        Console.Write("X\t");
                }
                Console.Write("\n\n");
            }
        }
        public void PokazPlansze2()
        {
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                        if (TablicaPol[j, i].val == -1)
                            Console.Write("B\t");
                        else if (TablicaPol[j, i].val == 0)
                            Console.Write(".\t");
                        else
                            Console.Write(TablicaPol[j, i].val + "\t");
                }
                Console.Write("\n\n");
            }
        }
    }
}
