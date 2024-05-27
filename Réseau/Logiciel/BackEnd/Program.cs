internal class Program
{
    public class Reseau
    {
        public uint[] adresse;
        public uint adrOctet1;
        public uint adrOctet2;
        public uint adrOctet3;
        public uint adrOctet4;

        public int NbOctet = 4;
        public int NbBit = 32; 

        public uint[] masque;
        public uint msqOctet1;
        public uint msqOctet2;
        public uint msqOctet3;
        public uint msqOctet4;
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
            string Octet1 = string.Empty;
            string Octet2 = string.Empty;
            string Octet3 = string.Empty;
            string Octet4 = string.Empty;
            for (int i = j; i < NbBit / 4; i++)
            {
                Octet1 += binaire[i];
                j++;
            }
            for (int i = j; i < NbBit / 2; i++)
            {
                Octet2 += binaire[i];
                j++;
            }
            for (int i = j; i < NbBit / 2 + NbBit / 4; i++)
            {
                Octet3 += binaire[i];
                j++;
            }
            for (int i = j; i < NbBit; i++)
            {
                Octet4 += binaire[i];
                j++;
            }
            msqOctet1 = Convert.ToUInt32(Octet1, 2);
            msqOctet2 = Convert.ToUInt32(Octet2, 2);
            msqOctet3 = Convert.ToUInt32(Octet3, 2);
            msqOctet4 = Convert.ToUInt32(Octet4, 2);
            masque = new uint[NbOctet];
            masque[0] = msqOctet1;
            masque[1] = msqOctet2;
            masque[2] = msqOctet3;
            masque[3] = msqOctet4;         
        }

        public Reseau()
        {
            uint reponse;
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
                            reponse = Convert.ToUInt32(Console.ReadLine(), 2);
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
                                break;
                            case 2:
                                adrOctet2 = reponse;
                                break;
                            case 3:
                                adrOctet3 = reponse;
                                break;
                            case 4:
                                adrOctet4 = reponse;
                                break;
                        }
                    }
                    adresse = new uint[NbOctet];
                    adresse[0] = adrOctet1;
                    adresse[1] = adrOctet2;
                    adresse[2] = adrOctet3;
                    adresse[3] = adrOctet4;
                    break;
                case 2:
                    for (int i = 1; i <= NbOctet; i++)
                    {
                        do
                        {
                            Console.WriteLine($"Quel est l'octet {i} de l'adresse réseau ?");
                            reponse = Convert.ToUInt32(Console.ReadLine());
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
                                break;
                            case 2:
                                adrOctet2 = reponse;
                                break;
                            case 3:
                                adrOctet3 = reponse;
                                break;
                            case 4:
                                adrOctet4 = reponse;
                                break;
                        }
                    }
                    adresse = new uint[NbOctet];
                    adresse[0] = adrOctet1;
                    adresse[1] = adrOctet2;
                    adresse[2] = adrOctet3;
                    adresse[3] = adrOctet4;
                    break;
            }
            
            Console.WriteLine("Notation CIDR du masque ? [1] : Oui, [2] : Non");
            reponse = Convert.ToUInt32(Console.ReadLine());
            switch (reponse)
            {
                default:
                    break;
                case 1:
                    Console.WriteLine("Quel est le CIDR ?");
                    CIDR = Convert.ToUInt32(Console.ReadLine());
                    ConversionCIDR(CIDR);
                    break;
                case 2:
                    for (int i = 1; i <= NbOctet; i++)
                    {
                        do
                        {
                            Console.WriteLine($"Quel est l'octet {i} du masque ?");
                            reponse = Convert.ToUInt32(Console.ReadLine());
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
                                break;
                            case 2:
                                msqOctet2 = reponse;
                                break;
                            case 3:
                                msqOctet3 = reponse;
                                break;
                            case 4:
                                msqOctet4 = reponse;
                                break;
                        }
                    }
                    masque = new uint[NbOctet];
                    masque[0] = msqOctet1;
                    masque[1] = msqOctet2;
                    masque[2] = msqOctet3;
                    masque[3] = msqOctet4;
                    break;
            }
            
        }

        public void AffichageReseau()
        {
            for (int i = 0; i < NbOctet; i++)
            {
                Console.Write($"{adresse[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < NbOctet; i++)
            {
                Console.Write($"{masque[i]} ");
            }
        }

    }   
    private static void Main(string[] args)
    {
        Reseau test = new Reseau();
        test.AffichageReseau();
    }
}