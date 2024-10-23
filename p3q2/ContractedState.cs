public class ContractedState : PropertyState {
    private Property property;

    public ContractedState(Property property) {
        this.property = property;
    }

    public void Offer(Buyer buyer) {
        Console.WriteLine("Cannot offer - contract already signed.");
    }

    public void BuyerPullout() {
        Console.WriteLine("Buyer cannot pull out - contract signed.");
    }

    public void VendorPullout() {
        Console.WriteLine("Vendor cannot pull out - contract signed.");
    }

    public void SignContract(Buyer buyer) {
        Console.WriteLine("Contract already signed.");
    }

    public void PayPrice() {
        Console.WriteLine("Price paid.");
        property.SetState(new CompletedState(property, true));
    }
}
