namespace MX.NetworkProtocol
{
    public class RecipeCraftRequest : RequestPacket
    {
        public override Protocol Protocol
        {
            get { return Protocol.Recipe_Craft; }
        }

        public long RecipeCraftUniqueId { get; set; }

        public long RecipeIngredientUniqueId { get; set; }

        public RecipeCraftRequest() { }
    }
}
