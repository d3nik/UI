using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;

namespace WinFormsApp.Services
{
    internal interface IBrandService
    {
        IEnumerable<Brand> GetAllBrands();
        IEnumerable<Brand> GetBrand(Brand brand);
        bool CreateBrand(Brand brand);
        bool DeleteBrand(Brand brand);
        IEnumerable<Brand> UpdateBrand(Brand brand);
    }
}
