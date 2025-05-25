
using TemplateGenCli.Enums;
using TemplateGenCli.Interfaces;

namespace TemplateGenCli.Factories;

public static class GeneratorFactory
{
    public static IGenerator? Create(GeneratorType type)
    {
        return type switch
        {
            GeneratorType.Mapster => new MapsterGenerator(),
            GeneratorType.Service => new ServiceGenerator(),
            GeneratorType.Repository => new RepositoryGenerator(),
            _ => null
        };
    }
}
