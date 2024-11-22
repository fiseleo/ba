using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MX.AssetBundles
{
    public class BundlePatchStrategy : IPatchStrategy
    {
        public BundlePatchStrategy(ServerInfoConnectionGroupData config) { }

        public bool HasRemoteCatalogURL
        {
            get { return default(bool); }
        }

        public string LocalRoot { get; }

        public string LocalCatalogPath { get; }

        public string LocalCatalogHashPath { get; }

        public Uri RemoteCatalogURL { get; }

        public Uri RemoteCatalogHashURL { get; }

        private string urlRoot { get; }

        public Uri GetFileUrl(BundleFile bundle)
        {
            return null;
        }

        public string GetFilePath(BundleFile bundle)
        {
            return null;
        }

        public string LocalCatalogHash { get; private set; }

        public string RemoteCatalogHash { get; private set; }

        public bool IsLocalFileExists
        {
            get { return default(bool); }
        }

        public bool HasRemoteCatalog
        {
            get { return default(bool); }
        }

        public bool NeedUpdate
        {
            get { return default(bool); }
        }

        public List<PatchFileInfo> ToBeDownload
        {
            get { return null; }
        }

        public List<PatchFileInfo> PrologueDownloads
        {
            get { return null; }
        }

        public List<PatchFileInfo> InGameDownloads
        {
            get { return null; }
        }

        public Dictionary<string, PatchFileInfo> BundleDownloadDict
        {
            get { return null; }
        }

        public long TotalDownloadBytes
        {
            get { return 0L; }
        }

        private BundleDownloadInfo availableCatalog
        {
            get { return null; }
        }

        public void Initialize() { }

        public IEnumerator CheckUIPrefabBundle()
        {
            return null;
        }

        public void Clear() { }

        public IEnumerable<string> ToBeDeleted
        {
            get { return null; }
        }

        public IEnumerable<PatchFileInfo> DownloadFailedFiles { get; private set; }

        private BundleDownloadInfo RemoteCatalog { get; set; }

        private BundleDownloadInfo LocalCatalog { get; set; }

        public bool LoadLocalCatalog()
        {
            return default(bool);
        }

        public void UpdateRemoteCatalog(string remoteHash, byte[] bytes) { }

        public void ClearLocal() { }

        public int DeleteDeprecatedFiles()
        {
            return 0;
        }

        private void WriteBundleCatalogFile() { }

        private void WriteBundleCatalog(string bundleDescriptorContents) { }

        private void WriteBundleCatalogHash(string hashContents) { }

        // private static string GetURLRoot(
        //     ServerInfoConnectionGroupData config,
        //     RuntimePlatform platform
        // )
        // {
        //     return null;
        // }

        public override string ToString()
        {
            return null;
        }

        private Dictionary<string, PatchFileInfo> _bundleDownloadDict;

        private HashSet<string> uIPrefabBundleDependencies;

        private Regex uiBundleRegex;
    }
}
