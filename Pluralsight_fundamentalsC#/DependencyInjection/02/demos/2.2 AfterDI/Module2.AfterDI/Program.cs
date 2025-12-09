using Module2.AfterDI;
using Module2.AfterDI.Shared;
using Module2.AfterDI.Source;
using Module2.AfterDI.Target;
using Microsoft.Extensions.DepencyInjection;
using Microsoft.Extensions.Hosting;

using var host = host.CreateDefaultBuilder(args).ConfigureServices((context, services) =>
{
    services.AddTransient<Configuration>();
    services.AddTransient<IPriceParser, PriceParser>(); // registering both the inteface and the class. The container will return a PriceParser whenever an IPriceParser is requested
    services.AddTransient<IProductFormatter, ProductFormatter>();
    services.AddTransient<IProductTarget, ProductTarget>();
    
     services.AddTransient<ProductImporter>();

}).Build(); 
 //.CreateDefaultBuilder, to start a default builder for the application host and store it in a variable called 'host'
 /*ConfigureServices((context, services)), takes lambda function as an argument which take two parameters: host builder 'context' and the service collection 'services' 
 to register the types and classes we want to use. In the body of the lambda function the registrations are added. Here all the classes that are being used are listed so that 
 the container can take over instantiating classes. */

var productImporter = host.Services.GetRequiredService<ProductImporter>(); // container will look for a registration type 'ProductImporter' if there is one, it will instanstiate it and return it 
productImporter.Run();

/* Below code was used BeforeDI

var configuration = new Configuration();
var priceParser = new PriceParser();

var productSource = new ProductSource(configuration, priceParser);

var productFormatter = new ProductFormatter();

var productTarget = new ProductTarget(configuration, productFormatter);

var productImporter = new ProductImporter(productSource, productTarget);
productImporter.Run();
*/
