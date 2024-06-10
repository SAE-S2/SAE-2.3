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
            if (!UpdateOctetFromDecimal(octet)) //Si erreur, réinitialiser
            {
                ResetOctetText(octet);
            }
        }

        private void txtIPBinOctet_Leave(object sender, EventArgs e)
        {
            TextBox octet = (TextBox)sender;
            if (!UpdateOctetFromBinary(octet)) //Si erreur, réinitialiser
            {
                ResetOctetText(octet);
            }
        }

        private bool UpdateOctetFromDecimal(TextBox octet)
        {
            try
            {
                uint valDec = Convert.ToUInt32(octet.Text);
                if (valDec > 255)
                {
                    throw new ArgumentOutOfRangeException();
                }
                string valBin = Convert.ToString(valDec, 2).PadLeft(8, '0');

                switch (octet.Tag)
                {
                    case "1":
                        reseau.adrOctet1 = valDec;
                        reseau.adrBinaire1 = valBin;
                        txtIPBinOctet1.Text = valBin;
                        break;
                    case "2":
                        reseau.adrOctet2 = valDec;
                        reseau.adrBinaire2 = valBin;
                        txtIPBinOctet2.Text = valBin;
                        break;
                    case "3":
                        reseau.adrOctet3 = valDec;
                        reseau.adrBinaire3 = valBin;
                        txtIPBinOctet3.Text = valBin;
                        break;
                    case "4":
                        reseau.adrOctet4 = valDec;
                        reseau.adrBinaire4 = valBin;
                        txtIPBinOctet4.Text = valBin;
                        break;
                    default:
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool UpdateOctetFromBinary(TextBox octet)
        {
            try
            {
                if (octet.Text != "")
                {
                    octet.Text = octet.Text.PadLeft(8, '0');
                }
                string valBin = octet.Text;
                uint valDec = Convert.ToUInt32(valBin, 2);
                if (valDec > 255)
                {
                    throw new ArgumentOutOfRangeException();
                }

                switch (octet.Tag)
                {
                    case "1":
                        reseau.adrBinaire1 = valBin;
                        reseau.adrOctet1 = valDec;
                        txtIPDecOctet1.Text = valDec.ToString();
                        break;
                    case "2":
                        reseau.adrBinaire2 = valBin;
                        reseau.adrOctet2 = valDec;
                        txtIPDecOctet2.Text = valDec.ToString();
                        break;
                    case "3":
                        reseau.adrBinaire3 = valBin;
                        reseau.adrOctet3 = valDec;
                        txtIPDecOctet3.Text = valDec.ToString();
                        break;
                    case "4":
                        reseau.adrBinaire4 = valBin;
                        reseau.adrOctet4 = valDec;
                        txtIPDecOctet4.Text = valDec.ToString();
                        break;
                    default:
                        return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void ResetOctetText(TextBox octet)
        {
            octet.Text = "";
            switch (octet.Tag)
            {
                case "1":
                    if (reseau.adrBinaire1 == null)
                    {
                        txtIPDecOctet1.Text = "";
                        txtIPBinOctet1.Text = "";
                    }
                    else
                    {
                        txtIPDecOctet1.Text = reseau.adrOctet1.ToString();
                        txtIPBinOctet1.Text = reseau.adrBinaire1;
                    }
                    break;
                case "2":
                    if (reseau.adrBinaire2 == null)
                    {
                        txtIPDecOctet2.Text = "";
                        txtIPBinOctet2.Text = "";
                    }
                    else
                    {
                        txtIPDecOctet2.Text = reseau.adrOctet2.ToString();
                        txtIPBinOctet2.Text = reseau.adrBinaire2;
                    }
                    break;
                case "3":
                    if (reseau.adrBinaire3 == null)
                    {
                        txtIPDecOctet3.Text = "";
                        txtIPBinOctet3.Text = "";
                    }
                    else
                    {
                        txtIPDecOctet3.Text = reseau.adrOctet3.ToString();
                        txtIPBinOctet3.Text = reseau.adrBinaire3;
                    }
                    break;
                case "4":
                    if (reseau.adrBinaire4 == null)
                    {
                        txtIPDecOctet4.Text = "";
                        txtIPBinOctet4.Text = "";
                    }
                    else
                    {
                        txtIPDecOctet4.Text = reseau.adrOctet4.ToString();
                        txtIPBinOctet4.Text = reseau.adrBinaire4;
                    }
                    break;
                default:
                    break;
            }
        }

    }
}
