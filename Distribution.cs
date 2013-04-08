using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Craftitude.Server
{
    public class Distribution
    {
        public Distribution(LocalRepository repository, string distributionName)
        {
            DistributionDirectory = repository.RepositoryDirectory.CreateSubdirectory(distributionName);
            Repository = repository;
        }

        public DirectoryInfo DistributionDirectory { get; set; }
        public LocalRepository Repository { get; set; }
        public string ID { get { return DistributionDirectory.Name; } }

        public Package GetPackage(string packageID)
        {
            return new Package(this, packageID);
        }

        public IEnumerable<Package> EnumeratePackages()
        {
            foreach (var packageDirectory in DistributionDirectory.GetDirectories())
                yield return GetPackage(packageDirectory.Name);
        }

        public Package[] GetPackages()
        {
            return EnumeratePackages().ToArray();
        }
    }
}
