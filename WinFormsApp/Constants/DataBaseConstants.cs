using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Constants
{
    internal static class DataBaseConstants
    {
        private const string ConnectionString = "Data Source=DENIK\\SQLEXPRESS;Initial Catalog=StoresForBike;Persist Security Info=True;User ID=sa;Password=2112106546";

        public static SqlConnection GetConnection()
            => new(ConnectionString);

        #region Brands

        public const string GetAllBrands = "sp_Brands_GetAll";
        public const string CreateBrand = "sp_Brands_CreateBrand";
        public const string DeleteBrand = "sp_Brands_DeleteBrand";
        public const string GetBrand = "sp_Brands_GetBrand";
        public const string UpdateBrand = "sp_Brands_UpdateBrand";

        #endregion
    }
}
