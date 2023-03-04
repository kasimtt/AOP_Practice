using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocationApp.Aspects
{
    public class DefensiveProgrammingAspect : MethodInterception
    {
        public override void OnBefore(IInvocation invocation)
        {
            var patameters = invocation.Arguments;

            foreach (var parameter in patameters)
            {
                if (parameter.Equals(null))
                {
                    throw new ArgumentNullException("parameters cannot be null");
                }
                Console.WriteLine("null check has been completed for{0}", parameter);
            }
            Console.WriteLine("null check has been completed for {0}", invocation.Method.Name);
        }
    }
}
