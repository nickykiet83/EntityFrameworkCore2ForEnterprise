using System;
using OnLineStore.Core.EntityLayer.Warehouse;

namespace OnLineStore.Core.EntityLayer.Sales
{
    public class OrderDetail : IAuditableEntity
    {
        public OrderDetail()
        {
        }

        public OrderDetail(long? orderDetailID)
        {
            OrderDetailID = orderDetailID;
        }

        public long? OrderDetailID { get; set; }

        public long? OrderHeaderID { get; set; }

        public int? ProductID { get; set; }

        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? Quantity { get; set; }

        public decimal? Total { get; set; }

        public string CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }

        public OrderHeader OrderFk { get; set; }

        public Product ProductFk { get; set; }
    }
}
