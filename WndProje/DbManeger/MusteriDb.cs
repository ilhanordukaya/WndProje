using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndProje.Model;
using WndProje.DataB;
using System.Data;
using System.Windows.Forms;

namespace WndProje.DbManeger
{
    class MusteriDb : Musteri
    {

        public MusteriMn Musteriler { get; set; }
        public SubeMn Subeler { get; set; }

        public MusteriDb()
        {
            Musteriler = new MusteriMn();
            Subeler = new SubeMn();
        }

        public void MusteriEkle(Musteri m)
        {
            using (var connection = Baglantı.GetirBaglantı())
            {
                connection.Open();

                // var command = new SqlCommand("insert into Musteriler values( @MusteriTuruID,@SubeID,@MusteriNo,@MusteriAd,@MusteriSoyAd,@TckNo)  ", connection);
                var command = new SqlCommand("gp_MusteriEkle",connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MusteriTuruID", m.MusteriTurID);
                command.Parameters.AddWithValue("@SubeID", m.SubeID);
                command.Parameters.AddWithValue("@MusteriNo", m.MusteriNo);
                command.Parameters.AddWithValue("@MusteriAd", m.Ad);
                command.Parameters.AddWithValue("@MusteriSoyAd", m.SoyAd);
                command.Parameters.AddWithValue("@TckNO", m.TckNO);
                command.ExecuteNonQuery();

                connection.Close();
            }

        }

        public Musteri Ara(int id)
        {

            Musteri musteriler = new Musteri();
            using (var connection = Baglantı.GetirBaglantı())
            {
                var command = new SqlCommand("select * from Musteriler where MusteriID=@id", connection);
                connection.Open();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    musteriler.MusteriID = dr.GetInt32(0);
                    musteriler.MusteriTurID = dr.GetInt32(1);
                    musteriler.SubeID = dr.GetInt32(2);
                    musteriler.MusteriNo = dr.GetString(3);
                    musteriler.Ad = dr.GetString(4);
                    musteriler.SoyAd = dr.GetString(5);
                    musteriler.TckNO = dr.GetString(6);
                }
                else
                {
                    musteriler.MusteriID = -1;
                    MessageBox.Show("Aradığınız kayıt bulunamadı...");
                }
            }
            return musteriler;
        }

        public void Guncelle(Musteri m)
        {
            using (var connection = Baglantı.GetirBaglantı())
            {
                connection.Open();

                //var command = new SqlCommand("update Musteriler set " +
                //    "MusteriTuruID=@MusteriTuruID,SubeID=@SubeID,MusteriNo=@MusteriNo," +
                //    "MusteriAd=@MusteriAd,MusteriSoyAd=@MusteriSoyAd,TckNO=@TckNO where MusteriID=@MusteriID", connection);

                var command = new SqlCommand("gp_MusteriGuncelle3", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@MusteriID", m.MusteriID);
                command.Parameters.AddWithValue("@MusteriTuruID", m.MusteriTurID);
                command.Parameters.AddWithValue("@SubeID", m.SubeID);
                command.Parameters.AddWithValue("@MusteriNo", m.MusteriNo);
                command.Parameters.AddWithValue("@MusteriAd", m.Ad);
                command.Parameters.AddWithValue("@MusteriSoyAd", m.SoyAd);
                command.Parameters.AddWithValue("@TckNO", m.TckNO);
                command.ExecuteNonQuery();

                connection.Close();
            }

        }

        public void Sil(int id)
        {
            using (var connection = Baglantı.GetirBaglantı())
            {
                connection.Open();

                var command = new SqlCommand("delete from Musteriler where MusteriID=@MusteriID", connection);

                command.Parameters.AddWithValue("@MusteriID", id);
                command.ExecuteNonQuery();

                connection.Close();
            }


        }

        public List<Musteri> Listele()
        {
            List<Musteri> musteriler = new List<Musteri>();
            using (var connection = Baglantı.GetirBaglantı())
            {
                var command = new SqlCommand("select * from Musteriler", connection);
                
                connection.Open();
                using (var dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Musteri m = new Musteri();
                        m.MusteriID = dr.GetInt32(0);
                        m.MusteriTurID = dr.GetInt32(1);
                        m.SubeID = dr.GetInt32(2);
                        m.MusteriNo = dr.GetString(3);
                        m.Ad = dr.GetString(4);
                        m.SoyAd = dr.GetString(5);
                        m.TckNO = dr.GetString(6);
                        musteriler.Add(m);
                    }
                }
                connection.Close();
            }
            return musteriler;
        }

        


    }
}
