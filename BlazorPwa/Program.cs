using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Components.Builder;

namespace BlazorPwa
{
    class Program
    {
        static void Main() => BlazorWebAssemblyHost.CreateDefaultBuilder().UseBlazorStartup<Startup>().Build().Run();
    
        class Startup
        {
            public void Configure(IComponentsApplicationBuilder b) => b.AddComponent<Body>("body");
        }
    }
}