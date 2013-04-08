using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Craftitude.Server
{
    public class Package
    {
        public Package(Distribution distribution, string package)
        {
            Distribution = distribution;
            PackageDirectory = Repository.RepositoryDirectory.CreateSubdirectory(package);
        }

        public Distribution Distribution { get; set; }
        public LocalRepository Repository { get { return Distribution.Repository; } }
        public DirectoryInfo PackageDirectory { get; set; }
        public string ID { get { return PackageDirectory.Name; } }

        public PackageVersion GetVersion(string versionID)
        {
            return new PackageVersion(this, versionID);
        }

        public PackageVersion[] GetVersions()
        {
            return EnumerateVersions().ToArray();
        }

        public IEnumerable<PackageVersion> EnumerateVersions()
        {
            foreach (var versionDir in PackageDirectory.GetDirectories())
                yield return GetVersion(versionDir.Name);
        }
    }
}
