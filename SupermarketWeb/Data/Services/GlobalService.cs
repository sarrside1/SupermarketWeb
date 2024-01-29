using System.Collections.Generic;
using Microsoft​.AspNetCore​.Http;

namespace SupermarketWeb.Data.Services
{
    public class GlobalService
    {
        public int StoreId {get;set;}
        public string? LoggedUser {get; set;}
        public int LoggedUserId {get; set;}
		public string? LoggedUserLevel { get; set; }
		public string? CurrentPage { get; set; }
        public string StoreType { get; set; } = "";
        public Guid uuid { get; set; } = Guid.NewGuid();
        public Dictionary<char, string> ExpensiveTypes = new Dictionary<char, string>
        {
            {'C',"Cost of goods" },
            {'T', "transport cost" },
            {'R', "Rent" },
            {'U', "Utilities" },
            {'S', "Salaries" },
            {'I', "Insurance"},
            {'E', "Expired/Damaged Goods" },
            {'M', "Miscellaneous Expenses" }
        };


        public List<string> PaymentTypes { get; set; } = new List<string>(){
            "CASH",
            "CREDIT CARD",
            "QRCODE"
        };

        public string getLoginUrl()
        {
            if(LoggedUserLevel == "Admin")
            {
                return "/Admin/Login";
            }
            else if (LoggedUserLevel == "Supplier")
            {
                return "/Supplier/Login";
            }
            return "/Login";
        }
    }
}