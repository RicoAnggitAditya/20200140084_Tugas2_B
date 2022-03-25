using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace _20200140084_Tugas2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();

        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-QU44LL4V;database=Exercise2;Integrated Security " +
                    "= TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand ("insert into Obat(Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang")values('111', 'Paracetamol', 'Rp20.000', '1')"
                       
                          + "insert into Obat(Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang")values('112', 'Intunal', 'Rp5000', '1')"
                          + "insert into Obat(Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang")values('113', 'Salbutamol', 'Rp5000', '1')"
                          + "insert into Obat(Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang")values('114', 'Vitamin C', 'Rp10.000', '1')"
                          + "insert into Obat(Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang")values('115', 'Meiji', 'Rp20.000', '1')"


                   + "insert into Pegawai(id_Pegawai, Nama_Pegawai) values ('01', 'Kenza')"
                   + "insert into Pegawai(id_Pegawai, Nama_Pegawai) values ('02', 'Ardito')"
                   + "insert into Pegawai(id_Pegawai, Nama_Pegawai) values ('03', 'Putri')"
                    + "insert into Pegawai(id_Pegawai, Nama_Pegawai) values ('04', 'Awa')"
                    + "insert into Pegawai(id_Pegawai, Nama_Pegawai) values ('05', 'Pradit')"

                   + " insert into Nota(id_Nota, Nama_Barang, Kode_Barang, Harga_Satuan, Qty, Total_Harga) values ('1001', 'Paracetamol', '111', 'Rp 20.000', '1', 'Rp 20.000')"
                    + " insert into Nota(id_Nota, Nama_Barang, Kode_Barang, Harga_Satuan, Qty, Total_Harga) values ('1002', 'Intunal', '112', 'Rp 5000', '1', 'Rp 5000')"
                       + " insert into Nota(id_Nota, Nama_Barang, Kode_Barang, Harga_Satuan, Qty, Total_Harga) values ('1003', 'Salbutamol', '113', 'Rp 5000', '1', 'Rp 5000')"
                        + " insert into Nota(id_Nota, Nama_Barang, Kode_Barang, Harga_Satuan, Qty, Total_Harga) values ('1004', 'Vitamin C', '114', 'Rp 10.000', '1', 'Rp 10.000')"
                        + " insert into Nota(id_Nota, Nama_Barang, Kode_Barang, Harga_Satuan, Qty, Total_Harga) values ('1005', 'Meiji', '115', 'Rp 20.000', '1', 'Rp 20.000')"

                        + "insert into Transaksi_masuk(Nota_masuk, Tgl_masuk) values ('11', '2021-04-01')"
                        +  "insert into Transaksi_masuk(Nota_masuk, Tgl_masuk) values('12', '2021-05-18')"
                        + "insert into Transaksi_masuk(Nota_masuk, Tgl_masuk) values('13', '2021-07-22')"
                         + "insert into Transaksi_masuk(Nota_masuk, Tgl_masuk) values('14', '2021-09-02')"
                        + "insert into Transaksi_masuk(Nota_masuk, Tgl_masuk) values('15', '2021-10-25')"

                        + "insert into Transaksi_keluar(Nota_keluar, Tgl_keluar) values ('11', '2021-04-01')"
                        +"insert into Transaksi_keluar(Nota_keluar, Tgl_keluar) values ('12', '2021-05-18')"
                         +  "insert into Transaksi_keluar(Nota_keluar, Tgl_keluar) values ('13', '2021-07-22')"
                        +"insert into Transaksi_keluar(Nota_keluar, Tgl_keluar) values ('14', '2021-09-02')"
                         +  "insert into Transaksi_keluar(Nota_keluar, Tgl_keluar) values ('15', '2021-10-25')"


                  
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }

    }
}
