using Microsoft.AspNetCore.Mvc.Internal;
using Microsoft.Extensions.DependencyModel;
using System.IO;
using System.Linq;

namespace WebApplication23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parts = DefaultAssemblyPartDiscoveryProvider.DiscoverAssemblyParts("WebApplication23");
            foreach (var item in parts)
            {
                System.Console.WriteLine(item.Name);
            }
        }
    }
}
