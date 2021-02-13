using MyCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Models
{
    public class Order
    {  public string Id { get; set; }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string OrderId { get; set; }
        public string UserOrd { get; set; } 
        public string Address { get; set; } 
        public string EmailOrd { get; set; }
        public ServiceItem ServiceItem { get; set; }
    }
}
