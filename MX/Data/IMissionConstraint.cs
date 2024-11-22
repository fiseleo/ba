namespace MX.Data
{
    public interface IMissionConstraint
    {
        bool CanComplete(DateTime serverTime);

        bool CanReceiveReward(DateTime serverTime);
    }
}
