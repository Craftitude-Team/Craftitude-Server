using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Craftitude.Server
{
    public class LocalRepository
    {
        public DirectoryInfo RepositoryDirectory { get; set; }

        public Distribution GetDistribution(string distribution)
        {
            return new Distribution(this, distribution);
        }

        public string ID { get { return RepositoryDirectory.Name; } }

        public LocalRepository(DirectoryInfo repositoryDir)
        {
            RepositoryDirectory = repositoryDir;
        }

        public LocalRepository(string repositoryDirPath)
            : this(new DirectoryInfo(repositoryDirPath))
        {
        }
    }
}
