using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketWeb.Data.Dtos
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string? firstname { get; set; }
        public string? lastname { get; set; }
        public string? middlename { get; set; }
        public string? phone { get; set; }
        public string? username { get; set; }
        public string? password { get; set; }
        public string? address { get; set; }
        public string? email { get; set; }
        public bool status { get; set; }
        public int storeId { get; set; }
        public EmployeeLevel EmployeeLevel { get; set; }
    }

    public enum EmployeeLevel
    {
        Admin,
        Cashier,
        Manager,
        Owner,
        Supplier
    }
}