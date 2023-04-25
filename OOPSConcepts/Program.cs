namespace OOPSConcepts
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClassName name= new ClassName();
            name.WithoutImplementationMethod();
            Constructor obj=new Constructor();
            obj.WithoutImplementationMethod();
            //this is enum
            Console.WriteLine(Project.Mansi);
            int count=(int) Project.Mansi;
            Console.WriteLine(count);
            //Inheritance
            ParentClass parent= new ParentClass();
            Console.WriteLine(parent.name = "Mansi");
            parent.TestName();
            parent.Class();

            //name.PrintName();
            //name.PrintType("MANSI");
            //name.Number();
            //name.NumberTwo(145,255,367);
            //Constructor obj= new Constructor();
            //Console.ReadKey();
        }
    }
}
