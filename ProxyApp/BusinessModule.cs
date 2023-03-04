using System;

namespace ProxyApp
{
    public partial class Program
    {
        public class BusinessModule : IBusinessModule
        {
            
            public void Method()
            {
                Console.WriteLine("method..");
            }
        }
    }
}
