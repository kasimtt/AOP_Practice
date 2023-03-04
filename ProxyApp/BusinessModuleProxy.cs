using System;

namespace ProxyApp
{
    public partial class Program
    {
        public class BusinessModuleProxy:IBusinessModule
        {

            BusinessModule businessModule;

            public BusinessModuleProxy()
            {
                   businessModule = new BusinessModule();
            }
            

            public void Method()
            {
                Console.WriteLine("before business");
                businessModule.Method();
                Console.WriteLine("after business");
            }
        }
    }
}
