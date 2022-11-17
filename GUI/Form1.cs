using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace GUI
{
    public partial class Form1 : Form
    {
        private ILogic logic;

        //lovely little int that allows us to know which Logic.Create method to use
        private int screan;

        //try/catch to inform the user that there is an issue
        public Form1()
        {
            InitializeComponent();
            try
            {
                logic = new InformationSystem();
            }
            catch (Exception)
            {
                //label2 aka "oh no error happened" label
                label2.Visible = true;
                label2.Text = "Can't find the Json files to run this program, fix you god damn code";
            }
            screan = 0;
        }

        //event handler for clicling Products button
        private void button1_Click(object sender, EventArgs e)
        {
            //clear the data grid of old information
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            //create new collumns
            dataGridView1.Columns.Add("productID", "Product ID");
            dataGridView1.Columns.Add("productName", "Product Name");
            dataGridView1.Columns.Add("productDescription", "Product Description");
            dataGridView1.Columns.Add("productPrice", "Product Price");
            dataGridView1.Columns.Add("sellerID", "Seller ID");

            //get the count of products
            int count = logic.GetProductCount();

            //populate the data grid
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    logic.GetProductId(i),
                    logic.GetProductName(i),
                    logic.GetProductDescription(i),
                    logic.GetProductPrice(i),
                    logic.GetProductSellerId(i)
                });
            }
            //a mass of text fields and labels that each has to be set to visible/invisible depending on what we want to do
            label1.Text = "To create a new product please fill in the bottom text fields and click Create button";

            label2.Visible = false;

            textBox1.Visible = true;
            textBox1.Clear();

            label4.Visible = true;
            label4.Text = "Name";

            textBox2.Visible = true;
            textBox2.Clear();

            label5.Visible = true;
            label5.Text = "Description";

            textBox3.Visible = true;
            textBox3.Clear();

            label6.Visible = true;
            label6.Text = "Price";

            textBox4.Visible = false;

            label7.Visible = false;

            textBox5.Visible = false;

            label8.Visible = false;

            textBox6.Visible = false;

            label9.Visible = false;

            textBox7.Visible = false;

            label10.Visible = false;

            textBox8.Visible = false;

            label11.Visible = false;

            textBox9.Visible = false;

            label12.Visible = false;

            textBox10.Visible = false;

            label15.Visible = false;

            label13.Visible = true;
            label13.Text = "Seller";

            //this is the fun little list box that we populate with information of each seller that exist in the system
            //user must pick one, listbox provides sellers Id and Name
            listBox1.Items.Clear();
            listBox1.Visible = true;
            //get the count of sellers
            int sellerCount = logic.GetSellerCount();
            //populate the listbox
            for (int i = 0; i < sellerCount; i++)
            {
                string text = logic.GetSellerId(i) + ", " + logic.GetSellerName(i);
                listBox1.Items.Add(text);
            }

            label14.Visible = false;

            listBox2.Items.Clear();
            listBox2.Visible = false;

            button6.Visible = true;

            label16.Visible = false;

            button7.Visible = false;

            //set screan to 1 so when the user clicks create button the systems know what to do
            screan = 1;
        }

        //handler for Customers button
        //method implementation is similar to button1_Click
        //method updates the datagrid and makes labels and textfields for customer creation visible
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("customerId", "Customer Id");
            dataGridView1.Columns.Add("customerFirstName", "Customer First Name");
            dataGridView1.Columns.Add("customerLastName", "Customer Last Name");
            dataGridView1.Columns.Add("customerCountry", "Customer Country");
            dataGridView1.Columns.Add("customerCity", "Customer City");
            dataGridView1.Columns.Add("customerStreet", "Customer Street");
            dataGridView1.Columns.Add("customerHouseNumber", "Customer House Number");
            dataGridView1.Columns.Add("customerAppartmentNumber", "Customer Appartment Number");
            dataGridView1.Columns.Add("customerPostalCode", "Customer Postal Code");
            dataGridView1.Columns.Add("customerPhoneNumber", "Customer Phone Number");
            dataGridView1.Columns.Add("customerEmail", "Customer Email");

            int count = logic.GetCustomerCount();

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    logic.GetCustomerId(i),
                    logic.GetCustomerFirstName(i),
                    logic.GetCustomerLastName(i),
                    logic.GetCustomerCountry(i),
                    logic.GetCustomerCity(i),
                    logic.GetCustomerStreet(i),
                    logic.GetCustomerHouseNumber(i),
                    logic.GetCustomerAppartmentNumber(i),
                    logic.GetCustomerPostalCode(i),
                    logic.GetCustomerPhoneNumber(i),
                    logic.GetCustomerEmail(i)
                });
            }

            label1.Text = "To create a new customer please fill in the bottom text fields and click Create button";

            label2.Visible = false;

            textBox1.Visible = true;
            textBox1.Clear();

            label4.Visible = true;
            label4.Text = "First Name";

            textBox2.Visible = true;
            textBox2.Clear();

            label5.Visible = true;
            label5.Text = "Last Name";

            textBox3.Visible = true;
            textBox3.Clear();

            label6.Visible = true;
            label6.Text = "Country";

            textBox4.Visible = true;
            textBox4.Clear();

            label7.Visible = true;
            label7.Text = "City";

            textBox5.Visible = true;
            textBox5.Clear();

            label8.Visible = true;
            label8.Text = "Street";

            textBox6.Visible = true;
            textBox6.Clear();

            label9.Visible = true;
            label9.Text = "House No.";

            textBox7.Visible = true;
            textBox7.Clear();

            label10.Visible = true;
            label10.Text = "Appartment No.";

            textBox8.Visible = true;
            textBox8.Clear();

            label11.Visible = true;
            label11.Text = "Post Code";

            textBox9.Visible = true;
            textBox9.Clear();

            label12.Visible = true;
            label12.Text = "Phone No.";

            textBox10.Visible = true;
            textBox10.Clear();

            label15.Visible = true;
            label15.Text = "Email";

            label13.Visible = false;

            listBox1.Items.Clear();
            listBox1.Visible = false;

            label14.Visible = false;

            listBox2.Items.Clear();
            listBox2.Visible = false;

            button6.Visible = true;

            label16.Visible = false;

            button7.Visible = false;

            screan = 2;
        }

        //handler for Seller button
        //same story as in Customers
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("sellerId", "Seller Id");
            dataGridView1.Columns.Add("sellerName", "Seller Name");
            dataGridView1.Columns.Add("sellerCountry", "Seller Country");
            dataGridView1.Columns.Add("sellerCity", "Seller City");
            dataGridView1.Columns.Add("sellerStreet", "Seller Street");
            dataGridView1.Columns.Add("sellerHouseNumber", "Seller House Number");
            dataGridView1.Columns.Add("sellerAppartmentNumber", "Seller Appartment Number");
            dataGridView1.Columns.Add("sellerPostalCode", "Seller Postal Code");
            dataGridView1.Columns.Add("sellerPhoneNumber", "Seller Phone Number");
            dataGridView1.Columns.Add("sellerEmail", "Seller Email");

            int count = logic.GetSellerCount();

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    logic.GetSellerId(i),
                    logic.GetSellerName(i),
                    logic.GetSellerCountry(i),
                    logic.GetSellerCity(i),
                    logic.GetSellerStreet(i),
                    logic.GetSellerHouseNumber(i),
                    logic.GetSellerAppartmentNumber(i),
                    logic.GetSellerPostalCode(i),
                    logic.GetSellerPhoneNumber(i),
                    logic.GetSellerEmail(i)
                });
            }

            label1.Text = "To create a new seller please fill in the bottom text fields and click Create button";

            label2.Visible = false;

            textBox1.Visible = true;
            textBox1.Clear();

            label4.Visible = true;
            label4.Text = "Name";

            textBox2.Visible = true;
            textBox2.Clear();

            label5.Visible = true;
            label5.Text = "Country";

            textBox3.Visible = true;
            textBox3.Clear();

            label6.Visible = true;
            label6.Text = "City";

            textBox4.Visible = true;
            textBox4.Clear();

            label7.Visible = true;
            label7.Text = "Street";

            textBox5.Visible = true;
            textBox5.Clear();

            label8.Visible = true;
            label8.Text = "House No.";

            textBox6.Visible = true;
            textBox6.Clear();

            label9.Visible = true;
            label9.Text = "Appartment No.";

            textBox7.Visible = true;
            textBox7.Clear();

            label10.Visible = true;
            label10.Text = "Post Code";

            textBox8.Visible = true;
            textBox8.Clear();

            label11.Visible = true;
            label11.Text = "Phone No.";

            textBox9.Visible = true;
            textBox9.Clear();

            label12.Visible = true;
            label12.Text = "Email";

            textBox10.Visible = false;

            label15.Visible = false;

            label13.Visible = false;

            listBox1.Items.Clear();
            listBox1.Visible = false;

            label14.Visible = false;

            listBox2.Items.Clear();
            listBox2.Visible = false;

            button6.Visible = true;

            label16.Visible = false;

            button7.Visible = false;

            screan = 3;
        }

        //handler for Sales button
        //Sales need the user to pick some information from 2 list boxes to create a new Sale
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("saleId", "Sale Id");
            dataGridView1.Columns.Add("customerId", "Customer Id");
            dataGridView1.Columns.Add("salePrice", "Sale Price");

            int count = logic.GetSaleCount();

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    logic.GetSaleId(i),
                    logic.GetSaleCustomerId(i),
                    logic.GetSalesPrice(i)
                });
            }

            label1.Text = "To create a new sale please fill in the bottom text fields and click Create button";

            label2.Visible = false;

            textBox1.Visible = false;

            label4.Visible = false;

            textBox2.Visible = false;

            label5.Visible = false;

            textBox3.Visible = false;

            label6.Visible = false;

            textBox4.Visible = false;

            label7.Visible = false;

            textBox5.Visible = false;

            label8.Visible = false;

            textBox6.Visible = false;

            label9.Visible = false;

            textBox7.Visible = false;

            label10.Visible = false;

            textBox8.Visible = false;

            label11.Visible = false;

            textBox9.Visible = false;

            label12.Visible = false;

            textBox10.Visible = false;

            label15.Visible = false;

            label13.Visible = true;
            label13.Text = "Customer";

            listBox1.Items.Clear();
            listBox1.Visible = true;
            int customerCount = logic.GetCustomerCount();
            for (int i = 0; i < customerCount; i++)
            {
                string text = logic.GetCustomerId(i) + ", " + logic.GetCustomerFirstName(i);
                listBox1.Items.Add(text);
            }

            label14.Visible = true;
            label14.Text = "Products";

            //Second list box has multi selection turned on,the code for it can be found in Form1.Designer.cs that being said it was auto generated by the Visual Studio
            listBox2.Items.Clear();
            listBox2.Visible = true;
            int productCount = logic.GetProductCount();
            for (int i = 0; i < productCount; i++)
            {
                string text = logic.GetProductId(i) + ", " + logic.GetProductName(i);
                listBox2.Items.Add(text);
            }

            button6.Visible = true;

            label16.Visible = false;

            button7.Visible = false;

            screan = 4;
        }

        //handler for Repairs button
        //Very similar to button1_Click
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("repairId", "Repair Id");
            dataGridView1.Columns.Add("repairId", "Repair Item Name");
            dataGridView1.Columns.Add("repairId", "Repair Description");
            dataGridView1.Columns.Add("repairId", "Repair Price");
            dataGridView1.Columns.Add("repairId", "Repair Is Done");
            dataGridView1.Columns.Add("customerId", "Customer Id");

            int count = logic.GetRepairsCount();

            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.Add(new object[]
                {
                    logic.GetRepairId(i),
                    logic.GetRepairItemName(i),
                    logic.GetRepairDescription(i),
                    logic.GetRepairPrice(i),
                    logic.GetRepairIsDone(i),
                    logic.GetRepairCustomerId(i)
                });
            }

            label1.Text = "To create a new Repair please fill in the bottom text fields and click Create button";

            label2.Visible = false;

            textBox1.Visible = true;
            textBox1.Clear();

            label4.Visible = true;
            label4.Text = "Item Name";

            textBox2.Visible = true;
            textBox2.Clear();

            label5.Visible = true;
            label5.Text = "Description";

            textBox3.Visible = true;
            textBox3.Clear();

            label6.Visible = true;
            label6.Text = "Price";

            textBox4.Visible = false;

            label7.Visible = false;

            textBox5.Visible = false;

            label8.Visible = false;

            textBox6.Visible = false;

            label9.Visible = false;

            textBox7.Visible = false;

            label10.Visible = false;

            textBox8.Visible = false;

            label11.Visible = false;

            textBox9.Visible = false;

            label12.Visible = false;

            textBox10.Visible = false;

            label15.Visible = false;

            label13.Visible = true;
            label13.Text = "Customer";

            listBox1.Items.Clear();
            listBox1.Visible = true;
            int customerCount = logic.GetCustomerCount();
            for (int i = 0; i < customerCount; i++)
            {
                string text = logic.GetCustomerId(i) + ", " + logic.GetCustomerFirstName(i);
                listBox1.Items.Add(text);
            }

            label14.Visible = false;

            listBox2.Items.Clear();
            listBox2.Visible = false;

            button6.Visible = true;

            label16.Visible = true;

            button7.Visible = true;

            screan = 5;
        }

        //the fun Create button
        private void button6_Click(object sender, EventArgs e)
        {
            //try/catch to handle misstakes, if the user does not input all needed data it will tell the user that an error happened
            try
            {
                //swtich with screan to tell us which section of GUI was the button clicked in
                //screan value is the same as the button number
                switch (screan)
                {
                    case 1:
                        //we take the string from the listbox, well selected item from the listBox isn't a string but making it into a string in .Net ain't hard
                        //we remove the information we don't need, aka the name of the seller as we only care about the id
                        string text = listBox1.SelectedItem.ToString();
                        string text1 = text.Remove(text.IndexOf(','));
                        //all create methods in LogicLayer have bool return type that helps us know if sirialization faild for some reason
                        if (!logic.CreateProduct(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(text1)))
                        {
                            label2.Visible = true;
                        }
                        else
                        {
                            //we "click" the button1 to refresh the page
                            button1_Click(sender, e);
                        }
                        break;
                    case 2:
                        if (!logic.CreateCustomer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, Int32.Parse(textBox6.Text), Int32.Parse(textBox7.Text), textBox8.Text, textBox9.Text, textBox10.Text))
                        {
                            label2.Visible = true;
                        }
                        else
                        {
                            button2_Click(sender, e);
                        }
                        break;
                    case 3:
                        if (!logic.CreateSeller(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Int32.Parse(textBox5.Text), Int32.Parse(textBox6.Text), textBox7.Text, textBox8.Text, textBox9.Text))
                        {
                            label2.Visible = true;
                        }
                        else
                        {
                            button3_Click(sender, e);
                        }
                        break;
                    case 4:
                        //this bit be the same as in case 1 of the switch
                        string text2 = listBox1.SelectedItem.ToString();
                        string text3 = text2.Remove(text2.IndexOf(','));

                        //now the little part of making a list of int from selected products in list box2 
                        //which we will use to create a sale
                        List<int> ints = new List<int>();

                        foreach (var item in listBox2.SelectedItems)
                        {
                            string text4 = item.ToString();
                            string text5 = text4.Remove(text4.IndexOf(','));
                            ints.Add(Int32.Parse(text5));
                        }

                        if (!logic.CreateSale(Int32.Parse(text3), ints))
                        {
                            label2.Visible = true;
                        }
                        else
                        {
                            button4_Click(sender, e);
                        }
                        break;
                    case 5:
                        string text6 = listBox1.SelectedItem.ToString();
                        string text7 = text6.Remove(text6.IndexOf(','));
                        if (!logic.CreateRepair(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), Int32.Parse(text7)))
                        {
                            label2.Visible = true;
                        }
                        else
                        {
                            button5_Click(sender, e);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                label2.Visible = true;
            }
            
        }

        //handler for the button Done that appears in Repairs section of the GUI
        private void button7_Click(object sender, EventArgs e)
        {
            int count = logic.GetRepairsCount();

            for (int i = 0; i < count; i++)
            {
                //the code bellow is to figure out which row was selected and to change the corresponding Repair to done
                if (dataGridView1.SelectedRows.Contains(dataGridView1.Rows[i]))
                {
                    logic.RepairDone(i+1);
                    button5_Click((object)sender, e);
                }
            }
        }
    }
}
