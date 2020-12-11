namespace Logik
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Red = new System.Windows.Forms.Label();
            this.lb_Guess1 = new System.Windows.Forms.Label();
            this.lb_Blue = new System.Windows.Forms.Label();
            this.lb_Guess2 = new System.Windows.Forms.Label();
            this.lb_Guess3 = new System.Windows.Forms.Label();
            this.lb_Guess4 = new System.Windows.Forms.Label();
            this.lb_Guess5 = new System.Windows.Forms.Label();
            this.lb_Green = new System.Windows.Forms.Label();
            this.lb_Black = new System.Windows.Forms.Label();
            this.lb_Yeallow = new System.Windows.Forms.Label();
            this.lb_Purple = new System.Windows.Forms.Label();
            this.bt_Start = new System.Windows.Forms.Button();
            this.nud_Presne = new System.Windows.Forms.NumericUpDown();
            this.lb_Presne = new System.Windows.Forms.Label();
            this.lb_Objevuje = new System.Windows.Forms.Label();
            this.nud_Objevuje = new System.Windows.Forms.NumericUpDown();
            this.bt_Budiz = new System.Windows.Forms.Button();
            this.bt_Hodnot = new System.Windows.Forms.Button();
            this.dGv_Guess = new System.Windows.Forms.DataGridView();
            this.Color1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Presne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Objevuje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Guess)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Red
            // 
            this.lb_Red.BackColor = System.Drawing.Color.Red;
            this.lb_Red.Location = new System.Drawing.Point(437, 33);
            this.lb_Red.Name = "lb_Red";
            this.lb_Red.Size = new System.Drawing.Size(47, 51);
            this.lb_Red.TabIndex = 0;
            this.lb_Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // lb_Guess1
            // 
            this.lb_Guess1.AllowDrop = true;
            this.lb_Guess1.BackColor = System.Drawing.Color.Silver;
            this.lb_Guess1.Location = new System.Drawing.Point(28, 33);
            this.lb_Guess1.Name = "lb_Guess1";
            this.lb_Guess1.Size = new System.Drawing.Size(47, 51);
            this.lb_Guess1.TabIndex = 1;
            this.lb_Guess1.DragDrop += new System.Windows.Forms.DragEventHandler(this.label2_DragDrop);
            this.lb_Guess1.DragEnter += new System.Windows.Forms.DragEventHandler(this.label2_DragEnter);
            // 
            // lb_Blue
            // 
            this.lb_Blue.BackColor = System.Drawing.Color.MidnightBlue;
            this.lb_Blue.Location = new System.Drawing.Point(490, 33);
            this.lb_Blue.Name = "lb_Blue";
            this.lb_Blue.Size = new System.Drawing.Size(47, 51);
            this.lb_Blue.TabIndex = 2;
            this.lb_Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Blue_MouseDown);
            // 
            // lb_Guess2
            // 
            this.lb_Guess2.AllowDrop = true;
            this.lb_Guess2.BackColor = System.Drawing.Color.Silver;
            this.lb_Guess2.Location = new System.Drawing.Point(81, 33);
            this.lb_Guess2.Name = "lb_Guess2";
            this.lb_Guess2.Size = new System.Drawing.Size(47, 51);
            this.lb_Guess2.TabIndex = 3;
            this.lb_Guess2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_Guess2_DragDrop);
            this.lb_Guess2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_Guess2_DragEnter);
            // 
            // lb_Guess3
            // 
            this.lb_Guess3.AllowDrop = true;
            this.lb_Guess3.BackColor = System.Drawing.Color.Silver;
            this.lb_Guess3.Location = new System.Drawing.Point(134, 33);
            this.lb_Guess3.Name = "lb_Guess3";
            this.lb_Guess3.Size = new System.Drawing.Size(47, 51);
            this.lb_Guess3.TabIndex = 4;
            this.lb_Guess3.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_Guess3_DragDrop);
            this.lb_Guess3.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_Guess3_DragEnter);
            // 
            // lb_Guess4
            // 
            this.lb_Guess4.AllowDrop = true;
            this.lb_Guess4.BackColor = System.Drawing.Color.Silver;
            this.lb_Guess4.Location = new System.Drawing.Point(187, 33);
            this.lb_Guess4.Name = "lb_Guess4";
            this.lb_Guess4.Size = new System.Drawing.Size(47, 51);
            this.lb_Guess4.TabIndex = 5;
            this.lb_Guess4.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_Guess4_DragDrop);
            this.lb_Guess4.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_Guess4_DragEnter);
            // 
            // lb_Guess5
            // 
            this.lb_Guess5.AllowDrop = true;
            this.lb_Guess5.BackColor = System.Drawing.Color.Silver;
            this.lb_Guess5.Location = new System.Drawing.Point(240, 33);
            this.lb_Guess5.Name = "lb_Guess5";
            this.lb_Guess5.Size = new System.Drawing.Size(47, 51);
            this.lb_Guess5.TabIndex = 6;
            this.lb_Guess5.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_Guess5_DragDrop);
            this.lb_Guess5.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_Guess5_DragEnter);
            // 
            // lb_Green
            // 
            this.lb_Green.BackColor = System.Drawing.Color.Lime;
            this.lb_Green.Location = new System.Drawing.Point(543, 33);
            this.lb_Green.Name = "lb_Green";
            this.lb_Green.Size = new System.Drawing.Size(47, 51);
            this.lb_Green.TabIndex = 7;
            this.lb_Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Green_MouseDown);
            // 
            // lb_Black
            // 
            this.lb_Black.BackColor = System.Drawing.Color.Black;
            this.lb_Black.Location = new System.Drawing.Point(596, 33);
            this.lb_Black.Name = "lb_Black";
            this.lb_Black.Size = new System.Drawing.Size(47, 51);
            this.lb_Black.TabIndex = 8;
            this.lb_Black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Black_MouseDown);
            // 
            // lb_Yeallow
            // 
            this.lb_Yeallow.BackColor = System.Drawing.Color.Gold;
            this.lb_Yeallow.Location = new System.Drawing.Point(649, 33);
            this.lb_Yeallow.Name = "lb_Yeallow";
            this.lb_Yeallow.Size = new System.Drawing.Size(47, 51);
            this.lb_Yeallow.TabIndex = 9;
            this.lb_Yeallow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Yeallow_MouseDown);
            // 
            // lb_Purple
            // 
            this.lb_Purple.BackColor = System.Drawing.Color.Purple;
            this.lb_Purple.Location = new System.Drawing.Point(702, 33);
            this.lb_Purple.Name = "lb_Purple";
            this.lb_Purple.Size = new System.Drawing.Size(47, 51);
            this.lb_Purple.TabIndex = 10;
            this.lb_Purple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_Purple_MouseDown);
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(440, 116);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(86, 37);
            this.bt_Start.TabIndex = 11;
            this.bt_Start.Text = "Start!";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // nud_Presne
            // 
            this.nud_Presne.Location = new System.Drawing.Point(440, 194);
            this.nud_Presne.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Presne.Name = "nud_Presne";
            this.nud_Presne.Size = new System.Drawing.Size(86, 20);
            this.nud_Presne.TabIndex = 12;
            // 
            // lb_Presne
            // 
            this.lb_Presne.AutoSize = true;
            this.lb_Presne.Location = new System.Drawing.Point(437, 178);
            this.lb_Presne.Name = "lb_Presne";
            this.lb_Presne.Size = new System.Drawing.Size(76, 13);
            this.lb_Presne.TabIndex = 13;
            this.lb_Presne.Text = "Přesná shoda!";
            // 
            // lb_Objevuje
            // 
            this.lb_Objevuje.AutoSize = true;
            this.lb_Objevuje.Location = new System.Drawing.Point(567, 178);
            this.lb_Objevuje.Name = "lb_Objevuje";
            this.lb_Objevuje.Size = new System.Drawing.Size(95, 13);
            this.lb_Objevuje.TabIndex = 14;
            this.lb_Objevuje.Text = "Barva se objevuje!";
            // 
            // nud_Objevuje
            // 
            this.nud_Objevuje.Location = new System.Drawing.Point(570, 194);
            this.nud_Objevuje.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_Objevuje.Name = "nud_Objevuje";
            this.nud_Objevuje.Size = new System.Drawing.Size(86, 20);
            this.nud_Objevuje.TabIndex = 15;
            // 
            // bt_Budiz
            // 
            this.bt_Budiz.Location = new System.Drawing.Point(668, 191);
            this.bt_Budiz.Name = "bt_Budiz";
            this.bt_Budiz.Size = new System.Drawing.Size(75, 23);
            this.bt_Budiz.TabIndex = 16;
            this.bt_Budiz.Text = "Budiž";
            this.bt_Budiz.UseVisualStyleBackColor = true;
            this.bt_Budiz.Click += new System.EventHandler(this.bt_Budiz_Click);
            // 
            // bt_Hodnot
            // 
            this.bt_Hodnot.Location = new System.Drawing.Point(749, 191);
            this.bt_Hodnot.Name = "bt_Hodnot";
            this.bt_Hodnot.Size = new System.Drawing.Size(75, 23);
            this.bt_Hodnot.TabIndex = 22;
            this.bt_Hodnot.Text = "Hodnoť";
            this.bt_Hodnot.UseVisualStyleBackColor = true;
            this.bt_Hodnot.Click += new System.EventHandler(this.bt_Hodnot_Click);
            // 
            // dGv_Guess
            // 
            this.dGv_Guess.AllowUserToAddRows = false;
            this.dGv_Guess.AllowUserToDeleteRows = false;
            this.dGv_Guess.AllowUserToResizeColumns = false;
            this.dGv_Guess.AllowUserToResizeRows = false;
            this.dGv_Guess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGv_Guess.ColumnHeadersVisible = false;
            this.dGv_Guess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Color1,
            this.Color2,
            this.Color3,
            this.Color4,
            this.Color5});
            this.dGv_Guess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dGv_Guess.Location = new System.Drawing.Point(31, 87);
            this.dGv_Guess.MultiSelect = false;
            this.dGv_Guess.Name = "dGv_Guess";
            this.dGv_Guess.ReadOnly = true;
            this.dGv_Guess.RowHeadersVisible = false;
            this.dGv_Guess.Size = new System.Drawing.Size(256, 163);
            this.dGv_Guess.TabIndex = 23;
            this.dGv_Guess.SelectionChanged += new System.EventHandler(this.dGv_Guess_SelectionChanged);
            // 
            // Color1
            // 
            this.Color1.HeaderText = "";
            this.Color1.Name = "Color1";
            this.Color1.ReadOnly = true;
            this.Color1.Width = 50;
            // 
            // Color2
            // 
            this.Color2.HeaderText = "";
            this.Color2.Name = "Color2";
            this.Color2.ReadOnly = true;
            this.Color2.Width = 50;
            // 
            // Color3
            // 
            this.Color3.HeaderText = "";
            this.Color3.Name = "Color3";
            this.Color3.ReadOnly = true;
            this.Color3.Width = 50;
            // 
            // Color4
            // 
            this.Color4.HeaderText = "";
            this.Color4.Name = "Color4";
            this.Color4.ReadOnly = true;
            this.Color4.Width = 50;
            // 
            // Color5
            // 
            this.Color5.HeaderText = "";
            this.Color5.Name = "Color5";
            this.Color5.ReadOnly = true;
            this.Color5.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 262);
            this.Controls.Add(this.dGv_Guess);
            this.Controls.Add(this.bt_Hodnot);
            this.Controls.Add(this.bt_Budiz);
            this.Controls.Add(this.nud_Objevuje);
            this.Controls.Add(this.lb_Objevuje);
            this.Controls.Add(this.lb_Presne);
            this.Controls.Add(this.nud_Presne);
            this.Controls.Add(this.bt_Start);
            this.Controls.Add(this.lb_Purple);
            this.Controls.Add(this.lb_Yeallow);
            this.Controls.Add(this.lb_Black);
            this.Controls.Add(this.lb_Green);
            this.Controls.Add(this.lb_Guess5);
            this.Controls.Add(this.lb_Guess4);
            this.Controls.Add(this.lb_Guess3);
            this.Controls.Add(this.lb_Guess2);
            this.Controls.Add(this.lb_Blue);
            this.Controls.Add(this.lb_Guess1);
            this.Controls.Add(this.lb_Red);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Presne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Objevuje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGv_Guess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Red;
        private System.Windows.Forms.Label lb_Guess1;
        private System.Windows.Forms.Label lb_Blue;
        private System.Windows.Forms.Label lb_Guess2;
        private System.Windows.Forms.Label lb_Guess3;
        private System.Windows.Forms.Label lb_Guess4;
        private System.Windows.Forms.Label lb_Guess5;
        private System.Windows.Forms.Label lb_Green;
        private System.Windows.Forms.Label lb_Black;
        private System.Windows.Forms.Label lb_Yeallow;
        private System.Windows.Forms.Label lb_Purple;
        private System.Windows.Forms.Button bt_Start;
        private System.Windows.Forms.NumericUpDown nud_Presne;
        private System.Windows.Forms.Label lb_Presne;
        private System.Windows.Forms.Label lb_Objevuje;
        private System.Windows.Forms.NumericUpDown nud_Objevuje;
        private System.Windows.Forms.Button bt_Budiz;
        private System.Windows.Forms.Button bt_Hodnot;
        private System.Windows.Forms.DataGridView dGv_Guess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color5;
    }
}

