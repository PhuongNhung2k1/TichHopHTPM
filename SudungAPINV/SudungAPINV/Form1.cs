using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace SudungAPINV
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

        //public void LoadDataGridView()
        //{
        //    string link = "http://localhost/nhanvien/api/nhanvien";
        //    HttpWebRequest request = HttpWebRequest.CreateHttp(link);
        //    WebResponse response = request.GetResponse();
        //    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Nhanvien[]));
        //    object data = js.ReadObject(response.GetResponseStream());
        //    Nhanvien[] arrNhanvien = data as Nhanvien[];
        //    dgvHienthi.DataSource = arrNhanvien;
        //}

        public void LoadDataGridView()
        {
            string link = "http://localhost/nhanvien/api/nhanvien";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Nhanvien[]));
            object data = js.ReadObject(response.GetResponseStream());
            Nhanvien[] arrNhanvien = data as Nhanvien[];
            dgvHienthi.DataSource = arrNhanvien;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postSTring = string.Format("?ma={0}&ten={1}&hsl={2}", txtmanv.Text, txttennv.Text, txthsl.Text);
            string link = "http://localhost/nhanvien/api/nhanvien" + postSTring;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArray = Encoding.UTF8.GetBytes(postSTring);
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
            }
            else
                MessageBox.Show("Them moi that bai");
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            string deleteString = string.Format("?ma={0}", txtmanv.Text);
            string link = "http://localhost/nhanvien/api/nhanvien"+deleteString;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            request.Method = "DELETE";
            request.ContentType = "application/jspon;charset=UTF-8";
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
                MessageBox.Show("Xoa san pham thanh cong");
            }else
                MessageBox.Show("Xoa san pham that bai");
        }

        private void cell_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHienthi.Rows[e.RowIndex];
            txtmanv.Text = Convert.ToString(row.Cells[0].Value);
            txttennv.Text = Convert.ToString(row.Cells[1].Value);
            txthsl.Text = Convert.ToString(row.Cells[2].Value);


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string putString = string.Format("?ma={0}&ten={1}&hsl={2}", txtmanv.Text, txttennv.Text, txthsl.Text);
            string link = "http://localhost/nhanvien/api/nhanvien" + putString;
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
                MessageBox.Show("Sua nhan vien thanh cong");
            }else 
                MessageBox.Show("Sua nhan vien that bai");
        }
    }
}
