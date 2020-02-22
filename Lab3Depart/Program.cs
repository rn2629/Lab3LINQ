using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3Depart
{
    public class Program
    {
        static void Main(string[] args)
        {
            var fruits = new List<Fruit>()
            {
                new Fruit() { Nom = "Abricot"},   new Fruit() { Nom = "Banane"},    new Fruit() { Nom = "Cerise"},  new Fruit() { Nom = "Datte"},
                new Fruit() { Nom = "Framboise"}, new Fruit() { Nom = "Grenade"},   new Fruit() { Nom = "Kiwi"},    new Fruit() { Nom = "Lime"},
                new Fruit() { Nom = "Mangue"},    new Fruit() { Nom = "Nectarine"}, new Fruit() { Nom = "Olive"},   new Fruit() { Nom = "Pomme"}
            };

            var personnes = new List<Personne>()
            {
                new Personne() { Nom = "Alice", Genre = 'F', Age = 22,   FruitsAimes = new List<Fruit>() { fruits[0], fruits[1], fruits[10] } },
                new Personne() { Nom = "Bob", Genre = 'M', Age = 12,     FruitsAimes = new List<Fruit>() { fruits[4], fruits[5], fruits[6], fruits[7], fruits[8] } },
                new Personne() { Nom = "Charlie", Genre = 'M', Age = 31, FruitsAimes = new List<Fruit>() { fruits[0], fruits[1], fruits[4], fruits[11] } },
                new Personne() { Nom = "Diane", Genre = 'F', Age = 45,   FruitsAimes = new List<Fruit>() { fruits[2], fruits[4] } },
                new Personne() { Nom = "Eve", Genre = 'F', Age = 4,      FruitsAimes = new List<Fruit>() { } }
  
            };

            var query = personnes.Where(p => p.Age < 18);
                                     

            LinqExo le = new LinqExo();

            Console.WriteLine("Les fruits qui contiennent la lettre A sont : ");
            var reponse = le.ContientA(fruits);
            Console.WriteLine ($"{string.Join(separator: ", ", values: reponse)}");
        
            Console.Read();
            Console.WriteLine("-------------------------");

            Console.WriteLine("Les personnes mineurs sont (par Extension): ");
            var reponse1 = le.EnfantsE(personnes);
            Console.WriteLine($"{string.Join(separator: ", ", values: reponse1)}");

            Console.Read();
            Console.WriteLine("-------------------------");

            Console.WriteLine("Les personnes mineurs sont (par Syntaxe) : ");
            var reponse2 = le.EnfantsS(personnes);
            Console.WriteLine($"{string.Join(separator: ", ", values: reponse2)}");

            Console.Read();
            Console.WriteLine("-------------------------");

            Console.WriteLine("La Plus vielle est (par Extension) : ");
            var reponse3 = le.LaPlusVielleE(personnes);
            Console.WriteLine($"{string.Join(separator: ", ", values: reponse3)}");

            Console.Read();
            Console.WriteLine("-------------------------");

            Console.WriteLine("La Plus vielle est (par syntaxe) : ");
            var reponse4 = le.LaPlusVielleS(personnes);
            Console.WriteLine($"{string.Join(separator: ", ", values: reponse4)}");

            Console.Read();
            Console.WriteLine("-------------------------");

            Console.WriteLine("Fruits par Ordre decroissant de popularité des personnes  (par Extension): ");
            var reponse5 = le.FruitsFavorisE(personnes);
            Console.WriteLine($"{string.Join(separator: ", ", values: reponse5)}");

            Console.Read();
            Console.WriteLine("-------------------------");


            Console.WriteLine("Fruits par Ordre decroissant de popularité des personnes (par Syntaxe): ");
            var reponse6 = le.FruitsFavorisS(personnes);
            Console.WriteLine($"{string.Join(separator: ", ", values: reponse6)}");


            Console.Read();
            Console.WriteLine("-------------------------");


            LinqExo parGenreRun = new LinqExo();
            parGenreRun.ParGenre(personnes);

            Console.Read();
            Console.WriteLine("-------------------------");

            LinqExo MoyAgeFruitsRun = new LinqExo();
            MoyAgeFruitsRun.MoyennAgeTotalFruit(personnes, fruits);

            Console.Read();






        }
    }
}
