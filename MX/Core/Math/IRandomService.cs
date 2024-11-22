namespace MX.Core.Math
{
    public interface IRandomService
    {
        int Next();

        int Next(int maxValue);

        int Next(int minValue, int maxValue);

        int NextIncludeMax(int minValue, int maxValue);

        float NextFloat();

        double NextDouble();

        ulong NextULong();
    }
}
