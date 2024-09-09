namespace Infrastructure.Features
{
    partial class ArticlesManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            sitemaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            artToolStripMenuItem = new ToolStripMenuItem();
            lisToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sitemaToolStripMenuItem, artToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sitemaToolStripMenuItem
            // 
            sitemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem });
            sitemaToolStripMenuItem.Name = "sitemaToolStripMenuItem";
            sitemaToolStripMenuItem.Size = new Size(60, 20);
            sitemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // artToolStripMenuItem
            // 
            artToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lisToolStripMenuItem });
            artToolStripMenuItem.Name = "artToolStripMenuItem";
            artToolStripMenuItem.Size = new Size(66, 20);
            artToolStripMenuItem.Text = "Articulos";
            // 
            // lisToolStripMenuItem
            // 
            lisToolStripMenuItem.Name = "lisToolStripMenuItem";
            lisToolStripMenuItem.Size = new Size(189, 22);
            lisToolStripMenuItem.Text = "Ver todos los articulos";
            lisToolStripMenuItem.Click += lisToolStripMenuItem_Click;
            // 
            // ArticlesManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ArticlesManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de articulos";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sitemaToolStripMenuItem;
        private ToolStripMenuItem artToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem lisToolStripMenuItem;
    }
}
