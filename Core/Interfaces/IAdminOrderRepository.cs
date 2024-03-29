﻿using Core.Models;
using Core.Models.OrderAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IAdminOrderRepository
    {
        Task<Order> ChangeOrderStatus(int id, OrderStatus status);
        Task<List<Order>> GetOrders();
        Task<List<Order>> GetFinishedOrders();
        Task<Product> AddProduct(Product product);
        Task<Product> GetProductById(int id);
        Task<Product> DeleteProductById(int id);
        Task<List<Product>> GetProducts();
        Task<Order> GetOrderById(int id);
    }
}
