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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            dgv_showFlats12.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Employee.xml");
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

                    if (dgv_showFlats12.ColumnCount == 0)
                    {
                        dgv_showFlats12.Columns.Add(flatID, flatID);
                        dgv_showFlats12.Columns.Add(customerID, customerID);
                        dgv_showFlats12.Columns.Add(empID, empID);
                        dgv_showFlats12.Columns.Add(flatDesc, flatDesc);
                        dgv_showFlats12.Columns.Add(price, price);
                        dgv_showFlats12.Columns.Add(flatLocation, flatLocation);
                        dgv_showFlats12.Columns.Add(flatStatus, flatStatus);
                        dgv_showFlats12.Columns.Add(customerReview, customerReview);

                    }
                    dgv_showFlats12.Rows.Add(new string[] { fvalue, cvalue, evalue, fdvalue, pvalue, flvalue, fsvalue, crvalue });


                }
            }
        }
        



        ///////////////////////////////////////////////////////////////////


        private void button1_Click(object sender, EventArgs e)
        {
            string x;
            x = bunifuRating1.Value.ToString();
            int xused = int.Parse(x);
            XmlDocument doc = new XmlDocument();
            doc.Load("Employee.xml");
           // string empid = ;
            
            XmlNodeList list = doc.GetElementsByTagName("employee");
            for (int i = 0; i < list.Count; i++)
            {


                XmlNodeList children = list[i].ChildNodes;
                if (children[0].InnerText == textBox1.Text)
                {
                    double rateused = double.Parse(children[2].InnerText);
                    rateused += (2 * xused);
                    rateused = rateused / 2;
                    children[2].InnerText = rateused.ToString();
                }
            }
            doc.Save("Employee.xml");
            MessageBox.Show("Done");

            dgv_showFlats12.Rows.Clear();
            XmlDocument doc2 = new XmlDocument();
            doc.Load("Employee.xml");
            XmlNodeList list2 = doc.GetElementsByTagName("employee");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;

                string idname = children[0].Name;
                string id = children[0].InnerText;

                string assflats = children[1].Name;
                string ass = children[1].InnerText;

                string rate = children[2].Name;
                string ratev = children[2].InnerText;

                if (dgv_showFlats12.Columns.Count == 0)
                {
                    dgv_showFlats12.Columns.Add("Id", idname);

                    dgv_showFlats12.Columns.Add("Assigned Flats", assflats);

                    dgv_showFlats12.Columns.Add("Rate", ratev);
                }
                dgv_showFlats12.Rows.Add(new string[] { id, ass, ratev });

            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any Unsaved Changes Will Be Lost,Do Want to Close", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
                this.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("Employee.xml");
            XmlNodeList list = doc.GetElementsByTagName("employee");
            for (int i = 0; i < list.Count; i++)
            {

                XmlNodeList children = list[i].ChildNodes;
               
                    string idname = children[0].Name;
                    string id = children[0].InnerText;

                    string assflats = children[1].Name;
                    string ass = children[1].InnerText;

                    string rate = children[2].Name;
                    string ratev = children[2].InnerText;

                    if (dgv_showFlats12.Columns.Count == 0)
                    {
                        dgv_showFlats12.Columns.Add("Id", idname);

                        dgv_showFlats12.Columns.Add("Assigned Flats", assflats);

                        dgv_showFlats12.Columns.Add("Rate", rate);
                    }
                    dgv_showFlats12.Rows.Add(new string[] { id, ass, ratev });

                

            }
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }

        private void dgv_showFlats12_Click(object sender, EventArgs e)
        {
          //  textBox1.Text = dgv_showFlats12.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgv_showFlats12_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
        }