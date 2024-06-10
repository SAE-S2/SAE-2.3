namespace FrontEnd
{
    public partial class Interface : Form
    {
        BackEnd.Reseau reseau;
        public Interface()
        {
            InitializeComponent();

            reseau = new BackEnd.Reseau();

            //Centrages de certains éléments
            pnlSaisie.Location = new Point((ClientSize.Width - pnlSaisie.Width) / 2, pnlSaisie.Top);
            pnlResultat.Location = new Point((ClientSize.Width - pnlResultat.Width) / 2, pnlResultat.Top);
            lblTitre.Location = new Point((ClientSize.Width - lblTitre.Width) / 2, lblTitre.Top);
            lblIPv4.Location = new Point((pnlSaisie.Width - lblIPv4.Width) / 2, lblIPv4.Top);
            lblMasque.Location = new Point((pnlSaisie.Width - lblMasque.Width) / 2, lblMasque.Top);
            btnValider.Location = new Point((pnlSaisie.Width - btnValider.Width) / 2, btnValider.Top);

            this.Height = pnlSaisie.Height + this.AutoScrollMargin.Height;
        }

        private void txtIPDecOctet_Leave(object sender, EventArgs e)
        {
            TextBox octet = (TextBox)sender;
            try
            {
                uint val = Convert.ToUInt32(octet.Text);
                if (val < 0 || val > 255)
                {
                    throw new ArgumentOutOfRangeException();
                }

                switch (octet.Tag)
                {
                    case 1:
                        reseau.adrOctet1 = val;
                        break;
                    case 2:
                        reseau.adrOctet2 = val;
                        break;
                    case 3:
                        reseau.adrOctet3 = val;
                        break;
                    case 4:
                        reseau.adrOctet4 = val;
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                //Réinitialise le texte si une erreur se produit
                octet.Text = "";
                return;
            }
        }

        private void txtIPBinOctet_Leave(object sender, EventArgs e)
        {

        }
    }
}
