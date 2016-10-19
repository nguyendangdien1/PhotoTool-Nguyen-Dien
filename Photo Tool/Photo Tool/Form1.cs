using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open file";
            dlg.Filter = "jpg files(*.jpg)|*.jpg|All file (*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)  // kieu liet ke
                try
                {
                        pbxPhoto.Image = new Bitmap(dlg.OpenFile()); // load anh len-luu vao bitmat
                }
                catch(ArgumentException ex)// lỗi tham số(không phải file ảnh)
                {
                    MessageBox.Show("Unable to load files:"+ ex.Message);
                    pbxPhoto.Image = null;
                }
            dlg.Dispose();
             
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
