using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using VkListInfo.Classes;
using VkListInfo.Forms;
using VkNet.Model;

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

        private void toolStripButtonIdInput_Click(object sender, EventArgs e) {
            IDList idList = new IDList();
            idList.ShowDialog();
            if (idList.DialogResult == DialogResult.OK) { MessageBox.Show("Получено " + IDList.UserList.Count + " ID"); }
        }

        private void toolStripButtonStart_Click(object sender, EventArgs e) {
            int i = 0;
            List<User> users = VKClass.VK.GetAccountInfo(IDList.UserList.ToArray());

            toolStripLabelStatus.Visible = true;
            toolStripProgressBar1.Visible = true;
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = IDList.UserList.Count;
            toolStripProgressBar1.Step = 1;
            foreach (var user in users) {

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = user.Id;
                dataGridView1.Rows[i].Cells[2].Value = user.FirstName;
                dataGridView1.Rows[i].Cells[3].Value = user.LastName;
                if (user.LastSeen != null)
                    dataGridView1.Rows[i].Cells[4].Value = user.LastSeen.Time;
                if (user.CanWritePrivateMessage == true) {
                    dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Green;
                    dataGridView1.Rows[i].Cells[5].Value = "Открыто";
                } else {
                    dataGridView1.Rows[i].Cells[5].Style.ForeColor = Color.Red;
                    dataGridView1.Rows[i].Cells[5].Value = "Закрыто";
                }
                i++;
                toolStripLabelStatus.Text = "Goods " + i + " из " + IDList.UserList.Count;
                toolStripProgressBar1.PerformStep();
            }
            MessageBox.Show("Готово!");
        }
    }
}
