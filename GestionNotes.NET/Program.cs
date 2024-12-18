using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                int choiceInput = int.Parse(Console.ReadLine());
                int choice = choiceInput;

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
                        int compteur = 0;
                        while (true)
                        {
                            Console.ResetColor();
                            Console.Write($"Merci de saisir la note {compteur + 1} (sur /20) : ");
                            int notesInput = int.Parse(Console.ReadLine());
                            if (notesInput.Equals(999))
                            {
                                break;

                            }
                            else if (notesInput > 20)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
                                Console.ResetColor();
                            }
                            else
                            {
                                listNotes.Add(notesInput);
                                compteur++;
                            }

                        }
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