namespace FrontEnd
{
    partial class Interface
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
            lblTitre = new Label();
            pnlSaisie = new Panel();
            txtBinOctet4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBinOctet3 = new TextBox();
            txtBinOctet2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBinOctet1 = new TextBox();
            txtDecOctet4 = new TextBox();
            lblPoint3 = new Label();
            lblPoint2 = new Label();
            txtDecOctet3 = new TextBox();
            txtDecOctet2 = new TextBox();
            lblPoint1 = new Label();
            lblDecimal = new Label();
            lblIPv4 = new Label();
            txtDecOctet1 = new TextBox();
            pnlSaisie.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Anchor = AnchorStyles.Top;
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(139, 28);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(322, 32);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Calculateur de sous-réseau";
            // 
            // pnlSaisie
            // 
            pnlSaisie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSaisie.BorderStyle = BorderStyle.FixedSingle;
            pnlSaisie.Controls.Add(txtBinOctet4);
            pnlSaisie.Controls.Add(label1);
            pnlSaisie.Controls.Add(label2);
            pnlSaisie.Controls.Add(txtBinOctet3);
            pnlSaisie.Controls.Add(txtBinOctet2);
            pnlSaisie.Controls.Add(label3);
            pnlSaisie.Controls.Add(label4);
            pnlSaisie.Controls.Add(txtBinOctet1);
            pnlSaisie.Controls.Add(txtDecOctet4);
            pnlSaisie.Controls.Add(lblPoint3);
            pnlSaisie.Controls.Add(lblPoint2);
            pnlSaisie.Controls.Add(txtDecOctet3);
            pnlSaisie.Controls.Add(txtDecOctet2);
            pnlSaisie.Controls.Add(lblPoint1);
            pnlSaisie.Controls.Add(lblDecimal);
            pnlSaisie.Controls.Add(lblIPv4);
            pnlSaisie.Controls.Add(txtDecOctet1);
            pnlSaisie.Location = new Point(50, 104);
            pnlSaisie.Name = "pnlSaisie";
            pnlSaisie.Padding = new Padding(26, 0, 26, 0);
            pnlSaisie.Size = new Size(500, 179);
            pnlSaisie.TabIndex = 1;
            // 
            // txtBinOctet4
            // 
            txtBinOctet4.Cursor = Cursors.IBeam;
            txtBinOctet4.Location = new Point(389, 84);
            txtBinOctet4.MaxLength = 8;
            txtBinOctet4.Name = "txtBinOctet4";
            txtBinOctet4.PlaceholderText = "octet n°4";
            txtBinOctet4.Size = new Size(80, 23);
            txtBinOctet4.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(373, 92);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 15;
            label1.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(271, 92);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 14;
            label2.Text = ".";
            // 
            // txtBinOctet3
            // 
            txtBinOctet3.Cursor = Cursors.IBeam;
            txtBinOctet3.Location = new Point(287, 84);
            txtBinOctet3.MaxLength = 8;
            txtBinOctet3.Name = "txtBinOctet3";
            txtBinOctet3.PlaceholderText = "octet n°3";
            txtBinOctet3.Size = new Size(80, 23);
            txtBinOctet3.TabIndex = 13;
            // 
            // txtBinOctet2
            // 
            txtBinOctet2.Cursor = Cursors.IBeam;
            txtBinOctet2.Location = new Point(185, 84);
            txtBinOctet2.MaxLength = 8;
            txtBinOctet2.Name = "txtBinOctet2";
            txtBinOctet2.PlaceholderText = "octet n°2";
            txtBinOctet2.Size = new Size(80, 23);
            txtBinOctet2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 92);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 11;
            label3.Text = ".";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 87);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Binaire :";
            // 
            // txtBinOctet1
            // 
            txtBinOctet1.Cursor = Cursors.IBeam;
            txtBinOctet1.Location = new Point(83, 84);
            txtBinOctet1.MaxLength = 8;
            txtBinOctet1.Name = "txtBinOctet1";
            txtBinOctet1.PlaceholderText = "octet n°1";
            txtBinOctet1.Size = new Size(80, 23);
            txtBinOctet1.TabIndex = 9;
            // 
            // txtDecOctet4
            // 
            txtDecOctet4.Cursor = Cursors.IBeam;
            txtDecOctet4.Location = new Point(389, 46);
            txtDecOctet4.MaxLength = 3;
            txtDecOctet4.Name = "txtDecOctet4";
            txtDecOctet4.PlaceholderText = "octet n°4";
            txtDecOctet4.Size = new Size(80, 23);
            txtDecOctet4.TabIndex = 8;
            // 
            // lblPoint3
            // 
            lblPoint3.AutoSize = true;
            lblPoint3.Location = new Point(373, 54);
            lblPoint3.Name = "lblPoint3";
            lblPoint3.Size = new Size(10, 15);
            lblPoint3.TabIndex = 7;
            lblPoint3.Text = ".";
            // 
            // lblPoint2
            // 
            lblPoint2.AutoSize = true;
            lblPoint2.Location = new Point(271, 54);
            lblPoint2.Name = "lblPoint2";
            lblPoint2.Size = new Size(10, 15);
            lblPoint2.TabIndex = 6;
            lblPoint2.Text = ".";
            // 
            // txtDecOctet3
            // 
            txtDecOctet3.Cursor = Cursors.IBeam;
            txtDecOctet3.Location = new Point(287, 46);
            txtDecOctet3.MaxLength = 3;
            txtDecOctet3.Name = "txtDecOctet3";
            txtDecOctet3.PlaceholderText = "octet n°3";
            txtDecOctet3.Size = new Size(80, 23);
            txtDecOctet3.TabIndex = 5;
            // 
            // txtDecOctet2
            // 
            txtDecOctet2.Cursor = Cursors.IBeam;
            txtDecOctet2.Location = new Point(185, 46);
            txtDecOctet2.MaxLength = 3;
            txtDecOctet2.Name = "txtDecOctet2";
            txtDecOctet2.PlaceholderText = "octet n°2";
            txtDecOctet2.Size = new Size(80, 23);
            txtDecOctet2.TabIndex = 4;
            // 
            // lblPoint1
            // 
            lblPoint1.AutoSize = true;
            lblPoint1.Location = new Point(169, 54);
            lblPoint1.Name = "lblPoint1";
            lblPoint1.Size = new Size(10, 15);
            lblPoint1.TabIndex = 3;
            lblPoint1.Text = ".";
            // 
            // lblDecimal
            // 
            lblDecimal.AutoSize = true;
            lblDecimal.Location = new Point(21, 49);
            lblDecimal.Name = "lblDecimal";
            lblDecimal.Size = new Size(56, 15);
            lblDecimal.TabIndex = 2;
            lblDecimal.Text = "Décimal :";
            // 
            // lblIPv4
            // 
            lblIPv4.Anchor = AnchorStyles.Top;
            lblIPv4.AutoSize = true;
            lblIPv4.Location = new Point(222, 10);
            lblIPv4.Name = "lblIPv4";
            lblIPv4.Size = new Size(73, 15);
            lblIPv4.TabIndex = 1;
            lblIPv4.Text = "Adresse IPv4";
            // 
            // txtDecOctet1
            // 
            txtDecOctet1.Cursor = Cursors.IBeam;
            txtDecOctet1.Location = new Point(83, 46);
            txtDecOctet1.MaxLength = 3;
            txtDecOctet1.Name = "txtDecOctet1";
            txtDecOctet1.PlaceholderText = "octet n°1";
            txtDecOctet1.Size = new Size(80, 23);
            txtDecOctet1.TabIndex = 0;
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 535);
            Controls.Add(pnlSaisie);
            Controls.Add(lblTitre);
            MinimumSize = new Size(600, 450);
            Name = "Interface";
            Padding = new Padding(50, 10, 50, 10);
            ShowIcon = false;
            Text = "Calculateur de sous-réseau";
            pnlSaisie.ResumeLayout(false);
            pnlSaisie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Panel pnlSaisie;
        private TextBox txtDecOctet1;
        private Label lblIPv4;
        private Label lblPoint1;
        private Label lblDecimal;
        private TextBox txtDecOctet2;
        private TextBox txtDecOctet4;
        private Label lblPoint3;
        private Label lblPoint2;
        private TextBox txtDecOctet3;
        private TextBox txtBinOctet4;
        private Label label1;
        private Label label2;
        private TextBox txtBinOctet3;
        private TextBox txtBinOctet2;
        private Label label3;
        private Label label4;
        private TextBox txtBinOctet1;
    }
}
