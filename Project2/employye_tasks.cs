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
namespace Project2
{
    public partial class employye_tasks : Form
    {
        public string s = "";
        public employye_tasks()
        {
            InitializeComponent();
        }
        public employye_tasks(string e_ID)
        {
            InitializeComponent();
            s = e_ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                if (children[0].InnerText == textBox1.Text)
                {
                    children[3].InnerText = textBox2.Text;
                    children[4].InnerText = textBox3.Text;
                    children[5].InnerText = textBox5.Text;
                    doc.Save("flats.xml");
                }
            }
            MessageBox.Show("Updated successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");

            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    if (children[2].InnerText == s)
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
                        dataGridView1.Rows.Add(new string[] { fvalue, cvalue, evalue, fdvalue, pvalue, flvalue, fsvalue, crvalue });
                    }
                }
                 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                if (children[0].InnerText == textBox1.Text)
                {
                    children[6].InnerText = textBox3.Text;

                    doc.Save("flats.xml");
                }
            }
            MessageBox.Show("Updated successfully");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
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

                    if (dataGridView2.ColumnCount == 0)
                    {
                        dataGridView2.Columns.Add(flatID, flatID);
                        dataGridView2.Columns.Add(customerID, customerID);
                        dataGridView2.Columns.Add(empID, empID);
                        dataGridView2.Columns.Add(flatDesc, flatDesc);
                        dataGridView2.Columns.Add(price, price);
                        dataGridView2.Columns.Add(flatLocation, flatLocation);
                        dataGridView2.Columns.Add(flatStatus, flatStatus);
                        dataGridView2.Columns.Add(customerReview, customerReview);
                    }
                    dataGridView2.Rows.Add(new string[] { fvalue, cvalue, evalue, fdvalue, pvalue, flvalue, fsvalue, crvalue });

                }
            }
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any Unsaved Changes Will Be Lost,Do Want to Close", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void employye_tasks_Load(object sender, EventArgs e)
        {

        }
     }
    }
