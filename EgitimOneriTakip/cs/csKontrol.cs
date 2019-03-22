using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimOneriTakip.cs
{
    class csKontrol
    {
        public static bool kayitVarmi(string tabloAdi, string kontrolKolon, bool update, SqlConnection baglanti, string kotrolDeger)
        {
            bool cevap = false;
            string sqlcommant = string.Format(@"select * from {0} where {1}=@{2} {3}", tabloAdi, kontrolKolon, kontrolKolon, (update) ? " AND {0}<>{4}" : "");
            using (SqlCommand cmd = new SqlCommand(sqlcommant, baglanti))
            {
                cmd.Parameters.Add("@" + kontrolKolon, SqlDbType.NVarChar).Value = kotrolDeger;
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    cevap = dr.Read();
                }

            }



            return cevap;
        }

    }
}
