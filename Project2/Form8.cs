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

    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string falt_id = textBox1.Text;
            string review = textBox2.Text;
            XmlDocument doc = new XmlDocument();

            doc.Load("flats.xml");

            XmlNodeList list = doc.GetElementsByTagName("flat");

            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList children = list[i].ChildNodes;

                if (children[0].InnerText == falt_id)
                {

                    children[7].InnerText += review + "/";


                }
            }


            doc.Save("flats.xml");


            MessageBox.Show("added");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string falt_id = textBox1.Text; ;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            XmlDocument doc = new XmlDocument();

            doc.Load("flats.xml");

            XmlNodeList list = doc.GetElementsByTagName("flat");


            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList children = list[i].ChildNodes;
                if (children[0].InnerText == falt_id)
                {
                    string[] okay = children[7].InnerText.Split('/');
                    // int c = 0;


                    for (int m = 0; m < okay.Length - 1; m++)
                    {
                        XmlNodeList children1 = list[i].ChildNodes;

                        string flatID = children1[0].Name;
                        string fvalue = children[0].InnerText;

                        string customerID = children[1].Name;
                        string cvalue = children[1].InnerText;

                        string empID = children[2].Name;
                        string evalue = children[2].InnerText;

                        string flatDesc = children[3].Name;
                        string fdvalue = children[3].InnerText;

                        string price = children[4].Name;
                        string pvalue = children[4].InnerText;

                        string flatLocation = children[5].Name;
                        string flvalue = children[5].InnerText;

                        string flatStatus = children[6].Name;
                        string fsvalue = children[6].InnerText;

                        string customerReview = children[7].Name;
                        string crvalue = children[7].InnerText;

                        if (dataGridView1.ColumnCount == 0)
                        {
                            dataGridView1.Columns.Add(flatID, flatID);
                            dataGridView1.Columns.Add(customerID, customerID);
                            dataGridView1.Columns.Add(empID, empID);
                            dataGridView1.Columns.Add(flatDesc, flatDesc);
                            dataGridView1.Columns.Add(price, price);
                            dataGridView1.Columns.Add(flatLocation, flatLocation);
                            dataGridView1.Columns.Add(flatStatus, flatStatus);
                            dataGridView1.Columns.Add(customerReview, customerReview);

                        }
                        dataGridView1.Rows.Add(new string[] { fvalue, cvalue, evalue, fdvalue, pvalue, flvalue, fsvalue, okay[m] });





                    }



                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
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





                if (dataGridView2.ColumnCount == 0)
                {
                    dataGridView2.Columns.Add(flatID, flatID);
                    dataGridView2.Columns.Add(customerID_f, customerID_f);

                    dataGridView2.Columns.Add(flatDes, flatDes);
                    dataGridView2.Columns.Add(price, price);
                    dataGridView2.Columns.Add(flatLocation, flatLocation);



                }
                dataGridView2.Rows.Add(new string[] { fvalue, cvalue, evalue, pvalue, flvalue });


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string falt_id = textBox1.Text;
            string review = textBox2.Text;
            XmlDocument doc = new XmlDocument();

            doc.Load("flats_ads.xml");

            XmlNodeList list = doc.GetElementsByTagName("flats_ads");

            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList children = list[i].ChildNodes;

                if (children[0].InnerText == falt_id)
                {

                    children[5].InnerText += review + "/";


                }
            }


            doc.Save("flats_ads.xml");


            MessageBox.Show("added");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string falt_id = textBox1.Text; ;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            XmlDocument doc = new XmlDocument();

            doc.Load("flats_ads.xml");

            XmlNodeList list = doc.GetElementsByTagName("flats_ads");


            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList children = list[i].ChildNodes;
                if (children[0].InnerText == falt_id)
                {
                    string[] okay = children[5].InnerText.Split('/');
                    // int c = 0;


                    for (int m = 0; m < okay.Length - 1; m++)
                    {
                        XmlNodeList children1 = list[i].ChildNodes;

                        string flatID = children1[0].Name;
                        string fvalue = children[0].InnerText;

                        string customerID = children[1].Name;
                        string cvalue = children[1].InnerText;

                        

                        string flatDesc = children[2].Name;
                        string fdvalue = children[2].InnerText;

                        string price = children[3].Name;
                        string pvalue = children[3].InnerText;

                        string flatLocation = children[4].Name;
                        string flvalue = children[4].InnerText;

                       

                        string customerReview = children[5].Name;
                        string crvalue = children[5].InnerText;

                        if (dataGridView1.ColumnCount == 0)
                        {
                            dataGridView1.Columns.Add(flatID, flatID);
                            dataGridView1.Columns.Add(customerID, customerID);
                        
                            dataGridView1.Columns.Add(flatDesc, flatDesc);
                            dataGridView1.Columns.Add(price, price);
                            dataGridView1.Columns.Add(flatLocation, flatLocation);
                           
                            dataGridView1.Columns.Add(customerReview, customerReview);

                        }
                        dataGridView1.Rows.Add(new string[] { fvalue, cvalue,  fdvalue, pvalue, flvalue,  okay[m] });





                    }
                }
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
    }
}

