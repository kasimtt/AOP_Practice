using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocationApp.Aspects
{
    public class InterceptorAspect : MethodInterception
    {
        public void Intercept(IInvocation invocation)
        {
           

            invocation.Proceed();
           

        }

        public override void OnBefore(IInvocation invocation)
        {
            Console.WriteLine("Begin method {0}", invocation.Method);
            Console.WriteLine($"{"Method Name",-20} : {invocation.Method.Name}");
            Console.WriteLine($"{"Target Type",-20} : {invocation.TargetType}");
            Console.WriteLine($"{"İnvocation Target",-20} : {invocation.InvocationTarget}");
            Console.WriteLine($"{"Proxy",-20} : {invocation.Proxy}");
            Console.WriteLine("ARGUEMENTS");
            foreach (var item in invocation.Arguments)
            {
                Console.WriteLine($"\t{"Type",-12} : {item.GetType(),-15} || {item}");
            }
        }

        public override void OnAfter(IInvocation invocation)
        {

            Console.WriteLine($"Last method {invocation.Method}");
        }
    }
}
