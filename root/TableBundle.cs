using System.Collections.Generic;
using MemoryPack;
using MemoryPack.Internal;
using MX.AssetBundles;

[MemoryPackable]
public partial class TableBundle : IMemoryPackable<TableBundle>, IMemoryPackFormatterRegister
{
    public required string Name { get; set; }
    public long Size { get; set; }
    public long Crc { get; set; }
    public bool isInbuild { get; set; }
    public bool isChanged { get; set; }
    public bool IsPrologue { get; set; }
    public bool IsSplitDownload { get; set; }
    public List<string>? Includes { get; set; }
}
