using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("flats_ads.xml");
            XmlNodeList list = doc.GetElementsByTagName("flats_ads");


                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string flatID = children[0].Name;
                    string fvalue = children[0].InnerText;

                    string customerID_f = children[1].Name;
                    string cvalue = children[1].InnerText;

                    string flatDes = children[2].Name;
                    string evalue = children[2].InnerText;

                   

                    string price = children[3].Name;
                    string pvalue = children[3].InnerText;

                    string flatLocation = children[4].Name;
                    string flvalue = children[4].InnerText;

                

                   

                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add(flatID, flatID);
                        dataGridView1.Columns.Add(customerID_f, customerID_f);
                      
                        dataGridView1.Columns.Add(flatDes, flatDes);
                        dataGridView1.Columns.Add(price, price);
                        dataGridView1.Columns.Add(flatLocation, flatLocation);
                       
                       

                    }
                    dataGridView1.Rows.Add(new string[] { fvalue, cvalue, evalue,  pvalue, flvalue });


                }
            }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any Unsaved Changes Will Be Lost,Do Want to Close", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
                this.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}
