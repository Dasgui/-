
namespace Turima
{
    partial class Poisk
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
            this.WhatIchem = new System.Windows.Forms.TextBox();
            this.GoPoisk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhatIchem
            // 
            this.WhatIchem.Location = new System.Drawing.Point(42, 36);
            this.WhatIchem.Name = "WhatIchem";
            this.WhatIchem.Size = new System.Drawing.Size(100, 20);
            this.WhatIchem.TabIndex = 0;
            // 
            // GoPoisk
            // 
            this.GoPoisk.Location = new System.Drawing.Point(148, 34);
            this.GoPoisk.Name = "GoPoisk";
            this.GoPoisk.Size = new System.Drawing.Size(75, 23);
            this.GoPoisk.TabIndex = 1;
            this.GoPoisk.Text = "button1";
            this.GoPoisk.UseVisualStyleBackColor = true;
            this.GoPoisk.Click += new System.EventHandler(this.GoPoisk_Click);
            // 
            // Poisk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 127);
            this.Controls.Add(this.GoPoisk);
            this.Controls.Add(this.WhatIchem);
            this.Name = "Poisk";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WhatIchem;
        private System.Windows.Forms.Button GoPoisk;
    }
}