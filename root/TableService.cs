using BA.Utils;
using MX.Core.Math;

public static class TableService
{
    // public static void ClearCache() { }

    // public static byte[] LoadBytes(string key, string extension, bool showFailedPopup = false) { }

    // public static string Load(string key, string extension) { }

    public static string CreatePassword(string key, int length = 0x14)
    {
        length = (int)Math.Round((decimal)(length / 4 * 3));
        int seed = XXHash.CalculateHash(key);
        var mt = new MersenneTwister(seed);
        byte[] bytes = mt.NextBytes(length);
        return Convert.ToBase64String(bytes);
    }

    // static TableService() { }

    // public static bool HasChanged;
}
