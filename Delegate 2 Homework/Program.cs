namespace Delegate_2_Homework
{
    public delegate void Func(string str); 
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");

            var str = Console.ReadLine();
            MyClass cls = new MyClass();
            Func funcDell = cls.Reverse; // params sadece sizin ora vereceyiniz parametrlerdi	
            funcDell += cls.Space;
            //burda funcDell-e functionlari verirsiniz

            Run run = new Run();
            run.RunFunc(funcDell, str); //cagiranda Space() ve Reverse() functionlari ise dusmelidir

        }
    }
}