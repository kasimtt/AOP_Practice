using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interceptors
{
    [AttributeUsage(
        AttributeTargets.Method|
        AttributeTargets.Property|
        AttributeTargets.Class|
        AttributeTargets.Assembly,
        AllowMultiple = true,
        Inherited = true
        )]
    public abstract class MethodInterceptionBaseAttribute : Attribute, IInterceptor
    {
        public int Priority;
        public virtual void Intercept(IInvocation invocation)
        {
            
        }
    }
}
