
namespace TemplateGenCli.Models;

public class GeneratorContext
{
    public EntityConfig EntityConfig { get; }

    public GeneratorContext(EntityConfig entityConfig)
    {
        EntityConfig = entityConfig;
    }
}