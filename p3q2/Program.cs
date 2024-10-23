class Program {
    static void Main(string[] args) {
        Property prop1 = new Property();
        Buyer buyer = new Buyer();

        prop1.Offer(buyer);
        prop1.BuyerPullout();
        prop1.SignContract(buyer);
        prop1.VendorPullout();
        prop1.Offer(buyer);

        Console.WriteLine();

        Property prop2 = new Property();
        prop2.Offer(buyer);
        prop2.PayPrice();
        prop2.SignContract(buyer);
        prop2.BuyerPullout();
        prop2.PayPrice();
        prop2.VendorPullout();
    }
}
