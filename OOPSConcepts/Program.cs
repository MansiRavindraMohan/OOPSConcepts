using System.Security.Cryptography.X509Certificates;

namespace OOPSConcepts
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Polymorphism
            OverLoading over = new OverLoading();
            over.MethodOne();
            over.MethodOne(4, "Mansi");
            over.MethodOne(6, "mansi");
            Console.ReadKey();
        }
    }
}
