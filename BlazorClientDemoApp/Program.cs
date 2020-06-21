using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace BlazorClientDemoApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app"); //where the app starts.

            //services! where to add DI.
            builder.Services.AddTransient(sp => new HttpClient 
            {
                //BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
                BaseAddress = new Uri("https://api.whichaspnetcore.com/")  //this is pointing to Tim's API app.
                                                                            //if he ever changes that, this won't work.
            });

            await builder.Build().RunAsync();
        }
    }
}
