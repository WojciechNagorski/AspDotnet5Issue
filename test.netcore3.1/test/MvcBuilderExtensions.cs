using System;
using System.Linq;
using System.Reflection;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using test.Validators;

namespace test
{
    public static class MvcBuilderExtensions
    {
        public static IMvcBuilder SetupValidation(this IMvcBuilder builder)
        {
            static void RegisterValidators(FluentValidationMvcConfiguration conf)
            {
                Console.WriteLine("Register");
                foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies().Where(a => !a.IsDynamic && a.DefinedTypes.Any(t => typeof(IRequestValidator).GetTypeInfo().IsAssignableFrom(t) && !t.IsAbstract)))
                {
                    conf.RegisterValidatorsFromAssembly(assembly);
                }
            }

            return builder.AddFluentValidation(RegisterValidators);
        }
    }
}