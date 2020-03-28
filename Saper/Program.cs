using System;

namespace Saper
{
    class Program
    {

        public static void Pokaz (int i, int j, Plansza plansza)
        {
            plansza.TablicaPol[i, j].widoczne = true;

            if (plansza.TablicaPol[i, j].val == 0)
            {
                if (i > 0 && j > 0)
                    if (plansza.TablicaPol[i - 1, j - 1].val == 0 && !plansza.TablicaPol[i - 1, j - 1].widoczne)
                    {
                        Pokaz(i - 1, j - 1, plansza);
                    }
                if (j > 0)
                    if (plansza.TablicaPol[i, j - 1].val == 0 && !plansza.TablicaPol[i, j - 1].widoczne)
                    {
                        Pokaz(i, j - 1, plansza);
                    }
                if (i < 7 && j > 0)
                    if (plansza.TablicaPol[i + 1, j - 1].val == 0 && !plansza.TablicaPol[i + 1, j - 1].widoczne)
                    {
                        Pokaz(i + 1, j - 1, plansza);
                    }
                if (i > 0)
                    if (plansza.TablicaPol[i - 1, j].val == 0 && !plansza.TablicaPol[i - 1, j].widoczne)
                    {
                        Pokaz(i - 1, j, plansza);
                    }
                if (i < 7)
                    if (plansza.TablicaPol[i + 1, j].val == 0 && !plansza.TablicaPol[i + 1, j].widoczne)
                    {
                        Pokaz(i + 1, j, plansza);
                    }
                if (i > 0 && j < 11)
                    if (plansza.TablicaPol[i - 1, j + 1].val == 0 && !plansza.TablicaPol[i - 1, j + 1].widoczne)
                    {
                        Pokaz(i - 1, j + 1, plansza);
                    }
                if (j < 11)
                    if (plansza.TablicaPol[i, j + 1].val == 0 && !plansza.TablicaPol[i, j + 1].widoczne)
                    {
                        Pokaz(i, j + 1, plansza);
                    }
                if (i < 7 && j < 11)
                    if (plansza.TablicaPol[i + 1, j + 1].val == 0 && !plansza.TablicaPol[i + 1, j + 1].widoczne)
                    {
                        Pokaz(i + 1, j + 1, plansza);
                    }
                if (i > 0 && j > 0)
                { 
                    plansza.TablicaPol[i - 1, j - 1].widoczne = true;
                }
                if (j > 0)
                {
                    plansza.TablicaPol[i, j - 1].widoczne = true;
                }
                if (i < 7 && j > 0)
                {
                    plansza.TablicaPol[i + 1, j - 1].widoczne = true;
                }
                if (i > 0)
                {
                    plansza.TablicaPol[i - 1, j].widoczne = true;
                }
                if (i < 7)
                {
                    plansza.TablicaPol[i + 1, j].widoczne = true;
                }
                if (i > 0 && j < 11)
                {
                    plansza.TablicaPol[i - 1, j + 1].widoczne = true;
                }
                if (j < 11)
                {
                    plansza.TablicaPol[i, j + 1].widoczne = true;
                }
                if (i < 7 && j < 11)
                {
                    plansza.TablicaPol[i + 1, j + 1].widoczne = true;
                }
            }
                
        }

        static void Main(string[] args)
        {
            Rozgrywka R = new Rozgrywka();
            R.graj();
        }
    }
}
