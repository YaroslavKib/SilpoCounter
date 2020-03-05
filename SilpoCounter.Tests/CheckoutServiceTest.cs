using System;
using Xunit;
using SilpoCounter.Checkout;

namespace SilpoCounter.Tests
{
    public class CheckoutServiceTest
    {    
        private Product milk_7;
        private CheckoutService checkoutService;
        private Product bread_3;

        private void SetUp()
        {
            checkoutService = new CheckoutService();
            milk_7 = new Product(7, "Milk");
            bread_3 = new Product(3, "Bread");
        }

        [Fact]
        public void CloseCheck_WithOneProducts_Returns7()
        {   
            SetUp();

            checkoutService.AddProduct(milk_7);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());
        }

        [Fact]
        public void CloseCheck_WithTwoProducts_Returns10()
        {    
            SetUp();
    
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bread_3);
            Check check = checkoutService.CloseCheck();    

            Assert.Equal(10, check.GetTotalCost());
        }
        
        [Fact]
        public void AddProduct_WhenCheckIsClosed_OpensNewCheck()
        {
            SetUp();

            checkoutService.AddProduct(milk_7);
            Check milkCheck = checkoutService.CloseCheck();
            Assert.Equal(7, milkCheck.GetTotalCost());

            checkoutService.AddProduct(bread_3);
            Check bredCheck = checkoutService.CloseCheck();
            Assert.Equal(3, bredCheck.GetTotalCost());
        }

        [Fact]
        void CloseCheck_CalcTotalPoints()
        {
            SetUp();

            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bread_3);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(10, check.GetTotalPoints());
        }
    }
}
