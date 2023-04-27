using System.Security.Cryptography.X509Certificates;

namespace OOPSConcepts
{
    class Program
    {
        public static void Main(string[] args)
        {
            TypeCasting obj = new TypeCasting();
            obj.Method();
            ValueType type = new ValueType();
            type.MethodValueType();
            ReferenceType typeOne = new ReferenceType();
            int value = 5;
            Console.WriteLine(value);
            typeOne.MethodReferenceType(ref value);
            Console.WriteLine(value);
            //Encapsulation encap=new Encapsulation();
            //Console.WriteLine(encap.Name);
            //encap.Name = "MANSI";
            //Console.WriteLine(encap.Name);
            //Console.WriteLine(encap.RollNo=456);
            //OverLoading over =new OverLoading();
            //over.MethodOne();
            //over.MethodOne(4,"Mansi");
            //over.MethodOne(6,"mansi");
            Console.ReadKey();

        }
    }
}
