using sample;
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
using WindowsFormsApp2;
using System.IO;

namespace Project2
{


    public partial class Form4 : Form
    {
        public int counter;
        public string s;
        public Form4()
        {
            InitializeComponent();

        }
        public Form4(string s1)
        {
            InitializeComponent();
            s = s1;
        }
        //public Form4(int i)
        //{
        //    InitializeComponent();

        //}
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any Unsaved Changes Will Be Lost,Do Want to Close", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox1.Visible = true;
            dgv_showFlats.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");


            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string flatID = children[0].Name;
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

                    if (dgv_showFlats.ColumnCount == 0)
                    {
                        dgv_showFlats.Columns.Add(flatID, flatID);
                        dgv_showFlats.Columns.Add(customerID, customerID);
                        dgv_showFlats.Columns.Add(empID, empID);
                        dgv_showFlats.Columns.Add(flatDesc, flatDesc);
                        dgv_showFlats.Columns.Add(price, price);
                        dgv_showFlats.Columns.Add(flatLocation, flatLocation);
                        dgv_showFlats.Columns.Add(flatStatus, flatStatus);
                        dgv_showFlats.Columns.Add(customerReview, customerReview);

                    }
                    dgv_showFlats.Rows.Add(new string[] { fvalue, cvalue, evalue, fdvalue, pvalue, flvalue, fsvalue, crvalue });


                }
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            textBox1.Visible = true;
            dgv_showFlats.Rows.Clear();

            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            doc.Load("flats.xml");
            doc2.Load("Customers.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");
            XmlNodeList list2 = doc2.GetElementsByTagName("customer");

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    XmlNodeList children2 = list2[counter].ChildNodes;
                    if (children2[2].InnerText == children[5].InnerText)
                    {
                        string flatID = children[0].Name;
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

                        if (dgv_showFlats.ColumnCount == 0)
                        {
                            dgv_showFlats.Columns.Add(flatID, flatID);
                            dgv_showFlats.Columns.Add(customerID, customerID);
                            dgv_showFlats.Columns.Add(empID, empID);
                            dgv_showFlats.Columns.Add(flatDesc, flatDesc);
                            dgv_showFlats.Columns.Add(price, price);
                            dgv_showFlats.Columns.Add(flatLocation, flatLocation);
                            dgv_showFlats.Columns.Add(flatStatus, flatStatus);
                            dgv_showFlats.Columns.Add(customerReview, customerReview);

                        }
                        dgv_showFlats.Rows.Add(new string[] { fvalue, cvalue, evalue, fdvalue, pvalue, flvalue, fsvalue, crvalue });
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            string fav = textBox1.Text;
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            doc.Load("flats.xml");
            doc2.Load("Customers.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");
            XmlNodeList list2 = doc2.GetElementsByTagName("customer");

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    XmlNodeList children2 = list2[j].ChildNodes;
                    if (children2[0].InnerText == s)
                    {
                        if (children[0].InnerText == fav)
                        {
                            children2[5].InnerText += fav + "/";

                        }
                    }
                }

            }
            doc.Save("flats.xml");
            doc2.Save("Customers.xml");

            MessageBox.Show("added");
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Visible = false;

            dgv_showFlats.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            doc.Load("flats.xml");
            doc2.Load("Customers.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");
            XmlNodeList list2 = doc2.GetElementsByTagName("customer");

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    XmlNodeList children2 = list2[j].ChildNodes;

                    if (children2[0].InnerText == s)
                    {
                        string[] okay = children2[5].InnerText.Split('/');
                        // int c = 0;


                        for (int m = 0; m < okay.Length; m++)
                        {
                           
                            if (children[0].InnerText == okay[m])
                            {
                                string flatID = children[0].Name;
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

                                if (dgv_showFlats.ColumnCount == 0)
                                {
                                    dgv_showFlats.Columns.Add(flatID, flatID);
                                    dgv_showFlats.Columns.Add(customerID, customerID);
                                    dgv_showFlats.Columns.Add(empID, empID);
                                    dgv_showFlats.Columns.Add(flatDesc, flatDesc);
                                    dgv_showFlats.Columns.Add(price, price);
                                    dgv_showFlats.Columns.Add(flatLocation, flatLocation);
                                    dgv_showFlats.Columns.Add(flatStatus, flatStatus);
                                    dgv_showFlats.Columns.Add(customerReview, customerReview);

                                }
                                dgv_showFlats.Rows.Add(new string[] { fvalue, cvalue, evalue, fdvalue, pvalue, flvalue, fsvalue, crvalue });

                            }



                        }

                    }
                }
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            add_ads a = new add_ads(s);
            a.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
        }



        private void button4_Click_1(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            string fav = textBox1.Text;
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            doc.Load("flats_ads.xml");
            doc2.Load("Customers.xml");
            XmlNodeList list = doc.GetElementsByTagName("flats_ads");
            XmlNodeList list2 = doc2.GetElementsByTagName("customer");

            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    XmlNodeList children2 = list2[j].ChildNodes;
                    if (children2[0].InnerText == s)
                    {
                        if (children[0].InnerText == fav)
                        {
                            children2[5].InnerText += fav + "/";

                        }
                    }
                }

            }
            doc.Save("flats_ads.xml");
            doc2.Save("Customers.xml");

            MessageBox.Show("added");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            textBox1.Visible = false;

            dgv_showFlats.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            XmlDocument doc2 = new XmlDocument();
            if (File.Exists("flats_ads.xml"))
            {
                doc.Load("flats_ads.xml");
                doc2.Load("Customers.xml");
                XmlNodeList list = doc.GetElementsByTagName("flats_ads");
                XmlNodeList list2 = doc2.GetElementsByTagName("customer");

                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = 0; j < list2.Count; j++)
                    {
                        XmlNodeList children = list[i].ChildNodes;
                        XmlNodeList children2 = list2[j].ChildNodes;

                        if (children2[0].InnerText == s)
                        {
                            string[] okay = children2[5].InnerText.Split('/');
                            // int c = 0;


                            for (int m = 0; m < okay.Length; m++)
                            {
                                if (children[0].InnerText == okay[m])
                                {
                                    string flatID = children[0].Name;
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
                                    string flat_status = children[6].Name;
                                    string fsvalue = children[6].InnerText;

                                    if (dgv_showFlats.ColumnCount == 0)
                                    {
                                        dgv_showFlats.Columns.Add(flatID, flatID);
                                        dgv_showFlats.Columns.Add(customerID, customerID);

                                        dgv_showFlats.Columns.Add(flatDesc, flatDesc);
                                        dgv_showFlats.Columns.Add(price, price);
                                        dgv_showFlats.Columns.Add(flatLocation, flatLocation);

                                        dgv_showFlats.Columns.Add(customerReview, customerReview);
                                        dgv_showFlats.Columns.Add(flat_status, flat_status);
                                    }
                                    dgv_showFlats.Rows.Add(new string[] { fvalue, cvalue, fdvalue, pvalue, flvalue, crvalue, fsvalue });

                                }
                            }
                        }
                    }
                }
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            buy2 b = new buy2(s);
            b.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buy b = new buy(s);
            b.Show();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}

                        
                    
             
                        
                    

    