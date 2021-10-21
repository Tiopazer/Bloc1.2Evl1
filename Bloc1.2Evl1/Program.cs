using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloc1._2Evl1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration
            float notes = 0;
            int dessus = 0, dessous = 0;

            //Demande de saisie de plusieur notes
            Console.Write("Veuillez saisir 10 notes : ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("vous avez saisi " + i + " notes");
                bool correct = false;
                while (!correct)
                {
                    try
                    {
                        notes = float.Parse(Console.ReadLine());
                        correct = true;
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Veuillez rentrer un nombre valide");
                    }
                }

                //Conditions qui augmente de 1 ma variable a chaque notes > à 10 ou < à 10
                if (notes >= 10)
                {
                    dessus++;
                }
                else if (notes < 10)
                {
                    dessous++;
                }
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue; //Ecris en bleu foncé dans la console    
            Console.WriteLine("parmis les notes saisie il y a : " + dessus + " notes au dessus de la moyenne");
            Console.WriteLine();
            Console.WriteLine("parmis les notes saisie il y a : " + dessous + " notes au dessous de la moyenne");
            Console.Read();
        }
    }
}
