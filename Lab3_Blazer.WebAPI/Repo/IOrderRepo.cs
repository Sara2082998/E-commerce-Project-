using Lab3_Blazer.shared;
using System.Collections.Generic;

namespace Lab3_Blazer.WebAPI.Repo
{
    public interface IOrderRepo
    {

        List<Order> GetOrdersById(string userId);
    }
}
