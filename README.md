# AspDotnet5Issue
https://github.com/dotnet/aspnetcore/issues/26882

Run test for .NET 5, reproduces the exception
```
dotnet test .\test.net5
```

Run test for .NET CORE 3.1, does not reproduce the exception
```
dotnet test .\test.netcore3.1
```

# Exception
```
  Error Message:
   System.Reflection.ReflectionTypeLoadException : Unable to load one or more of the requested types.
Could not load type 'Microsoft.AspNetCore.Components.Forms.ReadRequest' from assembly 'Microsoft.AspNetCore.Components.Web, Version=5.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60' because it contains an object field at offset 4 that is incorrectly aligned or overlapped by a non-object field.
  Stack Trace:
     at System.Reflection.RuntimeModule.GetTypes(RuntimeModule module)
   at test.MvcBuilderExtensions.<>c.<SetupValidation>b__0_1(Assembly a) in C:\work\test\test\MvcBuilderExtensions.cs:line 17
   at System.Linq.Enumerable.WhereArrayIterator`1.MoveNext()
   at test.MvcBuilderExtensions.<SetupValidation>g__RegisterValidators|0_0(FluentValidationMvcConfiguration conf) in C:\work\test\test\MvcBuilderExtensions.cs:line 17
   at FluentValidation.AspNetCore.FluentValidationMvcExtensions.AddFluentValidation(IMvcBuilder mvcBuilder, Action`1 configurationExpression) in C:\Projects\FluentValidation\src\FluentValidation.AspNetCore\FluentValidationMvcExtensions.cs:line 77
   at test.MvcBuilderExtensions.SetupValidation(IMvcBuilder builder) in C:\work\test\test\MvcBuilderExtensions.cs:line 23
   at test.Startup.ConfigureServices(IServiceCollection services) in C:\work\test\test\Startup.cs:line 18
   at System.RuntimeMethodHandle.InvokeMethod(Object target, Object[] arguments, Signature sig, Boolean constructor, Boolean wrapExceptions)
   at System.Reflection.RuntimeMethodInfo.Invoke(Object obj, BindingFlags invokeAttr, Binder binder, Object[] parameters, CultureInfo culture)
   at Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder.InvokeCore(Object instance, IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder.<>c__DisplayClass9_0.<Invoke>g__Startup|0(IServiceCollection serviceCollection)
   at Microsoft.AspNetCore.Hosting.StartupLoader.ConfigureServicesDelegateBuilder`1.<>c__DisplayClass15_1.<BuildStartupServicesFilterPipeline>g__InvokeStartup|1(IServiceCollection serviceCollection)
   at Microsoft.AspNetCore.TestHost.WebHostBuilderExtensions.ConfigureTestServicesStartupConfigureServicesFilter.<>c__DisplayClass2_0.<ConfigureServices>b__0(IServiceCollection serviceCollection)
   at Microsoft.AspNetCore.Hosting.StartupLoader.ConfigureServicesDelegateBuilder`1.<>c__DisplayClass15_0.<BuildStartupServicesFilterPipeline>g__RunPipeline|0(IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder.Invoke(Object instance, IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.ConfigureServicesBuilder.<>c__DisplayClass8_0.<Build>b__0(IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.StartupLoader.ConfigureServicesDelegateBuilder`1.<>c__DisplayClass14_0.<ConfigureServices>g__ConfigureServicesWithContainerConfiguration|0(IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.ConventionBasedStartup.ConfigureServices(IServiceCollection services)
   at Microsoft.AspNetCore.Hosting.WebHost.EnsureApplicationServices()
   at Microsoft.AspNetCore.Hosting.WebHost.Initialize()
   at Microsoft.AspNetCore.Hosting.WebHostBuilder.Build()
   at Microsoft.AspNetCore.TestHost.TestServer..ctor(IWebHostBuilder builder, IFeatureCollection featureCollection)
   at Microsoft.AspNetCore.TestHost.TestServer..ctor(IWebHostBuilder builder)
   at test.integration.Example.Test1() in C:\work\test\test.integration\Example.cs:line 12
--- End of stack trace from previous location ---
```
