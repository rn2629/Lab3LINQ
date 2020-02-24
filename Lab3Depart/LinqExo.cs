using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Lab3Depart
{
    public class LinqExo
    {
        public IEnumerable<Fruit> ContientA(IEnumerable<Fruit> fruits)
        {
            return fruits.Where(f => f.Nom.ToUpper().Contains("A")); /* Methode d'extension */
        }
        public IEnumerable<Fruit> ContientAS(IEnumerable<Fruit> fruits)
        {
            var query = from f in fruits
                        where f.Nom.ToUpper().Contains("A")
                        select f; /* Methode de Syntaxe */

            return query;
        }

            public IEnumerable<Personne> EnfantsE(IEnumerable<Personne> personnes)
        {
            return personnes.Where(p => p.Age < 18); /* Methode d'extension */
        }

        public IEnumerable<Personne> EnfantsS(IEnumerable<Personne> personnes)
        {
            var query = from p in personnes
                        where p.Age < 18
                        select p; /* Methode de Syntaxe */

            return query;
        }
            public Personne LaPlusVielleS(IEnumerable<Personne> personnes)
        {
            return personnes.Where(p => p.Age == personnes.Max(m => m.Age)).Max(); /* Methode d'extension */
        }
        public Personne LaPlusVielleE(IEnumerable<Personne> personnes)
        {
             var query =  from p in personnes
                        where p.Age == personnes.Max(m => m.Age)
                        select p;

            return query.FirstOrDefault(); /* Methode de Syntaxe */

        }

            public IEnumerable<Fruit> FruitsFavorisE(IEnumerable<Personne> personnes)
        {
            var fruits = personnes.SelectMany(p => p.FruitsAimes); /* Methode d'extension */
            return fruits.GroupBy(p => p.Nom).OrderByDescending(f => f.Count()).Select(f => f.First()); /* Methode d'extension */
        }

        public IEnumerable<Fruit> FruitsFavorisS(IEnumerable<Personne> personnes)
        {
            var query = from p in personnes
                        from f in p.FruitsAimes
                        group f by f.Nom into f1
                        orderby f1.Count() descending
                        select f1.First(); /* Methode de Syntaxe */

            return query;

        }

        public void ParGenre(IEnumerable<Personne> personnes)
        { 

            var genres = from p in personnes
                         group p by p.Genre into g
                         select new { Char = g.Key, Min = g.Min(p => p.Age), Max = g.Max(p => p.Age), Count = g.Count() };


            foreach(var g in genres)
            {
                Console.WriteLine("Genre: " + g.Char);
                Console.WriteLine("Nombre de personnes de ce genre: " + g.Count);
                Console.WriteLine("Age de la personne la plus vielle de ce genre: " + g.Max);
                Console.WriteLine("Age de la personne la plus jeune  de ce genre: " + g.Min);
            }

        }

        public void MoyennAgeTotalFruit (IEnumerable<Personne> personnes, IEnumerable<Fruit> fruits)  /*** MYSTERE ***/
        {
            
            var genres = from p in personnes
                         from f in p.FruitsAimes
                         group p by p.Genre into g  
                         select new { Char = g.Key, Average = g.Average(p => p.Age), Count = g.Count() };

            foreach (var g in genres)
            {
                Console.WriteLine("Genre: " + g.Char);
                Console.WriteLine("Nombre de personnes de ce genre: " + g.Count);
                Console.WriteLine("Moyenne d'age des personnes de ce genre : " + g.Average);
                Console.WriteLine("Nombres totals de fruits: " + g.Count);
            }

        }

    }
}
