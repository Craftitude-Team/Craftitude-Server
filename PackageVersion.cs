using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YaTools.Yaml;
using YaTools.Yaml.AbstractContracts;

namespace Craftitude.Server
{
    public class PackageVersion
    {
        public PackageVersion(Package package, string versionID)
        {
            Package = package;
            PackageVersionDirectory = Package.PackageDirectory.CreateSubdirectory(versionID);
        }

        public Package Package { get; set; }
        public DirectoryInfo PackageVersionDirectory { get; set; }
        public Distribution Distribution { get { return Package.Distribution; } }
        public LocalRepository Repository { get { return Package.Repository; } }
        public YamlPackageMetadata Metadata { get { return YamlLanguage.FileTo<YamlPackageMetadata>(Path.Combine(PackageVersionDirectory.FullName, "metadata.yml")); } }

    }
}
