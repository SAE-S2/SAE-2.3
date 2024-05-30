internal class Program
{
    public class Reseau
    {
        public uint[] adresse;
        public uint adrOctet1;
        public uint adrOctet2;
        public uint adrOctet3;
        public uint adrOctet4;
        public uint[] adressebin;
        public string adrBinaire1;
        public string adrBinaire2;
        public string adrBinaire3;
        public string adrBinaire4;

        public int NbOctet = 4;
        public int NbBit = 32;
        public int NbIP;
        public int NbMachine;

        public uint[] masque;
        public uint msqOctet1;
        public uint msqOctet2;
        public uint msqOctet3;
        public uint msqOctet4;
        public uint[] masquebin;
        public string msqBinaire1;
        public string msqBinaire2;
        public string msqBinaire3;
        public string msqBinaire4;
        public uint CIDR = 24;

        public char Classe;

        public uint[] net;
        public uint netOctet1;
        public uint netOctet2;
        public uint netOctet3;
        public uint netOctet4;

        public uint[] broadcast;
        public uint broadOctet1;
        public uint broadOctet2;
        public uint broadOctet3;
        public uint broadOctet4;

        public uint[] firstIP;
        public uint[] lastIP;

        public void Initialisation()
        {
            uint reponse;
            string rep;
            Console.WriteLine("Notation binaire du reseau ? [1] : Oui, [2] : Non");
            reponse = Convert.ToUInt32(Console.ReadLine());
            switch (reponse)
            {
                default:
                    break;
                case 1:
                    for (int i = 1; i <= NbOctet; i++)
                    {
                        do
                        {
                            Console.WriteLine($"Quel est l'octet {i} de l'adresse réseau ?");
                            rep = Console.ReadLine();
                            reponse = Convert.ToUInt32(rep, 2);
                            if (reponse > 255 || reponse < 0)
                            {
                                Console.WriteLine("Erreur : L'octet doit être compris entre 0 et 255");
                            }
                        } while (reponse > 255 || reponse < 0);
                        switch (i)
                        {
                            default:
                                break;
                            case 1:
                                adrBinaire1 = rep;
                                adrOctet1 = reponse;
                                break;
                            case 2:
                                adrBinaire2 = rep;
                                adrOctet2 = reponse;
                                break;
                            case 3:
                                adrBinaire3 = rep;
                                adrOctet3 = reponse;
                                break;
                            case 4:
                                adrBinaire4 = rep;
                                adrOctet4 = reponse;
                                break;
                        }
                    }
                    break;
                case 2:
                    for (int i = 1; i <= NbOctet; i++)
                    {
                        do
                        {
                            Console.WriteLine($"Quel est l'octet {i} de l'adresse réseau ?");
                            reponse = Convert.ToUInt32(Console.ReadLine());
                            rep = Convert.ToString(reponse, 2);
                            if (reponse > 255 || reponse < 0)
                            {
                                Console.WriteLine("Erreur : L'octet doit être compris entre 0 et 255");
                            }
                        } while (reponse > 255 || reponse < 0);
                        switch (i)
                        {
                            default:
                                break;
                            case 1:
                                adrOctet1 = reponse;
                                adrBinaire1 = rep;
                                break;
                            case 2:
                                adrOctet2 = reponse;
                                adrBinaire2 = rep;
                                break;
                            case 3:
                                adrOctet3 = reponse;
                                adrBinaire3 = rep;
                                break;
                            case 4:
                                adrOctet4 = reponse;
                                adrBinaire4 = rep;
                                break;
                        }
                    }
                    break;
            }
            adresse = new uint[NbOctet];
            adresse[0] = adrOctet1;
            adresse[1] = adrOctet2;
            adresse[2] = adrOctet3;
            adresse[3] = adrOctet4;
            adressebin = new uint[NbOctet];
            adressebin[0] = Convert.ToUInt32(adrBinaire1);
            adressebin[1] = Convert.ToUInt32(adrBinaire2);
            adressebin[2] = Convert.ToUInt32(adrBinaire3);
            adressebin[3] = Convert.ToUInt32(adrBinaire4);
            Console.WriteLine("Notation CIDR du masque ? [1] : Oui, [2] : Non");
            reponse = Convert.ToUInt32(Console.ReadLine());
            switch (reponse)
            {
                default:
                    break;
                case 1:
                    Console.WriteLine("Quel est le nombre CIDR ?");
                    CIDR = Convert.ToUInt32(Console.ReadLine());
                    ConversionCIDR(CIDR);
                    msqOctet1 = Convert.ToUInt32(msqBinaire1, 2);
                    msqOctet2 = Convert.ToUInt32(msqBinaire1, 2);
                    msqOctet3 = Convert.ToUInt32(msqBinaire3, 2);
                    msqOctet4 = Convert.ToUInt32(msqBinaire4, 2);
                    break;
                case 2:
                    for (int i = 1; i <= NbOctet; i++)
                    {
                        do
                        {
                            Console.WriteLine($"Quel est l'octet {i} du masque ?");
                            reponse = Convert.ToUInt32(Console.ReadLine());
                            rep = Convert.ToString(reponse, 2);
                            if (reponse > 255 || reponse < 0)
                            {
                                Console.WriteLine("Erreur : L'octet doit être compris entre 0 et 255");
                            }
                        } while (reponse > 255 || reponse < 0);
                        switch (i)
                        {
                            default:
                                break;
                            case 1:
                                msqOctet1 = reponse;
                                msqBinaire1 = rep;
                                break;
                            case 2:
                                msqOctet2 = reponse;
                                msqBinaire2 = rep;
                                break;
                            case 3:
                                msqOctet3 = reponse;
                                msqBinaire3 = rep;
                                break;
                            case 4:
                                msqOctet4 = reponse;
                                msqBinaire4 = rep;
                                break;
                        }
                    }
                    break;
            }
            masque = new uint[NbOctet];
            masque[0] = msqOctet1;
            masque[1] = msqOctet2;
            masque[2] = msqOctet3;
            masque[3] = msqOctet4;
            masquebin = new uint[NbOctet];
            masquebin[0] = Convert.ToUInt32(msqBinaire1);
            masquebin[1] = Convert.ToUInt32(msqBinaire2);
            masquebin[2] = Convert.ToUInt32(msqBinaire3);
            masquebin[3] = Convert.ToUInt32(msqBinaire4);
        }

        public void ConversionCIDR(uint CIDR)
        {
            string binaire = string.Empty;
            for (int i = 0; i < NbBit; i++)
            {
                if (i<CIDR)
                {
                    binaire += "1";
                }
                else
                {
                    binaire += "0"; 
                }
            }
            int j = 0;
            msqBinaire1 = string.Empty;
            msqBinaire2 = string.Empty;
            msqBinaire3 = string.Empty;
            msqBinaire4 = string.Empty;
            for (int i = j; i < NbBit / 4; i++)
            {
                msqBinaire1 += binaire[i];
                j++;
            }
            for (int i = j; i < NbBit / 2; i++)
            {
                msqBinaire2 += binaire[i];
                j++;
            }
            for (int i = j; i < NbBit / 2 + NbBit / 4; i++)
            {
                msqBinaire3 += binaire[i];
                j++;
            }
            for (int i = j; i < NbBit; i++)
            {
                msqBinaire4 += binaire[i];
                j++;
            }       
        }

        public void Calculs()
        {
            // Détermination Classe
            if (true)
            {
                
            }

            // Calcul adresse net


            // Calcul adresse broadcast


            // Calcul 1ere IP machine


            // Calcul dernière IP machine


            // Calcul nombre IPs


            // Calcul nombre machines

        }

        public Reseau()
        {
            Initialisation();
            Calculs();
        }

        public void AffichageReseau()
        {
            Console.Write("Adresse Reseau :");
            for (int i = 0; i < NbOctet; i++)
            {
                Console.Write($"{adresse[i]} ");
            }
            Console.WriteLine();
            Console.Write("Adresse Reseau Binaire :");
            for (int i = 0; i < NbOctet; i++)
            {
                Console.Write($"{adressebin[i]} ");
            }
            Console.WriteLine();
            Console.Write("Masque :");
            for (int i = 0; i < NbOctet; i++)
            {
                Console.Write($"{masque[i]} ");
            }
            Console.WriteLine();
            Console.Write("Masque Binaire :");
            for (int i = 0; i < NbOctet; i++)
            {
                Console.Write($"{masquebin[i]} ");
            }
        }

    }   
    private static void Main(string[] args)
    {
        Reseau test = new Reseau();
        test.AffichageReseau();
    }
}