namespace POOCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora oCalculadora = new Calculadora(2, 3);
            oCalculadora.Sumar();
            oCalculadora.Resta();
            oCalculadora.Multiplicacion();
            oCalculadora.Divide();
        }
    }
}
