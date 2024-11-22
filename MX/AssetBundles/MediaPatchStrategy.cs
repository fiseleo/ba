using System.Collections.Generic;
using Media.Service;

namespace MX.AssetBundles
{
    public class MediaPatchStrategy : IPatchStrategy
    {
        public MediaPatchStrategy(ServerInfoConnectionGroupData config) { }

        public bool HasRemoteCatalogURL
        {
            get { return default(bool); }
        }

        public string LocalRoot { get; }

        public string LocalCatalogPath { get; }

        public string LocalCatalogHashPath { get; }

        public Uri RemoteCatalogURL { get; }

        public Uri RemoteCatalogHashURL { get; }

        // private RuntimePlatform _platform { get; }

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

        private MediaCatalog availableCatalog
        {
            get { return null; }
        }

        public List<PatchFileInfo> InGameDownloads
        {
            get { return null; }
        }

        public Dictionary<string, PatchFileInfo> SplitDownloadBundlesDict
        {
            get { return null; }
        }

        public void Initialize() { }

        public void SetSplitDownloadList() { }

        public void Clear() { }

        public IEnumerable<string> ToBeDeleted
        {
            get { return null; }
        }

        private MediaCatalog RemoteCatalog { get; set; }

        private MediaCatalog LocalCatalog { get; set; }

        public string GetMediaPathAsUrlFormat(string key)
        {
            return null;
        }

        public Uri GetFileUrl(Media.Service.Media media)
        {
            return null;
        }

        public string GetFilePath(string key)
        {
            return null;
        }

        public string GetFilePath(Media.Service.Media media, bool isIncludeCRC = true)
        {
            return null;
        }

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

        private void WriteBundleCatalogFile(byte[] bytes) { }

        private void WriteBundleCatalog(byte[] bytes) { }

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

        private List<PatchFileInfo> _prologueDownloads;

        private List<PatchFileInfo> _inGameDownloads;

        private Dictionary<string, PatchFileInfo> _splitDownloadBundlesDict;

        private Dictionary<string, PatchFileInfo> downloadBundlesDict;

        private HashSet<string> splitFolders;
    }
}
