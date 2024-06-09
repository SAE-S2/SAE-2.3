namespace FrontEnd
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            lblTitre.Location = new Point((ClientSize.Width - lblTitre.Width) / 2, lblTitre.Height);
            lblIPv4.Location = new Point((pnlSaisie.Width - lblIPv4.Width) / 2, lblIPv4.Height);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
