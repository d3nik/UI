using DataBase.Constants;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;
using System.Data.SqlClient;

namespace WinFormsApp.Services
{
    internal class BrandService : IBrandService
    {
        public IEnumerable<Brand> GetAllBrands()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Brand>(
                    DataBaseConstants.GetAllBrands,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public IEnumerable<Brand> GetBrand(Brand brand)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Brand>(
                    DataBaseConstants.GetBrand,
                    new
                    {
                        brand.BrandID,
                    },
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public IEnumerable<Brand> UpdateBrand(Brand brand)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Brand>(
                    DataBaseConstants.UpdateBrand,
                    new
                    {
                        brand.BrandID,
                        brand.BrandName
                    },
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateBrand(Brand brand)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.CreateBrand,
                    new
                    {
                        brand.BrandName
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteBrand(Brand brand)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.DeleteBrand,
                    new
                    {
                        brand.BrandID
                    },
                    commandType: CommandType.StoredProcedure) ;
                return rows > 0;
            }
        }
    }
}
