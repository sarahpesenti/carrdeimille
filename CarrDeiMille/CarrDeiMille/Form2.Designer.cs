namespace CarrDeiMille
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlVeicoli = new Panel();
            dgv = new DataGridView();
            colMarca = new DataGridViewTextBoxColumn();
            colModello = new DataGridViewTextBoxColumn();
            colColore = new DataGridViewTextBoxColumn();
            colTarga = new DataGridViewTextBoxColumn();
            label4 = new Label();
            pnlVeicoli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // pnlVeicoli
            // 
            pnlVeicoli.BackColor = SystemColors.GradientInactiveCaption;
            pnlVeicoli.Controls.Add(dgv);
            pnlVeicoli.Controls.Add(label4);
            pnlVeicoli.Location = new Point(12, 12);
            pnlVeicoli.Name = "pnlVeicoli";
            pnlVeicoli.Size = new Size(540, 397);
            pnlVeicoli.TabIndex = 0;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgv.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgv.BorderStyle = BorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colMarca, colModello, colColore, colTarga });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle4;
            dgv.Enabled = false;
            dgv.GridColor = SystemColors.GradientInactiveCaption;
            dgv.Location = new Point(19, 55);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(471, 164);
            dgv.TabIndex = 2;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "MARCA";
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            colMarca.Width = 93;
            // 
            // colModello
            // 
            colModello.HeaderText = "MODELLO";
            colModello.Name = "colModello";
            colModello.ReadOnly = true;
            colModello.Width = 114;
            // 
            // colColore
            // 
            colColore.HeaderText = "COLORE";
            colColore.Name = "colColore";
            colColore.ReadOnly = true;
            colColore.Width = 98;
            // 
            // colTarga
            // 
            colTarga.HeaderText = "TARGA";
            colTarga.Name = "colTarga";
            colTarga.ReadOnly = true;
            colTarga.Width = 87;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(268, 29);
            label4.TabIndex = 1;
            label4.Text = "Elenco veicoli in database";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlVeicoli);
            Name = "Form2";
            Text = "Form2";
            pnlVeicoli.ResumeLayout(false);
            pnlVeicoli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label4;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colModello;
        private DataGridViewTextBoxColumn colColore;
        private DataGridViewTextBoxColumn colTarga;
        public Panel pnlVeicoli;
    }
}