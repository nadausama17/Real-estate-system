using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Project2;

namespace WindowsFormsApp2
{
    public partial class add_ads : Form
    {
        public string s="";
        public add_ads()
        {
            InitializeComponent();
        }
        public add_ads(String c_ID)
        {
            InitializeComponent();
            s = c_ID;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b1 = true;
            bool b2 = true;
            XmlDocument doc1 = new XmlDocument();
            doc1.Load("flats.xml");
            XmlNodeList list = doc1.GetElementsByTagName("FlatID");
            for (int i=0;i<list.Count;i++)
            {
                if (textBox1.Text==list[i].InnerText)
                {
                    b1 = false;
                }
            }
            if (File.Exists("flats_ads.xml"))
            {
                XmlDocument doc2 = new XmlDocument();
                doc2.Load("flats_ads.xml");
                XmlNodeList list2 = doc2.GetElementsByTagName("flat_id");
                for (int i = 0; i < list2.Count; i++)
                {
                    if (textBox1.Text == list2[i].InnerText)
                    {
                        b2 = false;
                    }
                }
            }

            if (b1 == true && b2 == true)
            {
                string flat_id = textBox1.Text;
               // string customerID_f = textBox7.Text;

                string flatDesc = textBox6.Text;
                string price = textBox2.Text;
                string flatLocation = textBox3.Text;


                if (!File.Exists("flats_ads.xml"))
                {
                    XmlWriter writer = XmlWriter.Create("flats_ads.xml");
                    writer.WriteStartDocument();
                    writer.WriteStartElement("table");
                    writer.WriteAttributeString("name", "flat1_ads");
                    writer.WriteStartElement("flats_ads");
                    writer.WriteStartElement("flat_id");
                    writer.WriteString(flat_id);
                    writer.WriteEndElement();
                  
                    writer.WriteStartElement("customerID_f");
                    writer.WriteString(s);
                    writer.WriteEndElement();

                    writer.WriteStartElement("flatDesc");
                    writer.WriteString(flatDesc);
                    writer.WriteEndElement();
                    writer.WriteStartElement("price");
                    writer.WriteString(price);

                    writer.WriteEndElement();

                    writer.WriteStartElement("flatLocation");
                    writer.WriteString(flatLocation);
                    writer.WriteEndElement();





                    writer.WriteStartElement("customer_Reviews");
                    writer.WriteString("");
                    writer.WriteEndElement();
                    writer.WriteStartElement("flat_status");
                    writer.WriteString("");
                    writer.WriteEndElement();

                    writer.WriteStartElement("buyer_id");
                    writer.WriteString("");
                    writer.WriteEndElement();

                    
                    writer.WriteEndElement();

                    writer.WriteEndDocument();
                    writer.Close();
                    MessageBox.Show("added sucessfully");
                }
                else
                {
                    XmlDocument doc = new XmlDocument();

                    XmlElement customers = doc.CreateElement("flats_ads");
                    XmlElement node = doc.CreateElement("flat_id");
                    node.InnerText = flat_id;
                    customers.AppendChild(node);
                    
                    
                    node = doc.CreateElement("customerID_f");
                    node.InnerText = s;
                    customers.AppendChild(node);

                    node = doc.CreateElement("flatDesc");
                    node.InnerText = flatDesc;
                    customers.AppendChild(node);
                    node = doc.CreateElement("price");
                    node.InnerText = price;
                    customers.AppendChild(node);

                    node = doc.CreateElement("flatLocation");
                    node.InnerText = flatLocation;
                    customers.AppendChild(node);


                    node = doc.CreateElement("customer_Reviews");
                    node.InnerText = "";
                    customers.AppendChild(node);

                    node = doc.CreateElement("flat_status");
                    node.InnerText = "";
                    customers.AppendChild(node);

                    node = doc.CreateElement("buyer_id");
                    node.InnerText = "";
                    customers.AppendChild(node);

                    doc.Load("flats_ads.xml");
                    XmlElement root1 = doc.DocumentElement;
                    root1.AppendChild(customers);
                    doc.Save("flats_ads.xml");

                    MessageBox.Show("added sucessfully");

                }
            }
            else
            {
                MessageBox.Show("This ID was taken");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }
    }
    }

