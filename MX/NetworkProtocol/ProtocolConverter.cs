using System.Text.Json;

namespace MX.NetworkProtocol
{
    internal class ProtocolConverter
    {
        public int TypeConversion(uint crc, Protocol protocol)
        {
            string folder = Path.Combine(AppContext.BaseDirectory, "TypeConversion");
            string file = Path.Combine(folder, protocol.ToString() + ".json");
            if (!File.Exists(file))
                throw new FileNotFoundException(file);

            string jsonString = File.ReadAllText(file);
            var arr = JsonSerializer.Deserialize<List<int>>(jsonString);
            ArgumentNullException.ThrowIfNull(arr);

            return arr[(int)(crc % 99)];

            // var result = (crc % 99) switch
            // {
            //     0 => TypeConversion0(protocol),
            //     1 => TypeConversion1(protocol),
            //     2 => TypeConversion2(protocol),
            //     3 => TypeConversion3(protocol),
            //     4 => TypeConversion4(protocol),
            //     5 => TypeConversion5(protocol),
            //     6 => TypeConversion6(protocol),
            //     7 => TypeConversion7(protocol),
            //     8 => TypeConversion8(protocol),
            //     9 => TypeConversion9(protocol),
            //     10 => TypeConversion10(protocol),
            //     11 => TypeConversion11(protocol),
            //     12 => TypeConversion12(protocol),
            //     13 => TypeConversion13(protocol),
            //     14 => TypeConversion14(protocol),
            //     15 => TypeConversion15(protocol),
            //     16 => TypeConversion16(protocol),
            //     17 => TypeConversion17(protocol),
            //     18 => TypeConversion18(protocol),
            //     19 => TypeConversion19(protocol),
            //     20 => TypeConversion20(protocol),
            //     21 => TypeConversion21(protocol),
            //     22 => TypeConversion22(protocol),
            //     23 => TypeConversion23(protocol),
            //     24 => TypeConversion24(protocol),
            //     25 => TypeConversion25(protocol),
            //     26 => TypeConversion26(protocol),
            //     27 => TypeConversion27(protocol),
            //     28 => TypeConversion28(protocol),
            //     29 => TypeConversion29(protocol),
            //     30 => TypeConversion30(protocol),
            //     31 => TypeConversion31(protocol),
            //     32 => TypeConversion32(protocol),
            //     33 => TypeConversion33(protocol),
            //     34 => TypeConversion34(protocol),
            //     35 => TypeConversion35(protocol),
            //     36 => TypeConversion36(protocol),
            //     37 => TypeConversion37(protocol),
            //     38 => TypeConversion38(protocol),
            //     39 => TypeConversion39(protocol),
            //     40 => TypeConversion40(protocol),
            //     41 => TypeConversion41(protocol),
            //     42 => TypeConversion42(protocol),
            //     43 => TypeConversion43(protocol),
            //     44 => TypeConversion44(protocol),
            //     45 => TypeConversion45(protocol),
            //     46 => TypeConversion46(protocol),
            //     47 => TypeConversion47(protocol),
            //     48 => TypeConversion48(protocol),
            //     49 => TypeConversion49(protocol),
            //     50 => TypeConversion50(protocol),
            //     51 => TypeConversion51(protocol),
            //     52 => TypeConversion52(protocol),
            //     53 => TypeConversion53(protocol),
            //     54 => TypeConversion54(protocol),
            //     55 => TypeConversion55(protocol),
            //     56 => TypeConversion56(protocol),
            //     57 => TypeConversion57(protocol),
            //     58 => TypeConversion58(protocol),
            //     59 => TypeConversion59(protocol),
            //     60 => TypeConversion60(protocol),
            //     61 => TypeConversion61(protocol),
            //     62 => TypeConversion62(protocol),
            //     63 => TypeConversion63(protocol),
            //     64 => TypeConversion64(protocol),
            //     65 => TypeConversion65(protocol),
            //     66 => TypeConversion66(protocol),
            //     67 => TypeConversion67(protocol),
            //     68 => TypeConversion68(protocol),
            //     69 => TypeConversion69(protocol),
            //     70 => TypeConversion70(protocol),
            //     71 => TypeConversion71(protocol),
            //     72 => TypeConversion72(protocol),
            //     73 => TypeConversion73(protocol),
            //     74 => TypeConversion74(protocol),
            //     75 => TypeConversion75(protocol),
            //     76 => TypeConversion76(protocol),
            //     77 => TypeConversion77(protocol),
            //     78 => TypeConversion78(protocol),
            //     79 => TypeConversion79(protocol),
            //     80 => TypeConversion80(protocol),
            //     81 => TypeConversion81(protocol),
            //     82 => TypeConversion82(protocol),
            //     83 => TypeConversion83(protocol),
            //     84 => TypeConversion84(protocol),
            //     85 => TypeConversion85(protocol),
            //     86 => TypeConversion86(protocol),
            //     87 => TypeConversion87(protocol),
            //     88 => TypeConversion88(protocol),
            //     89 => TypeConversion89(protocol),
            //     90 => TypeConversion90(protocol),
            //     91 => TypeConversion91(protocol),
            //     92 => TypeConversion92(protocol),
            //     93 => TypeConversion93(protocol),
            //     94 => TypeConversion94(protocol),
            //     95 => TypeConversion95(protocol),
            //     96 => TypeConversion96(protocol),
            //     97 => TypeConversion97(protocol),
            //     98 => TypeConversion98(protocol),
            //     _ => 0,
            // };
        }
    }
}
