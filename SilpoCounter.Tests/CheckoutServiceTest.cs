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

        public CheckoutServiceTest()
        {
            checkoutService = new CheckoutService();
            milk_7 = new Product(7, "Milk", Category.Milk);
            bread_3 = new Product(3, "Bread");
        }

        [Fact]
        public void CloseCheck_WithOneProducts_Returns7()
        {   
            checkoutService.AddProduct(milk_7);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(7, check.GetTotalCost());
        }

        [Fact]
        public void CloseCheck_WithTwoProducts_Returns10()
        {    
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bread_3);
            Check check = checkoutService.CloseCheck();    

            Assert.Equal(10, check.GetTotalCost());
        }
        
        [Fact]
        public void AddProduct_WhenCheckIsClosed_OpensNewCheck()
        {
            checkoutService.AddProduct(milk_7);
            Check milkCheck = checkoutService.CloseCheck();
            Assert.Equal(7, milkCheck.GetTotalCost());

            checkoutService.AddProduct(bread_3);
            Check bredCheck = checkoutService.CloseCheck();
            Assert.Equal(3, bredCheck.GetTotalCost());
        }

        [Fact]
        public void CloseCheck_CalcTotalPoints()
        {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bread_3);
            Check check = checkoutService.CloseCheck();

            Assert.Equal(10, check.GetTotalPoints());
        }

        [Fact]
        public void UseOffer_AddOfferPoints()
        {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bread_3);

            checkoutService.UseOffer(new AnyGoodsOffer(6, 2));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(12, check.GetTotalPoints());
        }

        [Fact]
        public void UseOffer_WhenCostLessThanRequired_DoNothing()
        {
            checkoutService.AddProduct(bread_3);

            checkoutService.UseOffer(new AnyGoodsOffer(6, 2));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(3, check.GetTotalPoints());
        }

        [Fact]
        public void UseOffer_FactorByCategory()
        {
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(milk_7);
            checkoutService.AddProduct(bread_3);;

            checkoutService.UseOffer(new FactorByCategoryOffer(Category.Milk, 2));
            Check check = checkoutService.CloseCheck();

            Assert.Equal(31, check.GetTotalPoints());
        }
    }
}
