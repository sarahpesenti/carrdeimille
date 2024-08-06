namespace CarrDeiMille
{
    partial class Veicoli
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgv = new DataGridView();
            colMarca = new DataGridViewTextBoxColumn();
            colModello = new DataGridViewTextBoxColumn();
            colColore = new DataGridViewTextBoxColumn();
            colTarga = new DataGridViewTextBoxColumn();
            colOre = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { colMarca, colModello, colColore, colTarga, colOre });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle2;
            dgv.Enabled = false;
            dgv.GridColor = SystemColors.GradientInactiveCaption;
            dgv.Location = new Point(22, 56);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(518, 164);
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
            // colOre
            // 
            colOre.HeaderText = "ORE";
            colOre.Name = "colOre";
            colOre.ReadOnly = true;
            colOre.Width = 67;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(268, 29);
            label1.TabIndex = 1;
            label1.Text = "Elenco veicoli in database";
            // 
            // Veicoli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(579, 358);
            Controls.Add(dgv);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Veicoli";
            Text = "Veicoli";
            Load += Veicoli_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgv;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colModello;
        private DataGridViewTextBoxColumn colColore;
        private DataGridViewTextBoxColumn colTarga;
        private DataGridViewTextBoxColumn colOre;
        private Label label1;
    }
}