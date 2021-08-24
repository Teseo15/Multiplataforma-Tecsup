using System;

namespace rectangulo
{
    class Calculos
    {
        public Coordenada co1=new Coordenada();
        public Coordenada co2=new Coordenada();
        public Coordenada co3=new Coordenada();
        public Coordenada co4=new Coordenada();
        
        public Double Distancia(Coordenada pto1,Coordenada pto2){
        return  Math.Sqrt(Math.Pow(pto1.x-pto2.x,2)+Math.Pow(pto1.y-pto2.y,2));
        }
        public Double Area(){
        Double d=Distancia(co1,co2)*Distancia(co2,co3);
        return Math.Round(d,2);
        }
        public Double Perimetro(){
        return Math.Round(Distancia(co1,co2)*2+Distancia(co2,co3)*2 , 2);
        }
        public String vertice(){
          Double x=  co2.x -co1.x;
          Double y=  co2.y -co1.y;
          co4.x = co3.x-x;
          co4.y = co3.y-y;
          String punto = "D("+co4.x+" , "+co4.y+")";
          return punto;    
        }
    }
}
