using System.Collections.Generic;

namespace MX.AssetBundles
{
    public class TablePatchStrategy : IPatchStrategy
    {
        // private RuntimePlatform _platform { get; }

        public TablePatchStrategy(ServerInfoConnectionGroupData config) { }

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

        public long TotalDownloadBytes
        {
            get { return 0L; }
        }

        private TableCatalog availableCatalog
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

        public void Initialize() { }

        public void Clear() { }

        public IEnumerable<string> ToBeDeleted
        {
            get { return null; }
        }

        public IEnumerable<PatchFileInfo> DownloadFailedFiles { get; private set; }

        private TableCatalog RemoteCatalog { get; set; }

        private TableCatalog LocalCatalog { get; set; }

        public bool LoadLocalCatalog()
        {
            return default(bool);
        }

        public void UpdateRemoteCatalog(string remoteHash, byte[] bytes) { }

        public void ClearLocal() { }

        public Uri GetFileUrl(string name)
        {
            return null;
        }

        public string GetFilePath(string name, bool isIncludeCRC = true)
        {
            return null;
        }

        public int DeleteDeprecatedFiles()
        {
            return 0;
        }

        private void WriteBundleCatalogFile(byte[] bytes) { }

        public PatchFileInfo GetLocalPatchFileInfo(string bundleName)
        {
            return null;
        }

        private Dictionary<string, string> _bundleMap { get; }

        public void MapRelativePathToBundleName() { }

        public string GetBundleNameFromRelativePath(string relativePath)
        {
            return null;
        }

        private void WriteBundleCatalog(byte[] bytes) { }

        private void WriteBundleCatalogHash(string hashContents) { }

        private static string GetURLRoot(ServerInfoConnectionGroupData config)
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

        private Dictionary<string, PatchFileInfo> _bundleDownloadDict;
    }
}
