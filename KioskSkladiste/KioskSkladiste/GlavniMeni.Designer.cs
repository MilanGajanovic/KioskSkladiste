namespace KioskSkladiste
{
    partial class GlavniMeni
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
            menuStrip = new MenuStrip();
            stanjeToolStripMenuItem = new ToolStripMenuItem();
            izvještajToolStripMenuItem = new ToolStripMenuItem();
            sviProizvodiToolStripMenuItem = new ToolStripMenuItem();
            brojnoStanjeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { stanjeToolStripMenuItem, izvještajToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(8, 3, 0, 3);
            menuStrip.Size = new Size(843, 30);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // stanjeToolStripMenuItem
            // 
            stanjeToolStripMenuItem.Name = "stanjeToolStripMenuItem";
            stanjeToolStripMenuItem.Size = new Size(64, 24);
            stanjeToolStripMenuItem.Text = "Stanje";
            stanjeToolStripMenuItem.Click += stanjeToolStripMenuItem_Click;
            // 
            // izvještajToolStripMenuItem
            // 
            izvještajToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sviProizvodiToolStripMenuItem, brojnoStanjeToolStripMenuItem });
            izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            izvještajToolStripMenuItem.Size = new Size(76, 24);
            izvještajToolStripMenuItem.Text = "Izvještaj";
            // 
            // sviProizvodiToolStripMenuItem
            // 
            sviProizvodiToolStripMenuItem.Name = "sviProizvodiToolStripMenuItem";
            sviProizvodiToolStripMenuItem.Size = new Size(179, 26);
            sviProizvodiToolStripMenuItem.Text = "Svi proizvodi";
            // 
            // brojnoStanjeToolStripMenuItem
            // 
            brojnoStanjeToolStripMenuItem.Name = "brojnoStanjeToolStripMenuItem";
            brojnoStanjeToolStripMenuItem.Size = new Size(179, 26);
            brojnoStanjeToolStripMenuItem.Text = "Brojno stanje";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 671);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 19, 0);
            statusStrip.Size = new Size(843, 26);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(49, 20);
            toolStripStatusLabel.Text = "Status";
            // 
            // GlavniMeni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 697);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GlavniMeni";
            Text = "Kiosk Gaja";
            WindowState = FormWindowState.Maximized;
            FormClosing += GlavniMeni_FormClosing;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private ToolStripMenuItem stanjeToolStripMenuItem;
        private ToolStripMenuItem izvještajToolStripMenuItem;
        private ToolStripMenuItem sviProizvodiToolStripMenuItem;
        private ToolStripMenuItem brojnoStanjeToolStripMenuItem;
    }
}



