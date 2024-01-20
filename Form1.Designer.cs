namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.brighttrackBar = new System.Windows.Forms.TrackBar();
            this.ContrasttrackBar = new System.Windows.Forms.TrackBar();
            this.binarizelabel = new System.Windows.Forms.Label();
            this.brightlabel = new System.Windows.Forms.Label();
            this.contrastlabel = new System.Windows.Forms.Label();
            this.contrasttextBox = new System.Windows.Forms.TextBox();
            this.contrastbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonScaleNeighbour = new System.Windows.Forms.Button();
            this.buttonScaleBilineal = new System.Windows.Forms.Button();
            this.buttonGauss = new System.Windows.Forms.Button();
            this.buttonNoise = new System.Windows.Forms.Button();
            this.buttonUniform = new System.Windows.Forms.Button();
            this.buttonSharpness = new System.Windows.Forms.Button();
            this.buttonEdge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brighttrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrasttrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выбрать изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сброс";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 476);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(743, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 574);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(634, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 371);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Негатив";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(570, 415);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "Серость";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(569, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 38);
            this.button5.TabIndex = 9;
            this.button5.Text = "Бинаризация";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(576, 145);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(121, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // brighttrackBar
            // 
            this.brighttrackBar.Location = new System.Drawing.Point(576, 218);
            this.brighttrackBar.Name = "brighttrackBar";
            this.brighttrackBar.Size = new System.Drawing.Size(121, 45);
            this.brighttrackBar.TabIndex = 11;
            this.brighttrackBar.Scroll += new System.EventHandler(this.brighttrackBar_Scroll);
            // 
            // ContrasttrackBar
            // 
            this.ContrasttrackBar.Enabled = false;
            this.ContrasttrackBar.Location = new System.Drawing.Point(372, 517);
            this.ContrasttrackBar.Maximum = 100;
            this.ContrasttrackBar.Minimum = -100;
            this.ContrasttrackBar.Name = "ContrasttrackBar";
            this.ContrasttrackBar.Size = new System.Drawing.Size(10, 45);
            this.ContrasttrackBar.TabIndex = 12;
            this.ContrasttrackBar.Visible = false;
            this.ContrasttrackBar.Scroll += new System.EventHandler(this.ContrasttrackBar_Scroll);
            // 
            // binarizelabel
            // 
            this.binarizelabel.AutoSize = true;
            this.binarizelabel.Location = new System.Drawing.Point(574, 120);
            this.binarizelabel.Name = "binarizelabel";
            this.binarizelabel.Size = new System.Drawing.Size(123, 13);
            this.binarizelabel.TabIndex = 13;
            this.binarizelabel.Text = "Уровень бинаризации:";
            // 
            // brightlabel
            // 
            this.brightlabel.AutoSize = true;
            this.brightlabel.Location = new System.Drawing.Point(573, 193);
            this.brightlabel.Name = "brightlabel";
            this.brightlabel.Size = new System.Drawing.Size(95, 13);
            this.brightlabel.TabIndex = 14;
            this.brightlabel.Text = "Уровень яркости";
            // 
            // contrastlabel
            // 
            this.contrastlabel.AutoSize = true;
            this.contrastlabel.Location = new System.Drawing.Point(567, 280);
            this.contrastlabel.Name = "contrastlabel";
            this.contrastlabel.Size = new System.Drawing.Size(129, 13);
            this.contrastlabel.TabIndex = 15;
            this.contrastlabel.Text = "Уровень контрастности";
            this.contrastlabel.Visible = false;
            // 
            // contrasttextBox
            // 
            this.contrasttextBox.Location = new System.Drawing.Point(563, 307);
            this.contrasttextBox.Name = "contrasttextBox";
            this.contrasttextBox.Size = new System.Drawing.Size(65, 20);
            this.contrasttextBox.TabIndex = 16;
            // 
            // contrastbutton
            // 
            this.contrastbutton.Location = new System.Drawing.Point(637, 307);
            this.contrastbutton.Name = "contrastbutton";
            this.contrastbutton.Size = new System.Drawing.Size(100, 20);
            this.contrastbutton.TabIndex = 17;
            this.contrastbutton.Text = "Контрастность";
            this.contrastbutton.UseVisualStyleBackColor = true;
            this.contrastbutton.Click += new System.EventHandler(this.contrastbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ширина : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(573, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Высота:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(685, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 20;
            // 
            // buttonScaleNeighbour
            // 
            this.buttonScaleNeighbour.Location = new System.Drawing.Point(557, 342);
            this.buttonScaleNeighbour.Name = "buttonScaleNeighbour";
            this.buttonScaleNeighbour.Size = new System.Drawing.Size(89, 23);
            this.buttonScaleNeighbour.TabIndex = 21;
            this.buttonScaleNeighbour.Text = "Ближ. соседа";
            this.buttonScaleNeighbour.UseVisualStyleBackColor = true;
            this.buttonScaleNeighbour.Click += new System.EventHandler(this.buttonScaleNeighbour_Click);
            // 
            // buttonScaleBilineal
            // 
            this.buttonScaleBilineal.Location = new System.Drawing.Point(652, 342);
            this.buttonScaleBilineal.Name = "buttonScaleBilineal";
            this.buttonScaleBilineal.Size = new System.Drawing.Size(85, 23);
            this.buttonScaleBilineal.TabIndex = 22;
            this.buttonScaleBilineal.Text = "Билинейная";
            this.buttonScaleBilineal.UseVisualStyleBackColor = true;
            this.buttonScaleBilineal.Click += new System.EventHandler(this.buttonScaleBilineal_Click);
            // 
            // buttonGauss
            // 
            this.buttonGauss.Location = new System.Drawing.Point(563, 517);
            this.buttonGauss.Name = "buttonGauss";
            this.buttonGauss.Size = new System.Drawing.Size(146, 23);
            this.buttonGauss.TabIndex = 23;
            this.buttonGauss.Text = "Фильтр Гаусса";
            this.buttonGauss.UseVisualStyleBackColor = true;
            this.buttonGauss.Click += new System.EventHandler(this.buttonGauss_Click);
            // 
            // buttonNoise
            // 
            this.buttonNoise.Location = new System.Drawing.Point(563, 554);
            this.buttonNoise.Name = "buttonNoise";
            this.buttonNoise.Size = new System.Drawing.Size(146, 23);
            this.buttonNoise.TabIndex = 24;
            this.buttonNoise.Text = "Шум";
            this.buttonNoise.UseVisualStyleBackColor = true;
            this.buttonNoise.Click += new System.EventHandler(this.buttonNoise_Click);
            // 
            // buttonUniform
            // 
            this.buttonUniform.Location = new System.Drawing.Point(411, 517);
            this.buttonUniform.Name = "buttonUniform";
            this.buttonUniform.Size = new System.Drawing.Size(146, 23);
            this.buttonUniform.TabIndex = 25;
            this.buttonUniform.Text = "Равномерный Фильтр";
            this.buttonUniform.UseVisualStyleBackColor = true;
            this.buttonUniform.Click += new System.EventHandler(this.buttonUniform_Click);
            // 
            // buttonSharpness
            // 
            this.buttonSharpness.Location = new System.Drawing.Point(470, 554);
            this.buttonSharpness.Name = "buttonSharpness";
            this.buttonSharpness.Size = new System.Drawing.Size(87, 23);
            this.buttonSharpness.TabIndex = 26;
            this.buttonSharpness.Text = "Резкость";
            this.buttonSharpness.UseVisualStyleBackColor = true;
            this.buttonSharpness.Click += new System.EventHandler(this.buttonSharpness_Click);
            // 
            // buttonEdge
            // 
            this.buttonEdge.Location = new System.Drawing.Point(377, 554);
            this.buttonEdge.Name = "buttonEdge";
            this.buttonEdge.Size = new System.Drawing.Size(87, 23);
            this.buttonEdge.TabIndex = 27;
            this.buttonEdge.Text = "Оконтуривание";
            this.buttonEdge.UseVisualStyleBackColor = true;
            this.buttonEdge.Click += new System.EventHandler(this.buttonEdge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 598);
            this.Controls.Add(this.buttonEdge);
            this.Controls.Add(this.buttonSharpness);
            this.Controls.Add(this.buttonUniform);
            this.Controls.Add(this.buttonNoise);
            this.Controls.Add(this.buttonGauss);
            this.Controls.Add(this.buttonScaleBilineal);
            this.Controls.Add(this.buttonScaleNeighbour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.contrastbutton);
            this.Controls.Add(this.contrasttextBox);
            this.Controls.Add(this.contrastlabel);
            this.Controls.Add(this.brightlabel);
            this.Controls.Add(this.binarizelabel);
            this.Controls.Add(this.ContrasttrackBar);
            this.Controls.Add(this.brighttrackBar);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "ЛР №5 Компьютерная графика";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brighttrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrasttrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar brighttrackBar;
        private System.Windows.Forms.TrackBar ContrasttrackBar;
        private System.Windows.Forms.Label binarizelabel;
        private System.Windows.Forms.Label brightlabel;
        private System.Windows.Forms.Label contrastlabel;
        private System.Windows.Forms.TextBox contrasttextBox;
        private System.Windows.Forms.Button contrastbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonScaleNeighbour;
        private System.Windows.Forms.Button buttonScaleBilineal;
        private System.Windows.Forms.Button buttonGauss;
        private System.Windows.Forms.Button buttonNoise;
        private System.Windows.Forms.Button buttonUniform;
        private System.Windows.Forms.Button buttonSharpness;
        private System.Windows.Forms.Button buttonEdge;
    }
}

