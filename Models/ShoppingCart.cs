﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebBanHangOnline.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartitem> items { get; set; }
        public ShoppingCart()
        {
            this.items = new List<ShoppingCartitem>();
        }
        public void AddToCart(ShoppingCartitem item, int Quantity)
        {
            var checkExits = items.FirstOrDefault(x => x.ProductId == item.ProductId);
            if(checkExits != null)
            {
                checkExits.Quantity += Quantity;
                checkExits.TotalPrice = checkExits.Price * checkExits.Quantity;
            }
            else
            {
                items.Add(item);
            }
        }
        public void Remove(int id)
        {
            var checkExits = items.SingleOrDefault(x => x.ProductId == id);
            if(checkExits != null)
            {
                items.Remove(checkExits);
            }          
        }
        public void UpdateQuantity(int id, int quantity)
        {
            var checkExits = items.SingleOrDefault(x => x.ProductId == id);
            if (checkExits != null)
            {
                checkExits.Quantity = quantity;
                checkExits.TotalPrice = checkExits.Price * checkExits.Quantity;
            }
        }
        public decimal GetTotalPrice()
        {
            return items.Sum(x => x.TotalPrice);
        }
        public decimal GetTotalQuantity()
        {
            return items.Sum(x => x.Quantity);
        }
        public void ClearCart()
        {
            items.Clear();
        }
    }
    public class ShoppingCartitem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}