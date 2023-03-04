// See https://aka.ms/new-console-template for more information

namespace CastleProxyDinamic
{
    public interface IMyClass
    {
        void MyMethod();
    }

    public class MyClass : IMyClass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("MyMehtod Body");
        }
    }

}