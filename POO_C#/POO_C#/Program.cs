namespace POO_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //Contructor.
            Cerveza oCerveza = new Cerveza(5, 6.5M, 30);
            oCerveza.Fermentacion();
        }
    }
}
