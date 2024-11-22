using System.Collections.Generic;
using Newtonsoft.Json;

namespace MX.AssetBundles
{
    public class BundleFile : IEquatable<BundleFile>
    {
        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public long Size { get; set; }

        [JsonProperty]
        public bool IsPrologue { get; set; }

        [JsonProperty]
        public long Crc { get; set; }

        [JsonProperty]
        public bool IsSplitDownload { get; set; }

        [JsonIgnore]
        public ulong FileHash
        {
            get { return 0UL; }
        }

        [JsonIgnore]
        public string Signature
        {
            get { return null; }
        }

        public bool IsAnyOf(IEnumerable<PatchFileInfo> files)
        {
            return default(bool);
        }

        private bool IsMatch(PatchFileInfo bundleFile)
        {
            return default(bool);
        }

        public string GetFilePath()
        {
            return null;
        }

        public string GetFilePath(string root)
        {
            return null;
        }

        public string GetFileHashPath()
        {
            return null;
        }

        public string GetFileHashPath(string root)
        {
            return null;
        }

        public bool Equals(BundleFile other)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public override string ToString()
        {
            return null;
        }

        public static bool operator ==(BundleFile left, BundleFile right)
        {
            return default(bool);
        }

        public static bool operator !=(BundleFile left, BundleFile right)
        {
            return default(bool);
        }

        public BundleFile() { }
    }
}
