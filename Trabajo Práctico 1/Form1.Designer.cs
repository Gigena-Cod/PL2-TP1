namespace Trabajo_Práctico_1
{
    partial class Form1
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
            vendedorToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            agregarNuevoVendedorToolStripMenuItem = new ToolStripMenuItem();
            listadoGeneralDeVendedoresToolStripMenuItem = new ToolStripMenuItem();
            consultaDeDatosDeUnVendedorToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, vendedorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, salirToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // vendedorToolStripMenuItem
            // 
            vendedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarNuevoVendedorToolStripMenuItem, listadoGeneralDeVendedoresToolStripMenuItem, consultaDeDatosDeUnVendedorToolStripMenuItem });
            vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            vendedorToolStripMenuItem.Size = new Size(69, 20);
            vendedorToolStripMenuItem.Text = "Vendedor";
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
            // 
            // agregarNuevoVendedorToolStripMenuItem
            // 
            agregarNuevoVendedorToolStripMenuItem.Name = "agregarNuevoVendedorToolStripMenuItem";
            agregarNuevoVendedorToolStripMenuItem.Size = new Size(255, 22);
            agregarNuevoVendedorToolStripMenuItem.Text = "Agregar nuevo vendedor";
            // 
            // listadoGeneralDeVendedoresToolStripMenuItem
            // 
            listadoGeneralDeVendedoresToolStripMenuItem.Name = "listadoGeneralDeVendedoresToolStripMenuItem";
            listadoGeneralDeVendedoresToolStripMenuItem.Size = new Size(255, 22);
            listadoGeneralDeVendedoresToolStripMenuItem.Text = "Listado general de vendedores";
            // 
            // consultaDeDatosDeUnVendedorToolStripMenuItem
            // 
            consultaDeDatosDeUnVendedorToolStripMenuItem.Name = "consultaDeDatosDeUnVendedorToolStripMenuItem";
            consultaDeDatosDeUnVendedorToolStripMenuItem.Size = new Size(255, 22);
            consultaDeDatosDeUnVendedorToolStripMenuItem.Text = "Consulta de datos de un vendedor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem vendedorToolStripMenuItem;
        private ToolStripMenuItem agregarNuevoVendedorToolStripMenuItem;
        private ToolStripMenuItem listadoGeneralDeVendedoresToolStripMenuItem;
        private ToolStripMenuItem consultaDeDatosDeUnVendedorToolStripMenuItem;
    }
}
