namespace MX.Campaign
{
    public class HexaTileState
    {
        public int Id { get; set; }

        public bool IsHide { get; set; }

        public bool IsFog { get; set; }

        public bool CanNotMove { get; set; }

        public HexaTileState() { }

        public HexaTileState(HexaTileState source) { }

        public HexaTileState Clone()
        {
            return null;
        }
    }
}
