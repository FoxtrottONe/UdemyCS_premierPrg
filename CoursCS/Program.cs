using System;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace reprise // Note: actual namespace depends on the project name.
{

    /*
     * cours Udemy c#
     * date création :
     * date édition   : 16.01.23
     * ver                :
     * ---------------->>>>>>>>>>>>>>>>>>>>    VOIR POUR UTILISER GIT          <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<----------------------
     */


    internal class Program
    {/// <summary>
     /// Udémy exercie de reprise
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Demander information personnes
            Console.Clear();
            string nomPersonne1 = DemanderNom(1);
            Console.WriteLine();
            int agePersonne1 = DemanderAge(nomPersonne1);

            Console.Clear();
            string nomPersonne2 = DemanderNom(2);
            Console.WriteLine();
            int agePersonne2 = DemanderAge(nomPersonne2);




            // AFFICHER LES RESULTATS
            Console.Clear();
            AffichageInfoPersonne(nomPersonne1, agePersonne1);
            Console.WriteLine();
            AffichageInfoPersonne(nomPersonne2, agePersonne2);
        }

        /// <summary>
        /// Demande le nom de la personne
        /// </summary>
        /// <returns></returns>
        static string DemanderNom(int noPersonne)
        {
            bool erreur = false;
            string nom = "";
            do
            {
                Console.Write("quel est ton nom de la personne numéro : {0} ?", noPersonne);
                nom = Console.ReadLine();
                nom = nom.Trim();

                if (nom == "" || nom.Length < 3)
                {
                    erreur = true;
                    Console.Clear();
                }
                else
                {
                    erreur = false;
                }
            } while (erreur);
            return nom;
        }

        /// <summary>
        /// Demande l'age de la personne
        /// </summary>
        /// <returns></returns>
        static int DemanderAge(string nomPersonne)
        {
            int age = 0;
            bool erreur = false;
            do
            {
                try
                {
                    Console.Write("{0} quel est votre age ? : ", nomPersonne);
                    age = int.Parse(Console.ReadLine());


                    if (age <= 0) // je ne veux pas d'age de (0 ou négatif ou alphanumérique)
                    {
                        erreur = true;
                        Console.Clear();
                        Console.WriteLine("\nErreur! Vous avez entrez un age de 0 ou moin !\n\n\n\n\n\n");
                    }
                    else if (age > 100)
                    {
                        Console.WriteLine("vous êtes sur que l'age est plus grand que 100 ans ? ");
                        erreur = true;
                    }
                    else
                    {
                        erreur = false;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("\nErreur! Vous devez entrer un age valide ! \n\n\n\n\n\n");
                    erreur = true;
                }
            } while (erreur);
            return age;
        }
        /// <summary>
        /// Gestion de l'affichage de réponse
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="age"></param>
        static void AffichageInfoPersonne(string nom, int age)
        {
            Console.WriteLine("salut {0}! tu as {1} ans", nom, age);
            Console.WriteLine("bientot vous aurez {0} ans !", age + 1);
            Console.WriteLine();
        }
    }
}