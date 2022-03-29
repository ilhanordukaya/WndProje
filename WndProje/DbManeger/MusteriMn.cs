using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndProje.Model;
using WndProje.DataB;
using System.Data.SqlClient;
using System.Data;

namespace WndProje.DbManeger
{
    public class MusteriMn :Musteri
    {
        //public List<Musteriler> MusteriEkle( Musteriler m)
        //{

        //    List<Musteriler> musteriler = new List<Musteriler>();
        //    using (var connection = Baglantı.GetirBaglantı())
        //    {
        //        var command = new SqlCommand("sp__Get @Id", connection);
        //        command.Parameters.Add(new SqlParameter("Id", ));
        //        connection.Open();
        //        command.ExecuteNonQuery
        //        using (var reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var musteris = new Musteriler();
        //                musteris.MusteriID = reader.GetInt32(0);
        //                musteris.MusteriTurID = reader.GetInt32(1);
        //                musteris.SubeID = reader.GetInt32(2);
        //                musteris.Ad = reader.GetString(3);
        //                musteris.SoyAd = reader.GetString(4);
        //                musteris.TckNO = reader.GetString(5);
        //                musteriler.Add(musteris);

        //            }
        //        }
        //        connection.Close();
        //    }
        //    return musteriler;


        //}

        //public void MusteriEkle(Musteriler m)
        //{
        //    using (var connection = Baglantı.GetirBaglantı())
        //    {
        //        connection.Open();

        //        var command = new SqlCommand("gp_MusteriEkle ", connection);
        //        command.CommandType = CommandType.StoredProcedure;


        //        command.Parameters.Add(new SqlParameter("MusteriTurID", m.MusteriTurID));
        //        command.Parameters.Add(new SqlParameter("SubeID", m.SubeID));
        //        command.Parameters.Add(new SqlParameter("MusteriNo", m.MusteriNo));
        //        command.Parameters.Add(new SqlParameter("Ad", m.Ad));
        //        command.Parameters.Add(new SqlParameter("SoyAd", m.SoyAd));
        //        command.Parameters.Add(new SqlParameter("TckNO", m.TckNO));
        //        command.ExecuteNonQuery();

        //       connection.Close();
        //    }

        //}
        //public List<Musteriler> Liste()
        //{
        //    return new List<Musteriler>();
        //}
    }
}
