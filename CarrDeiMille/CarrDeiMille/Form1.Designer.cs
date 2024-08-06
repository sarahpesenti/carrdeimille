namespace CarrDeiMille
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelside = new Panel();
            btnNuovo = new Button();
            btnVeicoli = new Button();
            btnG = new Button();
            btnM = new Button();
            btnF = new Button();
            btnD = new Button();
            mainpanel = new Panel();
            panelside.SuspendLayout();
            SuspendLayout();
            // 
            // panelside
            // 
            panelside.BackColor = SystemColors.GradientInactiveCaption;
            panelside.Controls.Add(btnNuovo);
            panelside.Controls.Add(btnVeicoli);
            panelside.Controls.Add(btnG);
            panelside.Controls.Add(btnM);
            panelside.Controls.Add(btnF);
            panelside.Controls.Add(btnD);
            panelside.Dock = DockStyle.Left;
            panelside.Location = new Point(0, 0);
            panelside.Name = "panelside";
            panelside.Size = new Size(223, 397);
            panelside.TabIndex = 9;
            // 
            // btnNuovo
            // 
            btnNuovo.BackColor = SystemColors.GradientActiveCaption;
            btnNuovo.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnNuovo.FlatAppearance.BorderSize = 0;
            btnNuovo.FlatStyle = FlatStyle.Flat;
            btnNuovo.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuovo.ForeColor = SystemColors.ControlText;
            btnNuovo.Image = (Image)resources.GetObject("btnNuovo.Image");
            btnNuovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuovo.Location = new Point(28, 327);
            btnNuovo.Name = "btnNuovo";
            btnNuovo.Size = new Size(169, 53);
            btnNuovo.TabIndex = 16;
            btnNuovo.Text = "NUOVO";
            btnNuovo.TextAlign = ContentAlignment.MiddleRight;
            btnNuovo.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNuovo.UseVisualStyleBackColor = false;
            btnNuovo.Click += btnNuovo_Click;
            // 
            // btnVeicoli
            // 
            btnVeicoli.BackColor = SystemColors.GradientActiveCaption;
            btnVeicoli.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnVeicoli.FlatAppearance.BorderSize = 0;
            btnVeicoli.FlatStyle = FlatStyle.Flat;
            btnVeicoli.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnVeicoli.ForeColor = SystemColors.ControlText;
            btnVeicoli.Image = (Image)resources.GetObject("btnVeicoli.Image");
            btnVeicoli.ImageAlign = ContentAlignment.MiddleLeft;
            btnVeicoli.Location = new Point(28, 266);
            btnVeicoli.Name = "btnVeicoli";
            btnVeicoli.Size = new Size(169, 53);
            btnVeicoli.TabIndex = 15;
            btnVeicoli.Text = "VEICOLI";
            btnVeicoli.TextAlign = ContentAlignment.MiddleRight;
            btnVeicoli.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnVeicoli.UseVisualStyleBackColor = false;
            btnVeicoli.Click += btnVeicoli_Click;
            // 
            // btnG
            // 
            btnG.BackColor = SystemColors.GradientActiveCaption;
            btnG.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnG.FlatAppearance.BorderSize = 0;
            btnG.FlatStyle = FlatStyle.Flat;
            btnG.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnG.ForeColor = SystemColors.ControlText;
            btnG.Image = (Image)resources.GetObject("btnG.Image");
            btnG.ImageAlign = ContentAlignment.MiddleLeft;
            btnG.Location = new Point(28, 205);
            btnG.Name = "btnG";
            btnG.Size = new Size(169, 53);
            btnG.TabIndex = 14;
            btnG.Text = "GIACOMO";
            btnG.TextAlign = ContentAlignment.MiddleRight;
            btnG.UseVisualStyleBackColor = false;
            // 
            // btnM
            // 
            btnM.BackColor = SystemColors.GradientActiveCaption;
            btnM.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnM.FlatAppearance.BorderSize = 0;
            btnM.FlatStyle = FlatStyle.Flat;
            btnM.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnM.ForeColor = SystemColors.ControlText;
            btnM.Image = (Image)resources.GetObject("btnM.Image");
            btnM.ImageAlign = ContentAlignment.MiddleLeft;
            btnM.Location = new Point(28, 144);
            btnM.Name = "btnM";
            btnM.Size = new Size(169, 53);
            btnM.TabIndex = 12;
            btnM.Text = "MATTEO";
            btnM.TextAlign = ContentAlignment.MiddleRight;
            btnM.UseVisualStyleBackColor = false;
            // 
            // btnF
            // 
            btnF.BackColor = SystemColors.GradientActiveCaption;
            btnF.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnF.FlatAppearance.BorderSize = 0;
            btnF.FlatStyle = FlatStyle.Flat;
            btnF.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnF.ForeColor = SystemColors.ControlText;
            btnF.Image = (Image)resources.GetObject("btnF.Image");
            btnF.ImageAlign = ContentAlignment.MiddleLeft;
            btnF.Location = new Point(28, 83);
            btnF.Name = "btnF";
            btnF.Size = new Size(169, 53);
            btnF.TabIndex = 11;
            btnF.Text = "FRANCO";
            btnF.TextAlign = ContentAlignment.MiddleRight;
            btnF.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            btnD.BackColor = SystemColors.GradientActiveCaption;
            btnD.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnD.FlatAppearance.BorderSize = 0;
            btnD.FlatStyle = FlatStyle.Flat;
            btnD.Font = new Font("Calibri", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnD.ForeColor = SystemColors.ControlText;
            btnD.Image = (Image)resources.GetObject("btnD.Image");
            btnD.ImageAlign = ContentAlignment.MiddleLeft;
            btnD.Location = new Point(28, 22);
            btnD.Name = "btnD";
            btnD.Size = new Size(169, 53);
            btnD.TabIndex = 10;
            btnD.Text = "DIEGO";
            btnD.TextAlign = ContentAlignment.MiddleRight;
            btnD.UseVisualStyleBackColor = false;
            // 
            // mainpanel
            // 
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(223, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(545, 397);
            mainpanel.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 397);
            Controls.Add(mainpanel);
            Controls.Add(panelside);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            panelside.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelside;
        private Button btnD;
        private Button btnG;
        private Button btnM;
        private Button btnF;
        private Button btnVeicoli;
        private Button btnNuovo;
        private Panel mainpanel;
    }
}