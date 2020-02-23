using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Model
{
    public class Basket
    {
        public Basket()
        {
            BasketItems = new List<BasketItem>();
        }

        public Guid BasketId { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<BasketItem> BasketItems { get; set; }
    }
}
