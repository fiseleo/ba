using System.Collections.Generic;

namespace MX.GameLogic.Parcel
{
    public class ParcelResultStepInfo
    {
        public ParcelProcessActionType ParcelProcessActionType { get; set; }

        public List<ParcelDetail> StepParcelDetails { get; set; } = [];

        public bool ShouldSerializeStepParcelDetails()
        {
            return StepParcelDetails.Count > 0;
        }

        public ParcelResultStepInfo() { }
    }
}
