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

namespace Project2
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Any Unsaved Changes Will Be Lost,Do Want to Close", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show();
        }

        private void btsmenu_Click(object sender, EventArgs e)
        {
            if (sidemenu.Width == 48)
            {
                bunifuFlatButton2.Visible = true;
                bunifuFlatButton1.Visible = true;
                bunifuFlatButton3.Visible = true;
                sidemenu.Visible = false;
                sidemenu.Width = 235;
                panelanimator2.ShowSync(sidemenu);
                logoanimator.ShowSync(logo);


            }
            else
            {
                bunifuFlatButton2.Visible = false;
                bunifuFlatButton1.Visible = false;
                bunifuFlatButton3.Visible = false;
                logoanimator.HideSync(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 48;
                panelanimator2.ShowSync(sidemenu);
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //animator
            if (sidemenu.Width == 48)
            {
                bunifuFlatButton2.Visible = true;
                bunifuFlatButton1.Visible = true;
                bunifuFlatButton3.Visible = true;
                sidemenu.Visible = false;
                sidemenu.Width = 235;
                panelanimator2.ShowSync(sidemenu);
                logoanimator.ShowSync(logo);


            }
            else
            {
                bunifuFlatButton2.Visible = false;
                bunifuFlatButton1.Visible = false;
                bunifuFlatButton3.Visible = false;
                logoanimator.HideSync(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 48;
                panelanimator2.ShowSync(sidemenu);
            }
           // animator


           
            //Show texts
            textBox2.Visible = true;
            label15.Visible = true;

            textBox2.Width = 95;
            label15.Height = 20;

            label4.Visible = false;
            txt_customerID.Visible = false;
            label14.Visible = false;
            textBox1.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;
            txt_customerName.Visible = false;
            txt_Address.Visible = false;
            txt_phoneNo.Visible = false;
            label4.Visible = true;
            txt_customerID.Visible = true;
            button9.Visible = false;
            button8.Visible = false;
            button10.Visible = false;
            dgv_showCustomers.Visible = false;
            button11.Visible = false;
            
            button5.Visible = false;
            dgv_showEmployees.Visible = false;
            button6.Visible = false;
            label3.Visible = true;
            
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            
            label10.Visible = true;
            txt_flatID.Visible = true;
            
            txt_EmpID.Visible = true;
            txt_flatDesc.Visible = true;
            txt_price.Visible = true;
            txt_flatLocation.Visible = true;
            txt_flatID.Width = 95;
            txt_flatID.Height = 20;



            txt_customerID.Width = 95;
            txt_customerID.Height = 20;

            txt_EmpID.Width = 95;
            txt_EmpID.Height = 20;
            txt_flatDesc.Width = 95;
            txt_flatDesc.Height = 20;
            txt_price.Width = 95;
            txt_price.Height = 20;
            txt_flatLocation.Width = 95;
            txt_flatLocation.Height = 20;
            
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button1.Width = 70;
            button1.Height = 28;
            button2.Width = 70;
            button2.Height = 28;
            button3.Width = 70;
            button3.Height = 28;
            button4.Visible = true;
            button4.Width = 90;
            button4.Height = 28;
            dgv_showFlats.Visible = true;
            //show texts

            //////////code of the button:

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            ///animator 
            if (sidemenu.Width == 48)
            {
                bunifuFlatButton2.Visible = true;
                bunifuFlatButton1.Visible = true;
                bunifuFlatButton3.Visible = true;
                sidemenu.Visible = false;
                sidemenu.Width = 235;
                panelanimator2.ShowSync(sidemenu);
                logoanimator.ShowSync(logo);


            }
            else
            {
                bunifuFlatButton2.Visible = false;
                bunifuFlatButton1.Visible = false;
                bunifuFlatButton3.Visible = false;
                logoanimator.HideSync(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 48;
                panelanimator2.ShowSync(sidemenu);
            }
            //animator


            //show texts

            label15.Visible = false;
            textBox2.Visible = false;
            label4.Visible = false;
            txt_customerID.Visible = false;
            txt_customerName.Visible = false;

            label14.Visible = false;
            textBox1.Visible = false;
            button4.Visible = false;
            label3.Visible = false;
            
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            
            label10.Visible = false;
            txt_flatID.Visible = false;
            
            txt_EmpID.Visible = false;
            txt_flatDesc.Visible = false;
            txt_price.Visible = false;
            txt_flatLocation.Visible = false;
           
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label13.Visible = false;
            label12.Visible = false;
            label11.Visible = false;

            txt_Address.Visible = false;
            txt_phoneNo.Visible = false;
            
            button9.Visible = false;
            button8.Visible = false;
            button10.Visible = false;
            dgv_showCustomers.Visible = false;
            button11.Visible = false;



            button6.Visible = true;
            button6.Width = 90;
            button6.Height = 28;
            txt_flatID.Visible = true;
            txt_EmpID.Visible = true;
            txt_flatID.Width = 95;
            txt_flatID.Height = 20;
            txt_EmpID.Width = 95;
            txt_EmpID.Height = 20;

            label3.Visible = true;
            label5.Visible = true;

            button5.Visible = true;
            button5.Height = 28;
            button5.Width = 130;
            dgv_showEmployees.Visible = true;

            button4.Visible = true;
            button4.Width = 90;
            button4.Height = 28;
            dgv_showFlats.Visible = true;
            //show texts
            //////////code of the button:
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txt_flatID.Text.Length == 0 )
            {
                if (File.Exists("Employee.xml"))
                {
                    bool b = false;
                    XmlDocument doc = new XmlDocument();
                    doc.Load("Employee.xml");
                    XmlNodeList list = doc.GetElementsByTagName("employee");
                    for (int i = 0; i < list.Count; i++)
                    {
                        XmlNodeList children = list[i].ChildNodes;
                        if (children[0].InnerText == txt_EmpID.Text)
                        {
                            b = true;
                        }
                    }
                    if (b == true)
                    {
                        MessageBox.Show("This ID was added before");
                    }
                    else
                    {
                        Employee emp = new Employee();
                        emp.add_employee(txt_EmpID.Text,textBox2.Text);
                        MessageBox.Show("Added successfully");
                    }
                }
                else
                {
                    Employee emp = new Employee();
                    emp.add_employee(txt_EmpID.Text,textBox2.Text);
                    MessageBox.Show("Added successfully");
                }
                
            }
            else
            {
                Flats f = new Flats();
               /* if (txt_flatID.Text.Length == 0)
                {
                    txt_flatID.Text = "";
                }*/
                
                if (txt_EmpID.Text.Length == 0)
                {
                    txt_EmpID.Text = "";
                }
                if (txt_flatDesc.Text.Length == 0)
                {
                    txt_flatDesc.Text = "";
                }
                if (txt_price.Text.Length == 0)
                {
                    txt_price.Text = "";
                }
                if (txt_flatLocation.Text.Length == 0)
                {
                    txt_flatLocation.Text = "";
                }
                
                
                if (File.Exists("flats.xml"))
                {
                    bool b = false;
                    XmlDocument doc = new XmlDocument();
                    doc.Load("flats.xml");
                    XmlNodeList list = doc.GetElementsByTagName("flat");
                    for (int i = 0; i < list.Count; i++)
                    {
                        XmlNodeList children = list[i].ChildNodes;
                        if (children[0].InnerText == txt_flatID.Text)
                        {
                            b = true;
                        }
                    }
                    if (b == true)
                    {
                        MessageBox.Show("This ID was added before");
                    }
                    else
                    {
                        f.insert_flats_info(txt_flatID.Text, txt_flatDesc.Text, txt_price.Text, txt_flatLocation.Text);
                        MessageBox.Show("Added Successfully");
                    }
                }
                else
                {
                    f.insert_flats_info(txt_flatID.Text, txt_flatDesc.Text, txt_price.Text, txt_flatLocation.Text);
                    MessageBox.Show("Added Successfully");
                }
                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (emp.check_ID(txt_flatID.Text, txt_EmpID.Text)==true)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Employee.xml");
                XmlNodeList list = doc.GetElementsByTagName("employee");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    if (children[0].InnerText == txt_EmpID.Text)
                    {
                        if (int.Parse(children[1].InnerText) >= 5)
                        {
                            MessageBox.Show("No.of assigned flats =5");
                            break;
                        }
                        else
                        {
                            Employee.no_AssignedFlats = int.Parse(children[1].InnerText);
                            if (emp.assign_flat(txt_flatID.Text, txt_EmpID.Text) == true)
                            {
                                MessageBox.Show("Assigned Successfully");

                                emp.no_assigned_flats(txt_EmpID.Text,++Employee.no_AssignedFlats);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("This flat was assigned");
                                break;
                            }
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Flat ID or Employee ID is wrong");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgv_showEmployees.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Employee.xml");
            XmlNodeList list = doc.GetElementsByTagName("employee");
            for (int i=0;i<list.Count;i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                string empID = children[0].Name;
                string evalue = children[0].InnerText;

                string no_assigned = children[1].Name;
                string nvalue = children[1].InnerText;

                string rate = children[2].Name;
                string rvalue = children[2].InnerText;

                

                if (dgv_showEmployees.ColumnCount==0)
                {
                    dgv_showEmployees.Columns.Add(empID, empID);
                    dgv_showEmployees.Columns.Add(no_assigned, no_assigned);
                    dgv_showEmployees.Columns.Add(rate, rate);
                }
                dgv_showEmployees.Rows.Add(new string[] { evalue, nvalue, rvalue });

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists("flats.xml"))
            {
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            if (txt_flatID.Text.Length > 0)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("flats.xml");
                foreach (XmlNode node in doc.SelectNodes("RE/flat"))
                {
                    if (node.SelectSingleNode("FlatID").InnerText == txt_flatID.Text)
                    {
                        emp.reduce_Noassigned(node.SelectSingleNode("EmpID").InnerText);
                        node.ParentNode.RemoveChild(node);
                        
                    }
                }
                doc.Save("flats.xml");
                MessageBox.Show("Deleted");
                
            }
            else if (txt_EmpID.Text.Length>0)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Employee.xml");
                foreach (XmlNode node in doc.SelectNodes("RE/employee"))
                {
                    if (node.SelectSingleNode("EmpID").InnerText == txt_EmpID.Text)
                    {
                        emp.delete_flatemp(txt_EmpID.Text);

                        node.ParentNode.RemoveChild(node);
                    }
                }
                doc.Save("Employee.xml");
                MessageBox.Show("Deleted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");
            for (int i=0;i<list.Count;i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                if (children[0].InnerText==txt_flatID.Text)
                {
                  
                   
                    children[3].InnerText = txt_flatDesc.Text;
                    children[4].InnerText = txt_price.Text;
                    children[5].InnerText = txt_flatLocation.Text;
                  
                    doc.Save("flats.xml");
                }
            }
            MessageBox.Show("Updated successfully");
            if (txt_EmpID.Text.Length>0)
            {
                XmlDocument doc1 = new XmlDocument();
                doc1.Load("Employee.xml");
                XmlNodeList list1 = doc1.GetElementsByTagName("employee");
                for (int i = 0; i < list1.Count; i++)
                {
                    XmlNodeList children1 = list1[i].ChildNodes;
                    if (children1[0].InnerText == txt_EmpID.Text)
                    {

                        children1[3].InnerText = textBox2.Text;

                        doc1.Save("Employee.xml");
                    }
                }
               
            }
        }

        private void dgv_showEmployees_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_showFlats_Click(object sender, EventArgs e)
        {
            txt_flatID.Text = dgv_showFlats.CurrentRow.Cells[0].Value.ToString();
            txt_flatDesc.Text = dgv_showFlats.CurrentRow.Cells[3].Value.ToString();
            txt_price.Text = dgv_showFlats.CurrentRow.Cells[4].Value.ToString();
            txt_flatLocation.Text = dgv_showFlats.CurrentRow.Cells[5].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {  //button gher da
         /*   XmlDocument doc = new XmlDocument();
            doc.Load("flats.xml");
            XmlNodeList list = doc.GetElementsByTagName("flat");



            if (MessageBox.Show("Do you want to confirm", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < list.Count; i++)
                {

                    XmlNodeList children = list[i].ChildNodes;
                    if (children[0].InnerText == txt_flatID.Text)
                    {
                        children[1].InnerText = txt_customerID.Text;
                        children[6].InnerText = "taken";
                    }
                } doc.Save("flats.xml");

                MessageBox.Show("Confirmed");
            }
            else
            {
                Close();
            }
            //
            Employee emp = new Employee();
            emp.un_assign_employee();
            MessageBox.Show("Done");*/
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ///animator 
            if (sidemenu.Width == 48)
            {
                bunifuFlatButton2.Visible = true;
                bunifuFlatButton1.Visible = true;
                bunifuFlatButton3.Visible = true;
                sidemenu.Visible = false;
                sidemenu.Width = 235;
                panelanimator2.ShowSync(sidemenu);
                logoanimator.ShowSync(logo);
                

            }
            else
            {
                bunifuFlatButton2.Visible = false;
                bunifuFlatButton1.Visible = false;
                bunifuFlatButton3.Visible = false;
                logoanimator.HideSync(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 48;
                panelanimator2.ShowSync(sidemenu);
            }
            //animator

            button6.Visible = false;
           // dgv
            button5.Visible = false;
            dgv_showEmployees.Visible = false;
            dgv_showFlats.Visible = false;


            label15.Visible = false;
            textBox2.Visible = false;
            label4.Visible = true;
            txt_customerID.Visible = true;

            txt_customerID.Width = 95;
            txt_customerID.Height = 20;

            label14.Visible = true; //password
            textBox1.Visible = true;//password


            textBox1.Width = 95;
            textBox1.Height = 20;


            button4.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            
            label10.Visible = false;
            txt_flatID.Visible = false;
            txt_EmpID.Visible = false;
            txt_flatDesc.Visible = false;
            txt_price.Visible = false;
            txt_flatLocation.Visible = false;
            
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;

            txt_customerName.Visible = true;


            label13.Visible = true;
            label12.Visible = true;
            label11.Visible = true;
            
            txt_Address.Visible = true;
            txt_phoneNo.Visible = true;
            
            button9.Visible = true;
            button8.Visible = true;
            button10.Visible = true;
            dgv_showCustomers.Visible = true;
           
            
            button11.Visible = true;

            
           
            txt_customerName.Width = 95;
            txt_customerName.Height = 20;
            
            txt_Address.Width = 95;
            txt_Address.Height = 20;
            
            txt_phoneNo.Width = 95;
            txt_phoneNo.Height = 20;



            
            button10.Width = 90;
            button10.Height = 28;
            
            button9.Width = 90;
            button9.Height = 28;
            
            button8.Width = 90;
            button8.Height = 28;
            
            button11.Width = 90;
            button11.Height = 28;

            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (File.Exists("Customers.xml"))
            {
                bool b = false;
                XmlDocument doc = new XmlDocument();
                doc.Load("Customers.xml");
                XmlNodeList list = doc.GetElementsByTagName("customer");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    if (children[0].InnerText == txt_customerID.Text)
                    {
                        b = true;
                    }
                }
                if (b == true)
                {
                    MessageBox.Show("This ID was added before");
                }
                else
                {
                    Customers c = new Customers();
                    c.add_customer(txt_customerID.Text, txt_customerName.Text, txt_Address.Text, txt_phoneNo.Text,textBox1.Text);
                    MessageBox.Show("Added successfully");
                }
            }
            else
            {
                Customers c = new Customers();
                c.add_customer(txt_customerID.Text, txt_customerName.Text, txt_Address.Text, txt_phoneNo.Text, textBox1.Text);
                MessageBox.Show("Added successfully");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Customers.xml");
            XmlNodeList list = doc.GetElementsByTagName("customer");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                if (children[0].InnerText == txt_customerID.Text)
                {
                    children[1].InnerText = txt_customerName.Text;
                    children[2].InnerText = txt_Address.Text;
                    children[3].InnerText = txt_phoneNo.Text;
                    children[4].InnerText = textBox1.Text;
                    
                    doc.Save("Customers.xml");
                }
            }
            MessageBox.Show("Updated successfully");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Customers c = new Customers();
            XmlDocument doc = new XmlDocument();
            doc.Load("Customers.xml");
            foreach (XmlNode node in doc.SelectNodes("RE/customer"))
            {
                if (node.SelectSingleNode("CustomerID").InnerText == txt_customerID.Text)
                {
                    c.delete_customerfromflats(txt_customerID.Text);
                    node.ParentNode.RemoveChild(node);
                }
            }
            doc.Save("Customers.xml");
            MessageBox.Show("Deleted");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dgv_showCustomers.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Customers.xml");
            XmlNodeList list = doc.GetElementsByTagName("customer");
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList children = list[i].ChildNodes;
                string cusID = children[0].Name;
                string cvalue = children[0].InnerText;

                string cusName = children[1].Name;
                string nvalue = children[1].InnerText;

                string address = children[2].Name;
                string avalue = children[2].InnerText;

                string phone_number = children[3].Name;
                string pvalue = children[3].InnerText;

                if (dgv_showCustomers.ColumnCount == 0)
                {
                    dgv_showCustomers.Columns.Add(cusID, cusID);
                    dgv_showCustomers.Columns.Add(cusName, cusName);
                    dgv_showCustomers.Columns.Add(address, address);
                    dgv_showCustomers.Columns.Add(phone_number, phone_number);
                }
                dgv_showCustomers.Rows.Add(new string[] { cvalue, nvalue, avalue, pvalue });

            }
        }

        private void dgv_showCustomers_MouseClick(object sender, MouseEventArgs e)
        {
            txt_customerID.Text = dgv_showCustomers.CurrentRow.Cells[0].Value.ToString();
            txt_customerName.Text = dgv_showCustomers.CurrentRow.Cells[1].Value.ToString();
            txt_Address.Text = dgv_showCustomers.CurrentRow.Cells[2].Value.ToString();
            txt_phoneNo.Text = dgv_showCustomers.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgv_showFlats_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
