using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YaTools.Yaml;
using YaTools.Yaml.AbstractContracts;

namespace Craftitude.Server
{
    public class Package
    {
        public LocalRepository Repository { get; set; }
        public DirectoryInfo PackageDirectory { get; set; }
        public YamlLanguage MetadataYaml { get; set; }

        public Package(LocalRepository repository, string package)
        {
            Repository = repository;
            PackageDirectory = Repository.RepositoryDirectory.CreateSubdirectory(package);
            MetadataYaml = YamlLanguage.FileTo<
        }

        public string PackageName { get { return PackageDirectory.Name; } }
        public string Directory { get; set; }
    }

}
