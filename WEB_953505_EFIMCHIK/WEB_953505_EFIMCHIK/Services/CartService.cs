using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WEB_953505_EFIMCHIK.Entities;
using WEB_953505_EFIMCHIK.Extensions;
using WEB_953505_EFIMCHIK.Models;

namespace WEB_953505_EFIMCHIK.Services
{
    public class CartService : Cart
    {
        private string sessionKey = "cart";
        [JsonIgnore]
        ISession Session { get; set; }
        public static Cart GetCart(IServiceProvider sp)
        {
            // получить объект сессии
            var session = sp
            .GetRequiredService<IHttpContextAccessor>()
            .HttpContext
            .Session;
            // получить CartService из сессии
            // или создать новый для возможности тестирования
            var cart = session?.Get<CartService>("cart")
            ?? new CartService();
            cart.Session = session;
            return cart;
        }
        public override void AddToCart(Auto auto)
        {
            base.AddToCart(auto);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void RemoveFromCart(int id)
        {
            base.RemoveFromCart(id);
            Session?.Set<CartService>(sessionKey, this);
        }
        public override void ClearAll()
        {
            base.ClearAll();
            Session?.Set<CartService>(sessionKey, this);
        }
    }
}
