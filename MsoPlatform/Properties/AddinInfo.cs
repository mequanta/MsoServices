using Mono.Addins;

[assembly:Addin ("MsoPlatform", 
	Namespace = "MonoDevelop",
	Version = MonoDevelop.BuildInfo.Version,
	Category = "Platform Support")]

[assembly:AddinName ("MonoDevelop Mso Platform Support")]
[assembly:AddinDescription ("Mso Platform Support for MonoDevelop")]
[assembly:AddinDependency ("Core", MonoDevelop.BuildInfo.Version)]
[assembly:AddinDependency ("Ide", MonoDevelop.BuildInfo.Version)]