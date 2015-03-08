using System;
using Microsoft.CodeAnalysis.MSBuild;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Mso.Roslyn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var path = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "..", "..", ".."));
            Console.WriteLine(path);
            GetSolutionInDirectory(path);
        }

        public static string GetSolutionInDirectory(string workspaceDir)
        {
            var slnFile = Directory.GetFiles(workspaceDir, "*.sln", SearchOption.TopDirectoryOnly).FirstOrDefault();
            Console.WriteLine(slnFile);
            var ws = MSBuildWorkspace.Create();
            var solution = ws.OpenSolutionAsync(slnFile).Result;
            foreach (var p in solution.Projects)
            {
                Console.WriteLine(p.Name);
                foreach (var r in p.ProjectReferences)
                {
                    Console.WriteLine(r.ProjectId);
                }
                foreach (var r in p.MetadataReferences)
                {
                    Console.WriteLine(r.Display);
                }
                foreach (var d in p.Documents)
                {
                    Console.WriteLine(d.FilePath);
                }
            }
            //Console.WriteLine(solution.FilePath);
            return "{}";
        }
    }
}
