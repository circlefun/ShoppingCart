namespace ShoppingCart
{
    public class ShoppingCart : ITerminal
    {
        private Dictionary<char, Product> inventory = new Dictionary<char, Product>();
        private Dictionary<char, int> cart = new Dictionary<char, int>();

        public ShoppingCart()
        {
            LoadInventory();
        }
        public void Scan(string item)
        {
            if (!String.IsNullOrEmpty(item))
            {
                foreach (char i in item)
                {
                    if (inventory.ContainsKey(i))
                    {
                        if (cart.ContainsKey(i))
                        {
                            cart[i]++;
                        }
                        else
                        {
                            cart.Add(i, 1);
                        }
                    }
                    else
                    {
                        throw new Exception($"Product {i} is out of stock");
                    }
                }
            }
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (char product in cart.Keys)
            {
                total += inventory[product].Total(cart[product]);
            }

            return total;
        }

        private void LoadInventory()
        {
            // this could be replace with loading from database
            var a = new Product('A', 2);
            a.Promotion = new Promotion(4, 7);
            var b = new Product('B', 12);
            var c = new Product('C', 1.25m);
            c.Promotion = new Promotion(6, 6);
            var d = new Product('D', 0.15m);
        }
    }
}