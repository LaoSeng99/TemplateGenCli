using TemplateGenCli.Enums;
using TemplateGenCli.Interfaces;

namespace TemplateGenCli.Models;
public class MapsterConfig: IGeneratorConfig
{
    public bool Enable { get; set; }
    public string Namespace { get; set; }
    public string OutputPath { get; set; }
    public string ConfigFile { get; set; }
    public string StartMark { get; set; }
    public string EndMark { get; set; }
    public GeneratorType Type { get; set; } = GeneratorType.Mapster;    
}
