using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_C_
{
    public class Cerveza
    {
        // Atributos (Características).
        public int Amargor { get; set;}
        public decimal Alcohol { get; set;}
        public int TiempoFermentacion { get; set;}

        public Cerveza (int amargor, decimal alcohol, int tiempoFermentacion )
        {
          this.Amargor = amargor;
          this.Alcohol = alcohol;
          this.TiempoFermentacion = tiempoFermentacion;

        }



        //Método (Acción).
        public void Fermentacion()
        {
            for(int i = 0;i<TiempoFermentacion;i++) 
            Console.WriteLine("Se fermentó");
        }

    }
}
