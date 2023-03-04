// See https://aka.ms/new-console-template for more information

using Castle.Components.DictionaryAdapter;
using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspects;
using System.Security.Cryptography.X509Certificates;

namespace InvocationApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
            var proxy = new ProxyGenerator();
            var aspect = proxy.CreateClassProxy<Employee>(
                 new DefensiveProgrammingAspect(),
                new InterceptorAspect()
                );

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "kasim",
                LastName = "tatli"
                
            };

            aspect.Add(employee.Id, employee.FirstName,employee.LastName);

             
        }
    }
}



