
using TemplateGenCli.Factories;
using TemplateGenCli.Interfaces;
using TemplateGenCli.Models;

namespace TemplateGenCli;

public class CodeGenManager
{
    private readonly List<IGeneratorConfig> _configs;
    private readonly GeneratorContext _context;
    public CodeGenManager(CodeGenConfig codeGenConfig)
    {
        _context = new GeneratorContext(codeGenConfig.EntityConfig,codeGenConfig.StructureConfig);
        _configs = new List<IGeneratorConfig>
        {
            codeGenConfig.MapsterConfig,
            codeGenConfig.ServiceConfig,
            codeGenConfig.RepositoryConfig,
            codeGenConfig.DtoConfig
        };
    }

    public void Run()
    {
        foreach (var config in _configs)
        {
            if (!config.Enable) continue;

            var generator = GeneratorFactory.Create(config.Type);
            generator?.Run(config, _context);
        }
    }
}
