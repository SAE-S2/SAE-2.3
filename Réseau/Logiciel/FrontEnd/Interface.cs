namespace FrontEnd
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
            pnlSaisie.Location = new Point((ClientSize.Width - pnlSaisie.Width) / 2, pnlSaisie.Top);
            lblTitre.Location = new Point((ClientSize.Width - lblTitre.Width) / 2, lblTitre.Top);
            lblIPv4.Location = new Point((pnlSaisie.Width - lblIPv4.Width) / 2, lblIPv4.Top);
            lblMasque.Location = new Point((pnlSaisie.Width - lblMasque.Width) / 2, lblMasque.Top);
            btnValider.Location = new Point((pnlSaisie.Width - btnValider.Width) / 2, btnValider.Top);
        }
    }
}
