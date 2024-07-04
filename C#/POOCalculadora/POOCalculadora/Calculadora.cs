using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOCalculadora
{
    public class Calculadora
    {
        // Atributos
        public int num1;
        public int num2;

        public Calculadora(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void Sumar()
        {
            int suma =num1 + num2;
            Console.WriteLine(suma);
        }
        public void Resta()
        {
           int resta = num1 - num2;
           Console.WriteLine (resta);
        }
        public void Multiplicacion ()
        {
           int  multi = num1*num2;
           Console.WriteLine(multi);
        }

        public void Divide()
        {
            if (num2 != 0)
            {
                double division = (double)num1 / num2;
                Console.WriteLine($"División: {division}");
            }
            else
            {
                Console.WriteLine("No se puede dividir por cero.");
            }
        }
    }
}