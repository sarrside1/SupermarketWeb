using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketWeb.Data.Dtos
{
    public class SupplierModel
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public bool Status { get; set; }
    }
}