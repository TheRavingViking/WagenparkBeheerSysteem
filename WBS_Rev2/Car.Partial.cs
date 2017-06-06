using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBS_Rev2
{
    public partial class Car
    {
        public string CheckApk()
        {

            if (ManufacturingDate >= (DateTime.Now.AddYears(-4)))
            {
                return "Valid";
            }
            else
            {
                if (ApkDate >= DateTime.Now)
                {
                    return "Valid";
                }
            }
            return "Expired";

        }







    }
}
