using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Net;
namespace SDapisanpham
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            string link = "http://localhost/dsspham/api/sanpham";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Sanpham[]));
            object data = js.ReadObject(response.GetResponseStream());
            Sanpham[] arrSanpham = data as Sanpham[];
            dgvhienthi.DataSource = arrSanpham;
        }

        private void dgvhienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvhienthi.Rows[e.RowIndex];
            txtmasp.Text = Convert.ToString(row.Cells[0].Value);
            txttensp.Text = Convert.ToString(row.Cells[1].Value);
            txtdongia.Text = Convert.ToString(row.Cells[2].Value);

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}",txtmasp.Text,txttensp.Text,txtdongia.Text);
            string link = "http://localhost/dsspham/api/sanpham" + postString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArray = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Them moi thanh cong");
            }else
            MessageBox.Show("them moi that bai");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putString = string.Format("?ma={0}&ten={1}&gia={2}", txtmasp.Text, txttensp.Text, txtdongia.Text);
            string link = "http://localhost/dsspham/api/sanpham" + putString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArray = Encoding.UTF8.GetBytes(putString);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Sua thanh cong");
            }
            else
                MessageBox.Show("Sua that bai");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string deleteString = string.Format("?ma={0}", txtmasp.Text);
            string link = "http://localhost/dsspham/api/sanpham" + deleteString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArray = Encoding.UTF8.GetBytes(deleteString);
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                LoadDataGridView();
                MessageBox.Show("Xoa thanh cong");
            }
            else
                MessageBox.Show("Xoa that bai");
        }
    }
}
