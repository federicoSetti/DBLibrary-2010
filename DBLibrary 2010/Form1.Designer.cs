namespace DBLibrary
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.DisplayGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ColumnsList = new System.Windows.Forms.CheckedListBox();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayGrid
            // 
            this.DisplayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayGrid.Location = new System.Drawing.Point(12, 12);
            this.DisplayGrid.Name = "DisplayGrid";
            this.DisplayGrid.Size = new System.Drawing.Size(438, 216);
            this.DisplayGrid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleziona Colonne";
            // 
            // ColumnsList
            // 
            this.ColumnsList.FormattingEnabled = true;
            this.ColumnsList.Location = new System.Drawing.Point(459, 52);
            this.ColumnsList.Name = "ColumnsList";
            this.ColumnsList.Size = new System.Drawing.Size(114, 94);
            this.ColumnsList.TabIndex = 4;
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Location = new System.Drawing.Point(456, 12);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(127, 21);
            this.TableComboBox.TabIndex = 6;
            this.TableComboBox.Tag = "";
            this.TableComboBox.Text = "Seleziona La Tabella";
            this.TableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 242);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ColumnsList);
            this.Controls.Add(this.DisplayGrid);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DisplayGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ColumnsList;
        private System.Windows.Forms.ComboBox TableComboBox;
    }
}

