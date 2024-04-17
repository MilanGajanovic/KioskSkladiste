using System.Data;
using System.Data.SqlClient;

namespace KioskSkladiste
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            this.ActiveControl = dateTimePicker1;
            LoadData();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                product_code_textBox.Focus();

        }

        private void product_code_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (product_code_textBox.Text.Length > 0)
                    product_name_textBox.Focus();
                else
                    product_code_textBox.Focus();
            }
        }

        private void product_name_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (product_name_textBox.Text.Length > 0)
                    quantity_textBox.Focus();
                else
                    product_name_textBox.Focus();
            }
        }

        private void quantity_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (quantity_textBox.Text.Length > 0)
                    add_Button.Focus();
                else
                    quantity_textBox.Focus();

            }
        }

        private void product_code_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void quantity_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        public void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GNPDKHR\\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [Stock]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells["redni_br"].Value = n + 1;
                dataGridView2.Rows[n].Cells["sifra_Artikla"].Value = item["ProductCode"].ToString();
                dataGridView2.Rows[n].Cells["naziv_artikla"].Value = item["ProductName"].ToString();
                dataGridView2.Rows[n].Cells["kolicina"].Value = float.Parse(item["Quantity"].ToString());
                dataGridView2.Rows[n].Cells["rok_trajanja"].Value = Convert.ToDateTime(item["ExpirationDate"].ToString()).ToString("dd/MM/yyyy");

                if (dataGridView2.Rows.Count > 0)
                {
                    ukupno_artikala.Text = dataGridView2.Rows.Count.ToString();

                    float ukupno_art = 0;

                    for (int i = 0; i < dataGridView2.Rows.Count; ++i)
                    {
                        var cell = dataGridView2.Rows[i].Cells["kolicina"].Value;

                        if (cell != null)
                        {
                            if (float.TryParse(cell.ToString(), out float kolicina))
                                ukupno_art += kolicina;
                        }
                    }

                    ukupna_kolicina.Text = ukupno_art.ToString();
                }
                else
                {
                    ukupna_kolicina.Text = "0";
                    ukupno_artikala.Text = "0";
                }

            }
        }
        private bool Validation()
        {

            if (string.IsNullOrEmpty(product_code_textBox.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(product_code_textBox, "Product code required!");
            }
            else if (string.IsNullOrEmpty(product_name_textBox.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(product_name_textBox, "Product name required!");
            }
            else if (string.IsNullOrEmpty(quantity_textBox.Text))
            {
                errorProvider.Clear();
                errorProvider.SetError(quantity_textBox, "Quantity is required!");
            }
            else
            {
                errorProvider.Clear();
                return true;
            }
            return false;
        }

        private bool ifProductExists(SqlConnection con, string sifra_Artikla)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT 1 FROM [Stock] WHERE [ProductCode] = '" + sifra_Artikla + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-GNPDKHR\\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
                con.Open();


                dataGridView2.Rows.Clear();

                SqlCommand cmd;
                if (ifProductExists(con, product_code_textBox.Text))
                {

                    cmd = new SqlCommand(@"UPDATE [dbo].[Stock] SET 
                [ProductName] = @ProductName,
                [ExpirationDate] = @ExpirationDate,
                [Quantity] = @Quantity 
                WHERE [ProductCode] = @ProductCode", con);
                }
                else
                {

                    cmd = new SqlCommand(@"INSERT INTO [Stock] 
                ([ProductCode], [ProductName], [ExpirationDate], [Quantity]) 
                VALUES (@ProductCode, @ProductName, @ExpirationDate, @Quantity)", con);
                }


                cmd.Parameters.AddWithValue("@ProductCode", int.Parse(product_code_textBox.Text));
                cmd.Parameters.AddWithValue("@ProductName", product_name_textBox.Text);
                cmd.Parameters.AddWithValue("@ExpirationDate", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Quantity", float.Parse(quantity_textBox.Text));


                cmd.ExecuteNonQuery();

                con.Close();


                LoadData();
                ResetText();
                add_Button.Text = "Dodaj";
            }
        }


        private void ResetText()
        {
            dateTimePicker1.Value = DateTime.Now;
            product_code_textBox.Clear();
            product_name_textBox.Clear();
            quantity_textBox.Clear();
            add_Button.Text = "Dodaj";
            dateTimePicker1.Focus();

        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void dataGridView2_MouseClick(object sender, MouseEventArgs e)
        {
            //TASK: When clicked on empty dataGridView it throws an error - NOT SOLVED
            //TASK: Prevent data in dataGrid to be visibly editable and able to click like text box - SOLVED
            //SOLVED -Edited columns in dataGridView to Read Only = True

            add_Button.Text = "Uredi";

            //adding info in boxes when item is selected by single click 
            product_code_textBox.Text = dataGridView2.SelectedRows[0].Cells["sifra_Artikla"].Value.ToString();
            product_name_textBox.Text = dataGridView2.SelectedRows[0].Cells["naziv_artikla"].Value.ToString();
            quantity_textBox.Text = dataGridView2.SelectedRows[0].Cells["kolicina"].Value.ToString();
            dateTimePicker1.Text = DateTime.Parse(dataGridView2.SelectedRows[0].Cells["rok_trajanja"].Value.ToString()).ToString("dd/MM/yyyy");

        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Jeste li sigurni da zelite izbrisati", "Message", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (Validation())
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-GNPDKHR\\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
                    var sqlQuery = "";
                    if (ifProductExists(con, product_code_textBox.Text))
                    {
                        con.Open();
                        sqlQuery = @"DELETE FROM [Stock] WHERE [ProductCode] = '" + product_code_textBox.Text + "'";
                        SqlCommand cmd = new SqlCommand(sqlQuery, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Artikal izbrisan");
                    }
                    else
                    {
                        MessageBox.Show("Artikal ne postoji");
                    }

                    //clears products before loading from database to prevent doubling data
                    dataGridView2.Rows.Clear();

                    //Loading products again after deleting
                    LoadData();

                    ResetText();
                }
            }
        }
    }
}
