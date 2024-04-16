using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KioskSkladiste
{
    public partial class Proizvodi : Form
    {
        public Proizvodi()
        {
            InitializeComponent();
        }

        private void Proizvodi_Load(object sender, EventArgs e)
        {
            Status.SelectedIndex = 0;
            LoadData();
        }

        private void Product_Load_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GNPDKHR\\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
            con.Open();

            //clears products display before loading from database to prevent issue with adding double products
            dataGridView1.Rows.Clear();
            bool status = false;

            //checking status bc default is always 0
            if (Status.SelectedIndex == 0)
                status = true;
            else
                status = false;
            

            var sqlQuery = "";
            if (ifProductExists(con, textBox1.Text))
            {
                sqlQuery = @"UPDATE [dbo].[Products] SET [ProductName] = '" + Product_Name.Text + "' ,[ProductStatus] = '" + status + "' WHERE [ProductCode] = '" + textBox1.Text + "'";
            }
            else
            {
                sqlQuery = @"INSERT INTO [Products] ([ProductCode] ,[ProductName]" + ",[ProductStatus])" + "" +
                "VALUES  ('" + textBox1.Text + "' ,'" + Product_Name.Text + "','" + status + "')";
            }



            //adding new products in database 
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //Loading products
            LoadData();

            //Task new: prevent user from inputing number larger then integer/give error message 

            //Task: item is not being selected when updated or added
            // Clear any selection of rows in the data grid view
            dataGridView1.ClearSelection();

            // Highlight the specific row corresponding to the updated or added item
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox1.Text)
                {
                    // Set the current cell to the specific row
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    break;
                }
            }
        }

        private bool ifProductExists(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [Products] WHERE [ProductCode] = '" + productCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GNPDKHR\\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Products]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();

                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Inactive";
                }
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            //TASK: When clicked on empty dataGridView it throws an error for
            //TASK: Prevent data in dataGrid to be visibly editable and able to click like text box

            //adding info in boxes when item is selected by single click 
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            Product_Name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                Status.SelectedIndex = 0;
            }
            else
            {
                Status.SelectedIndex = 1;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GNPDKHR\\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
            var sqlQuery = "";
            if (ifProductExists(con, textBox1.Text))
            {   
                con.Open();
                sqlQuery = @"DELETE FROM [dbo].[Products] WHERE [ProductCode] = '" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {   //Add title to the box
                MessageBox.Show("Artikal ne postoji");
            }

            //clears products before loading from database to prevent doubling data
            dataGridView1.Rows.Clear();

            //Loading products
            LoadData();
        }
    }
}











