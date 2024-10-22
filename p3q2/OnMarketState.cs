class OnMarketState:PropertyState{
    public bool hasBuyer;
    public bool hasVendor;
    public void handle(){}

    public void buyerPullout(){
        System.Console.WriteLine("Buyer Pulls Out.");
        hasBuyer = false;
    }
    public void offer(Buyer buyer){
        System.Console.WriteLine("Offer made.");
        hasBuyer = true;
    }

    public void vendorPullout(){
        System.Console.WriteLine("Vendor pulls out.");
        hasVendor = false;
    }
}