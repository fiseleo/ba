using System.Buffers;
using System.Collections.Generic;
using MemoryPack;
using MemoryPack.Internal;
using MX.AssetBundles;
using Newtonsoft.Json;

namespace Media.Service
{
    [MemoryPackable]
    public partial class Media : IMemoryPackable<Media>, IMemoryPackFormatterRegister
    {
        [JsonProperty("path")]
        public required string Path { get; set; }
        public required string FileName { get; set; }
        public long Bytes { get; set; }
        public long Crc { get; set; }
        public bool IsPrologue { get; set; }
        public bool IsSplitDownload { get; set; }
        public MediaType MediaType { get; set; }
    }
}
