public class Property {
    private PropertyState currentState;

    // Constructor: Start with the OnMarketState
    public Property() {
        currentState = new OnMarketState(this);
    }

    // Method to change state
    public void SetState(PropertyState state) {
        currentState = state;
    }

    // Delegate methods to the current state
    public void Offer(Buyer buyer) {
        currentState.Offer(buyer);
    }

    public void BuyerPullout() {
        currentState.BuyerPullout();
    }

    public void VendorPullout() {
        currentState.VendorPullout();
    }

    public void SignContract(Buyer buyer) {
        currentState.SignContract(buyer);
    }

    public void PayPrice() {
        currentState.PayPrice();
    }
}
