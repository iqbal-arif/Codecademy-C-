using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sedan
{
    class Tools
    {
        private static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string GenerateLicensePlate()
        {
            Random rand = new Random();
            string licensePlate = "";
            for (int i = 0; i < 8; i++)
            {
                licensePlate += chars[rand.Next(chars.Length)];
            }
            return licensePlate;
        }
    }
}
