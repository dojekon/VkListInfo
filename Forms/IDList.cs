using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VkListInfo.Forms {
    public partial class IDList : Form {
        public IDList() {
            InitializeComponent();
        }
        public static List<long> UserList = new List<long>();
        private void button1_Click(object sender, EventArgs e) {
            Regex rg = new Regex(@"([0-9]+)");
            MatchCollection matchedIDs = rg.Matches(textBox1.Text);
            if (matchedIDs.Count > 0) {
                foreach (Match id in matchedIDs) {
                    UserList.Add(Convert.ToInt64(id.Value));
                }
            }
            DialogResult = DialogResult.OK;            
        }
    }
}
