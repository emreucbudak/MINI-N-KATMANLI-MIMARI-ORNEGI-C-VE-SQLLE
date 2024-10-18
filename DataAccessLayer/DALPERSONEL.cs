using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DALPERSONEL
    {
        public static List<EntityPersonel> listele()
        {
            List<EntityPersonel> liste = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand(@"SELECT * FROM FIRMAPERSONEL", Baglanti.conn);
            if(komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                EntityPersonel personel = new EntityPersonel();
                personel.ID1 = int.Parse(reader["ID"].ToString());
                personel.Ad = reader["AD"].ToString();
                personel.Soyad = reader["SOYAD"].ToString() ;
                personel.Sehir = reader["SEHIR"].ToString();
                personel.Maas = int.Parse(reader["MAAS"].ToString());
                personel.Gorev = reader["GOREV"].ToString();
                liste.Add(personel);

            }
            reader.Close();


            return liste;
        }
        public static int ekle (EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("insert into FIRMAPERSONEL (AD,SOYAD,SEHIR,MAAS,GOREV) values (@p1,@p2,@p3,@p4,@p5)", Baglanti.conn);
            komut.Parameters.AddWithValue("@p1", p.Ad);
            komut.Parameters.AddWithValue("@p2", p.Soyad);
            komut.Parameters.AddWithValue("@p3",p.Sehir);
            komut.Parameters.AddWithValue("@p4", p.Maas);
            komut.Parameters.AddWithValue("@p5", p.Gorev);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();

        }
        public static int guncelle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("update  FIRMAPERSONEL set AD = @a1,SOYAD = @a2,SEHIR = @a3, MAAS = @a4, GOREV = @a5 where ID = @a6",Baglanti.conn);
            komut.Parameters.AddWithValue("@a1", p.Ad);
            komut.Parameters.AddWithValue("@a2", p.Soyad);
            komut.Parameters.AddWithValue("@a3", p.Sehir);
            komut.Parameters.AddWithValue("@a4", p.Maas);
            komut.Parameters.AddWithValue("@a5", p.Gorev);
            komut.Parameters.AddWithValue("@a6", p.ID1);
            return komut.ExecuteNonQuery();

        }
        public static int sil (int p )
        {
            SqlCommand komut = new SqlCommand("DELETE FROM FIRMAPERSONEL WHERE ID = @b1",Baglanti.conn);
            if (komut.Connection.State != System.Data.ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@b1", p);
            komut.ExecuteNonQuery();
            return 0;
                }
    }
}
