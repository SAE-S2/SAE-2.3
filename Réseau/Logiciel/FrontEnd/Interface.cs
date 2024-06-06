namespace FrontEnd
{
    public partial class Interface : Form
    {
        int BaseFormWidth;
        int BaseFormHeight;

        public Interface()
        {
            InitializeComponent();
            BaseFormWidth = this.Size.Width;
            BaseFormHeight = this.Size.Height;

            lblTitre.Location = new Point((ClientSize.Width - lblTitre.Width)/2, lblTitre.Height);
        }

        private void lblTitre_Resize()
        {
            //Modifie la taille de la police afin de rendre le texte responsive

            float BaseFont = 18F;

            float RatioWidth = (float)ClientSize.Width / BaseFormWidth;
            float RatioHeight = (float)ClientSize.Height / BaseFormHeight;
            float ratio = Math.Min(RatioWidth, RatioHeight);

            lblTitre.Font = new Font(lblTitre.Font.FontFamily, ratio*BaseFont, FontStyle.Bold);
            lblTitre.Location = new Point((ClientSize.Width - lblTitre.Width) / 2, lblTitre.Height);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lblTitre_Resize();
        }
    }
}
