namespace Projekt_v2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tekstDlaPizzy = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.MnieSzukaj = new System.Windows.Forms.TextBox();
            this.SzukajSkladnik = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj przykładowe pizze";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(146, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sprawdź wszystkie pizze";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 11);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "Dodaj pizze";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tekstDlaPizzy
            // 
            this.tekstDlaPizzy.Location = new System.Drawing.Point(9, 68);
            this.tekstDlaPizzy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tekstDlaPizzy.Name = "tekstDlaPizzy";
            this.tekstDlaPizzy.ReadOnly = true;
            this.tekstDlaPizzy.Size = new System.Drawing.Size(410, 106);
            this.tekstDlaPizzy.TabIndex = 3;
            this.tekstDlaPizzy.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 184);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 34);
            this.button4.TabIndex = 4;
            this.button4.Text = "Wyszukaj po nazwie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MnieSzukaj
            // 
            this.MnieSzukaj.Location = new System.Drawing.Point(146, 192);
            this.MnieSzukaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MnieSzukaj.Name = "MnieSzukaj";
            this.MnieSzukaj.Size = new System.Drawing.Size(273, 20);
            this.MnieSzukaj.TabIndex = 5;
            // 
            // SzukajSkladnik
            // 
            this.SzukajSkladnik.Location = new System.Drawing.Point(146, 250);
            this.SzukajSkladnik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SzukajSkladnik.Name = "SzukajSkladnik";
            this.SzukajSkladnik.Size = new System.Drawing.Size(273, 20);
            this.SzukajSkladnik.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 242);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "Wyszukaj po składniku";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(332, 11);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 54);
            this.button6.TabIndex = 8;
            this.button6.Text = "Usuń pizze";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(448, 337);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.SzukajSkladnik);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.MnieSzukaj);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tekstDlaPizzy);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox tekstDlaPizzy;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox MnieSzukaj;
        private System.Windows.Forms.TextBox SzukajSkladnik;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

