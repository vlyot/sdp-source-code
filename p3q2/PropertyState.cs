public interface PropertyState {
    void Offer(Buyer buyer);
    void BuyerPullout();
    void VendorPullout();
    void SignContract(Buyer buyer);
    void PayPrice();
}
