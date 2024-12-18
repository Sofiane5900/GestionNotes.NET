using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Je déclare une liste (car mon nombre de notes na pas de limite de taille)
            List<int> listNotes = new List<int>();
            do
            {
                Console.WriteLine("--- Gestion des notes avec Menu ---\n");

                Console.WriteLine("1--- Saisir les notes");
                Console.WriteLine("2--- La plus grande note");
                Console.WriteLine("3--- La plus petite note");
                Console.WriteLine("4--- La moyenne des notes");
                Console.WriteLine("0--- Quitter");

                Console.Write("Faites votre choix : ");
                int choiceInput = int.Parse(Console.ReadLine()); // Je stock l'input de l'user dans une var choiceInput
                int choice = choiceInput; // je dis que choice = choiceinput 

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-- Saisir les notes ---");
                        Console.WriteLine("(999 pour stoper la saisie) \n");
                        int compteur = 0; // j'initialise une var compteur pour itérer dans ma list
                        do // execute le code une premiere fois meme si la condition est fausse
                        {
                            Console.ResetColor();
                            Console.Write($"Merci de saisir la note {compteur + 1} (sur /20) : ");
                            int notesInput = int.Parse(Console.ReadLine());
                            if (notesInput.Equals(999)) // Si la saisie de l'user = 999 je sors de ma "case 1"
                            {
                                break; 

                            }
                            else if (notesInput > 20) 
                            {
                                Console.ForegroundColor = ConsoleColor.Red; 
                                Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
                                Console.ResetColor();
                            }
                            else // Si la saisie de l'user != 999 && >20, alors j'ajoute sa saisie a ma list et j'incrémente compteur
                            {
                                listNotes.Add(notesInput);
                                compteur++;
                            }

                        }
                        while (true);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("------ La plus grande note ------ \n");
                        Console.WriteLine($"-- La plus grande note est {listNotes.Max()}/20 --- \n");
                        Console.ResetColor();
                        break;
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("------ La plus petite note ------ \n");
                        Console.WriteLine($"-- La plus pette note est {listNotes.Min()}/20 --- \n");
                        Console.ResetColor();
                        break;
                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------ La moyenne des notes ------ \n");
                        Console.WriteLine($"-- La moyenne des notes est {listNotes.Average()}/20 --- \n");
                        Console.ResetColor();
                        break;
                }
            } while (true);
        }
    }
}