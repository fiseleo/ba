using System.Collections.Generic;

namespace MX.AssetBundles
{
    public interface IPatchStrategy
    {
        string LocalRoot { get; }

        string LocalCatalogPath { get; }

        string LocalCatalogHashPath { get; }

        bool IsLocalFileExists { get; }

        Uri RemoteCatalogURL { get; }

        Uri RemoteCatalogHashURL { get; }

        string LocalCatalogHash { get; }

        string RemoteCatalogHash { get; }

        bool HasRemoteCatalog { get; }

        bool NeedUpdate { get; }

        IEnumerable<string> ToBeDeleted { get; }

        bool LoadLocalCatalog();

        void UpdateRemoteCatalog(string remoteHash, byte[] bytes);

        void ClearLocal();

        int DeleteDeprecatedFiles();

        void Clear();
    }
}
