namespace TemplateGenCli.Models;

public class CodeGenConfig
{
    public StructureConfig StructureConfig { get; set; }
    public EntityConfig EntityConfig { get; set; }
    public MapsterConfig MapsterConfig { get; set; }
    public ServiceConfig ServiceConfig { get; set; }
    public RepositoryConfig RepositoryConfig { get; set; }
    public DtoConfig DtoConfig { get; set; }
}
