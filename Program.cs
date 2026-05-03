
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine($"Version: {version}");
Console.WriteLine($"Plataforma: {Environment.OSVersion}");
Console.WriteLine($".Net Version: {Environment.Version}");
Console.WriteLine();
Console.WriteLine("Estructura del proyecto:");
Console.WriteLine(" InventarioApp/");
Console.WriteLine("  ├── Program.cs");
Console.WriteLine("  ├── InventarioApp.csproj");
Console.WriteLine("  ├── .gitignore");
Console.WriteLine("  ├── README.md");
Console.WriteLine("  ├── src/");
Console.WriteLine("  │   └── Models/ Proxima clase");
Console.WriteLine("Configuracion .csproj");
Console.WriteLine("Carpeta src/ Creada");
Console.WriteLine("Metadatos configurados");
Console.WriteLine("Proximo paso: Checkpoint");