
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using TemplateGenCli.Models;

namespace TemplateGenCli.Extensions;

public static class StringExtensions
{
    public static string GetModularName(this string file, string modularName)
    {
        if (string.IsNullOrWhiteSpace(file) || !File.Exists(file))
            return "";

        if (string.IsNullOrEmpty(modularName))
        {
            Console.WriteLine($"Modular Name not found : {modularName}");
            return "";
        }

        var fileContent = File.ReadAllText(file);
        if (string.IsNullOrWhiteSpace(fileContent))
            return "";

        var tree = CSharpSyntaxTree.ParseText(fileContent);
        var root = tree.GetRoot();

        var classNode = root?.DescendantNodes()
                            .OfType<ClassDeclarationSyntax>()
                            .FirstOrDefault();

        if (classNode == null || classNode.AttributeLists.Count == 0)
            return "";

        foreach (var attr in classNode.AttributeLists.SelectMany(a => a.Attributes))
        {
            var attrName = attr?.Name?.ToString().Trim('"');
            if (string.IsNullOrEmpty(attrName))
                continue;

            if (attrName.Contains(modularName))
            {
                var arg = attr?.ArgumentList?.Arguments.FirstOrDefault();
                var moduleName = arg?.ToString().Trim('"');
                if (!string.IsNullOrWhiteSpace(moduleName))
                    return moduleName;
            }
        }

        return "";
    }

    public static List<string> GetEntitiesFilePath(this string path, List<string> exceptEntities)
    {
        if (exceptEntities.Any(e => e.Contains(" ")))
        {
            Console.WriteLine("Warning: Entity exclusion list may contain invalid names. Make sure they match exact entity class names.");
        }

        var excluded = new HashSet<string>(
            exceptEntities ?? Enumerable.Empty<string>(),
            StringComparer.OrdinalIgnoreCase
        );

        var entityFiles = Directory.GetFiles(path, "*.cs")
            .Where(filePath =>
            {
                var className = Path.GetFileNameWithoutExtension(filePath);
                return !excluded.Contains(className);
            })
            .ToList();

        return entityFiles;
    }

}
