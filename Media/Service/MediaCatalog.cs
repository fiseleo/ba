using System.Collections.Generic;
using MemoryPack;
using MemoryPack.Internal;

namespace Media.Service
{
    [MemoryPackable]
    public partial class MediaCatalog : IMemoryPackable<MediaCatalog>, IMemoryPackFormatterRegister
    {
        public required Dictionary<string, Media> Table { get; set; }
    }
}
