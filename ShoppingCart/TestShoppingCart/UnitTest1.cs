using ShoppingCart;

namespace ShoppingCart.TestShoppingCart
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var cart = new ShoppingCart();
            cart.Scan("ABCDABAA");
            Assert.Equal(32.40m, cart.Total());
        }
        [Fact]
        public void Test2()
        {
            var cart = new ShoppingCart();
            cart.Scan("CCCCCCC");
            Assert.Equal(7.25m, cart.Total());
        }
        [Fact]
        public void Test3()
        {
            var cart = new ShoppingCart();
            cart.Scan("ABCD");
            Assert.Equal(15.4m, cart.Total());
        }
        [Fact]
        public void Test4()
        {
            var cart = new ShoppingCart();
            cart.Scan("ABCDCCBACACACDCA");
            Assert.Equal(40.55m, cart.Total());
        }
    }
}