using System;
using Microsoft.CodeAnalysis.MSBuild;
using System.IO;
using System.Linq;

namespace Mso.Roslyn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GetSolutionInDirectory("/home/alex/SampleProjects");
            Console.WriteLine("Hello World!");
        }

        public static string GetSolutionInDirectory(string workspaceDir)
        {
            var slnFile = Directory.GetFiles(workspaceDir, "*.sln", SearchOption.TopDirectoryOnly).FirstOrDefault();
            Console.WriteLine(slnFile);
            var ws = MSBuildWorkspace.Create();
            var solution = ws.OpenSolutionAsync(slnFile).Result;
            Console.WriteLine(solution.FilePath);
            return "{}";
        }
    }
}
