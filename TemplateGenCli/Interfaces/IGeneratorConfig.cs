using TemplateGenCli.Enums;
using TemplateGenCli.Models;

namespace TemplateGenCli.Interfaces;

public interface  IGeneratorConfig
{
    bool Enable { get; }
    GeneratorType Type { get; } 
}

public interface IGenerator
{
    void Run(IGeneratorConfig config, GeneratorContext context);
}