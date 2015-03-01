using System;
using System.IO;
using MonoDevelop.Projects;
using System.Collections.Generic;

namespace MonoDevelop.Projects
{
    class ProjectFolder
    {
    }

    public static class MsoExtensions
    {
        public static string AsJson(this Workspace workspace)
        {
            foreach (var item in workspace.Items)
                Console.WriteLine("{0}", item.Name);
            return "{}";
        }

        public static string AsJson(this WorkspaceItem item)
        {
            if (item is Workspace)
                Console.WriteLine((item as Workspace).FileName);
            else if (item is Solution)
                Console.WriteLine((item as Solution).Name);
            else if (item is UnknownWorkspaceItem)
                Console.WriteLine("UnknownWorkspaceItem");
            return "{}";
        }

        public static string AsJson(this Solution solution)
        {
         //   var hasChildren = solution.RootFolder.Items.Count || solution.RootFolder.Files.Count;
            foreach (var item in solution.RootFolder.Items)
                Console.WriteLine(item.Name);
            foreach (var item in solution.RootFolder.Files)
                Console.WriteLine(item.FullPath);
            return "{}";
        }

        public static string AsJson(this SolutionItem item)
        {
            if (item is Project)
                Console.WriteLine((item as Project).Name);
            else if (item is SolutionFolder)
                Console.WriteLine((item as SolutionFolder).Name);
            return "{}";
        }

        public static string AsJson(this ProjectFile file)
        {
            var label = file.Link.IsNullOrEmpty ? file.FilePath.FileName : file.Link.FileName;
            if (file.HasChildren)
                foreach(var f in file.DependentChildren)
                    Console.WriteLine(f.Name);

            return "{}";
        }


        public static string AsJson(this ProjectItem item)
        {
            return "{}";
        }

        public static string AsJson(this Project project)
        {
            if (project is DotNetProject)
            {
                foreach (var reference in (project as DotNetProject).References)
                    Console.WriteLine(reference.Reference);
            }
            var path = project.BaseDirectory;
            ProjectFileCollection files;
            List<string> folders;
            GetFolderContent(project, path, out files, out folders);
            foreach (var file in files)
                Console.WriteLine(file.Name);
            foreach (var folder in folders)
                Console.WriteLine(folder);
            return "{}";
        }
        static void GetFolderContent(Project project, string folder, out ProjectFileCollection files, out List<string> folders)
        {
            var prefix = folder + Path.DirectorySeparatorChar;
            files = new ProjectFileCollection();
            folders = new List<string>();

            foreach (var file in project.Files)
            {
                string dir;
                if (file.Subtype != Subtype.Directory)
                {
                    if (file.DependsOnFile != null)
                        continue;
                    dir = file.IsLink
                        ? project.BaseDirectory.Combine(file.ProjectVirtualPath).ParentDirectory
                        : file.FilePath.ParentDirectory;
                    if (dir == folder)
                    {
                        files.Add(file);
                        continue;
                    }
                }
                else
                    dir = file.Name;
                // Add the direcotry if it isn't already present
                if (dir.StartsWith(prefix, StringComparison.Ordinal))
                {
                    int i = dir.IndexOf(Path.DirectorySeparatorChar, prefix.Length);
                    if (i != -1)
                        dir = dir.Substring(0, i);
                    if (!folders.Contains(dir))
                        folders.Add(dir);
                }
            }
        }
        public static string AsJson(this SolutionFolder folder)
        {
            Console.WriteLine(folder.Name);
            foreach (var item in folder.Items)
                Console.WriteLine(item.Name);
            foreach (var item in folder.Files)
                Console.WriteLine(item.FullPath);
            return "{}";
        }
    }
}

