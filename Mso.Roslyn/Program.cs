using System;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis;
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
          //  GetSolutionInDirectory(path);
            CreateSolution();
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

        public static void CreateSolution()
        {
            throw new NotSupportedException();
        }

        public static void NotMain ()
        {
//            var provider = new DpapiDataProtectionProvider ();
//            var protector = provider.Create ("SignalR.ConnectionToken");
//            var b = Encoding.UTF8.GetBytes ("d01b35ad-d712-433f-b8a7-58d00a2d0f52:");
//            var un = Convert.ToBase64String (protector.Protect (b));
//            Console.WriteLine (un);
//             var ree = protector.Unprotect (Convert.FromBase64String(un));
//            Console.WriteLine ("ree:{0}",Encoding.UTF8.GetString(ree));
//            Console.WriteLine ("Hello World!");
        }
    }
}
