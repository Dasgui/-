namespace Kanoisk
{
    partial class Mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainmenu));
            this.MainText = new System.Windows.Forms.Label();
            this.AboutMaider = new System.Windows.Forms.Button();
            this.mainGame = new System.Windows.Forms.Button();
            this.InformationAboutGame = new System.Windows.Forms.Button();
            this.ExitButten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainText
            // 
            this.MainText.AutoSize = true;
            this.MainText.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainText.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.MainText.Location = new System.Drawing.Point(98, 46);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(219, 37);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "Ханойская башня";
            // 
            // AboutMaider
            // 
            this.AboutMaider.BackColor = System.Drawing.Color.DarkCyan;
            this.AboutMaider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutMaider.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutMaider.ForeColor = System.Drawing.Color.Aqua;
            this.AboutMaider.Location = new System.Drawing.Point(119, 230);
            this.AboutMaider.Name = "AboutMaider";
            this.AboutMaider.Size = new System.Drawing.Size(163, 38);
            this.AboutMaider.TabIndex = 1;
            this.AboutMaider.Text = "Об авторе";
            this.AboutMaider.UseVisualStyleBackColor = false;
            this.AboutMaider.Click += new System.EventHandler(this.AboutMaider_Click);
            // 
            // mainGame
            // 
            this.mainGame.BackColor = System.Drawing.Color.DarkCyan;
            this.mainGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainGame.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainGame.ForeColor = System.Drawing.Color.Aqua;
            this.mainGame.Location = new System.Drawing.Point(119, 110);
            this.mainGame.Name = "mainGame";
            this.mainGame.Size = new System.Drawing.Size(163, 38);
            this.mainGame.TabIndex = 2;
            this.mainGame.Text = "Игра";
            this.mainGame.UseVisualStyleBackColor = false;
            this.mainGame.Click += new System.EventHandler(this.mainGame_Click);
            // 
            // InformationAboutGame
            // 
            this.InformationAboutGame.BackColor = System.Drawing.Color.DarkCyan;
            this.InformationAboutGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationAboutGame.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationAboutGame.ForeColor = System.Drawing.Color.Aqua;
            this.InformationAboutGame.Location = new System.Drawing.Point(119, 171);
            this.InformationAboutGame.Name = "InformationAboutGame";
            this.InformationAboutGame.Size = new System.Drawing.Size(163, 38);
            this.InformationAboutGame.TabIndex = 3;
            this.InformationAboutGame.Text = "О самой игре";
            this.InformationAboutGame.UseVisualStyleBackColor = false;
            this.InformationAboutGame.Click += new System.EventHandler(this.InformationAboutGame_Click);
            // 
            // ExitButten
            // 
            this.ExitButten.BackColor = System.Drawing.Color.DarkCyan;
            this.ExitButten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButten.Font = new System.Drawing.Font("Haettenschweiler", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButten.ForeColor = System.Drawing.Color.Aqua;
            this.ExitButten.Location = new System.Drawing.Point(119, 290);
            this.ExitButten.Name = "ExitButten";
            this.ExitButten.Size = new System.Drawing.Size(163, 38);
            this.ExitButten.TabIndex = 4;
            this.ExitButten.Text = "Выйти";
            this.ExitButten.UseVisualStyleBackColor = false;
            this.ExitButten.Click += new System.EventHandler(this.ExitButten_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(424, 401);
            this.Controls.Add(this.ExitButten);
            this.Controls.Add(this.InformationAboutGame);
            this.Controls.Add(this.mainGame);
            this.Controls.Add(this.AboutMaider);
            this.Controls.Add(this.MainText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainmenu_FormClosing);
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Button AboutMaider;
        private System.Windows.Forms.Button mainGame;
        private System.Windows.Forms.Button InformationAboutGame;
        private System.Windows.Forms.Button ExitButten;
    }
}