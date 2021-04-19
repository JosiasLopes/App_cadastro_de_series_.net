using System;

namespace series
{
    class Program
    {
        static void Main(string[] args)
        {
            Serie serie = new Serie(1,Genero.Aventura,"Querida encolhi as crianças","Um cinetista maluco acabou encolhendo seus filhso sem querer",1985);
           
            Console.WriteLine(serie);
        }
    }
}
