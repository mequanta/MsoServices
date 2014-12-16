using System;
using System.Threading.Tasks;

namespace Mso.EdgeJs
{
    public class MonoDevelopService
    {
        private string basePath;

        public MonoDevelopService(string basePath)
        {
            this.basePath = basePath;
        }

        public async void ClearWorkspace()
        {
            throw new NotImplementedException();
        }

        public async void RenameSolutionAsync(string oldName, string newName)
        {
            throw new NotImplementedException();
        }

        public async void CreateProjectAsync(string projectName)
        {
            throw new NotImplementedException();
        }

        public async void DeleteProjectAsync(string projectName)
        {
            throw new NotImplementedException();
        }

        public async void AddProjectFileAsync(string projectName, string fileName)
        {
            throw new NotImplementedException();
        }

        public async void DeleteProjectFileAsync(string projectName, string fileName)
        {
            throw new NotImplementedException();
        }

        public async void RenameProjectFileAsync(string projectName, string oldFileName, string newFileName)
        {
            throw new NotImplementedException();
        }

        public async void RenameProjectAsync(string oldName, string newName)
        {
            throw new NotImplementedException();
        }

        public async void UpdateProjectAsync(string projectName, string jsonConfig)
        {
            throw new NotImplementedException();
        }

        public async void SaveProjectFileAsync(string projectName, string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task<string> LoadProjectFileAsync(string projectName, string fileName)
        {
            throw new NotImplementedException();
        }

        public async void BuildSolutionAsync(string solutionName)
        {
            throw new NotImplementedException();
        }

        public async void BuildProjectAsync(string projectName)
        {
            throw new NotImplementedException();
        }
    }
}
