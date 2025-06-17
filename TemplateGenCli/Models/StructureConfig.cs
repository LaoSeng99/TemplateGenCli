
namespace TemplateGenCli.Models;

public class StructureConfig
{
    public bool Enable { get; set; }
    public bool RepoInterfaceModular { get; set; }
    public bool RepoImplModular { get; set; }
    public bool ServiceInterfaceModular { get; set; }
    public bool ServiceImplModular { get; set; }
    public bool MapsterModular { get; set; }
    public bool DtoModular { get; set; }
    public string ModularAttributeName { get; set; }

}
