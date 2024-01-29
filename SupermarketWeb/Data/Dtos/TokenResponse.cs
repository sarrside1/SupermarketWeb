using System;
namespace SupermarketWeb.Data.Dtos
{
	public class TokenResponse
	{
		public string? jwtToken { get; set; }
		public string? jwtRefreshToken { get; set; }
		public int StoreID { get; set; }
        public int LoggedUserId { get; set; }
        public string? LoggedUserLevel { get; set; }
		public string StoreType { get; set; } = "";
	}
}

