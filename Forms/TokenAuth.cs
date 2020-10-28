using System;
using System.Windows.Forms;
using VkListInfo.Classes;
using VkNet.Exception;

namespace VkListInfo.Forms {
    public partial class TokenAuth : Form {

        public TokenAuth() {
            InitializeComponent();
        }

        private void GetToken_Load(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                VKClass.VK.Auth(textBoxToken.Text);
                DialogResult = DialogResult.OK;
            }
            catch (VkApiException) {
                MessageBox.Show("Непонятная ошибка");
            }
            catch {
                if (textBoxToken.Text == "") MessageBox.Show("Не введен токен");
                else MessageBox.Show("Непонятная ошибка");
            }
        }
    }
}
