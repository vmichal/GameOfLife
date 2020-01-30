namespace GameOfLife
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.svet = new System.Windows.Forms.PictureBox();
            this.labelKola = new System.Windows.Forms.Label();
            this.runCudlik = new System.Windows.Forms.Button();
            this.pauseCudlik = new System.Windows.Forms.Button();
            this.labelZive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearCudlik = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.rychlostLabel = new System.Windows.Forms.Label();
            this.upDownMinPreziti = new System.Windows.Forms.NumericUpDown();
            this.upDownMaxPreziti = new System.Windows.Forms.NumericUpDown();
            this.upDownMinOziveni = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.upDownMaxOziveni = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.KrokButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.svet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinPreziti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMaxPreziti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinOziveni)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMaxOziveni)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 150;
            this.timer.Tick += new System.EventHandler(this.Tick);
            // 
            // svet
            // 
            this.svet.Location = new System.Drawing.Point(0, 0);
            this.svet.Name = "svet";
            this.svet.Size = new System.Drawing.Size(686, 626);
            this.svet.TabIndex = 0;
            this.svet.TabStop = false;
            this.svet.Click += new System.EventHandler(this.PaintBoxClick);
            this.svet.Paint += new System.Windows.Forms.PaintEventHandler(this.Vybarvi);
            // 
            // labelKola
            // 
            this.labelKola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKola.Location = new System.Drawing.Point(904, 483);
            this.labelKola.Name = "labelKola";
            this.labelKola.Size = new System.Drawing.Size(90, 50);
            this.labelKola.TabIndex = 1;
            this.labelKola.Text = "0";
            this.labelKola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // runCudlik
            // 
            this.runCudlik.Enabled = false;
            this.runCudlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.runCudlik.Location = new System.Drawing.Point(769, 120);
            this.runCudlik.Name = "runCudlik";
            this.runCudlik.Size = new System.Drawing.Size(201, 63);
            this.runCudlik.TabIndex = 3;
            this.runCudlik.Text = "Run";
            this.runCudlik.UseVisualStyleBackColor = true;
            this.runCudlik.Click += new System.EventHandler(this.Spust);
            // 
            // pauseCudlik
            // 
            this.pauseCudlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pauseCudlik.Location = new System.Drawing.Point(769, 258);
            this.pauseCudlik.Name = "pauseCudlik";
            this.pauseCudlik.Size = new System.Drawing.Size(201, 63);
            this.pauseCudlik.TabIndex = 4;
            this.pauseCudlik.Text = "Pause";
            this.pauseCudlik.UseVisualStyleBackColor = true;
            this.pauseCudlik.Click += new System.EventHandler(this.Pause);
            // 
            // labelZive
            // 
            this.labelZive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelZive.Location = new System.Drawing.Point(904, 405);
            this.labelZive.Name = "labelZive";
            this.labelZive.Size = new System.Drawing.Size(94, 50);
            this.labelZive.TabIndex = 5;
            this.labelZive.Text = "nA";
            this.labelZive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(748, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Číslo generace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(748, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 50);
            this.label2.TabIndex = 7;
            this.label2.Text = "Živých buněk";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearCudlik
            // 
            this.clearCudlik.Enabled = false;
            this.clearCudlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearCudlik.Location = new System.Drawing.Point(769, 327);
            this.clearCudlik.Name = "clearCudlik";
            this.clearCudlik.Size = new System.Drawing.Size(201, 63);
            this.clearCudlik.TabIndex = 8;
            this.clearCudlik.Text = "Clear";
            this.clearCudlik.UseVisualStyleBackColor = true;
            this.clearCudlik.Click += new System.EventHandler(this.Clear);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Custom",
            "Jednoduchý kříž",
            "Lichý kříž",
            "Řada 3",
            "Řada 5",
            "Řada 6",
            "Řada 7",
            "Řada 8",
            "Řada 9",
            "Řada 10",
            "Řada 14",
            "Řada 15",
            "Řada 16",
            "Řada 19",
            "Krumpáč",
            "Krumpáč deluxe",
            "Roh 4x4",
            "Patnáctiúhelník",
            "Dělo"});
            this.comboBox1.Location = new System.Drawing.Point(769, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(765, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 63);
            this.label3.TabIndex = 10;
            this.label3.Text = "Předdefinované šablony";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(115, 632);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(571, 56);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.Value = 20;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Rychlost";
            // 
            // rychlostLabel
            // 
            this.rychlostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rychlostLabel.Location = new System.Drawing.Point(706, 631);
            this.rychlostLabel.Name = "rychlostLabel";
            this.rychlostLabel.Size = new System.Drawing.Size(120, 46);
            this.rychlostLabel.TabIndex = 14;
            this.rychlostLabel.Text = "200 ms";
            this.rychlostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upDownMinPreziti
            // 
            this.upDownMinPreziti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upDownMinPreziti.Location = new System.Drawing.Point(384, 60);
            this.upDownMinPreziti.Name = "upDownMinPreziti";
            this.upDownMinPreziti.Size = new System.Drawing.Size(59, 30);
            this.upDownMinPreziti.TabIndex = 15;
            this.upDownMinPreziti.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // upDownMaxPreziti
            // 
            this.upDownMaxPreziti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upDownMaxPreziti.Location = new System.Drawing.Point(384, 154);
            this.upDownMaxPreziti.Name = "upDownMaxPreziti";
            this.upDownMaxPreziti.Size = new System.Drawing.Size(59, 30);
            this.upDownMaxPreziti.TabIndex = 16;
            this.upDownMaxPreziti.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // upDownMinOziveni
            // 
            this.upDownMinOziveni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upDownMinOziveni.Location = new System.Drawing.Point(384, 240);
            this.upDownMinOziveni.Name = "upDownMinOziveni";
            this.upDownMinOziveni.Size = new System.Drawing.Size(59, 30);
            this.upDownMinOziveni.TabIndex = 17;
            this.upDownMinOziveni.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.upDownMaxOziveni);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.upDownMinPreziti);
            this.panel1.Controls.Add(this.upDownMinOziveni);
            this.panel1.Controls.Add(this.upDownMaxPreziti);
            this.panel1.Location = new System.Drawing.Point(299, 148);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 451);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(102, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 49);
            this.button2.TabIndex = 23;
            this.button2.Text = "Pokračovat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.HideNasatveni);
            // 
            // upDownMaxOziveni
            // 
            this.upDownMaxOziveni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.upDownMaxOziveni.Location = new System.Drawing.Point(384, 320);
            this.upDownMaxOziveni.Name = "upDownMaxOziveni";
            this.upDownMaxOziveni.Size = new System.Drawing.Size(59, 30);
            this.upDownMaxOziveni.TabIndex = 22;
            this.upDownMaxOziveni.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(25, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(338, 74);
            this.label8.TabIndex = 21;
            this.label8.Text = "maximální počet sousedů pro oživení";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(25, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 74);
            this.label7.TabIndex = 20;
            this.label7.Text = "minimální počet sousedů pro oživení";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(25, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(338, 74);
            this.label6.TabIndex = 19;
            this.label6.Text = "maximální počet sousedů pro přežití";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 74);
            this.label5.TabIndex = 18;
            this.label5.Text = "minimální počet sousedů pro přežití";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(769, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 63);
            this.button1.TabIndex = 19;
            this.button1.Text = "Pokročilá nastavení";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowNastaveni);
            // 
            // KrokButton
            // 
            this.KrokButton.Enabled = false;
            this.KrokButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KrokButton.Location = new System.Drawing.Point(769, 189);
            this.KrokButton.Name = "KrokButton";
            this.KrokButton.Size = new System.Drawing.Size(201, 63);
            this.KrokButton.TabIndex = 20;
            this.KrokButton.Text = "Krok";
            this.KrokButton.UseVisualStyleBackColor = true;
            this.KrokButton.Click += new System.EventHandler(this.KrokButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rychlostLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.clearCudlik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelZive);
            this.Controls.Add(this.pauseCudlik);
            this.Controls.Add(this.runCudlik);
            this.Controls.Add(this.labelKola);
            this.Controls.Add(this.svet);
            this.Controls.Add(this.KrokButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.svet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinPreziti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMaxPreziti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upDownMinOziveni)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upDownMaxOziveni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox svet;
        private System.Windows.Forms.Label labelKola;
        private System.Windows.Forms.Button runCudlik;
        private System.Windows.Forms.Button pauseCudlik;
        private System.Windows.Forms.Label labelZive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearCudlik;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rychlostLabel;
        private System.Windows.Forms.NumericUpDown upDownMinPreziti;
        private System.Windows.Forms.NumericUpDown upDownMaxPreziti;
        private System.Windows.Forms.NumericUpDown upDownMinOziveni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown upDownMaxOziveni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button KrokButton;
    }
}

