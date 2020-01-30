using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  
using System.Threading;

namespace GameOfLife
{                             
    public enum GameState
    {
        Ready,
        Running,
        Paused
    }    

    public partial class Form1 : Form
    {                  
        public Cell[,] bunky;     
        public int generace = 1;
        public GameState stav;
        public List<Cell> ziveBunky;
        public List<string> savy;

        public Form1()
        {

            InitializeComponent();
            Vlakna.SetForm(this);
            Vlakna.startV.Start();                                 
            stav = GameState.Ready;                                 
            pauseCudlik.Enabled = false;
            trackBar1.Value = (int)(timer.Interval / 10);
            rychlostLabel.Text = timer.Interval.ToString() + " ms";       
        }      

        /// <summary>
        /// Vypočte nové stavy pro všechny buňky
        /// </summary>
        public void PrepoctiStavy()
        {
            ziveBunky = new List<Cell>();
            for (int x = 0 ; x < 100 ; x++)
            {
                for (int y = 0 ; y < 100 ; y++)
                {
                    if (bunky[x, y].PropoctiNextState())
                    {
                        ziveBunky.Add(bunky[x, y]);
                    }
                }
            }

        }

        /// <summary>
        /// Převede všechny buňky do nové generace
        /// </summary>
        public void JdiDoNoveGenerace()
        {
            for (int fn = 0 ; fn < 100 ; fn++)
            {
                for (int nf = 0 ; nf < 100 ; nf++)
                {
                    bunky[fn, nf].DoNoveGenerace();
                }
            }                                                                                                                                                   
        }

        

        /// <summary>
        /// Jeden tik timeru
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tick(object sender, EventArgs e)
        {                   
            PrepoctiStavy();
            JdiDoNoveGenerace();  
            generace++;
            svet.Invalidate();
            labelKola.Text = generace.ToString();
            labelZive.Text = ziveBunky.Count.ToString();
            if (ziveBunky.Count == 0)
            {
                timer.Enabled = false;
                MessageBox.Show("Vaše buňky umřely, počet generací: " + generace.ToString());
                Clear(null,null);                                                                   
            }
        }

        /// <summary>
        /// Vykreslí buňky na plátno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vybarvi(object sender, PaintEventArgs e)
        {                 
            for (int x = 0 ; x<100 ;x++)
            {
                for (int y = 0 ;y<100 ; y++)
                {
                    if (bunky[x,y].CurrentState)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), x * 5, y * 5, 4, 4);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(new SolidBrush(Color.White), x * 5, y * 5, 4, 4);
                    }  
                }
            } 
        }

        /// <summary>
        /// Run tlačítko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Spust(object sender, EventArgs e)
        {
            if (ziveBunky.Count > 0)
            {
                timer.Enabled = true;
                labelKola.Text = generace.ToString();
                labelZive.Text = ziveBunky.Count.ToString();
                stav = GameState.Running;
                comboBox1.Enabled = false;
                runCudlik.Enabled = false;
                pauseCudlik.Enabled = true; 
            }
        }

        /// <summary>
        /// pause tlačítko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pause(object sender, EventArgs e)
        {
            if (ziveBunky.Count > 0)
            {
                if (stav == GameState.Running)
                {
                    pauseCudlik.Text = "Continue";
                    timer.Enabled = false;
                    stav = GameState.Paused;
                    KrokButton.Enabled = true;
                }
                else
                {
                    pauseCudlik.Text = "Pause";
                    timer.Enabled = true;
                    stav = GameState.Running;
                    KrokButton.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Klik na plátno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaintBoxClick(object sender, EventArgs e)
        {             
            if (stav == GameState.Ready)
            {                                                                               
                Point point = PointToClient(Cursor.Position);
                point.Y--;
                point.X--;
                int xpom = point.X;
                int ypom = point.Y;                                                     
                int x = 0;
                int y = 0;
                while (xpom > 4)
                {
                    xpom -= 5;
                    x++;
                }
                while (ypom > 4)
                {
                    ypom -= 5;
                    y++;
                }                                                                    
                if (bunky[x, y].CurrentState)
                {                                                               
                    bunky[x, y].CurrentState = false;     
                    ziveBunky.Remove(bunky[x, y]);
                }
                else
                {                                                              
                    bunky[x, y].CurrentState = true;  
                    ziveBunky.Add(bunky[x, y]);
                }
                svet.Invalidate();
                labelZive.Text = ziveBunky.Count.ToString();
                comboBox1.SelectedIndex = 0;
            }   
            if (ziveBunky.Count>0)
            {
                clearCudlik.Enabled = true;
                runCudlik.Enabled = true;
            }
            else
            {
                clearCudlik.Enabled = false;
                runCudlik.Enabled = false;
            }
        }               

        /// <summary>
        /// Clear tlačítko
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear(object sender, EventArgs e)
        {
            comboBox1.SelectedValue = 0;
            comboBox1.Enabled = true;
            timer.Enabled = false;
            generace = 0;
            labelKola.Text = generace.ToString();
            labelZive.Text = "n/A";
            ziveBunky.Clear();
            for (int i=0 ;i<100 ; i++)
            {
                for (int j=0 ;j<100 ; j++)
                {
                    bunky[i, j].CurrentState = false;
                    bunky[i, j].NextState = false;
                }
            }                         
            svet.Invalidate();
            stav = GameState.Ready;
            runCudlik.Enabled = true;
            pauseCudlik.Enabled = false;
            pauseCudlik.Text = "Pause";
            clearCudlik.Enabled = false;
            runCudlik.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > 0)
            {
                ziveBunky.Clear();
                for (int i=0 ;i<100 ; i++)
                {
                    for (int j=0 ;j<100 ; j++)
                    {
                        bunky[i, j].CurrentState = false;
                        bunky[i, j].NextState = false;
                    }
                } 
                Char[] splitter = new Char[1];
                splitter[0] = ';';
                string[] pole = savy[comboBox1.SelectedIndex-1].Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                for (int a = 0 ; a < pole.Length ; a++)
                {
                    string[] pole2d = pole[a].Split(',');
                    int x = Convert.ToInt32(pole2d[0]);
                    int y = Convert.ToInt32(pole2d[1]);
                    bunky[x, y].CurrentState = true;
                    ziveBunky.Add(bunky[x, y]);
                }
                svet.Invalidate();
                runCudlik.Enabled = true;   
            }
            if (ziveBunky.Count > 0)
            {
                clearCudlik.Enabled = true;
                runCudlik.Enabled = true;
            }
            else
            {
                clearCudlik.Enabled = false;
                runCudlik.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer.Interval = trackBar1.Value * 10;
            rychlostLabel.Text = timer.Interval.ToString() + " ms";
        }

        private void ShowNastaveni(object sender, EventArgs e)
        {
            panel1.Visible = true;
            timer.Enabled = false;

        }

        private void HideNasatveni(object sender, EventArgs e)
        {
            if ((upDownMaxOziveni.Value >= upDownMinOziveni.Value) && (upDownMaxPreziti.Value >= upDownMinPreziti.Value))
            {
                panel1.Visible = false;
                Cell.minPreziti = (int) upDownMinPreziti.Value;
                Cell.maxPreziti = (int) upDownMaxPreziti.Value;
                Cell.minOziveni = (int) upDownMinOziveni.Value;
                Cell.maxOziveni = (int) upDownMaxOziveni.Value;
                if (stav == GameState.Running)
                {                          
                    timer.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Nesmyslné hodnoty");
            }
            
        }

        private void KrokButton_Click(object sender, EventArgs e)
        {
            if (stav == GameState.Paused)
            {
                Tick(null, new EventArgs());
            }
        }
    }
}
