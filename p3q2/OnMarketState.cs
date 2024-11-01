public class OnMarketState : PropertyState {
    private Property property;

    public OnMarketState(Property property) {
        this.property = property;
    }

    public void Offer(Buyer buyer) {
        Console.WriteLine("Offer made.");
        property.SetState(new UnderOfferState(property));
    }

    public void BuyerPullout() {
        Console.WriteLine("No buyer to pull out.");
    }

    public void VendorPullout() {
        Console.WriteLine("Vendor pulls out.");
        Console.WriteLine("Sale is complete with success = false.");
        property.SetState(new CompletedState(property, false));
    }

    public void SignContract(Buyer buyer) {
        Console.WriteLine("No buyer to sign contract.");
    }

    public void PayPrice() {
        Console.WriteLine("Cannot pay price without an offer.");
    }
}
