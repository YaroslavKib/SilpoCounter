using System;
using Xunit;
using SilpoCounter.Checkout;

namespace SilpoCounter.Tests
{
    public class CheckoutServiceTest
    {
        [Fact]
        public void CloseCheck_WithOneProducts_Returns7()
        {    
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk"));
            Check check = checkoutService.CloseCheck();

            Assert.True(check.GetTotalCost() == 7);
        }

        [Fact]
        public void CloseCheck_WithTwoProducts_Returns10()
        {    
            CheckoutService checkoutService = new CheckoutService();
            checkoutService.OpenCheck();

            checkoutService.AddProduct(new Product(7, "Milk"));
            checkoutService.AddProduct(new Product(3, "Bread"));
            Check check = checkoutService.CloseCheck();

            Assert.True(check.GetTotalCost() == 10);
        }
    }
}
