using Media.Service;

namespace MX.AssetBundles
{
    public class PatchFileInfo : IEquatable<PatchFileInfo>
    {
        public string FileName { get; }

        public long Size { get; }

        public long Crc { get; }

        public Uri URL { get; }

        public bool IsSplitDownload { get; set; }

        public bool IsPrologue { get; }

        public string LocalPath { get; }

        public string LegacyLocalPath { get; }

        public string TmpFilePath
        {
            get { return null; }
        }

        public string HashFilePath { get; }

        public ulong FileNameHash
        {
            get { return 0UL; }
        }

        public string Signature
        {
            get { return null; }
        }

        public PatchFileInfo(BundlePatchStrategy strategy, BundleFile bundle) { }

        public PatchFileInfo(TablePatchStrategy strategy, TableBundle table) { }

        public PatchFileInfo(MediaPatchStrategy strategy, Media.Service.Media media) { }

        public bool Equals(PatchFileInfo other)
        {
            return default(bool);
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return null;
        }

        private PatchFileInfo(string fileName, long size, long crc) { }

        public static PatchFileInfo CreateFromLocal(string path, string name)
        {
            return null;
        }
    }
}
