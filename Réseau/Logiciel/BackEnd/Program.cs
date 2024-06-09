namespace BackEnd
{
        public class Reseau
        {
            public uint[] adresse;
            public uint adrOctet1;
            public uint adrOctet2;
            public uint adrOctet3;
            public uint adrOctet4;
            public string[] adressebin;
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
            public string[] masquebin;
            public string msqBinaire1;
            public string msqBinaire2;
            public string msqBinaire3;
            public string msqBinaire4;
            public uint CIDR = 0;

            public char Classe;

            public uint[] net;
            public uint[] broadcast;
            public uint[] firstIP;
            public uint[] lastIP;

            public Reseau()
            {
            }

            public void Initialisation()
            {
                uint reponse;
                string rep;
                Console.WriteLine("Notation binaire du reseau ? [1] : Oui, [2] : Non");
                while (!uint.TryParse(Console.ReadLine(), out reponse) || (reponse != 1 && reponse != 2))
                {
                    Console.WriteLine("Erreur : Veuillez entrer 1 pour Oui ou 2 pour Non.");
                }
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
                adressebin = new string[NbOctet];
                adressebin[0] = adrBinaire1;
                adressebin[1] = adrBinaire2;
                adressebin[2] = adrBinaire3;
                adressebin[3] = adrBinaire4;

                Console.WriteLine("Notation CIDR du masque ? [1] : Oui, [2] : Non");
                while (!uint.TryParse(Console.ReadLine(), out reponse) || (reponse != 1 && reponse != 2))
                {
                    Console.WriteLine("Erreur : Veuillez entrer 1 pour Oui ou 2 pour Non.");
                }
                switch (reponse)
                {
                    default:
                        break;
                    case 1:
                        Console.WriteLine("Quel est le nombre CIDR ?");
                        CIDR = Convert.ToUInt32(Console.ReadLine());
                        ConversionCIDR(CIDR);
                        msqOctet1 = Convert.ToUInt32(msqBinaire1, 2);
                        msqOctet2 = Convert.ToUInt32(msqBinaire2, 2);
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
                masquebin = new string[NbOctet];
                masquebin[0] = msqBinaire1;
                masquebin[1] = msqBinaire2;
                masquebin[2] = msqBinaire3;
                masquebin[3] = msqBinaire4;
                if (CIDR == 0)
                {
                    CIDR = CalculerCIDR(masquebin);
                }
            }

            public void ConversionCIDR(uint CIDR)
            {
                string binaire = new string('1', (int)CIDR).PadRight(NbBit, '0');
                msqBinaire1 = binaire.Substring(0, 8);
                msqBinaire2 = binaire.Substring(8, 8);
                msqBinaire3 = binaire.Substring(16, 8);
                msqBinaire4 = binaire.Substring(24, 8);
            }

            public uint CalculerCIDR(string[] masquebin)
            {
                uint cidr = 0;
                foreach (string octet in masquebin)
                {
                    foreach (char bit in octet)
                    {
                        if (bit == '1')
                        {
                            cidr++;
                        }
                    }
                }
                return cidr;
            }

            public void Calculs()
            {
                // Détermination Classe
                if (adrOctet1 >= 240)
                {
                    Classe = 'E';
                }
                else if (adrOctet1 >= 224)
                {
                    Classe = 'D';
                }
                else if (adrOctet1 >= 192)
                {
                    Classe = 'C';
                }
                else if (adrOctet1 >= 128)
                {
                    Classe = 'B';
                }
                else
                {
                    Classe = 'A';
                }

                // Calcul adresse net
                net = new uint[NbOctet];
                for (int i = 0; i < NbOctet; i++)
                {
                    net[i] = adresse[i] & masque[i];
                }

                // Calcul adresse broadcast
                broadcast = new uint[NbOctet];
                for (int i = 0; i < NbOctet; i++)
                {
                    broadcast[i] = adresse[i] | (~masque[i] & 0xFF);
                }

                // Calcul 1ere IP machine
                firstIP = (uint[])net.Clone();
                firstIP[NbOctet - 1] += 1;

                // Calcul dernière IP machine
                lastIP = (uint[])broadcast.Clone();
                lastIP[NbOctet - 1] -= 1;

                // Calcul nombre IPs
                NbIP = (int)Math.Pow(2, 32 - CIDR);

                // Calcul nombre machines
                NbMachine = NbIP - 2; // Exclusion de l'adresse réseau et de broadcast
            }

            public void AffichageReseau()
            {
                Console.WriteLine("Adresse Reseau : " + string.Join(".", adresse));
                Console.WriteLine("Adresse Reseau Binaire : " + string.Join(" ", adressebin));
                Console.WriteLine("Masque : " + string.Join(".", masque));
                Console.WriteLine("Masque Binaire : " + string.Join(" ", masquebin));
                Console.WriteLine("Nombre CIDR : " + CIDR);
                Console.WriteLine("Classe : " + Classe);
                Console.WriteLine("Adresse Net : " + string.Join(".", net));
                Console.WriteLine("Adresse Broadcast : " + string.Join(".", broadcast));
                Console.WriteLine("Première IP : " + string.Join(".", firstIP));
                Console.WriteLine("Dernière IP : " + string.Join(".", lastIP));
                Console.WriteLine("Nombre d'IPs : " + NbIP);
                Console.WriteLine("Nombre de machines : " + NbMachine);
            }

        }
}