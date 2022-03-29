using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WndProje.Model;
using WndProje.DataB;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WndProje.DbManeger
{
    class SubeMn:Sube
    {

        
        public void SubeEkle(Sube s)
        {
            using (var connection = Baglantı.GetirBaglantı())
            {
                connection.Open();

                 var command = new SqlCommand("insert into Sube(SubeAdı) values(@SubeAdı)", connection);
                
                
                
                command.Parameters.AddWithValue("@SubeAdı", s.SubeAdı);
                
                command.ExecuteNonQuery();

                connection.Close();
            }

        }


        public Sube SubeAra(int id)
        {

            Sube subeler = new Sube();
            using (var connection = Baglantı.GetirBaglantı())
            {
                var command = new SqlCommand("select * from Sube where SubeID=@id", connection);
                connection.Open();
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    
                    subeler.SubeID = dr.GetInt32(0);
                    subeler.SubeAdı = dr.GetString(1);
                    
                }
                else
                {
                    subeler.SubeID = -1;
                    MessageBox.Show("Aradığınız kayıt bulunamadı...");
                }
            }
            return subeler;
        }

        public void subeGuncelle(Sube s)
        {
            using (var connection = Baglantı.GetirBaglantı())
            {
                connection.Open();

                var command = new SqlCommand("update Sube set " +
                    "SubeAdı=@SubeAdı where SubeID=@SubeID", connection);



                command.Parameters.AddWithValue("@SubeID", s.SubeID);
                command.Parameters.AddWithValue("@SubeAdı", s.SubeAdı);
                
                command.ExecuteNonQuery();

                connection.Close();
            }

        }

        
        public void subeSil(int id)
        {
            using (var connection = Baglantı.GetirBaglantı())
            {
                connection.Open();

                var command = new SqlCommand("delete from Sube where SubeID=@SubeID", connection);

                command.Parameters.AddWithValue("@SubeID", id);
                command.ExecuteNonQuery();

                connection.Close();
            }


        }
        public void SubeAdGetir(ComboBox comboBox)
        {
            using (var connection = Baglantı.GetirBaglantı())
            {
                

                var command = new SqlCommand("select SubeAdı from Sube ", connection);
                connection.Open();

                SqlDataReader dr = command.ExecuteReader();
                
                while (dr.Read())
                {
                     comboBox.Items.Add(dr["SubeAdı"]);
                    

                }

                connection.Close();
            }

        }

        

        public List<Sube> SubeListele()
        {
            List<Sube> subeler = new List<Sube>();
            using (var connection = Baglantı.GetirBaglantı())
            {
                var command = new SqlCommand("select * from Sube", connection);

                connection.Open();
                using (var dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Sube s = new Sube();

                        s.SubeID = dr.GetInt32(0);
                        s.SubeAdı = dr.GetString(1);

                        subeler.Add(s);
                    }
                }
                connection.Close();
            }
            return subeler;
        }
    }
}
