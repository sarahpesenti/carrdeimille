namespace CarrDeiMille
{
    partial class Nuovo
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
            btnAggiungi = new Button();
            txtColore = new TextBox();
            label7 = new Label();
            txtModello = new TextBox();
            label8 = new Label();
            txtMarca = new TextBox();
            label6 = new Label();
            txtTarga = new TextBox();
            label5 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAggiungi
            // 
            btnAggiungi.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAggiungi.Location = new Point(150, 252);
            btnAggiungi.Margin = new Padding(2);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(137, 50);
            btnAggiungi.TabIndex = 9;
            btnAggiungi.Text = "AGGIUNGI";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // txtColore
            // 
            txtColore.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtColore.Location = new Point(184, 189);
            txtColore.Margin = new Padding(2);
            txtColore.Name = "txtColore";
            txtColore.Size = new Size(176, 32);
            txtColore.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(76, 193);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 7;
            label7.Text = "COLORE";
            // 
            // txtModello
            // 
            txtModello.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModello.Location = new Point(184, 151);
            txtModello.Margin = new Padding(2);
            txtModello.Name = "txtModello";
            txtModello.Size = new Size(176, 32);
            txtModello.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(76, 155);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 5;
            label8.Text = "MODELLO";
            // 
            // txtMarca
            // 
            txtMarca.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtMarca.Location = new Point(184, 112);
            txtMarca.Margin = new Padding(2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(176, 32);
            txtMarca.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(76, 116);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 3;
            label6.Text = "MARCA";
            // 
            // txtTarga
            // 
            txtTarga.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtTarga.Location = new Point(184, 74);
            txtTarga.Margin = new Padding(2);
            txtTarga.Name = "txtTarga";
            txtTarga.Size = new Size(176, 32);
            txtTarga.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(76, 78);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 1;
            label5.Text = "TARGA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 9);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(276, 29);
            label4.TabIndex = 0;
            label4.Text = "Inserimento nuovo veicolo";
            // 
            // Nuovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(535, 358);
            Controls.Add(txtColore);
            Controls.Add(label7);
            Controls.Add(btnAggiungi);
            Controls.Add(txtModello);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txtMarca);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtTarga);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Nuovo";
            Text = "Nuovo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlAggiungi;
        private Button btnAggiungi;
        private TextBox txtColore;
        private Label label7;
        private TextBox txtModello;
        private Label label8;
        private TextBox txtMarca;
        private Label label6;
        private TextBox txtTarga;
        private Label label5;
        private Label label4;
    }
}