namespace Features
{
    partial class ListClients
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
            textBoxAverage = new TextBox();
            label4 = new Label();
            textBoxDebts = new TextBox();
            label3 = new Label();
            textBoxTotalClientes = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dataGridViewClients = new DataGridView();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnFullName = new DataGridViewTextBoxColumn();
            ColumnDebt = new DataGridViewTextBoxColumn();
            ColumnCredit = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // textBoxAverage
            // 
            textBoxAverage.Location = new Point(383, 86);
            textBoxAverage.Name = "textBoxAverage";
            textBoxAverage.ReadOnly = true;
            textBoxAverage.Size = new Size(159, 23);
            textBoxAverage.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 56);
            label4.MaximumSize = new Size(540, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 32;
            label4.Text = "Promedio de deudas";
            // 
            // textBoxDebts
            // 
            textBoxDebts.Location = new Point(202, 86);
            textBoxDebts.Name = "textBoxDebts";
            textBoxDebts.ReadOnly = true;
            textBoxDebts.Size = new Size(166, 23);
            textBoxDebts.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 56);
            label3.MaximumSize = new Size(540, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 30;
            label3.Text = "Total de deudas";
            // 
            // textBoxTotalClientes
            // 
            textBoxTotalClientes.Location = new Point(12, 86);
            textBoxTotalClientes.Name = "textBoxTotalClientes";
            textBoxTotalClientes.ReadOnly = true;
            textBoxTotalClientes.Size = new Size(172, 23);
            textBoxTotalClientes.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.MaximumSize = new Size(540, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 28;
            label1.Text = "Total de clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.MaximumSize = new Size(540, 0);
            label2.Name = "label2";
            label2.Size = new Size(531, 30);
            label2.TabIndex = 27;
            label2.Text = "Este formulario te permite consultar los datos de los clientes. Facilita la visualización y organización de la información de manera eficiente.";
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnFullName, ColumnDebt, ColumnCredit });
            dataGridViewClients.Location = new Point(12, 128);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(530, 250);
            dataGridViewClients.TabIndex = 26;
            // 
            // ColumnCode
            // 
            ColumnCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCode.HeaderText = "Codigo";
            ColumnCode.Name = "ColumnCode";
            // 
            // ColumnFullName
            // 
            ColumnFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnFullName.HeaderText = "Nombre";
            ColumnFullName.Name = "ColumnFullName";
            // 
            // ColumnDebt
            // 
            ColumnDebt.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnDebt.HeaderText = "Deuda";
            ColumnDebt.Name = "ColumnDebt";
            // 
            // ColumnCredit
            // 
            ColumnCredit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCredit.HeaderText = "Limite de credito";
            ColumnCredit.Name = "ColumnCredit";
            // 
            // button1
            // 
            button1.Location = new Point(404, 406);
            button1.Name = "button1";
            button1.Size = new Size(139, 30);
            button1.TabIndex = 34;
            button1.Text = "Generar reporte";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 448);
            Controls.Add(button1);
            Controls.Add(textBoxAverage);
            Controls.Add(label4);
            Controls.Add(textBoxDebts);
            Controls.Add(label3);
            Controls.Add(textBoxTotalClientes);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridViewClients);
            Name = "ListClients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de clientes";
            Load += ListClients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAverage;
        private Label label4;
        private TextBox textBoxDebts;
        private Label label3;
        private TextBox textBoxTotalClientes;
        private Label label1;
        private Label label2;
        private DataGridView dataGridViewClients;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnFullName;
        private DataGridViewTextBoxColumn ColumnDebt;
        private DataGridViewTextBoxColumn ColumnCredit;
        private Button button1;
    }
}