
namespace TemplateGenCli.Models;

public class GeneratorContext
{
    public EntityConfig EntityConfig { get; }
    public StructureConfig StructureConfig { get; }

    public GeneratorContext(EntityConfig entityConfig, StructureConfig structureConfig)
    {
        EntityConfig = entityConfig;
        StructureConfig = structureConfig;
    }
}