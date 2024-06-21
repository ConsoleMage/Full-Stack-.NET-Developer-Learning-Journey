namespace FullStackJourney.OOPPrinciples
{
    internal static class SolutionVendingMachine
    {
        public static void Main(String[] args)
        {
            VendingMachine machine = new VendingMachine();
            machine.ShowProductPrice("coke");
            System.Console.WriteLine("Total Price of Selection is " + machine.BuyProduct("coke", 2));
        }
    }

    internal class VendingMachine
    {
        private const int cokePrice = 30;
        private const int chipsPrice = 20;
        private const int juicePrice = 40;
        private const int biscuitPrice = 15;
        
        public void ShowProductPrice(string productName)
        {
            switch (productName)
            {
                case "coke":
                    System.Console.WriteLine("Price of Coke is " + cokePrice);
                    break;
                case "chips":
                    System.Console.WriteLine("Price of Chips is " + chipsPrice);
                    break;
                case "biscuit":
                    System.Console.WriteLine("Price of Biscuit is " + biscuitPrice);
                    break;
                case "juice":
                    System.Console.WriteLine("Price of Juice is " + juicePrice);
                    break;
            }
        }

        public int BuyProduct(string productName, int quantity)
        {
            int productPrice = GetPrice(productName);
            int totalPrice = productPrice * quantity;
            return totalPrice;
        }

        public static int GetPrice(string productName)
        {
            int price = 0;

            switch (productName)
            {
                case "coke":
                    price = cokePrice;
                    break;
                case "chips":
                    price = chipsPrice;
                    break;
                case "biscuit":
                    price = biscuitPrice;
                    break;
                case "juice":
                    price = juicePrice;
                    break;
            }

            return price;
        }
    }
}
