using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkListInfo.Classes;
using VkListInfo.Forms;

namespace VkListInfo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void toolStripButtonToken_Click(object sender, EventArgs e) {
            TokenAuth getToken = new TokenAuth();
            getToken.ShowDialog();
            if (getToken.DialogResult == DialogResult.OK) {
                MessageBox.Show(VKClass.VK.UserName() + ", авторизация успешна!");
            }
        }
    }
}
