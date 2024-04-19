
namespace Turima
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NameOfProekt = new System.Windows.Forms.Label();
            this.BaseOfMurder = new System.Windows.Forms.Button();
            this.GraphOfWorker = new System.Windows.Forms.Button();
            this.FoodInput = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.InformationOfOrganaiz = new System.Windows.Forms.Button();
            this.InformationOfProgramm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfProekt
            // 
            this.NameOfProekt.AutoSize = true;
            this.NameOfProekt.BackColor = System.Drawing.Color.Orange;
            this.NameOfProekt.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameOfProekt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NameOfProekt.Location = new System.Drawing.Point(74, 9);
            this.NameOfProekt.Name = "NameOfProekt";
            this.NameOfProekt.Size = new System.Drawing.Size(252, 25);
            this.NameOfProekt.TabIndex = 0;
            this.NameOfProekt.Text = "Тюрьма \"Черный Дельфин\"";
            this.NameOfProekt.Click += new System.EventHandler(this.NameOfProekt_Click);
            // 
            // BaseOfMurder
            // 
            this.BaseOfMurder.BackColor = System.Drawing.Color.Orange;
            this.BaseOfMurder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BaseOfMurder.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseOfMurder.Location = new System.Drawing.Point(88, 35);
            this.BaseOfMurder.Name = "BaseOfMurder";
            this.BaseOfMurder.Size = new System.Drawing.Size(227, 36);
            this.BaseOfMurder.TabIndex = 1;
            this.BaseOfMurder.Text = "Данные о заключенных";
            this.BaseOfMurder.UseVisualStyleBackColor = false;
            this.BaseOfMurder.Click += new System.EventHandler(this.BaseOfMurder_Click);
            // 
            // GraphOfWorker
            // 
            this.GraphOfWorker.BackColor = System.Drawing.Color.Orange;
            this.GraphOfWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphOfWorker.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphOfWorker.Location = new System.Drawing.Point(116, 77);
            this.GraphOfWorker.Name = "GraphOfWorker";
            this.GraphOfWorker.Size = new System.Drawing.Size(173, 39);
            this.GraphOfWorker.TabIndex = 2;
            this.GraphOfWorker.Text = "График работы сотрудников";
            this.GraphOfWorker.UseVisualStyleBackColor = false;
            this.GraphOfWorker.Click += new System.EventHandler(this.GraphOfWorker_Click);
            // 
            // FoodInput
            // 
            this.FoodInput.BackColor = System.Drawing.Color.Orange;
            this.FoodInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FoodInput.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FoodInput.Location = new System.Drawing.Point(116, 122);
            this.FoodInput.Name = "FoodInput";
            this.FoodInput.Size = new System.Drawing.Size(173, 40);
            this.FoodInput.TabIndex = 3;
            this.FoodInput.Text = "График поставки еды";
            this.FoodInput.UseVisualStyleBackColor = false;
            this.FoodInput.Click += new System.EventHandler(this.FoodInput_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Orange;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(152, 180);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(96, 33);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Выйти";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // InformationOfOrganaiz
            // 
            this.InformationOfOrganaiz.BackColor = System.Drawing.Color.Orange;
            this.InformationOfOrganaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationOfOrganaiz.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationOfOrganaiz.Location = new System.Drawing.Point(125, 285);
            this.InformationOfOrganaiz.Name = "InformationOfOrganaiz";
            this.InformationOfOrganaiz.Size = new System.Drawing.Size(145, 31);
            this.InformationOfOrganaiz.TabIndex = 5;
            this.InformationOfOrganaiz.Text = "Об организации";
            this.InformationOfOrganaiz.UseVisualStyleBackColor = false;
            this.InformationOfOrganaiz.Click += new System.EventHandler(this.InformationOfOrganaiz_Click);
            // 
            // InformationOfProgramm
            // 
            this.InformationOfProgramm.BackColor = System.Drawing.Color.Orange;
            this.InformationOfProgramm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformationOfProgramm.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationOfProgramm.Location = new System.Drawing.Point(161, 238);
            this.InformationOfProgramm.Name = "InformationOfProgramm";
            this.InformationOfProgramm.Size = new System.Drawing.Size(78, 41);
            this.InformationOfProgramm.TabIndex = 6;
            this.InformationOfProgramm.Text = "Справка";
            this.InformationOfProgramm.UseVisualStyleBackColor = false;
            this.InformationOfProgramm.Click += new System.EventHandler(this.InformationOfProgramm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Turima.Properties.Resources._3df8b2e5f2ca986d21a59d04371adcfb;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 341);
            this.Controls.Add(this.InformationOfProgramm);
            this.Controls.Add(this.InformationOfOrganaiz);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.FoodInput);
            this.Controls.Add(this.GraphOfWorker);
            this.Controls.Add(this.BaseOfMurder);
            this.Controls.Add(this.NameOfProekt);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Основное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameOfProekt;
        private System.Windows.Forms.Button BaseOfMurder;
        private System.Windows.Forms.Button GraphOfWorker;
        private System.Windows.Forms.Button FoodInput;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button InformationOfOrganaiz;
        private System.Windows.Forms.Button InformationOfProgramm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

