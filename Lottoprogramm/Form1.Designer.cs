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
            this.ausloser = new System.Windows.Forms.Button();
            this.zahl1 = new System.Windows.Forms.TextBox();
            this.zahl2 = new System.Windows.Forms.TextBox();
            this.zahl3 = new System.Windows.Forms.TextBox();
            this.zahl4 = new System.Windows.Forms.TextBox();
            this.zahl5 = new System.Windows.Forms.TextBox();
            this.zahl6 = new System.Windows.Forms.TextBox();
            this.eingabe_zahl6 = new System.Windows.Forms.TextBox();
            this.eingabe_zahl5 = new System.Windows.Forms.TextBox();
            this.eingabe_zahl4 = new System.Windows.Forms.TextBox();
            this.eingabe_zahl3 = new System.Windows.Forms.TextBox();
            this.eingabe_zahl2 = new System.Windows.Forms.TextBox();
            this.eingabe_zahl1 = new System.Windows.Forms.TextBox();
            this.deintip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ausloser
            // 
            this.ausloser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ausloser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ausloser.BackgroundImage")));
            this.ausloser.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ausloser.Location = new System.Drawing.Point(271, 50);
            this.ausloser.Name = "ausloser";
            this.ausloser.Size = new System.Drawing.Size(250, 74);
            this.ausloser.TabIndex = 6;
            this.ausloser.Text = "Lottozahlen auslosen";
            this.ausloser.UseVisualStyleBackColor = false;
            this.ausloser.Click += new System.EventHandler(this.ausloser_Click);
            // 
            // zahl1
            // 
            this.zahl1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zahl1.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zahl1.Location = new System.Drawing.Point(119, 188);
            this.zahl1.Name = "zahl1";
            this.zahl1.ReadOnly = true;
            this.zahl1.Size = new System.Drawing.Size(80, 31);
            this.zahl1.TabIndex = 7;
            this.zahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zahl1.TextChanged += new System.EventHandler(this.zahl1_TextChanged);
            // 
            // zahl2
            // 
            this.zahl2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zahl2.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zahl2.Location = new System.Drawing.Point(214, 188);
            this.zahl2.Name = "zahl2";
            this.zahl2.ReadOnly = true;
            this.zahl2.Size = new System.Drawing.Size(80, 31);
            this.zahl2.TabIndex = 8;
            this.zahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zahl2.TextChanged += new System.EventHandler(this.zahl2_TextChanged);
            // 
            // zahl3
            // 
            this.zahl3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zahl3.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zahl3.Location = new System.Drawing.Point(307, 188);
            this.zahl3.Name = "zahl3";
            this.zahl3.ReadOnly = true;
            this.zahl3.Size = new System.Drawing.Size(80, 31);
            this.zahl3.TabIndex = 9;
            this.zahl3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zahl3.TextChanged += new System.EventHandler(this.zahl3_TextChanged);
            // 
            // zahl4
            // 
            this.zahl4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zahl4.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl4.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zahl4.Location = new System.Drawing.Point(399, 188);
            this.zahl4.Name = "zahl4";
            this.zahl4.ReadOnly = true;
            this.zahl4.Size = new System.Drawing.Size(80, 31);
            this.zahl4.TabIndex = 10;
            this.zahl4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zahl4.TextChanged += new System.EventHandler(this.zahl4_TextChanged);
            // 
            // zahl5
            // 
            this.zahl5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zahl5.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl5.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zahl5.Location = new System.Drawing.Point(488, 188);
            this.zahl5.Name = "zahl5";
            this.zahl5.ReadOnly = true;
            this.zahl5.Size = new System.Drawing.Size(80, 31);
            this.zahl5.TabIndex = 11;
            this.zahl5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zahl5.TextChanged += new System.EventHandler(this.zahl5_TextChanged);
            // 
            // zahl6
            // 
            this.zahl6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.zahl6.Cursor = System.Windows.Forms.Cursors.No;
            this.zahl6.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zahl6.Location = new System.Drawing.Point(581, 188);
            this.zahl6.Name = "zahl6";
            this.zahl6.ReadOnly = true;
            this.zahl6.Size = new System.Drawing.Size(80, 31);
            this.zahl6.TabIndex = 12;
            this.zahl6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.zahl6.TextChanged += new System.EventHandler(this.zahl6_TextChanged);
            // 
            // eingabe_zahl6
            // 
            this.eingabe_zahl6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eingabe_zahl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eingabe_zahl6.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingabe_zahl6.Location = new System.Drawing.Point(581, 382);
            this.eingabe_zahl6.Name = "eingabe_zahl6";
            this.eingabe_zahl6.Size = new System.Drawing.Size(80, 31);
            this.eingabe_zahl6.TabIndex = 18;
            this.eingabe_zahl6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eingabe_zahl6.TextChanged += new System.EventHandler(this.eingabe_zahl6_TextChanged);
            // 
            // eingabe_zahl5
            // 
            this.eingabe_zahl5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eingabe_zahl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eingabe_zahl5.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingabe_zahl5.Location = new System.Drawing.Point(488, 382);
            this.eingabe_zahl5.Name = "eingabe_zahl5";
            this.eingabe_zahl5.Size = new System.Drawing.Size(80, 31);
            this.eingabe_zahl5.TabIndex = 17;
            this.eingabe_zahl5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eingabe_zahl5.TextChanged += new System.EventHandler(this.eingabe_zahl5_TextChanged);
            // 
            // eingabe_zahl4
            // 
            this.eingabe_zahl4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eingabe_zahl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eingabe_zahl4.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingabe_zahl4.Location = new System.Drawing.Point(399, 382);
            this.eingabe_zahl4.Name = "eingabe_zahl4";
            this.eingabe_zahl4.Size = new System.Drawing.Size(80, 31);
            this.eingabe_zahl4.TabIndex = 16;
            this.eingabe_zahl4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eingabe_zahl4.TextChanged += new System.EventHandler(this.eingabe_zahl4_TextChanged);
            // 
            // eingabe_zahl3
            // 
            this.eingabe_zahl3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eingabe_zahl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eingabe_zahl3.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingabe_zahl3.Location = new System.Drawing.Point(307, 382);
            this.eingabe_zahl3.Name = "eingabe_zahl3";
            this.eingabe_zahl3.Size = new System.Drawing.Size(80, 31);
            this.eingabe_zahl3.TabIndex = 15;
            this.eingabe_zahl3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eingabe_zahl3.TextChanged += new System.EventHandler(this.eingabe_zahl3_TextChanged);
            // 
            // eingabe_zahl2
            // 
            this.eingabe_zahl2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eingabe_zahl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eingabe_zahl2.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingabe_zahl2.Location = new System.Drawing.Point(214, 382);
            this.eingabe_zahl2.Name = "eingabe_zahl2";
            this.eingabe_zahl2.Size = new System.Drawing.Size(80, 31);
            this.eingabe_zahl2.TabIndex = 14;
            this.eingabe_zahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eingabe_zahl2.TextChanged += new System.EventHandler(this.eingabe_zahl2_TextChanged);
            // 
            // eingabe_zahl1
            // 
            this.eingabe_zahl1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.eingabe_zahl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eingabe_zahl1.Font = new System.Drawing.Font("Arial Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eingabe_zahl1.Location = new System.Drawing.Point(119, 382);
            this.eingabe_zahl1.Name = "eingabe_zahl1";
            this.eingabe_zahl1.Size = new System.Drawing.Size(80, 31);
            this.eingabe_zahl1.TabIndex = 13;
            this.eingabe_zahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eingabe_zahl1.TextChanged += new System.EventHandler(this.eingabe_zahl1_TextChanged);
            // 
            // deintip
            // 
            this.deintip.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.deintip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deintip.BackgroundImage")));
            this.deintip.Cursor = System.Windows.Forms.Cursors.No;
            this.deintip.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deintip.Location = new System.Drawing.Point(271, 288);
            this.deintip.Name = "deintip";
            this.deintip.Size = new System.Drawing.Size(250, 74);
            this.deintip.TabIndex = 19;
            this.deintip.Text = "Dein Tip:";
            this.deintip.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.deintip);
            this.Controls.Add(this.eingabe_zahl6);
            this.Controls.Add(this.eingabe_zahl5);
            this.Controls.Add(this.eingabe_zahl4);
            this.Controls.Add(this.eingabe_zahl3);
            this.Controls.Add(this.eingabe_zahl2);
            this.Controls.Add(this.eingabe_zahl1);
            this.Controls.Add(this.zahl6);
            this.Controls.Add(this.zahl5);
            this.Controls.Add(this.zahl4);
            this.Controls.Add(this.zahl3);
            this.Controls.Add(this.zahl2);
            this.Controls.Add(this.zahl1);
            this.Controls.Add(this.ausloser);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lotto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ausloser;
        private System.Windows.Forms.TextBox zahl1;
        private System.Windows.Forms.TextBox zahl2;
        private System.Windows.Forms.TextBox zahl3;
        private System.Windows.Forms.TextBox zahl4;
        private System.Windows.Forms.TextBox zahl5;
        private System.Windows.Forms.TextBox zahl6;
        private System.Windows.Forms.TextBox eingabe_zahl6;
        private System.Windows.Forms.TextBox eingabe_zahl5;
        private System.Windows.Forms.TextBox eingabe_zahl4;
        private System.Windows.Forms.TextBox eingabe_zahl3;
        private System.Windows.Forms.TextBox eingabe_zahl2;
        private System.Windows.Forms.TextBox eingabe_zahl1;
        private System.Windows.Forms.Button deintip;
    }
}

