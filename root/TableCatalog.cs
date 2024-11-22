using System.Collections.Generic;
using MemoryPack;
using MemoryPack.Internal;

[MemoryPackable]
public partial class TableCatalog : IMemoryPackable<TableCatalog>, IMemoryPackFormatterRegister
{
    public required Dictionary<string, TableBundle> Table { get; set; }
}
