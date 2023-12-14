using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostServer
{
    public class OrderController : ApiController
    {
        order[] orders = new order[]
       {
            new order {id = 1 , name = "Hammer" , category = "Handtools" , price = 23} ,
              new order {id = 2 , name = "shovel" , category = "Gardening tools" , price = 33} ,
                 new order {id = 3 , name = "wheelbarrow" , category = "Gardening tools" , price = 40} ,


       };
        [HttpGet]
        [Route("api/orders")]
        public IEnumerable<order> GetOrders()
        {
            return orders;
        }
    }
}
