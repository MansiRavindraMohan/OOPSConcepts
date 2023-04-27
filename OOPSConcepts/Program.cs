using System.Security.Cryptography.X509Certificates;

namespace OOPSConcepts
{
    class Program
    {
        public static void Main(string[] args)
        {
            Encapsulation encap = new Encapsulation();
            Console.WriteLine(encap.Name);
            encap.Name = "MANSI";
            Console.WriteLine(encap.Name);
            Console.WriteLine(encap.RollNo = 456);
            //OverLoading over =new OverLoading();
            //over.MethodOne();
            //over.MethodOne(4,"Mansi");
            //over.MethodOne(6,"mansi");
            Console.ReadKey();

        }
    }
}
