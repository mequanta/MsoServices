using System;
using MonoDevelop.Core;

namespace Mso.MonoDevelop.Tests
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            Runtime.Initialize (true);
            var service = global::MonoDevelop.Projects.Services.ProjectService;
            foreach (var binding in global::MonoDevelop.Projects.LanguageBindingService.LanguageBindings) {
                Console.WriteLine ("binding: {0}", binding.Language);
            }
            //          Runtime.Initialize (true);
            //          var service = MonoDevelop.Projects.Services.ProjectService;
            //          foreach (var binding in LanguageBindingService.LanguageBindings) {
            //              Console.WriteLine ("binding: {0}", binding.Language);
            //          }
            //          Solution solution = (Solution)service.ReadWorkspaceItem(new NullProgressMonitor(),  "e:\\tess2.sln");
            //          Console.WriteLine (solution.FileName);
            //      CreateNewSolution ("e:\\", "Tees2");
            //      CreateNewProject ("e:\\Tees.cs");
            //          Solution solution1 = service.GetWrapperSolution(new NullProgressMonitor(), dd);
            //          Console.WriteLine (solution1.FileName);
            //          foreach (var p in solution1.GetAllProjects())
            //              Console.WriteLine (p.Name);
            //  var context = new ExecutionContext (Runtime.ProcessService.DefaultExecutionHandler, IdeApp.Workbench.ProgressMonitors, IdeApp.Workspace.ActiveExecutionTarget);
            //          var context = null;
            //          ExecuteFile ("e:\\Program.cs", context);

            //          var p = Project.LoadProject ("C:\\Users\\Alex\\KSB2BClient\\B2BClient.vcxproj");
            //          Console.WriteLine("project: {0}",p)
            //ExecuteFile ("e:\\Program.cs", null);
            //CreateNewSolution ();
            //  Console.ReadKey ();
        }

        //      public static IAsyncOperation ExecuteFile (string file, ExecutionContext context)
        //      {
        //          Project tempProject = MonoDevelop.Projects.Services.ProjectService.CreateSingleFileProject (file);
        //          //          var info = new ProjectCreateInformation ();
        //          //          info.SolutionName = "Solu1";
        //          //          info.SolutionPath = "e:\\Tee\\Solu";
        //          //          info.ProjectName = "MyProj";
        //          //          info.ProjectBasePath = new FilePath("c:\\Tee\\Solu\\Proj1");
        //
        //          /// var projectOptions = new XmlElement ();
        //          //  projectOptions.SetAttribute ("language", "C");
        //          //  Project tempProject = MonoDevelop.Projects.Services.ProjectService.CreateProject("DotNet", info, null);
        //
        //          if (tempProject != null) {
        //              Console.WriteLine (tempProject);
        //              //var config = ConfigurationSelector.Default;
        //
        //              foreach(var t in tempProject.GetExecutionTargets (ConfigurationSelector.Default))
        //                  Console.WriteLine("target:{0}",t);
        //
        //              Console.WriteLine(tempProject.CanExecute (context,  ConfigurationSelector.Default));
        //
        //
        //
        //              //  IAsyncOperation aop = Execute (tempProject, context);
        //              //  aop.Completed += delegate { tempProject.Dispose (); };
        //              //              return aop;
        //          } else {
        //              //          //  MessageService.ShowError(GettextCatalog.GetString ("No runnable executable found."));
        //              return NullAsyncOperation.Failure;
        //          }
        //          return NullAsyncOperation.Failure;
        //      }
        //
        //      static void CreateNewSolution(string path, string name)
        //      {
        //          Solution item = new Solution ();
        //          item.SetLocation(path, name);
        //          item.Save(new NullProgressMonitor());
        //      }
        //
        //      static void CreateNewProject(string name)
        //      {
        //          //          var option = new XmlElement ();
        //          //          var ci = new ProjectCreateInformation ();
        //          //          var project = Services.ProjectService.CreateProject ("CSharp", ci, option);
        //          //          project.Save (new NullProgressMonitor ());
        //          //
        //          //
        //          string file = name;
        //          var info = new ProjectCreateInformation ();
        //          info.ProjectName = Path.GetFileNameWithoutExtension (file);
        //          info.SolutionPath = Path.GetDirectoryName (file);
        //          info.ProjectBasePath = Path.GetDirectoryName (file);
        //          XmlDocument doc = new XmlDocument();
        //          var option = doc.CreateElement ("what");
        //          option.SetAttribute ("language", "C#");
        //          Project project = Services.ProjectService.CreateProject("DotNet", info, option);
        //
        //          //  Project project = Services.ProjectService.CreateSingleFileProject ("e:\\backup\\Program.cs");
        //          project.Save (new NullProgressMonitor ());
        //      }
    }
}
