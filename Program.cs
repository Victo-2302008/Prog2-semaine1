using System.Globalization;
using System.Linq.Expressions;

namespace semaine1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
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

        
    }
}