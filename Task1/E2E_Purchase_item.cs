/*
 * Created by Ranorex
 * User: silvan.salgues
 * Date: 11/8/2021
 * Time: 10:43 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Task1
{
    /// <summary>
    /// Description of E2E_Purchase_item.
    /// </summary>
    [TestModule("F28A02DA-91F8-4569-A32B-914195C62162", ModuleType.UserCode, 1)]
    public class E2E_Purchase_item : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public E2E_Purchase_item()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs E2E item purchase actions on SWAGLAB web page.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
        	Task1Repository repo = Task1Repository.Instance;
        	
            // Log in with standard user credential
            Report.Log(ReportLevel.Info, "Section", "Log in with standard user credential");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.UserName' at Center.", repo.SwagLabs.UserNameInfo);
            repo.SwagLabs.UserName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'standard_user' with focus on 'SwagLabs.UserName'.", repo.SwagLabs.UserNameInfo);
            repo.SwagLabs.UserName.PressKeys("standard_user");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.Password' at Center.", repo.SwagLabs.PasswordInfo);
            repo.SwagLabs.Password.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'secret_sauce' with focus on 'SwagLabs.Password'.", repo.SwagLabs.PasswordInfo);
            repo.SwagLabs.Password.PressKeys("secret_sauce");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.LoginButton' at Center.", repo.SwagLabs.LoginButtonInfo);
            repo.SwagLabs.LoginButton.Click();
            Delay.Milliseconds(0);
            
            // Add Sauce Labs Backpack to cart
            Report.Log(ReportLevel.Info, "Section", "Add Sauce Labs Backpack to cart");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SwagLabs.Products'", repo.SwagLabs.ProductsInfo, new ActionTimeout(5000));
            repo.SwagLabs.ProductsInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.AddToCartSauceLabsBackpack' at Center.", repo.SwagLabs.AddToCartSauceLabsBackpackInfo);
            repo.SwagLabs.AddToCartSauceLabsBackpack.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='1') on item 'SwagLabs.cart_badge'.", repo.SwagLabs.cart_badgeInfo);
            Validate.AttributeEqual(repo.SwagLabs.cart_badgeInfo, "InnerText", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.ShoppingCartLink' at Center.", repo.SwagLabs.ShoppingCartLinkInfo);
            repo.SwagLabs.ShoppingCartLink.Click();
            Delay.Milliseconds(0);
            
            // Verify the cart content
            Report.Log(ReportLevel.Info, "Section", "Verify the cart content");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SwagLabs.YourCart'", repo.SwagLabs.YourCartInfo, new ActionTimeout(5000));
            repo.SwagLabs.YourCartInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Sauce Labs Backpack') on item 'SwagLabs.CartItem.Item_name'.", repo.SwagLabs.CartItem.Item_nameInfo);
            Validate.AttributeEqual(repo.SwagLabs.CartItem.Item_nameInfo, "InnerText", "Sauce Labs Backpack");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='1') on item 'SwagLabs.CartItem.Cart_quantity'.", repo.SwagLabs.CartItem.Cart_quantityInfo);
            Validate.AttributeEqual(repo.SwagLabs.CartItem.Cart_quantityInfo, "InnerText", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='$29.99') on item 'SwagLabs.CartItem.item_price'.", repo.SwagLabs.CartItem.item_priceInfo);
            Validate.AttributeEqual(repo.SwagLabs.CartItem.item_priceInfo, "InnerText", "$29.99");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.') on item 'SwagLabs.CartItem.item_description'.", repo.SwagLabs.CartItem.item_descriptionInfo);
            Validate.AttributeEqual(repo.SwagLabs.CartItem.item_descriptionInfo, "InnerText", "carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.Checkout' at Center.", repo.SwagLabs.CheckoutInfo);
            repo.SwagLabs.Checkout.Click();
            Delay.Milliseconds(0);
            
            // Checkout page fill in
            Report.Log(ReportLevel.Info, "Section", "Checkout page fill in");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SwagLabs.CheckoutYourInformation'", repo.SwagLabs.CheckoutYourInformationInfo);
            repo.SwagLabs.CheckoutYourInformationInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.FirstName' at Center.", repo.SwagLabs.FirstNameInfo);
            repo.SwagLabs.FirstName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'salgues' with focus on 'SwagLabs.FirstName'.", repo.SwagLabs.FirstNameInfo);
            repo.SwagLabs.FirstName.PressKeys("salgues");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.LastName' at Center.", repo.SwagLabs.LastNameInfo);
            repo.SwagLabs.LastName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'silvan' with focus on 'SwagLabs.LastName'.", repo.SwagLabs.LastNameInfo);
            repo.SwagLabs.LastName.PressKeys("silvan");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.PostalCode' at Center.", repo.SwagLabs.PostalCodeInfo);
            repo.SwagLabs.PostalCode.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad3}{NumPad4}{NumPad0}{NumPad0}{NumPad0}' with focus on 'SwagLabs.PostalCode'.", repo.SwagLabs.PostalCodeInfo);
            repo.SwagLabs.PostalCode.EnsureVisible();
            Keyboard.Press("{NumPad3}{NumPad4}{NumPad0}{NumPad0}{NumPad0}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.Continue' at Center.", repo.SwagLabs.ContinueInfo);
            repo.SwagLabs.Continue.Click();
            Delay.Milliseconds(0);
            
            // Verify the checkout overview page  content
            Report.Log(ReportLevel.Info, "Section", "Verify the checkout overview page  content");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to exist. Associated repository item: 'SwagLabs.CheckoutOverview'", repo.SwagLabs.CheckoutOverviewInfo, new ActionTimeout(5000));
            repo.SwagLabs.CheckoutOverviewInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Sauce Labs Backpack') on item 'SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item_name'.", repo.SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item_nameInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item_nameInfo, "InnerText", "Sauce Labs Backpack");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='1') on item 'SwagLabs.CheckoutSummaryContainer.CartList.CartItem.cart_quantity'.", repo.SwagLabs.CheckoutSummaryContainer.CartList.CartItem.cart_quantityInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutSummaryContainer.CartList.CartItem.cart_quantityInfo, "InnerText", "1");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='$29.99') on item 'SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item__price'.", repo.SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item__priceInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item__priceInfo, "InnerText", "$29.99");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.') on item 'SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item_description'.", repo.SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item_descriptionInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutSummaryContainer.CartList.CartItem.item_descriptionInfo, "InnerText", "carry.allTheThings() with the sleek, streamlined Sly Pack that melds uncompromising style with unequaled laptop and tablet protection.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Item total: $29.99') on item 'SwagLabs.CheckoutSummaryContainer.summary_subtotal'.", repo.SwagLabs.CheckoutSummaryContainer.summary_subtotalInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutSummaryContainer.summary_subtotalInfo, "InnerText", "Item total: $29.99");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Tax: $2.40') on item 'SwagLabs.CheckoutSummaryContainer.summary_tax'.", repo.SwagLabs.CheckoutSummaryContainer.summary_taxInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutSummaryContainer.summary_taxInfo, "InnerText", "Tax: $2.40");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Total: $32.39') on item 'SwagLabs.CheckoutSummaryContainer.summary_total'.", repo.SwagLabs.CheckoutSummaryContainer.summary_totalInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutSummaryContainer.summary_totalInfo, "InnerText", "Total: $32.39");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.Finish' at Center.", repo.SwagLabs.FinishInfo);
            repo.SwagLabs.Finish.Click();
            Delay.Milliseconds(0);
            
            // Verify thet Checkout Complete page content
            Report.Log(ReportLevel.Info, "Section", "Verify thet Checkout Complete page content");
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s to not exist. Associated repository item: 'SwagLabs.CheckoutComplete'", repo.SwagLabs.CheckoutCompleteInfo, new ActionTimeout(5000));
            repo.SwagLabs.CheckoutCompleteInfo.WaitForExists(5000);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='THANK YOU FOR YOUR ORDER') on item 'SwagLabs.CheckoutCompleteContainer.complete_header'.", repo.SwagLabs.CheckoutCompleteContainer.complete_headerInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutCompleteContainer.complete_headerInfo, "InnerText", "THANK YOU FOR YOUR ORDER");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your order has been dispatched, and will arrive just as fast as the pony can get there!') on item 'SwagLabs.CheckoutCompleteContainer.Complete_text'.", repo.SwagLabs.CheckoutCompleteContainer.Complete_textInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutCompleteContainer.Complete_textInfo, "InnerText", "Your order has been dispatched, and will arrive just as fast as the pony can get there!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='https://www.saucedemo.com/static/media/pony-express.46394a5d.png') on item 'SwagLabs.CheckoutCompleteContainer.PonyExpress'.", repo.SwagLabs.CheckoutCompleteContainer.PonyExpressInfo);
            Validate.AttributeEqual(repo.SwagLabs.CheckoutCompleteContainer.PonyExpressInfo, "Src", "https://www.saucedemo.com/static/media/pony-express.46394a5d.png");
            Delay.Milliseconds(100);
            
            // Go back to the products page
            Report.Log(ReportLevel.Info, "Section", "Go back to the products page");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SwagLabs.BackToProducts' at Center.", repo.SwagLabs.BackToProductsInfo);
            repo.SwagLabs.BackToProducts.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Products') on item 'SwagLabs.Products'.", repo.SwagLabs.ProductsInfo);
            Validate.AttributeEqual(repo.SwagLabs.ProductsInfo, "InnerText", "Products");
            Delay.Milliseconds(100);
        }
    }
}
