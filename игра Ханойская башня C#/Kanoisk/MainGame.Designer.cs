namespace Kanoisk
{
    partial class MainGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.BaseST = new System.Windows.Forms.PictureBox();
            this.Stolb = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BaseFundament = new System.Windows.Forms.PictureBox();
            this.BaseST2 = new System.Windows.Forms.PictureBox();
            this.BaseST3 = new System.Windows.Forms.PictureBox();
            this.BaseST4 = new System.Windows.Forms.PictureBox();
            this.BaseST5 = new System.Windows.Forms.PictureBox();
            this.BaseST6 = new System.Windows.Forms.PictureBox();
            this.StolbR = new System.Windows.Forms.PictureBox();
            this.StolbL = new System.Windows.Forms.PictureBox();
            this.BaseFundamentR = new System.Windows.Forms.PictureBox();
            this.BaseFundamentL = new System.Windows.Forms.PictureBox();
            this.MainInformation = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяВМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stolb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFundament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StolbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StolbL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFundamentR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFundamentL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseST
            // 
            this.BaseST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseST.BackColor = System.Drawing.Color.LightSalmon;
            this.BaseST.Location = new System.Drawing.Point(303, 125);
            this.BaseST.Name = "BaseST";
            this.BaseST.Size = new System.Drawing.Size(120, 25);
            this.BaseST.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BaseST.TabIndex = 1;
            this.BaseST.TabStop = false;
            this.BaseST.Click += new System.EventHandler(this.BaseST_Click);
            this.BaseST.DragEnter += new System.Windows.Forms.DragEventHandler(this.BaseST_DragEnter);
            this.BaseST.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseST_MouseDown);
            this.BaseST.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseST_MouseMove);
            this.BaseST.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseST_MouseUp);
            // 
            // Stolb
            // 
            this.Stolb.BackColor = System.Drawing.Color.Transparent;
            this.Stolb.Image = global::Kanoisk.Properties.Resources.Чистый_столб;
            this.Stolb.Location = new System.Drawing.Point(662, 125);
            this.Stolb.Name = "Stolb";
            this.Stolb.Size = new System.Drawing.Size(29, 264);
            this.Stolb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Stolb.TabIndex = 0;
            this.Stolb.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BaseFundament
            // 
            this.BaseFundament.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseFundament.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BaseFundament.Location = new System.Drawing.Point(-16, 381);
            this.BaseFundament.Name = "BaseFundament";
            this.BaseFundament.Size = new System.Drawing.Size(1239, 79);
            this.BaseFundament.TabIndex = 2;
            this.BaseFundament.TabStop = false;
            // 
            // BaseST2
            // 
            this.BaseST2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseST2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BaseST2.Location = new System.Drawing.Point(284, 171);
            this.BaseST2.Name = "BaseST2";
            this.BaseST2.Size = new System.Drawing.Size(150, 25);
            this.BaseST2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BaseST2.TabIndex = 3;
            this.BaseST2.TabStop = false;
            this.BaseST2.Click += new System.EventHandler(this.BaseST2_Click);
            this.BaseST2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseST2_MouseDown);
            this.BaseST2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseST2_MouseMove);
            this.BaseST2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseST2_MouseUp);
            // 
            // BaseST3
            // 
            this.BaseST3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseST3.Image = global::Kanoisk.Properties.Resources.Цветной_столб;
            this.BaseST3.Location = new System.Drawing.Point(268, 224);
            this.BaseST3.Name = "BaseST3";
            this.BaseST3.Size = new System.Drawing.Size(180, 25);
            this.BaseST3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BaseST3.TabIndex = 4;
            this.BaseST3.TabStop = false;
            this.BaseST3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseST3_MouseDown);
            this.BaseST3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseST3_MouseMove);
            this.BaseST3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseST3_MouseUp);
            // 
            // BaseST4
            // 
            this.BaseST4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseST4.BackColor = System.Drawing.Color.DarkRed;
            this.BaseST4.Location = new System.Drawing.Point(253, 273);
            this.BaseST4.Name = "BaseST4";
            this.BaseST4.Size = new System.Drawing.Size(210, 25);
            this.BaseST4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BaseST4.TabIndex = 5;
            this.BaseST4.TabStop = false;
            this.BaseST4.Click += new System.EventHandler(this.BaseST4_Click);
            this.BaseST4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseST4_MouseDown);
            this.BaseST4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseST4_MouseMove);
            this.BaseST4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseST4_MouseUp);
            // 
            // BaseST5
            // 
            this.BaseST5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseST5.BackColor = System.Drawing.Color.DarkOrange;
            this.BaseST5.Location = new System.Drawing.Point(243, 319);
            this.BaseST5.Name = "BaseST5";
            this.BaseST5.Size = new System.Drawing.Size(240, 25);
            this.BaseST5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BaseST5.TabIndex = 6;
            this.BaseST5.TabStop = false;
            this.BaseST5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseST5_MouseDown);
            this.BaseST5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseST5_MouseMove);
            this.BaseST5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseST5_MouseUp);
            // 
            // BaseST6
            // 
            this.BaseST6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaseST6.BackColor = System.Drawing.Color.OliveDrab;
            this.BaseST6.Location = new System.Drawing.Point(228, 350);
            this.BaseST6.Name = "BaseST6";
            this.BaseST6.Size = new System.Drawing.Size(270, 25);
            this.BaseST6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BaseST6.TabIndex = 7;
            this.BaseST6.TabStop = false;
            this.BaseST6.Click += new System.EventHandler(this.BaseST6_Click);
            this.BaseST6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseST6_MouseDown);
            this.BaseST6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseST6_MouseMove);
            this.BaseST6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BaseST6_MouseUp);
            // 
            // StolbR
            // 
            this.StolbR.BackColor = System.Drawing.Color.Transparent;
            this.StolbR.Image = global::Kanoisk.Properties.Resources.Чистый_столб;
            this.StolbR.Location = new System.Drawing.Point(962, 125);
            this.StolbR.Name = "StolbR";
            this.StolbR.Size = new System.Drawing.Size(29, 264);
            this.StolbR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StolbR.TabIndex = 8;
            this.StolbR.TabStop = false;
            // 
            // StolbL
            // 
            this.StolbL.BackColor = System.Drawing.Color.Transparent;
            this.StolbL.Image = global::Kanoisk.Properties.Resources.Чистый_столб;
            this.StolbL.Location = new System.Drawing.Point(351, 125);
            this.StolbL.Name = "StolbL";
            this.StolbL.Size = new System.Drawing.Size(29, 264);
            this.StolbL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StolbL.TabIndex = 9;
            this.StolbL.TabStop = false;
            // 
            // BaseFundamentR
            // 
            this.BaseFundamentR.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BaseFundamentR.Location = new System.Drawing.Point(1222, 0);
            this.BaseFundamentR.Name = "BaseFundamentR";
            this.BaseFundamentR.Size = new System.Drawing.Size(10, 389);
            this.BaseFundamentR.TabIndex = 11;
            this.BaseFundamentR.TabStop = false;
            // 
            // BaseFundamentL
            // 
            this.BaseFundamentL.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BaseFundamentL.Location = new System.Drawing.Point(-10, -8);
            this.BaseFundamentL.Name = "BaseFundamentL";
            this.BaseFundamentL.Size = new System.Drawing.Size(10, 389);
            this.BaseFundamentL.TabIndex = 12;
            this.BaseFundamentL.TabStop = false;
            // 
            // MainInformation
            // 
            this.MainInformation.AutoSize = true;
            this.MainInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainInformation.ForeColor = System.Drawing.Color.Brown;
            this.MainInformation.Location = new System.Drawing.Point(5, 34);
            this.MainInformation.Name = "MainInformation";
            this.MainInformation.Size = new System.Drawing.Size(189, 25);
            this.MainInformation.TabIndex = 13;
            this.MainInformation.Text = "Башня не собранна";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяВМенюToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяВМенюToolStripMenuItem
            // 
            this.вернутьсяВМенюToolStripMenuItem.Name = "вернутьсяВМенюToolStripMenuItem";
            this.вернутьсяВМенюToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.вернутьсяВМенюToolStripMenuItem.Text = "Вернуться в меню";
            this.вернутьсяВМенюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяВМенюToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1222, 450);
            this.Controls.Add(this.MainInformation);
            this.Controls.Add(this.BaseFundamentL);
            this.Controls.Add(this.BaseFundamentR);
            this.Controls.Add(this.BaseST6);
            this.Controls.Add(this.BaseST5);
            this.Controls.Add(this.BaseST4);
            this.Controls.Add(this.BaseST3);
            this.Controls.Add(this.BaseST2);
            this.Controls.Add(this.BaseFundament);
            this.Controls.Add(this.BaseST);
            this.Controls.Add(this.Stolb);
            this.Controls.Add(this.StolbR);
            this.Controls.Add(this.StolbL);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanoisk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainGame_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.BaseST)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stolb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFundament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseST6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StolbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StolbL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFundamentR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaseFundamentL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Stolb;
        private System.Windows.Forms.PictureBox BaseST;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox BaseFundament;
        private System.Windows.Forms.PictureBox BaseST2;
        private System.Windows.Forms.PictureBox BaseST3;
        private System.Windows.Forms.PictureBox BaseST4;
        private System.Windows.Forms.PictureBox BaseST5;
        private System.Windows.Forms.PictureBox BaseST6;
        private System.Windows.Forms.PictureBox StolbR;
        private System.Windows.Forms.PictureBox StolbL;
        private System.Windows.Forms.PictureBox BaseFundamentR;
        private System.Windows.Forms.PictureBox BaseFundamentL;
        private System.Windows.Forms.Label MainInformation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяВМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

