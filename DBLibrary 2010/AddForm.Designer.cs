namespace WindowsFormsApplication1
{
    partial class AddForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newValuesGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.newValuesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(459, 275);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(124, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Aggiungi";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Aggiungi qui i nuovi valori";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newValuesGrid
            // 
            this.newValuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newValuesGrid.Location = new System.Drawing.Point(12, 259);
            this.newValuesGrid.Name = "newValuesGrid";
            this.newValuesGrid.Size = new System.Drawing.Size(438, 39);
            this.newValuesGrid.TabIndex = 9;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 310);
            this.Controls.Add(this.newValuesGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddBtn);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Controls.SetChildIndex(this.ColumnsList, 0);
            this.Controls.SetChildIndex(this.TableComboBox, 0);
            this.Controls.SetChildIndex(this.AddBtn, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.newValuesGrid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.newValuesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView newValuesGrid;
    }
}