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

namespace Mso.SignalR.Hubs
{
    public class MonoDevelopHub : Hub
    {
        static MonoDevelopHub()
        {
            Runtime.Initialize(true);
        }

        public string GetSolutionInDirectory(string workspaceDir)
        {
            var slnFile = Directory.GetFiles(workspaceDir, "*.sln", SearchOption.TopDirectoryOnly).FirstOrDefault();
            var solution = Services.ProjectService.ReadWorkspaceItem(new NullProgressMonitor(), slnFile).GetAllSolutions().First();
            return string.Format("{{\"items\":[{0}]}}", solution != null ? JsonConvert.SerializeObject(solution.ToMsoObject(), new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }) : "");
        }

//        public async Task ClearWorkspace()
//        {
//            throw new NotImplementedException();
//        }
//
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

