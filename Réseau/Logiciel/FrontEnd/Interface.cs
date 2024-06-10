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

        private void txtMasqueDecOctet_Leave(object sender, EventArgs e)
        {
            TextBox octet = (TextBox)sender;
            if (!UpdateOctetFromDecimal(octet)) //Si erreur, réinitialiser
            {
                ResetOctetText(octet);
            }
        }

        private void txtMasqueBinOctet_Leave(object sender, EventArgs e)
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
                    case "IP1":
                        reseau.adrOctet1 = valDec;
                        reseau.adrBinaire1 = valBin;
                        txtIPBinOctet1.Text = valBin;
                        break;
                    case "IP2":
                        reseau.adrOctet2 = valDec;
                        reseau.adrBinaire2 = valBin;
                        txtIPBinOctet2.Text = valBin;
                        break;
                    case "IP3":
                        reseau.adrOctet3 = valDec;
                        reseau.adrBinaire3 = valBin;
                        txtIPBinOctet3.Text = valBin;
                        break;
                    case "IP4":
                        reseau.adrOctet4 = valDec;
                        reseau.adrBinaire4 = valBin;
                        txtIPBinOctet4.Text = valBin;
                        break;
                    case "MSQ1":
                        reseau.msqOctet1 = valDec;
                        reseau.msqBinaire1 = valBin;
                        txtMasqueBinOctet1.Text = valBin;
                        break;
                    case "MSQ2":
                        reseau.msqOctet2 = valDec;
                        reseau.msqBinaire2 = valBin;
                        txtMasqueBinOctet2.Text = valBin;
                        break;
                    case "MSQ3":
                        reseau.msqOctet3 = valDec;
                        reseau.msqBinaire3 = valBin;
                        txtMasqueBinOctet3.Text = valBin;
                        break;
                    case "MSQ4":
                        reseau.msqOctet4 = valDec;
                        reseau.msqBinaire4 = valBin;
                        txtMasqueBinOctet4.Text = valBin;
                        break;
                    default:
                        return false;
                }
                reseau.UpdateAdresse();
                reseau.UpdateMasque();
                if (reseau.VerificationMasque(reseau.masquebin))
                {
                    reseau.CalculerCIDR();
                    txtMasqueCIDR.Text = reseau.CIDR.ToString();
                    btnValider.Enabled = true;
                }
                else
                {
                    reseau.CIDR = 0;
                    txtMasqueCIDR.Text = "";
                    btnValider.Enabled = false;
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
                    case "IP1":
                        reseau.adrBinaire1 = valBin;
                        reseau.adrOctet1 = valDec;
                        txtIPDecOctet1.Text = valDec.ToString();
                        break;
                    case "IP2":
                        reseau.adrBinaire2 = valBin;
                        reseau.adrOctet2 = valDec;
                        txtIPDecOctet2.Text = valDec.ToString();
                        break;
                    case "IP3":
                        reseau.adrBinaire3 = valBin;
                        reseau.adrOctet3 = valDec;
                        txtIPDecOctet3.Text = valDec.ToString();
                        break;
                    case "IP4":
                        reseau.adrBinaire4 = valBin;
                        reseau.adrOctet4 = valDec;
                        txtIPDecOctet4.Text = valDec.ToString();
                        break;
                    case "MSQ1":
                        reseau.msqBinaire1 = valBin;
                        reseau.msqOctet1 = valDec;
                        txtMasqueDecOctet1.Text = valDec.ToString();
                        break;
                    case "MSQ2":
                        reseau.msqBinaire2 = valBin;
                        reseau.msqOctet2 = valDec;
                        txtMasqueDecOctet2.Text = valDec.ToString();
                        break;
                    case "MSQ3":
                        reseau.msqBinaire3 = valBin;
                        reseau.msqOctet3 = valDec;
                        txtMasqueDecOctet3.Text = valDec.ToString();
                        break;
                    case "MSQ4":
                        reseau.msqBinaire4 = valBin;
                        reseau.msqOctet4 = valDec;
                        txtMasqueDecOctet4.Text = valDec.ToString();
                        break;
                    default:
                        return false;
                }
                reseau.UpdateAdresse();
                reseau.UpdateMasque();
                if (reseau.VerificationMasque(reseau.masquebin))
                {
                    reseau.CalculerCIDR();
                    txtMasqueCIDR.Text = reseau.CIDR.ToString();
                    btnValider.Enabled = true;
                }
                else
                {
                    btnValider.Enabled = false;
                    reseau.CIDR = 0;
                    txtMasqueCIDR.Text = "";
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
                case "IP1":
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
                case "IP2":
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
                case "IP3":
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
                case "IP4":
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
                case "MSQ1":
                    if (reseau.msqBinaire1 == null)
                    {
                        txtMasqueDecOctet1.Text = "";
                        txtMasqueBinOctet1.Text = "";
                    }
                    else
                    {
                        txtMasqueDecOctet1.Text = reseau.msqOctet1.ToString();
                        txtMasqueBinOctet1.Text = reseau.msqBinaire1;
                    }
                    break;
                case "MSQ2":
                    if (reseau.msqBinaire2 == null)
                    {
                        txtMasqueDecOctet2.Text = "";
                        txtMasqueBinOctet2.Text = "";
                    }
                    else
                    {
                        txtMasqueDecOctet2.Text = reseau.msqOctet2.ToString();
                        txtMasqueBinOctet2.Text = reseau.msqBinaire2;
                    }
                    break;
                case "MSQ3":
                    if (reseau.msqBinaire3 == null)
                    {
                        txtMasqueDecOctet3.Text = "";
                        txtMasqueBinOctet3.Text = "";
                    }
                    else
                    {
                        txtMasqueDecOctet3.Text = reseau.msqOctet3.ToString();
                        txtMasqueBinOctet3.Text = reseau.msqBinaire3;
                    }
                    break;
                case "MSQ4":
                    if (reseau.msqBinaire4 == null)
                    {
                        txtMasqueDecOctet4.Text = "";
                        txtMasqueBinOctet4.Text = "";
                    }
                    else
                    {
                        txtMasqueDecOctet4.Text = reseau.msqOctet4.ToString();
                        txtMasqueBinOctet4.Text = reseau.msqBinaire4;
                    }
                    break;
                case "CIDR":
                    if (reseau.CIDR == 0)
                    {
                        txtMasqueCIDR.Text = "";
                        txtMasqueDecOctet1.Text = "";
                        txtMasqueBinOctet1.Text = "";
                        txtMasqueDecOctet2.Text = "";
                        txtMasqueBinOctet2.Text = "";
                        txtMasqueDecOctet3.Text = "";
                        txtMasqueBinOctet3.Text = "";
                        txtMasqueDecOctet4.Text = "";
                        txtMasqueBinOctet4.Text = "";
                    }
                    else
                    {
                        txtMasqueCIDR.Text = reseau.CIDR.ToString();
                        txtMasqueDecOctet1.Text = reseau.msqOctet1.ToString();
                        txtMasqueBinOctet1.Text = reseau.msqBinaire1;
                        txtMasqueDecOctet2.Text = reseau.msqOctet2.ToString();
                        txtMasqueBinOctet2.Text = reseau.msqBinaire2;
                        txtMasqueDecOctet3.Text = reseau.msqOctet3.ToString();
                        txtMasqueBinOctet3.Text = reseau.msqBinaire3;
                        txtMasqueDecOctet4.Text = reseau.msqOctet4.ToString();
                        txtMasqueBinOctet4.Text = reseau.msqBinaire4;
                    }
                    break;
                default:
                    break;
            }
        }

        private void txtMasqueCIDR_Leave(object sender, EventArgs e)
        {
            TextBox cidr = (TextBox)sender;
            try
            {
                uint val = Convert.ToUInt32(cidr.Text);
                if (val > 32)
                {
                    throw new ArgumentOutOfRangeException();
                }

                reseau.CIDR = val;
                reseau.ConversionCIDR(val);
                reseau.UpdateMasque();
                txtMasqueBinOctet1.Text = reseau.msqBinaire1;
                txtMasqueBinOctet2.Text = reseau.msqBinaire2;
                txtMasqueBinOctet3.Text = reseau.msqBinaire3;
                txtMasqueBinOctet4.Text = reseau.msqBinaire4;
                txtMasqueDecOctet1.Text = reseau.msqOctet1.ToString();
                txtMasqueDecOctet2.Text = reseau.msqOctet2.ToString();
                txtMasqueDecOctet3.Text = reseau.msqOctet3.ToString();
                txtMasqueDecOctet4.Text = reseau.msqOctet4.ToString();
                btnValider.Enabled = true;
            }
            catch
            {
                ResetOctetText(cidr);
                return;
            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            reseau.Calculs();
            Height = 663;
            pnlResultat.Visible = true;

            lblClasse.Text = $"Classe : {reseau.Classe}";
            lblNet.Text = $"Adresse Net : {reseau.IPToString(reseau.net)}";
            lblBroadcast.Text = $"Adresse Broadcast : {reseau.IPToString(reseau.broadcast)}";
            lblPremiereIP.Text = $"1ère adresse IP : {reseau.IPToString(reseau.firstIP)}";
            lblDerniereIP.Text = $"Dernière adresse IP : {reseau.IPToString(reseau.lastIP)}";
            lblNombreIP.Text = $"Nombre d'IPs : {reseau.NbIP}";
            lblMachines.Text = $"Nombre de machines : {reseau.NbMachine}";
        }
    }
}
