using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constructor.MesClass;

namespace Constructor
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(" J'ai entendu dire que vous voulez construire un batiment. ");
            Console.WriteLine(" Mais je vais avoir besoin de quelque info");
            Console.WriteLine();

            Building monImmeuble;

            int tailleEtage = Initialisation_etage();
            int tailleBuilding = Initialisation_taille();

            if (tailleBuilding == 0)
                monImmeuble = new Building(tailleEtage);
            else
                monImmeuble = new Building(tailleEtage, tailleBuilding);

            Console.WriteLine("La taille Moyenne de mes étages sera de " + monImmeuble.GetFloorMaxSize());
            Console.ReadKey();
        }

        static int Initialisation_etage()
        {
            int tailleEtageRentre = 0;
            bool etageEstUnChiffre = false;



            while (!etageEstUnChiffre)
            {
                Console.WriteLine(" Combien voulez vous d'étage : ");
                etageEstUnChiffre = int.TryParse(Console.ReadLine(), out tailleEtageRentre);
                if (!etageEstUnChiffre || tailleEtageRentre <= 0)
                {
                    etageEstUnChiffre = false;
                    Console.WriteLine(" Veuillez entrer un chiffre positif");
                    Console.WriteLine("");
                }
            }
            return tailleEtageRentre;
        }
        static int Initialisation_taille()
        {
            int tailleBatiment = 0;
            bool tailleEstUnChiffre = false;
            while (!tailleEstUnChiffre)
            {
                Console.WriteLine(" Quelle taille doit faire le batiment (chiffre supérieur à 2 ou vide si non décidé) : ");
                string tailleEntre = Console.ReadLine();
                if (tailleEntre == "")
                    return 0  ;
                else
                {
                    
                    tailleEstUnChiffre = int.TryParse(tailleEntre, out tailleBatiment);
                    if (!tailleEstUnChiffre || tailleBatiment < 2)
                    {
                        tailleEstUnChiffre = false;
                        Console.WriteLine(" Veuillez entrer un chiffre superieur à 2m ");
                        Console.WriteLine("");
                    }
                }


            }


            return tailleBatiment;
        }
    }
}
