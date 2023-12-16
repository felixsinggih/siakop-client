using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SIAKop_client.Class {
    public static class Rupiah {
        public static string ToRupiah(this int angka) {
            return string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N}", angka);
        }

        public static int ToAngka(this string rupiah) {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", " "));
        }
    }
}
