namespace Features
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
            sistenmaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem = new ToolStripMenuItem();
            cToolStripMenuItem1 = new ToolStripMenuItem();
            verTodosLosClientesToolStripMenuItem = new ToolStripMenuItem();
            verTofdosLosClientesDToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistenmaToolStripMenuItem, cToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistenmaToolStripMenuItem
            // 
            sistenmaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem });
            sistenmaToolStripMenuItem.Name = "sistenmaToolStripMenuItem";
            sistenmaToolStripMenuItem.Size = new Size(60, 20);
            sistenmaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(126, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // cToolStripMenuItem
            // 
            cToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cToolStripMenuItem1, verTodosLosClientesToolStripMenuItem, verTofdosLosClientesDToolStripMenuItem });
            cToolStripMenuItem.Name = "cToolStripMenuItem";
            cToolStripMenuItem.Size = new Size(61, 20);
            cToolStripMenuItem.Text = "Clientes";
            // 
            // cToolStripMenuItem1
            // 
            cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            cToolStripMenuItem1.Size = new Size(193, 22);
            cToolStripMenuItem1.Text = "Crear clientes";
            cToolStripMenuItem1.Click += cToolStripMenuItem1_Click;
            // 
            // verTodosLosClientesToolStripMenuItem
            // 
            verTodosLosClientesToolStripMenuItem.Name = "verTodosLosClientesToolStripMenuItem";
            verTodosLosClientesToolStripMenuItem.Size = new Size(193, 22);
            verTodosLosClientesToolStripMenuItem.Text = "Ver todos los clientes";
            verTodosLosClientesToolStripMenuItem.Click += verTodosLosClientesToolStripMenuItem_Click;
            // 
            // verTofdosLosClientesDToolStripMenuItem
            // 
            verTofdosLosClientesDToolStripMenuItem.Name = "verTofdosLosClientesDToolStripMenuItem";
            verTofdosLosClientesDToolStripMenuItem.Size = new Size(193, 22);
            verTofdosLosClientesDToolStripMenuItem.Text = "Ver todos los deudores";
            verTofdosLosClientesDToolStripMenuItem.Click += verTofdosLosClientesDToolStripMenuItem_Click;
            // 
            // ClientsManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ClientsManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador de clientes";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistenmaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem verTodosLosClientesToolStripMenuItem;
        private ToolStripMenuItem verTofdosLosClientesDToolStripMenuItem;
    }
}
