public class UnderOfferState : PropertyState {
    private Property property;

    public UnderOfferState(Property property) {
        this.property = property;
    }

    public void Offer(Buyer buyer) {
        Console.WriteLine("Offer already made.");
    }

    public void BuyerPullout() {
        Console.WriteLine("Buyer pulls out.");
        property.SetState(new OnMarketState(property));
    }

    public void VendorPullout() {
        Console.WriteLine("Vendor pulls out.");
        Console.WriteLine("Sale is complete with success = false.");
        property.SetState(new CompletedState(property, false));
    }

    public void SignContract(Buyer buyer) {
        Console.WriteLine("Buyer signs contract.");
        property.SetState(new ContractedState(property));
    }

    public void PayPrice() {
        Console.WriteLine("Cannot pay price before contract is signed.");
    }
}
