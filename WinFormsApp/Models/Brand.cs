using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp.Models
{
    internal class Brand
    {
        public int BrandID { get; set; }
        public string? BrandName { get; set; }

        public Brand() {}
        public Brand(int newId)
        {
            BrandID = newId;
        }

        public Brand(string newBrand)
        {
            BrandName = newBrand;
        }
    }
}
