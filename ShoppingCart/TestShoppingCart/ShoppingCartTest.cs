using ShoppingCart;

namespace ShoppingCart.TestShoppingCart
{
    public class ShoppingCartTest 
    {
        [Fact]
        public void TestProductAPromotion()
        {
            var cart = new ShoppingCart();
            cart.Scan("ABCDABAA");
            Assert.Equal(32.40m, cart.Total());
        }
        [Fact]
        public void TestProductCPromotion()
        {
            var cart = new ShoppingCart();
            cart.Scan("CCCCCCC");
            Assert.Equal(7.25m, cart.Total());
        }
        [Fact]
        public void TestNoPromotion()
        {
            var cart = new ShoppingCart();
            cart.Scan("ABCD");
            Assert.Equal(15.4m, cart.Total());
        }
        [Fact]
        public void TestProductAandCPromotion()
        {
            var cart = new ShoppingCart();
            cart.Scan("ABCDCCBACACACDCA");
            Assert.Equal(40.55m, cart.Total());
        }
    }
}