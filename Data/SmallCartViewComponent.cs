using Microsoft.AspNetCore.Mvc;
using Sonata_eStore.Models.ViewModels;
using Sonata_eStore.Data;
using Sonata_eStore.Models;

namespace Sonata_eStore.Data
{
        public class SmallCartViewComponent : ViewComponent
        {
                public IViewComponentResult Invoke()
                {
                        List<CartItem> cart = HttpContext.Session.GetJson<List<CartItem>>("Cart");
                        SmallCartViewModel smallCartVM;

                        if (cart == null || cart.Count == 0)
                        {
                                smallCartVM = null;
                        }
                        else
                        {
                                smallCartVM = new()
                                {
                                        NumberOfItems = cart.Sum(x => x.Quantity),
                                        TotalAmount = cart.Sum(x => x.Quantity * x.Price)
                                };
                        }

                        return View(smallCartVM);
                }
        }
}
