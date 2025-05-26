using TemplateGenCli.Enums;
using TemplateGenCli.Interfaces;

namespace TemplateGenCli.Models;
public class ServiceConfig : IGeneratorConfig
{
    public bool Enable { get; set; }
    public string OutputPath { get; set; }
    public string Namespace { get; set; }
    public string InterfaceOutput { get; set; }
    public string InterfaceNamespace { get; set; }
    public string RepoInterfaceNamespace { get; set; }
    public string StartMark { get; set; }
    public string EndMark { get; set; }
    public string DiFilePath { get; set; }
    public GeneratorType Type { get; set; } = GeneratorType.Service;
}
