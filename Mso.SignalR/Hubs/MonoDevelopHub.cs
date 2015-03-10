using System;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using MonoDevelop.Core;
using MonoDevelop.Projects;
using MonoDevelop.Core.ProgressMonitoring;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Xml;

namespace Mso.SignalR.Hubs
{
    public class MonoDevelopHub : Hub
    {
        static MonoDevelopHub()
        {
            Runtime.Initialize(true);
        }

        public string GetBackendInfo() {
            return string.Format("MonoDevelop: {0}", MonoDevelop.Core.Runtime.Version);
        }

        public string GetSolutionInDirectory(string workspaceDir)
        {
            var slnFile = Directory.GetFiles(workspaceDir, "*.sln", SearchOption.TopDirectoryOnly).FirstOrDefault();
            var solution = Services.ProjectService.ReadWorkspaceItem(new NullProgressMonitor(), slnFile).GetAllSolutions().First();
            return string.Format("{{\"items\":[{0}]}}", solution != null ? JsonConvert.SerializeObject(solution.ToMsoObject(), new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }) : "");
        }

        private Solution CreateSolution(string dir, string name)
        {
            var solution = new Solution();
            var slnFile = Path.Combine(dir, string.Format("{0}.sln", name));
            solution.SetLocation (Path.GetDirectoryName (slnFile), Path.GetFileNameWithoutExtension (slnFile));
            solution.CreateDefaultConfigurations ();
            solution.Save (new NullProgressMonitor());
            return solution;
        }

        public static Project createProject(Solution solution, string prjName)
        {
            var doc = new XmlDocument();
            var projectOptions = doc.CreateElement("Project");
            projectOptions.SetAttribute("language", "C#");
            var pci = new ProjectCreateInformation()
            {
                ProjectName = prjName,
                ProjectBasePath = solution.BaseDirectory
            };

            var project = Services.ProjectService.CreateProject("DotNet", pci, projectOptions);
            project.BaseDirectory = Path.Combine(solution.BaseDirectory.FileNameWithoutExtension, prjName);
            Directory.CreateDirectory(project.BaseDirectory);
            project.FileName = Path.Combine(project.BaseDirectory.FullPath, prjName);
            solution.RootFolder.AddItem(project, true);
            project.Save(new NullProgressMonitor());
            solution.Save(new NullProgressMonitor());
            return project;
        }

        public static void AddProjectToSolution(Solution solution, Project project)
        {
            solution.RootFolder.AddItem(project, true);
            solution.Save(new NullProgressMonitor());
        }

        public static void RemoveProjectFromSolution(Solution solution, Project project)
        {
            solution.RootFolder.Items.Remove(project);
            solution.Save(new NullProgressMonitor());
        }
//        public async Task RenameSolutionAsync(string oldName, string newName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task CreateProjectAsync(string projectName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task DeleteProjectAsync(string projectName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task AddProjectFileAsync(string projectName, string fileName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task DeleteProjectFileAsync(string projectName, string fileName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task RenameProjectFileAsync(string projectName, string oldFileName, string newFileName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task RenameProjectAsync(string oldName, string newName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task UpdateProjectAsync(string projectName, string jsonConfig)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task SaveProjectFileAsync(string projectName, string fileName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task<string> LoadProjectFileAsync(string projectName, string fileName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task BuildSolutionAsync(string solutionName)
//        {
//            throw new NotImplementedException();
//        }
//
//        public async Task BuildProjectAsync(string projectName)
//        {
//            throw new NotImplementedException();
//        }
//
//        private string GetSolutionAsJson(Solution solution)
//        {
//            return solution.AsJson();
//        }
    }
}

