using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Craftitude.Server
{
    public class LocalRepository
    {
        public DirectoryInfo RepositoryDirectory;

        public LocalRepository(DirectoryInfo repositoryDir)
        {
            RepositoryDirectory = repositoryDir;
        }

        public Package GetPackage(string packageName)
        {
        }

        public Package[] GetPackages()
        {
        }
    }
}
