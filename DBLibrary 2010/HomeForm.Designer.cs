namespace DBLibrary
{
    partial class HomeForm
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
            this.VisualizzaBtn = new System.Windows.Forms.Button();
            this.AggiornaBtn = new System.Windows.Forms.Button();
            this.EliminaBtn = new System.Windows.Forms.Button();
            this.AggiungiBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VisualizzaBtn
            // 
            this.VisualizzaBtn.Location = new System.Drawing.Point(12, 72);
            this.VisualizzaBtn.Name = "VisualizzaBtn";
            this.VisualizzaBtn.Size = new System.Drawing.Size(75, 23);
            this.VisualizzaBtn.TabIndex = 0;
            this.VisualizzaBtn.Text = "Visualizza";
            this.VisualizzaBtn.UseVisualStyleBackColor = true;
            this.VisualizzaBtn.Click += new System.EventHandler(this.VisualizzaBtn_Click);
            // 
            // AggiornaBtn
            // 
            this.AggiornaBtn.Location = new System.Drawing.Point(115, 72);
            this.AggiornaBtn.Name = "AggiornaBtn";
            this.AggiornaBtn.Size = new System.Drawing.Size(75, 23);
            this.AggiornaBtn.TabIndex = 1;
            this.AggiornaBtn.Text = "Aggiorna";
            this.AggiornaBtn.UseVisualStyleBackColor = true;
            this.AggiornaBtn.Click += new System.EventHandler(this.AggiornaBtn_Click);
            // 
            // EliminaBtn
            // 
            this.EliminaBtn.Location = new System.Drawing.Point(12, 137);
            this.EliminaBtn.Name = "EliminaBtn";
            this.EliminaBtn.Size = new System.Drawing.Size(75, 23);
            this.EliminaBtn.TabIndex = 2;
            this.EliminaBtn.Text = "Elimina";
            this.EliminaBtn.UseVisualStyleBackColor = true;
            this.EliminaBtn.Click += new System.EventHandler(this.EliminaBtn_Click);
            // 
            // AggiungiBtn
            // 
            this.AggiungiBtn.Location = new System.Drawing.Point(115, 137);
            this.AggiungiBtn.Name = "AggiungiBtn";
            this.AggiungiBtn.Size = new System.Drawing.Size(75, 23);
            this.AggiungiBtn.TabIndex = 3;
            this.AggiungiBtn.Text = "Aggiungi";
            this.AggiungiBtn.UseVisualStyleBackColor = true;
            this.AggiungiBtn.Click += new System.EventHandler(this.AggiungiBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Che Cosa Vuoi Fare?";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AggiungiBtn);
            this.Controls.Add(this.EliminaBtn);
            this.Controls.Add(this.AggiornaBtn);
            this.Controls.Add(this.VisualizzaBtn);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VisualizzaBtn;
        private System.Windows.Forms.Button AggiornaBtn;
        private System.Windows.Forms.Button EliminaBtn;
        private System.Windows.Forms.Button AggiungiBtn;
        private System.Windows.Forms.Label label1;
    }
}