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
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            XmlDocument doc1 = new XmlDocument();
            doc1.Load("customers.xml");
            XmlNodeList list = doc1.GetElementsByTagName("customers");



            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList xc = list[i].ChildNodes;
                string flatID = xc[0].Name;
                string ivaluee = xc[0].InnerText;
                string customerID_flat = xc[1].Name;
                string isw = xc[1].InnerText;
                string empID_f = xc[2].Name;
                string ival = xc[2].InnerText;
                string flatDesc = xc[3].Name;
                string ivalu = xc[3].InnerText;
                string price = xc[4].Name;
                string ivalue1 = xc[4].InnerText;
                string flatLocation = xc[5].Name;
                string ivalue = xc[5].InnerText;
                string flatStatus = xc[6].Name;
                string nvalue = xc[6].InnerText;



                dataGridView2.Rows.Add(new string[] { ivaluee, isw, ival, ivalu, ivalue1, ivalue, nvalue });

            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            string id_c = textBox2.Text;
            string customers_review = textBox1.Text;
            
            XmlDocument doc = new XmlDocument();
            doc.Load("customers.xml");
            XmlNodeList list = doc.GetElementsByTagName("customers");



            for (int i = 0; i < list.Count; i++)

            {
                
                XmlNodeList xc = list[i].ChildNodes;
                if (xc[0].InnerText == textBox2.Text)
                {
                    xc[7].InnerText = textBox1.Text;
                }
                doc.Save("customers.xml");

                MessageBox.Show("added sucessfully");

            }
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
                dataGridView1.Rows.Clear();
                XmlDocument doc = new XmlDocument();
                doc.Load("customers.xml");
                XmlNodeList list = doc.GetElementsByTagName("customers");



                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList d = list[i].ChildNodes;
                string flatID = d[0].Name;
                string ivaluee = d[0].InnerText;

                string customer_Reviews = d[7].Name;
                    string mnvalue = d[7].InnerText;


                    dataGridView1.Rows.Add(new string[] { ivaluee, mnvalue });

                }
            }
        }
    }
    



