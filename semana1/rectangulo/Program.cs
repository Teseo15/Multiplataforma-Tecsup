using System;
namespace rectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Calculos x = new Calculos();
           
            Console.WriteLine("Ingresar coordenada del Punto A");
 	            Console.Write("x: ");
                x.co1.x=Double.Parse(Console.ReadLine());
                Console.Write("y: ");
                x.co1.y=Double.Parse(Console.ReadLine());
                     
            Console.WriteLine("Ingresar coordenada del Punto B");
                Console.Write("x: ");
                x.co2.x=Double.Parse(Console.ReadLine());
                Console.Write("y: ");
		        x.co2.y=Double.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar coordenada del Punto C");
                Console.Write("x: ");
                x.co3.x=Double.Parse(Console.ReadLine());
                Console.Write("y: ");
		        x.co3.y=Double.Parse(Console.ReadLine());

            Console.WriteLine("coordenada del Punto D");
            Console.WriteLine(x.vertice());

            Console.WriteLine("El área del rectangulo es: "+ x.Area());
            Console.WriteLine( "El perimetro del rectangulo es: "+x.Perimetro());
        }

    }
}
