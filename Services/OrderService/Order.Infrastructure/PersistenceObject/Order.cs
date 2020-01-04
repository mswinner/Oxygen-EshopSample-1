using InfrastructureBase;
using Order.Domain.Aggregation.ValueObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Order.Infrastructure.PersistenceObject
{
    public class Order: PersistenceObjectBase
    {
        // <summary>
        /// ������
        /// </summary>
        public string OrderNo { get; set; }
        /// <summary>
        /// �����ܼ�
        /// </summary>
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// ����״̬
        /// </summary>
        public OrderStateEnum State { get; set; }
        /// <summary>
        /// �µ��û�Id
        /// </summary>
        public Guid UserId { get; set; }
    }
}
