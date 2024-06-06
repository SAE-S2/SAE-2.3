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
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Anchor = AnchorStyles.None;
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(282, 25);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(393, 41);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Calculateur de sous-réseau";
            // 
            // Interface
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            Controls.Add(lblTitre);
            Name = "Interface";
            Text = "Form1";
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
    }
}
