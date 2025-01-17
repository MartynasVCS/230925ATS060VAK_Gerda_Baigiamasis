﻿using Framework.Pages;
using NUnit.Framework;

namespace Tests.Baldai1
{
    internal class ShoppingCartFunctionality : BaseTest
    {
        [Test]
        public void AddItemToShoppingCart() 
        {
            string expectedItemTitle = "Minkštas kampas Delaware 100 (Alova 10 + Alova 04)";

            HomePage.ClickOnItemInHomePage();
            ProductPage.ClickButtonAddToCart();
            ProductPage.ClickCloseOptionToCheckout();
            HomePage.UserSection.ClickOpenShoppingCartDropdown();
            HomePage.UserSection.ClickOpenShoppingCart();

            Assert.That(expectedItemTitle, Is.EqualTo(CartPage.GetTitleOfFirstItem()));
        
        }
    }
}
