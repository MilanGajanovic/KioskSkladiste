namespace KioskSkladiste
{
    partial class Proizvodi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deleteButton = new Button();
            Product_Load = new Button();
            textBox1 = new TextBox();
            Product_Name = new TextBox();
            dataGridView1 = new DataGridView();
            productCode = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            productStatus = new DataGridViewTextBoxColumn();
            Status = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.ActiveBorder;
            deleteButton.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(635, 92);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(115, 50);
            deleteButton.TabIndex = 0;
            deleteButton.Text = "Izbriši";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // Product_Load
            // 
            Product_Load.BackColor = SystemColors.ActiveBorder;
            Product_Load.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Product_Load.ForeColor = SystemColors.ActiveCaptionText;
            Product_Load.Location = new Point(767, 92);
            Product_Load.Name = "Product_Load";
            Product_Load.Size = new Size(115, 50);
            Product_Load.TabIndex = 1;
            Product_Load.Text = "Dodaj";
            Product_Load.UseVisualStyleBackColor = false;
            Product_Load.Click += Product_Load_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 13;
            // 
            // Product_Name
            // 
            Product_Name.Location = new Point(218, 104);
            Product_Name.Name = "Product_Name";
            Product_Name.Size = new Size(190, 27);
            Product_Name.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productCode, productName, productStatus });
            dataGridView1.Location = new Point(22, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(860, 361);
            dataGridView1.TabIndex = 5;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // productCode
            // 
            productCode.HeaderText = "Šifra";
            productCode.MinimumWidth = 6;
            productCode.Name = "productCode";
            productCode.Width = 125;
            // 
            // productName
            // 
            productName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productName.HeaderText = "Naziv artikla";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            // 
            // productStatus
            // 
            productStatus.HeaderText = "Status";
            productStatus.MinimumWidth = 6;
            productStatus.Name = "productStatus";
            productStatus.Width = 125;
            // 
            // Status
            // 
            Status.Font = new Font("Segoe UI", 10.9F);
            Status.Items.AddRange(new object[] { "Active", "Inactive" });
            Status.Location = new Point(414, 100);
            Status.Name = "Status";
            Status.Size = new Size(190, 33);
            Status.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 7;
            label1.Text = "Šifra artikla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(264, 82);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 8;
            label2.Text = "Naziv artikla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 82);
            label3.Name = "label3";
            label3.Size = new Size(50, 19);
            label3.TabIndex = 9;
            label3.Text = "Status";
            // 
            // Proizvodi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 566);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Status);
            Controls.Add(dataGridView1);
            Controls.Add(Product_Name);
            Controls.Add(textBox1);
            Controls.Add(Product_Load);
            Controls.Add(deleteButton);
            Name = "Proizvodi";
            Padding = new Padding(100, 0, 0, 0);
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Proizvodi";
            Load += Proizvodi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private Button Product_Load;
        private TextBox textBox1;
        private TextBox Product_Name;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productCode;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productStatus;
        private ComboBox Status;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}