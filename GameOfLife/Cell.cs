using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell : IComparable
    {
        /// <summary>
        /// Současný stav buňky
        /// </summary>
        public bool CurrentState { get; set; }
        /// <summary>
        /// Stav buňky v příští generaci
        /// </summary>
        public bool NextState { get; set; }
        /// <summary>
        /// Souřadnice top-left kotvy buňky na ose x
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Souřadnice top-left kotvy buňky na ose y
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Sloupec buňky
        /// </summary>
        public int Sloupec { get; set; }
        /// <summary>
        /// Řada buňky
        /// </summary>
        public int Rada { get; set; }
        public Cell[] okolniBunky;
        public static int maxPreziti = 3;
        public static int minPreziti = 2;
        public static int minOziveni = 3;
        public static int maxOziveni = 3;
                                     

        /// <summary>
        /// Prázdné buňky
        /// </summary>
        public Cell() { }            

        /// <summary>
        /// Hlavni konstruktor Buňky
        /// </summary>
        /// <param name="sloupec">pořadí sloupce (x souřadnice)</param>
        /// <param name="rada">pořadní řady (y souřadnice)</param>
        /// <param name="currentState">bude buňka živá?</param>
        public Cell(int sloupec, int rada, bool currentState)
        {
            Sloupec = sloupec;
            Rada = rada;
            X = sloupec*5;
            Y = rada*5;
            CurrentState = currentState;
            NextState = CurrentState;
        }

        /// <summary>
        /// Získá pro buňku reference na okolní buňky
        /// </summary>
        /// <param name="arrayBunek"></param>
        public void GetOkoli(Cell[,] arrayBunek)
        {
            int s = Sloupec;
            int r = Rada;
            if ((s > 0) && (s < 99) && (r > 0) && (r < 99))      //Tělo pole
            {
                okolniBunky = InicializujArray<Cell>(8);
                for (int a = -1 ; a < 2 ; a++)
                {
                    okolniBunky[a + 1] = arrayBunek[s + a, r - 1];
                }
                okolniBunky[3] = arrayBunek[s - 1, r];
                okolniBunky[4] = arrayBunek[s + 1, r];
                for (int a = -1 ; a < 2 ; a++)
                {
                    okolniBunky[a + 6] = arrayBunek[s + a, r + 1];
                }
            }
            else if ((s > 0) && (s < 99) && (r == 0))            //Horní strana
            {
                okolniBunky = InicializujArray<Cell>(5);
                okolniBunky[0] = arrayBunek[s - 1, r];
                okolniBunky[1] = arrayBunek[s + 1, r];
                for (int a = -1 ; a < 2 ; a++)
                {
                    okolniBunky[a + 3] = arrayBunek[s + a, r + 1];
                }
            }
            else if ((s > 0) && (s < 99) && (r == 99))           //Dolní strana
            {
                okolniBunky = InicializujArray<Cell>(5);
                for (int a = -1 ; a < 1 ; a++)
                {
                    okolniBunky[a + 1] = arrayBunek[s + a, r - 1];
                }
                okolniBunky[3] = arrayBunek[s - 1, r];
                okolniBunky[4] = arrayBunek[s + 1, r];
            }
            else if ((s == 0) && (r > 0) && (r < 99))            //Levá strana
            {
                okolniBunky = InicializujArray<Cell>(5);
                for (int a = 0 ; a < 2 ; a++)
                {
                    okolniBunky[a] = arrayBunek[s + a, r - 1];
                }
                okolniBunky[2] = arrayBunek[s + 1, r];
                for (int a = 0 ; a < 2 ; a++)
                {
                    okolniBunky[a + 3] = arrayBunek[s + a, r + 1];
                }
            }
            else if ((s == 99) && (r > 0) && (r < 99))           //Pravá strana
            {
                okolniBunky = InicializujArray<Cell>(5);
                for (int a = -1 ; a < 1 ; a++)
                {
                    okolniBunky[a + 1] = arrayBunek[s + a, r - 1];
                }
                okolniBunky[2] = arrayBunek[s - 1, r];
                for (int a = -1 ; a < 1 ; a++)
                {
                    okolniBunky[a + 4] = arrayBunek[s + a, r + 1];
                }
            }
            else if ((s == 0) && (r == 0))                          //Levý horní roh
            {
                okolniBunky = InicializujArray<Cell>(3);
                okolniBunky[0] = arrayBunek[s + 1, r];
                for (int a = 0 ; a < 2 ; a++)
                {
                    okolniBunky[a + 1] = arrayBunek[s + a, r + 1];
                }
            }
            else if ((s == 99) && (r == 0))                           //Pravý horní roh
            {
                okolniBunky = InicializujArray<Cell>(3);
                okolniBunky[0] = arrayBunek[s - 1, r];
                for (int a = -1 ; a < 1 ; a++)
                {
                    okolniBunky[a + 2] = arrayBunek[s + a, r + 1];
                }
            }
            else if ((s == 0) && (r == 99))                           //Levý dolní roh
            {
                okolniBunky = InicializujArray<Cell>(3);
                for (int a = 0 ; a < 2 ; a++)
                {
                    okolniBunky[a] = arrayBunek[s + a, r - 1];
                }
                okolniBunky[2] = arrayBunek[s + 1, r];
            }
            else if ((s == 99) && (r == 99))                          //Pravý dolní roh
            {
                okolniBunky = InicializujArray<Cell>(3);
                for (int a = -1 ; a < 1 ; a++)
                {
                    okolniBunky[a + 1] = arrayBunek[s + a, r - 1];
                }
                okolniBunky[2] = arrayBunek[s - 1, r];
            }
        }

        /// <summary>
        /// Inicializuje pole 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="delka">délka pole</param>
        /// <returns></returns>
        public T[] InicializujArray<T>(int delka) where T : new()
        {
            T[] pole = new T[delka];
            for (int i=0 ;i<delka ; i++)
            {
                pole[i] = new T();
            }
            return pole;
        }

        /// <summary>
        /// Nastaví buňce nextState podle podmínek prostředí
        /// </summary>
        public bool PropoctiNextState()
        {
            int pocetZivychSousedu = 0;
            for (int j = 0 ; j < okolniBunky.Length ; j++)
            {
                if (okolniBunky[j].CurrentState)
                {
                    pocetZivychSousedu++;
                }
            }  
            if (CurrentState)
            {
                if ((pocetZivychSousedu <= maxPreziti) && (pocetZivychSousedu >= minPreziti)) 
                {
                    NextState = true;
                }
                else
                {
                    NextState = false;
                }                   
            }
            else
            {
                if ((pocetZivychSousedu <= maxOziveni) && (pocetZivychSousedu >= minOziveni)) 
                {
                    NextState = true;
                }
            }
            return NextState;
        }     

        /// <summary>
        /// Nastaví buňce currentState = nextState 
        /// </summary>
        public void DoNoveGenerace()
        {
            CurrentState = NextState;
        }

        public override bool Equals(object obj)
        {
            Cell druha = (Cell) obj;
            return ((X == druha.X) && (Y == druha.Y));
        }

        public int CompareTo(object obj)
        {
            Cell druha = (Cell) obj;
            if (Rada != druha.Rada)
            {
                return Rada.CompareTo(druha.Rada);
            }
            else
            {
                return Sloupec.CompareTo(druha.Sloupec);
            }            
        }
    }
}
                                                          