public class CompletedState : PropertyState {
    private Property property;
    private bool success;

    public CompletedState(Property property, bool success) {
        this.property = property;
        this.success = success;
    }

    public void Offer(Buyer buyer) {
        Console.WriteLine("Cannot offer - sale is complete with success = " + success);
    }

    public void BuyerPullout() {
        Console.WriteLine("Sale already completed.");
    }

    public void VendorPullout() {
        Console.WriteLine("Sale already completed.");
    }

    public void SignContract(Buyer buyer) {
        Console.WriteLine("Sale already completed.");
    }

    public void PayPrice() {
        Console.WriteLine("Sale already completed.");
    }
}
