using Lab3_Blazer.WebAPI.Models;
using Lab3_Blazer.shared;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Lab3_Blazer.WebAPI.Repo
{
    public class OrderProductRepo:IProductOrderRepo

    {
        EcomerceEntity db;
        public OrderProductRepo(EcomerceEntity db)
        {
            this.db = db;
        }

        public List<OrderProduct> getOrderProducts(int id)
        {
            return db.OrderProducts.Include(op => op.Product).Where(op => op.OrderId == id).ToList();
        }
    }
}
