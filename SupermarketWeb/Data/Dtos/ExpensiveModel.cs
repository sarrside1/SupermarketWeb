using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketWeb.Data.Dtos
{
    public class ExpensiveModel
	{
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public char Type { get; set; }
        public int StoreId { get; set; }
    }
}