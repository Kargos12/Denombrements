using System;
/**
* titre : Denombrement
* description : Programme permettant de faire des permutations, arrangements et combinaisons
* auteur : inconnu
* date création : inconnue
* date dernière modification : 14/11/2020
*/

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix = 1, total, nombre;
            long resultat;
            while (choix != 0)
            {
                // boucle qui se repète si la saisie n'est pas entre 0 et 3
                do
                {
                    Console.WriteLine("Permutation ...................... 1");
                    Console.WriteLine("Arrangement ...................... 2");
                    Console.WriteLine("Combinaison ...................... 3");
                    Console.WriteLine("Quitter .......................... 0");
                    Console.Write("Choix :                            ");
                    choix = int.Parse(Console.ReadLine());
                } while (choix < 0 || choix > 3);

                if (choix == 0) { Environment.Exit(0); }

                else
                {
                    // saisie du nombre d'éléments à gérer
                    Console.Write("nombre total d'éléments à gérer = ");
                    total = int.Parse(Console.ReadLine());

                    if (choix == 1)
                    {
                        // calcul du resultat
                        resultat = 1;
                        for (int k = 1; k <= total; k++)
                            resultat *= k;
                        Console.WriteLine(total + "! = " + resultat);
                    }
                    else
                    {
                        // saisie du nombre de sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = ");
                        nombre = int.Parse(Console.ReadLine());
                        if (choix == 2)
                        {
                            // calcul de resultat
                            resultat = 1;
                            for (int k = (total - nombre + 1); k <= total; k++)
                                resultat *= k;
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("A(" + total + "/" + nombre + ") = " + resultat);
                        }
                        else
                        {
                            // calcul de r1
                            long r1 = 1;
                            for (int k = (total - nombre + 1); k <= total; k++)
                                r1 *= k;

                            // calcul de r2
                            long r2 = 1;
                            for (int k = 1; k <= nombre; k++)
                                r2 *= k;
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("C(" + total + "/" + nombre + ") = " + (r1 / r2));
                        }

                    }
                    Console.ReadLine();
                }
            }
        }
    }
}

