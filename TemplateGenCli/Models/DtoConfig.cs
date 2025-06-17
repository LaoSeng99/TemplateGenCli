
using TemplateGenCli.Enums;
using TemplateGenCli.Interfaces;

namespace TemplateGenCli.Models;

public class DtoConfig : IGeneratorConfig
{
    public bool Enable { get; set; }
    public string OutputPath { get; set; }
    public string Namespace { get; set; }
    public GeneratorType Type { get; set; } = GeneratorType.Dto;

}
