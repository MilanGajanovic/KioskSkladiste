namespace KioskSkladiste
{
    partial class Stock
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
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            product_code_textBox = new TextBox();
            quantity_textBox = new TextBox();
            product_name_textBox = new TextBox();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            redni_br = new DataGridViewTextBoxColumn();
            sifra_Artikla = new DataGridViewTextBoxColumn();
            naziv_artikla = new DataGridViewTextBoxColumn();
            kolicina = new DataGridViewTextBoxColumn();
            rok_trajanja = new DataGridViewTextBoxColumn();
            add_Button = new Button();
            delete_Button = new Button();
            reset_Button = new Button();
            label5 = new Label();
            label6 = new Label();
            ukupno_artikala = new Label();
            ukupna_kolicina = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(95, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(150, 27);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.KeyDown += dateTimePicker1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 67);
            label1.Name = "label1";
            label1.Size = new Size(107, 22);
            label1.TabIndex = 1;
            label1.Text = "Rok trajanja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(286, 67);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 2;
            label2.Text = "Sifra artikla";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(754, 67);
            label3.Name = "label3";
            label3.Size = new Size(79, 22);
            label3.TabIndex = 3;
            label3.Text = "Kolicina";
            // 
            // product_code_textBox
            // 
            product_code_textBox.Location = new Point(286, 104);
            product_code_textBox.Name = "product_code_textBox";
            product_code_textBox.Size = new Size(105, 27);
            product_code_textBox.TabIndex = 4;
            product_code_textBox.KeyDown += product_code_textBox_KeyDown;
            product_code_textBox.KeyPress += product_code_textBox_KeyPress;
            // 
            // quantity_textBox
            // 
            quantity_textBox.Location = new Point(743, 104);
            quantity_textBox.Name = "quantity_textBox";
            quantity_textBox.Size = new Size(128, 27);
            quantity_textBox.TabIndex = 5;
            quantity_textBox.KeyDown += quantity_textBox_KeyDown;
            quantity_textBox.KeyPress += quantity_textBox_KeyPress;
            // 
            // product_name_textBox
            // 
            product_name_textBox.Location = new Point(422, 104);
            product_name_textBox.Name = "product_name_textBox";
            product_name_textBox.Size = new Size(273, 27);
            product_name_textBox.TabIndex = 6;
            product_name_textBox.KeyDown += product_name_textBox_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(504, 67);
            label4.Name = "label4";
            label4.Size = new Size(113, 22);
            label4.TabIndex = 7;
            label4.Text = "Naziv artikla";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { redni_br, sifra_Artikla, naziv_artikla, kolicina, rok_trajanja });
            dataGridView2.Location = new Point(33, 203);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(950, 374);
            dataGridView2.TabIndex = 8;
            dataGridView2.MouseClick += dataGridView2_MouseClick;
            // 
            // redni_br
            // 
            redni_br.HeaderText = "Redni br.";
            redni_br.MinimumWidth = 6;
            redni_br.Name = "redni_br";
            redni_br.Width = 125;
            // 
            // sifra_Artikla
            // 
            sifra_Artikla.HeaderText = "Sifra artikla";
            sifra_Artikla.MinimumWidth = 6;
            sifra_Artikla.Name = "sifra_Artikla";
            sifra_Artikla.ReadOnly = true;
            sifra_Artikla.Width = 125;
            // 
            // naziv_artikla
            // 
            naziv_artikla.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            naziv_artikla.HeaderText = "Naziv artikla";
            naziv_artikla.MinimumWidth = 6;
            naziv_artikla.Name = "naziv_artikla";
            naziv_artikla.ReadOnly = true;
            // 
            // kolicina
            // 
            kolicina.HeaderText = "Kolicina";
            kolicina.MinimumWidth = 6;
            kolicina.Name = "kolicina";
            kolicina.ReadOnly = true;
            kolicina.Width = 125;
            // 
            // rok_trajanja
            // 
            rok_trajanja.HeaderText = "Rok trajanja";
            rok_trajanja.MinimumWidth = 6;
            rok_trajanja.Name = "rok_trajanja";
            rok_trajanja.ReadOnly = true;
            rok_trajanja.Width = 125;
            // 
            // add_Button
            // 
            add_Button.BackColor = SystemColors.ScrollBar;
            add_Button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_Button.Location = new Point(355, 147);
            add_Button.Name = "add_Button";
            add_Button.Size = new Size(90, 50);
            add_Button.TabIndex = 9;
            add_Button.Text = "Dodaj";
            add_Button.UseVisualStyleBackColor = false;
            add_Button.Click += add_Button_Click;
            // 
            // delete_Button
            // 
            delete_Button.BackColor = SystemColors.ScrollBar;
            delete_Button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_Button.Location = new Point(451, 147);
            delete_Button.Name = "delete_Button";
            delete_Button.Size = new Size(90, 50);
            delete_Button.TabIndex = 10;
            delete_Button.Text = "Izbrisi";
            delete_Button.UseVisualStyleBackColor = false;
            delete_Button.Click += delete_Button_Click;
            // 
            // reset_Button
            // 
            reset_Button.BackColor = SystemColors.ScrollBar;
            reset_Button.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reset_Button.Location = new Point(547, 147);
            reset_Button.Name = "reset_Button";
            reset_Button.Size = new Size(90, 50);
            reset_Button.TabIndex = 11;
            reset_Button.Text = "Reset";
            reset_Button.UseVisualStyleBackColor = false;
            reset_Button.Click += reset_Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(72, 600);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 12;
            label5.Text = "Ukupno artikala:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(635, 600);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 13;
            label6.Text = "Ukupna kolicina:";
            // 
            // ukupno_artikala
            // 
            ukupno_artikala.AutoSize = true;
            ukupno_artikala.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ukupno_artikala.Location = new Point(206, 600);
            ukupno_artikala.Name = "ukupno_artikala";
            ukupno_artikala.Size = new Size(18, 20);
            ukupno_artikala.TabIndex = 14;
            ukupno_artikala.Text = "0";
            // 
            // ukupna_kolicina
            // 
            ukupna_kolicina.AutoSize = true;
            ukupna_kolicina.Location = new Point(754, 600);
            ukupna_kolicina.Name = "ukupna_kolicina";
            ukupna_kolicina.Size = new Size(17, 20);
            ukupna_kolicina.TabIndex = 15;
            ukupna_kolicina.Text = "0";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1056, 676);
            Controls.Add(ukupna_kolicina);
            Controls.Add(ukupno_artikala);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(reset_Button);
            Controls.Add(delete_Button);
            Controls.Add(add_Button);
            Controls.Add(label4);
            Controls.Add(product_name_textBox);
            Controls.Add(quantity_textBox);
            Controls.Add(product_code_textBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView2);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox product_code_textBox;
        private TextBox quantity_textBox;
        private TextBox product_name_textBox;
        private Label label4;
        private DataGridView dataGridView2;
        private Button add_Button;
        private Button delete_Button;
        private Button reset_Button;
        private Label label5;
        private Label label6;
        private Label ukupno_artikala;
        private Label ukupna_kolicina;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn redni_br;
        private DataGridViewTextBoxColumn sifra_Artikla;
        private DataGridViewTextBoxColumn naziv_artikla;
        private DataGridViewTextBoxColumn kolicina;
        private DataGridViewTextBoxColumn rok_trajanja;
    }
}