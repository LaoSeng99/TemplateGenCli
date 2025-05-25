using Microsoft.Extensions.Configuration;
using TemplateGenCli;
using TemplateGenCli.Models;

var configuration = new ConfigurationBuilder()
          .SetBasePath(AppContext.BaseDirectory)
          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false)
          .Build();

var codeGenConfig = new CodeGenConfig();
configuration.GetSection("CodeGenConfig").Bind(codeGenConfig);

var manager = new CodeGenManager(codeGenConfig);
manager.Run();