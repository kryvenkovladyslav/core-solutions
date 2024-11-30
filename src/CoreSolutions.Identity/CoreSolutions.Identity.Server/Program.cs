namespace CoreSolutions.Identity.Server
{
    public sealed class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();
  
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var assemblyName = typeof(Program).Assembly.FullName!;
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(builder => builder.UseStartup(assemblyName));
        }
    }
}