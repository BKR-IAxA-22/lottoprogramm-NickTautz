namespace Lottoprogramm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.zahl1 = new System.Windows.Forms.Button();
            this.zahl2 = new System.Windows.Forms.Button();
            this.zahl3 = new System.Windows.Forms.Button();
            this.zahl4 = new System.Windows.Forms.Button();
            this.zahl5 = new System.Windows.Forms.Button();
            this.zahl6 = new System.Windows.Forms.Button();
            this.ausloser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zahl1
            // 
            this.zahl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.zahl1.Location = new System.Drawing.Point(115, 283);
            this.zahl1.Name = "zahl1";
            this.zahl1.Size = new System.Drawing.Size(114, 41);
            this.zahl1.TabIndex = 0;
            this.zahl1.UseVisualStyleBackColor = false;
            this.zahl1.Click += new System.EventHandler(this.zahl1_Click);
            // 
            // zahl2
            // 
            this.zahl2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.zahl2.Location = new System.Drawing.Point(235, 283);
            this.zahl2.Name = "zahl2";
            this.zahl2.Size = new System.Drawing.Size(98, 42);
            this.zahl2.TabIndex = 1;
            this.zahl2.UseVisualStyleBackColor = false;
            this.zahl2.Click += new System.EventHandler(this.zahl2_Click);
            // 
            // zahl3
            // 
            this.zahl3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.zahl3.Location = new System.Drawing.Point(339, 283);
            this.zahl3.Name = "zahl3";
            this.zahl3.Size = new System.Drawing.Size(88, 41);
            this.zahl3.TabIndex = 2;
            this.zahl3.UseVisualStyleBackColor = false;
            this.zahl3.Click += new System.EventHandler(this.zahl3_Click);
            // 
            // zahl4
            // 
            this.zahl4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.zahl4.Location = new System.Drawing.Point(433, 283);
            this.zahl4.Name = "zahl4";
            this.zahl4.Size = new System.Drawing.Size(84, 42);
            this.zahl4.TabIndex = 3;
            this.zahl4.UseVisualStyleBackColor = false;
            this.zahl4.Click += new System.EventHandler(this.zahl4_Click);
            // 
            // zahl5
            // 
            this.zahl5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.zahl5.Location = new System.Drawing.Point(523, 283);
            this.zahl5.Name = "zahl5";
            this.zahl5.Size = new System.Drawing.Size(86, 41);
            this.zahl5.TabIndex = 4;
            this.zahl5.UseVisualStyleBackColor = false;
            this.zahl5.Click += new System.EventHandler(this.zahl5_Click);
            // 
            // zahl6
            // 
            this.zahl6.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.zahl6.Location = new System.Drawing.Point(615, 283);
            this.zahl6.Name = "zahl6";
            this.zahl6.Size = new System.Drawing.Size(91, 41);
            this.zahl6.TabIndex = 5;
            this.zahl6.UseVisualStyleBackColor = false;
            this.zahl6.Click += new System.EventHandler(this.zahl6_Click);
            // 
            // ausloser
            // 
            this.ausloser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ausloser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ausloser.BackgroundImage")));
            this.ausloser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausloser.Location = new System.Drawing.Point(271, 118);
            this.ausloser.Name = "ausloser";
            this.ausloser.Size = new System.Drawing.Size(250, 64);
            this.ausloser.TabIndex = 6;
            this.ausloser.Text = "Lottozahlen auslosen";
            this.ausloser.UseVisualStyleBackColor = false;
            this.ausloser.Click += new System.EventHandler(this.ausloser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ausloser);
            this.Controls.Add(this.zahl6);
            this.Controls.Add(this.zahl5);
            this.Controls.Add(this.zahl4);
            this.Controls.Add(this.zahl3);
            this.Controls.Add(this.zahl2);
            this.Controls.Add(this.zahl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zahl1;
        private System.Windows.Forms.Button zahl2;
        private System.Windows.Forms.Button zahl3;
        private System.Windows.Forms.Button zahl4;
        private System.Windows.Forms.Button zahl5;
        private System.Windows.Forms.Button zahl6;
        private System.Windows.Forms.Button ausloser;
    }
}

