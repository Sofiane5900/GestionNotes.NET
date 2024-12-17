﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tableauNotes = new int[4];
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
                    for (int i = 0; i < tableauNotes.Length; i++)
                    {
                        Console.ResetColor();
                        Console.Write($"Merci de saisir la note {i + 1} (sur /20) : ");
                        int notesInput = int.Parse(Console.ReadLine());
                        tableauNotes[i] = notesInput;
                        if (notesInput.Equals(999))
                        {
                            Environment.Exit(0);
                        } else if (notesInput > 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\tErreur de saisie, la note est sur 20 !");
                            Console.ResetColor();
                        }

                    }

                        break;
            }
        }
    }
}