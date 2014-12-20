using System;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Hubs;

namespace Mso.SignalR.Hubs
{
    public class MonoDevelopHub : Hub<IMonoDevelopService>
    {
        public async Task ClearWorkspace()
        {
            throw new NotImplementedException();
        }

        public async Task RenameSolutionAsync(string oldName, string newName)
        {
            throw new NotImplementedException();
        }

        public async Task CreateProjectAsync(string projectName)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProjectAsync(string projectName)
        {
            throw new NotImplementedException();
        }

        public async Task AddProjectFileAsync(string projectName, string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProjectFileAsync(string projectName, string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task RenameProjectFileAsync(string projectName, string oldFileName, string newFileName)
        {
            throw new NotImplementedException();
        }

        public async Task RenameProjectAsync(string oldName, string newName)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProjectAsync(string projectName, string jsonConfig)
        {
            throw new NotImplementedException();
        }

        public async Task SaveProjectFileAsync(string projectName, string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task<string> LoadProjectFileAsync(string projectName, string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task BuildSolutionAsync(string solutionName)
        {
            throw new NotImplementedException();
        }

        public async Task BuildProjectAsync(string projectName)
        {
            throw new NotImplementedException();
        }
    }
}

