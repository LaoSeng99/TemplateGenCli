namespace TemplateGenCli.Models;
public class EntityConfig
{
    public string Path { get; set; }
    public string Namespace { get; set; }
    public List<string> ExceptEntities { get; set; } = [];
}
