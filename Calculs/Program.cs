using System;

namespace Calculs
{
    /// <summary>
    /// Application Calculs : addition ou multiplication de 2 nombres
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct; // Saisie correcte ou non
            reponse = 0;
            solution = 0;

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {        
                // affiche le menu et saisie le choix
                correct = false;
                while (!correct)
                {
                    try
                    {
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());

                        correct = true;
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie");
                    }
                }
                
                
                // traitement des choix
                switch (choix)
                {
                    case 0:
                        break; //Quitter

                    case 1:
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());

                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie");
                                Console.Write(val1 + " + " + val2 + " = ");
                            }
                        }
                            // comparaison avec la bonne réponse
                            solution = val1 + val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                            }
                            break;
                        

                    case 2:
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        correct = false;
                        while (!correct)
                        {
                            try
                            {
                                reponse = int.Parse(Console.ReadLine());

                                correct = true;
                            }
                            catch
                            {
                                Console.WriteLine("Erreur de saisie");
                                Console.Write(val1 + " x " + val2 + " = ");
                            }
                        }
                            // comparaison avec la bonne réponse
                            solution = val1 * val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                            }
                            break;
                       
                         
                    default:
                        // Si le choix est autre que 0, 1 ou 2
                        Console.WriteLine("Erreur : veuillez séléctionner un choix valide.");
                        break;
                    }
                }
            }
        }
    }

