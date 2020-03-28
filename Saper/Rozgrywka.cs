using System;
using System.Collections.Generic;
using System.Text;

namespace Saper
{
    class Rozgrywka
    {
        int x;
        int y;
        bool porazka;
        Plansza plansza;

        public Rozgrywka()
        {
            plansza = new Plansza();
            porazka = false; 
            x = 0;
            y = 0;
        }

        public void graj ()
        {
            plansza.PokazPlansze();
            do
            {
                Console.WriteLine("Wybierz pole");
                try
                {
                    Console.WriteLine("X:");
                    x = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Y:");
                    y = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to parse ");
                }
                if (x >= 0 && x < 8 && y >= 0 && y < 12)
                {
                    if (plansza.TablicaPol[x, y].val == -1)
                    {
                        porazka = true;
                    }
                    Pokaz(x, y, plansza);
                    plansza.PokazPlansze();
                }
                Console.WriteLine("Podaj liczby z zakresu 0-7 oraz 0-11");
            }
            while (!porazka && plansza.liczWidoczne() < 86);

            if (porazka)
            {
                Console.WriteLine("Przegrales :/");
            }
            else
            {
                Console.WriteLine("Wygrales!! ;)");
            }
        }

        public void Pokaz(int i, int j, Plansza plansza)
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


    }
}
