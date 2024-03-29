﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace semaine1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = {1,2,3,4};
            
            Exercice32(tableau);

            foreach(int num in tableau)
            {
                Console.WriteLine(num);
            }
            
        }
        /// <summary>
        /// Afficher "Allo p2" a la console
        /// </summary>
        static void Exercice1()
        {
            Console.WriteLine("Allo p2");
        }       
        /// <summary>
        /// Identifie et imprime deux nombre donner en parametre
        /// </summary>
        /// <param name="num1">premier nombre</param>
        /// <param name="num2">deuxieme nombre</param>
        static void Exercice2(int num1 ,int num2)
        {
            Console.WriteLine("Premier nombre : " + num1 + "\nDeuxieme nombre : " + num2);
        }
        /// <summary>
        /// Additionne deux nombre et retourne le resultat
        /// </summary>
        /// <param name="num1">premier nombre</param>
        /// <param name="num2">deuxieme nombre</param>
        /// <returns>Resultat de l'addition</returns>
        static int Exercice3(int num1 ,int num2)
        {
            int resultat = num1 + num2;
            return resultat;
        }
        /// <summary>
        /// Demande un nombre a l'utilisateur et le retourne
        /// </summary>
        /// <returns>Nombre demander a l'utilisateur</returns>
        static int Exercice4()
        {
            int nombre;
            Console.Write("Entrer un nombre : ");
            int.TryParse(Console.ReadLine(),out nombre);

            return nombre;
        }
        /// <summary>
        /// Demande un nombre superieur ou egal a 0 a l'utilisateur et le retourne
        /// </summary>
        /// <remarks>Un nombre invalide retourne -1</remarks>
        /// <returns></returns>
        static int Exercice5()
        {
            int nombre;
            Console.Write("Entrer un nombre superieur a 0 : ");
            int.TryParse(Console.ReadLine(),out nombre);
            if (nombre < 0)
            {
                nombre = -1;
            }
            return nombre;
        }
        /// <summary>
        /// Demande a l'utilisateur un nombre jusqu'a ce qu'il soit superieur a 10
        /// </summary>
        /// <returns>le nombre valide</returns>
        static int Exercice6()
        {
            int nombre = 0;
            while (nombre <= 10)
            {
                Console.Write("Entrer un nombre superieur a 10");
                int.TryParse(Console.ReadLine(),out nombre);
            }
            return nombre;
        }
        /// <summary>
        /// Divise deux numero donner en parametre et retourne le resultat
        /// </summary>
        /// <remarks>Retourne 0 si le denominateur est 0
        /// <param name="numerateur">Numerateur</param>
        /// <param name="denominateur">Denominateur</param>
        /// <returns>Resultat de la division</returns>
        static int Exercice7(int numerateur ,int denominateur)
        {
            int resultat;

            if (denominateur == 0)
            {
                resultat = 0;
            }
            else
            {
                resultat = numerateur / denominateur;
            }

            return resultat;
        }
        /// <summary>
        /// Retourne un tableau de nombre d'une longueur donner en parametre
        /// </summary>
        /// <param name="longueur">Longueur du tableau</param>
        /// <returns>Tableau initialiser a 0 de la longueur donner</returns>
        static int[] Exercice8(int longueur)
        {
            int[] tableau = new int[longueur];
            return tableau;
        }
        /// <summary>
        /// Retourne un tableau de nombre d'une longueur donner en parametre rempli de nombre aleatoire entre deux nombre donner en parametre
        /// </summary>
        /// <remarks>Peut contenir le maximum</remarks>
        /// <param name="longueur">Longueur du tableau</param>
        /// <param name="min">Nombre minimum</param>
        /// <param name="max">Nombre maximum</param>
        /// <returns>Tableau initialiser</returns>
        static int[] Exercice9(int longueur ,int min ,int max)
        {
            int[] tableau = new int[longueur];
            Random random = new Random();
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = random.Next(min,max+1);
            }
            return tableau;
        }
        /// <summary>
        /// Retourne un tableau d'une longueur donner en parametre, rempli de nombre entre deux nombre donner en parametre.
        /// </summary>
        /// <remarks>Si le max est inferieur au min, les deux chiffre sont inverser. Peut contenir le troisieme parametre</remarks>
        /// <param name="longueur">Longueur du tableau</param>
        /// <param name="min">Minimum</param>
        /// <param name="max">Maximum</param>
        /// <returns>Tableau initialiser</returns>
        static int[] Exercice10(int longueur, int min, int max)
        {
            int[] tableau = new int[longueur];
            Random random = new Random();
            if (min > max)
            {
                int mem = max;
                max = min;
                min = mem;
            }
            for (int i = 0; i < tableau.Length;i++)
            {
                tableau[i] = random.Next(min,max+1);
            }
            return tableau;
        }
        /// <summary>
        /// Retourne un tableau d'une longueur donner en parametre, rempli de nombre entre deux nombre donner en parametre.
        /// </summary>
        /// <remarks>Peut contenir des nombre negatif et le troisieme parametre</remarks>
        /// <param name="longueur">Longueur du tableau</param>
        /// <param name="minimum">Minimum</param>
        /// <param name="maximum">Maximum</param>
        /// <returns>Tableau initialiser</returns>
        static int[] Exercice11(int longueur, int minimum, int maximum)
        {
            int[] tableau = new int[longueur];
            Random random = new Random();
            for (int i = 0; i < tableau.Length;i++)
            {
                tableau[i] = random.Next(minimum,maximum+1);
            }
            return tableau;
        }
        /// <summary>
        /// Retourne un tableau d'une longueur donner en parametre rempli de nombre entre deux limite donner en parametre
        /// </summary>
        /// <remarks>Peut etre negatif et contenir les deux limites</remarks>
        /// <param name="longueur">Longueur du tableau</param>
        /// <param name="min">Premiere limite</param>
        /// <param name="max">Deuxieme limite</param>
        /// <returns>tableau initialiser</returns>
        static int[] Exercice12(int longueur, int min, int max)
        {
            int[] tableau = new int[longueur];
            Random random = new Random();
            if (max > min)
            {
                int mem = max;
                max = min;
                min = mem;
            }
            for (int i = 0; i < tableau.Length; i++)
            {
                tableau[i] = random.Next(min,max+1);
            }
            return tableau;
        }
        /// <summary>
        /// Additionne tout les nombres dans un tableau et retourne le resultat
        /// </summary>
        /// <param name="tableau">Tableau a additioner</param>
        /// <returns>Resultat total</returns>
        static int Exercice13(int[] tableau)
        {
            int resultat = 0;
            for (int i = 0; i < tableau.Length ; i++)
            {
                resultat += tableau[i];
            }
            return resultat;
        }
        /// <summary>
        /// Additionne tout les nombres dans un tableau et retourne le resultat
        /// </summary>
        /// <param name="tableau">Tableau a additioner</param>
        /// <returns>Resultat total</returns>
        static int Exercice14(int[] tableau)
        {
            int resultat = 0;
            int i = 0;
            while (i < tableau.Length)
            {
                resultat += tableau[i];
                i++;
            }
            return resultat;
        }
        /// <summary>
        /// Additionne tout les nombres dans un tableau et retourne le resultat
        /// </summary>
        /// <param name="tableau">Tableau a additioner</param>
        /// <returns>Resultat total</returns>
        static int Exercice15(int[] tableau)
        {
            int resultat = 0;
            int i = 0;
            do
            {
                resultat += tableau[i];
                i++;
            } while (i < tableau.Length);
            return resultat;
        }
        /// <summary>
        /// Afficher une grille de 3x3 de "*"
        /// </summary>
        static void Exercice16()
        {
            Console.WriteLine("* * *\n* * *\n* * *");
        }
        /// <summary>
        /// Affiche une grille de "*" d'une longueur et une largeur donner en parametre
        /// </summary>
        /// <param name="longueur">Longueur de la grille</param>
        /// <param name="largeur">Largeur de la grille</param>
        static void Exercice17(int longueur, int largeur)
        {
            for (int i = 0; i < longueur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Affiche une grille de "*" d'une longueur et une largeur donner en parametre
        /// </summary>
        /// <remarks>La longueur et la largueur peuvent etre negatives
        /// <param name="longueur">Longueur de la grille</param>
        /// <param name="largeur">Largeur de la grille</param>
        static void Exercice18(int longueur, int largeur)
        {
            longueur = Math.Abs(longueur);
            largeur = Math.Abs(largeur);

            for (int i = 0; i < longueur; i++)
            {
                int j = 0;
                while (j < largeur)
                {
                    Console.Write("* ");
                    j++;
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Afficher une grille de "*" d'une longueur et largeur donner en parametre
        /// </summary>
        /// <param name="longueur">Longueur de la grille</param>
        /// <param name="largeur">Largeur de la grille</param>
        static void Exercice19(int longueur, int largeur)
        {
            if (longueur < 1)
            {
                Console.WriteLine("Impossible de faire un tableau de " + longueur + " de longueur");
                return;
            }
            else if ( largeur < 1)
            {
                Console.WriteLine("Impossible de faire un tableau de " + longueur + " de longueur");
                return;
            }
            for (int i = 0; i < longueur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Afficher une grille du charactere donner en parametre d'une longueur et largeur donner en parametre
        /// </summary>
        /// <param name="longueur">Longueur de la grille</param>
        /// <param name="largeur">Largeur de la grille</param>
        /// <param name="c">Charactere a afficher</param>
        static void Exercice20(int longueur, int largeur, char c)
        {
            if (longueur < 1)
            {
                Console.WriteLine("Impossible de faire un tableau de " + longueur + " de longueur");
                return;
            }
            else if ( largeur < 1)
            {
                Console.WriteLine("Impossible de faire un tableau de " + longueur + " de longueur");
                return;
            }
            for (int i = 0; i < longueur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Afficher une tableau de charactere donner en parametre d'une longueur et largeur donner en parametre. Cette forme est repeter un nombre de fois donner en parametre
        /// </summary>
        /// <param name="longueur">Longueur de la forme</param>
        /// <param name="largeur">Largeur de la forme</param>
        /// <param name="nbFormes">Nombre de formes</param>
        /// <param name="c">Charactere a afficher</param>
        static void Exercice21(int longueur, int largeur, int nbFormes, char c)
        {
            if (longueur < 1)
            {
                Console.WriteLine("Impossible de faire une grille de " + longueur + " de longueur");
                return;
            }
            else if ( largeur < 1)
            {
                Console.WriteLine("Impossible de faire une grille de " + longueur + " de longueur");
                return;
            }
            else if (nbFormes < 1)
            {
                Console.WriteLine("Impossible d'afficher une grille " + longueur + " fois");
                return;
            }
            for (int k = 0; k < nbFormes; k++)
            {
                for (int i = 0; i < longueur; i++)
                {
                    for (int j = 0; j < largeur; j++)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Afficher une forme d'une longueur donner en parametre et afficher un charactere de plus a chaque ligne
        /// </summary>
        /// <param name="longueur">Longueur de la forme</param>
        static void Exercice22(int longueur)
        {
            for (int i = 0; i < longueur; i++)
            {
                for (int j = 0; j < i+1 ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Affiche une forme de longueur decroissante de longueur donner en parametre
        /// </summary>
        /// <param name="longueur">Longueur de la forme</param>
        static void Exercice23(int longueur)
        {
            // debug
            if (longueur < 1)
            {
                Debug.WriteLine("Longueur ne peut pas etre inferieure a 1, est : " + longueur, "Exercice 23 ");
            }

            // code
            while (longueur > 0)
            {
                int i = 0;
                while (i < longueur)
                {
                    Console.Write("*");
                    i++;
                }
                Console.WriteLine();
                longueur--;
            }
        }
        /// <summary>
        /// Affiche une forme de longueur decroissante de longueur donner en parametre
        /// </summary>
        /// <param name="longueur">Longueur de la forme</param>
        static void Exercice24(int longueur)
        {
            // debug
            if (longueur < 1)
            {
                Debug.WriteLine("Longueur ne peut pas etre inferieure a 1, est : " + longueur, "Exercice 24 ");
            }

            // code
            do
            {
                int i = 0;
                do
                {
                    Console.Write("*");
                    i++;
                } while (i < longueur);
                Console.WriteLine();
                longueur--;
            } while (longueur > 0);
        }
        /// <summary>
        /// Affiche une forme de va et viens dont la ligne la plus longue est d'une longueur donner en parametre
        /// </summary>
        /// <param name="longueur">Longueur de la ligne la plus longue</param>
        static void Exercice25(int longueur)
        {
            // debug 
            if (longueur < 1)
            {
                Debug.WriteLine("Impossible d'afficher une forme d'une longueur de : " + longueur, "Exercice 25");
            }

            // code
            for (int i = longueur-1; i > 0; i--)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Exercice22(longueur);
        }
        /// <summary>
        /// Retourne une string contenant un pyramide de la hauteur donner en parametre
        /// </summary>
        /// <param name="longueur">Hauteur de la pyramide</param>
        /// <returns>Une string contenant la pyramide</returns>
        static string Exercice26(int longueur)
        {
            // debug
            if (longueur < 1)
            {
                Debug.WriteLine("Impossible de creer une pyramide de " + longueur + " de hauteur", "Exercice 26 ");
            }


            // code
            string resultat = "";
            int ligne = longueur;
            for (int i = 1; i < longueur+1; i++)
            {
                for (int j = 0; j < ligne-1; j++)
                {
                    resultat += " ";
                }
                for (int k = 0; k < i; k++)
                {
                    resultat += "*";
                    if (k != i)
                    {
                        resultat += " ";
                    }
                }
                ligne--;
                resultat += "\n";
            }
            return resultat;
        }
        /// <summary>
        /// Retourne la moyenne des nombres dans un taleau donner en parametre
        /// </summary>
        /// <param name="tableau">Tableau de nombre</param>
        /// <returns>Moyenne du tableau</returns>
        static double Exercice27(int[] tableau)
        {
            int resultat = 0;

            for (int i = 0; i < tableau.Length; i++)
            {
                resultat += tableau[i];
            }
            resultat = resultat / tableau.Length;

            return resultat;
        }
        /// <summary>
        /// Retourne l'ecart type d'un tableau donner en parametre
        /// </summary>
        /// <param name="tableau">Tableau de nombre</param>
        /// <returns>L'ecart type du tableau</returns>
        static double Exercice28(int[] tableau)
        {
            double moyenne = Exercice27(tableau);
            double[] ecarts = new double[tableau.Length];

            for (int  i = 0; i < tableau.Length; i++)
            {
                ecarts[i] = Math.Abs(tableau[i]-moyenne);
            }

            double ecartType = 0.0;
            foreach (double ecart in ecarts)
            {
                ecartType += ecart;
            }
            ecartType = ecartType / ecarts.Length;

            return ecartType;
        }
        /// <summary>
        /// Retourne le plus grand nombre des positions donner en parametre dans le tableau donner en parametre
        /// </summary>
        /// <param name="tableau">Tableau de nombre</param>
        /// <param name="index1">Premier index</param>
        /// <param name="index2">Deuxieme index</param>
        /// <returns>Le plus grand nombre</returns>
        static int Exercice29(int[] tableau, int index1, int index2)
        {
            // debug

            if (index1 < 0 || index1 > tableau.Length)
            {
                Debug.WriteLine("Impossible d'utiliser " + index1 + " comme premier index", "Exercice 30 ");
                return -1;
            }
            if (index2 < 0 || index2 > tableau.Length)
            {
                Debug.WriteLine("Impossible d'utiliser " + index2 + " comme deuxieme index", "Exercice 30 ");
                return -1;
            }

            // code

            int resultat;
            if (tableau[index1] > tableau[index2])
            {
                resultat = tableau[index1];
            }
            else
            {
                resultat = tableau[index2];
            }
            return resultat;
        }
        /// <summary>
        /// Inverse dans un tableau donner en parametre les deux position donner en parametre
        /// </summary>
        /// <param name="tableau">Tableau de nombre</param>
        /// <param name="index1">Premiere position</param>
        /// <param name="index2">Deuxieme position</param>
        static void Exercice30(int[] tableau, int index1, int index2)
        {
            // Debug 

            if (index1 < 0 || index1 > tableau.Length)
            {
                Debug.WriteLine("Impossible d'utiliser " + index1 + " comme premier index", "Exercice 31 ");
                return;
            }
            if (index2 < 0 || index2 > tableau.Length)
            {
                Debug.WriteLine("Impossible d'utiliser " + index2 + " comme deuxieme index", "Exercice 31 ");
                return;
            }

            // code

            int mem = tableau[index1];
            tableau[index1] = tableau[index2];
            tableau[index2] = mem;
        }
        /// <summary>
        /// Retourne l'index du plus gros nombre du tableau donner en parametre
        /// </summary>
        /// <param name="tableau">Tableau de nombre. Doit etre au moins 1 de longueur</param>
        /// <returns>Index du plus gros nombre</returns>
        static int Exercice31(int[] tableau)
        {
            // debug

            if (tableau.Length < 1)
            {
                Debug.WriteLine("Le tableau n'est pas assez long. minimum = 1 tableau est de  " + tableau.Length, "Exercice31");
                return -1;
            }

            // code
            int num = -999999999;
            int index = 0;

            for (int i = 0; i < tableau.Length;i++)
            {
                if (tableau[i] > num)
                {
                    index = i;
                }
            }

            return index;
        }
        /// <summary>
        /// Inverse le tableau de nombre donner en parametre
        /// </summary>
        /// <remarks>Tableau doit etre au moins 2 de long</remarks>
        /// <param name="tableau">Tableau a inverser</param>
        static void Exercice32(int[] tableau)
        {
            // debug
            
            if (tableau.Length < 2)
            {
                Debug.WriteLine("Tableau est moins de 2 de long. Longueur : " + tableau.Length, "Exercice32 ");
                return;
            }

            // code

            int[] resultat = new int[tableau.Length];

            for (int i = 0; i < tableau.Length;i++)
            {
                resultat[resultat.Length-i-1] = tableau[i];
            }

            for (int j = 0;j < tableau.Length;j++)
            {
                tableau[j] = resultat[j];
            }
        }
        /// <summary>
        /// Substitue la premiere moitier et la deuxieme moitier du taableau donner en parametre
        /// </summary>
        /// <param name="tableau">Tableau de nombre. Doit etre d'une longueur pair</param>
        static void Exercice33(int[] tableau)
        {

        }
    }
}