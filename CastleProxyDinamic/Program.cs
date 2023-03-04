// See https://aka.ms/new-console-template for more information

using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interceptors;
namespace CastleProxyDinamic
{

    public class Program
    {
        static void Main(string[] args)
        {
            var Proxy = new ProxyGenerator();
            var Aspect = Proxy.CreateClassProxy<MyClass>( new MyInterceptorAspect());

            Aspect.MyMethod();
            Console.ReadLine();
            var builder = new ContainerBuilder();
            builder.RegisterType<MyClass>().As<IMyClass>().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
               
                Selector = new AspectInterceptorSelector()
            }).SingleInstance(); 
        }
    }

}