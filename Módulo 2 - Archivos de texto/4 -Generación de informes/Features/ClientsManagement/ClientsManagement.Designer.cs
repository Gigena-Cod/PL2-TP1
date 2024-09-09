namespace _4__Generación_de_informes
{
    partial class ClientsManagement
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
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            acercaraToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            crearClienteToolStripMenuItem = new ToolStripMenuItem();
            verTodosLosToolStripMenuItem = new ToolStripMenuItem();
            verTodosLosDeudoresToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, clientesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaraToolStripMenuItem, salirToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaraToolStripMenuItem
            // 
            acercaraToolStripMenuItem.Name = "acercaraToolStripMenuItem";
            acercaraToolStripMenuItem.Size = new Size(126, 22);
            acercaraToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(126, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { crearClienteToolStripMenuItem, verTodosLosToolStripMenuItem, verTodosLosDeudoresToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // crearClienteToolStripMenuItem
            // 
            crearClienteToolStripMenuItem.Name = "crearClienteToolStripMenuItem";
            crearClienteToolStripMenuItem.Size = new Size(193, 22);
            crearClienteToolStripMenuItem.Text = "Crear cliente";
            crearClienteToolStripMenuItem.Click += crearClienteToolStripMenuItem_Click;
            // 
            // verTodosLosToolStripMenuItem
            // 
            verTodosLosToolStripMenuItem.Name = "verTodosLosToolStripMenuItem";
            verTodosLosToolStripMenuItem.Size = new Size(193, 22);
            verTodosLosToolStripMenuItem.Text = "Ver todos los clientes";
            verTodosLosToolStripMenuItem.Click += verTodosLosToolStripMenuItem_Click;
            // 
            // verTodosLosDeudoresToolStripMenuItem
            // 
            verTodosLosDeudoresToolStripMenuItem.Name = "verTodosLosDeudoresToolStripMenuItem";
            verTodosLosDeudoresToolStripMenuItem.Size = new Size(193, 22);
            verTodosLosDeudoresToolStripMenuItem.Text = "Ver todos los deudores";
            verTodosLosDeudoresToolStripMenuItem.Click += verTodosLosDeudoresToolStripMenuItem_Click;
            // 
            // ClientsManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Name = "ClientsManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de clientes";
            WindowState = FormWindowState.Maximized;
            Load += ClientsManagement_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem acercaraToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem crearClienteToolStripMenuItem;
        private ToolStripMenuItem verTodosLosToolStripMenuItem;
        private ToolStripMenuItem verTodosLosDeudoresToolStripMenuItem;
    }
}
