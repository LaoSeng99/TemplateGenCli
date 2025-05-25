namespace TemplateGenCli.Models;

public class CodeGenConfig
{
    public EntityConfig EntityConfig { get; set; }
    public MapsterConfig MapsterConfig { get; set; }
    public ServiceConfig ServiceConfig { get; set; }
    public RepositoryConfig RepositoryConfig { get; set; }
}
