using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] tableauNotes = new int [4];
            Console.WriteLine("--- Gestion des notes avec Menu ---\n");

            Console.WriteLine("1--- Saisir les notes");
            Console.WriteLine("2--- La plus grande note");
            Console.WriteLine("3--- La plus petite note");
            Console.WriteLine("4--- La moyenne des notes");
            Console.WriteLine("0--- Quitter");

            Console.Write("Faites votre choix : ");
            int userInput = int.Parse(Console.ReadLine());
            int choice = userInput;


          
            switch(choice)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                 case 1:
                    Console.WriteLine("Merci de saisir la note 1 (sur /20)");


            }

            

        }
    }
}