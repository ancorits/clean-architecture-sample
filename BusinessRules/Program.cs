using AlternativeBusinessService;
using BusinessFacade;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BusinessRules
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ICalculator, AlternativeCalculator>()
                .BuildServiceProvider();

            var calc = serviceProvider.GetService<ICalculator>();
            int result = calc.Add(2,3);


        }
    }
}
