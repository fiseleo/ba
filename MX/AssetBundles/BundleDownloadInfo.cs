using System.Collections.Generic;
using Newtonsoft.Json;

namespace MX.AssetBundles
{
    public class BundleDownloadInfo : IEquatable<BundleDownloadInfo>
    {
        [JsonProperty]
        public BundleFile[] BundleFiles { get; set; }

        public IEnumerable<BundleFile> Diff(BundleDownloadInfo other)
        {
            return null;
        }

        public override bool Equals(object obj)
        {
            return default(bool);
        }

        public bool Equals(BundleDownloadInfo other)
        {
            return default(bool);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static bool operator ==(BundleDownloadInfo left, BundleDownloadInfo right)
        {
            return default(bool);
        }

        public static bool operator !=(BundleDownloadInfo left, BundleDownloadInfo right)
        {
            return default(bool);
        }

        public BundleDownloadInfo() { }
    }
}
