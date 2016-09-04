using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCollectionTest
{
    public partial class MainForm : Form
    {
        private StringCollection scStringCollection = new StringCollection();
        private NameValueCollection nvcNameValueCollection = new NameValueCollection();


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStringCollection_Click(object sender, EventArgs e)
        {
            scStringCollection.Add(txtStringCollection.Text);
            txtStringCollection.Clear();
            txtStringCollection.Focus();
            lstStringCollection.Items.Clear();
            foreach (string value in scStringCollection) {
                lstStringCollection.Items.Add(value);
            }
        }

        private void btnNameValueCollection_Click(object sender, EventArgs e)
        {
            nvcNameValueCollection.Add(txtNameValueCollection.Text, txtNameValueCollection.Text);
            txtNameValueCollection.Clear();
            txtNameValueCollection.Focus();
            lstNameValueCollection.Items.Clear();
            foreach (string key in nvcNameValueCollection.Keys )
            {
                lstNameValueCollection.Items.Add(key+":" + nvcNameValueCollection.Get(key));
            }
        }


    }
}
