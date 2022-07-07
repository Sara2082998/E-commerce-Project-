using Lab3_Blazer.shared;
using Lab3_Blazer.WebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lab3_Blazer.WebAPI.Repo
{
    public class OrderRepo
    {
        EcomerceEntity db;
        public OrderRepo(EcomerceEntity db)
        {
            this.db = db;
        }


        //public List<Order> GetOrdersById(string userId)
        //{
        //    return db.Orders.Where(o => o.user_id == userId && o.submitted == true).ToList();

        //}



    }
}
