using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace GameOfLife
{
    public static class Vlakna
    {
        private static Form1 form1;
        public static void SetForm(Form1 f)
        {
            form1 = f;
        }

        #region Startovací vlákno 
        public static Thread startV = new Thread(new ThreadStart(StartVlakno));                                                                   
        
        public static void StartVlakno()
        {
            form1.ziveBunky = new List<Cell>();
            form1.bunky = new Cell[100, 100];
            for (int a = 0 ; a < 100 ; a++)
            {
                for (int b = 0 ; b < 100 ; b++)
                {
                    form1.bunky[a, b] = new Cell(a, b, false);
                }
            }
            PosliArray();
            form1.savy = Properties.zdroje.sablony.Split(Environment.NewLine.ToCharArray()).ToList();
        }    

        /// <summary>
        /// Rozešle všem buňkám array buněk a nechá je si vybrat reference na okolní
        /// </summary>
        private static void PosliArray()
        {
            for (int x = 0 ; x < 100 ; x++)
            {
                for (int y = 0 ; y < 100 ; y++)
                {
                    form1.bunky[x, y].GetOkoli(form1.bunky);
                }
            }
        }
        #endregion





    }
}
