namespace Features
{
    partial class ListDebtorClients
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
            button1 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(412, 403);
            button1.Name = "button1";
            button1.Size = new Size(129, 35);
            button1.TabIndex = 45;
            button1.Text = "Generar reporte";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxAverage
            // 
            textBoxAverage.Location = new Point(383, 95);
            textBoxAverage.Name = "textBoxAverage";
            textBoxAverage.ReadOnly = true;
            textBoxAverage.Size = new Size(159, 23);
            textBoxAverage.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(383, 65);
            label4.MaximumSize = new Size(540, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 43;
            label4.Text = "Promedio de deudas";
            // 
            // textBoxDebts
            // 
            textBoxDebts.Location = new Point(202, 95);
            textBoxDebts.Name = "textBoxDebts";
            textBoxDebts.ReadOnly = true;
            textBoxDebts.Size = new Size(166, 23);
            textBoxDebts.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 65);
            label3.MaximumSize = new Size(540, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 41;
            label3.Text = "Total de deudas";
            // 
            // textBoxTotalClientes
            // 
            textBoxTotalClientes.Location = new Point(12, 95);
            textBoxTotalClientes.Name = "textBoxTotalClientes";
            textBoxTotalClientes.ReadOnly = true;
            textBoxTotalClientes.Size = new Size(172, 23);
            textBoxTotalClientes.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.MaximumSize = new Size(540, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 39;
            label1.Text = "Total de clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.MaximumSize = new Size(540, 0);
            label2.Name = "label2";
            label2.Size = new Size(531, 30);
            label2.TabIndex = 38;
            label2.Text = "Este formulario te permite consultar los datos de los clientes. Facilita la visualización y organización de la información de manera eficiente.";
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnFullName, ColumnDebt, ColumnCredit });
            dataGridViewClients.Location = new Point(12, 137);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(530, 250);
            dataGridViewClients.TabIndex = 36;
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
            // ListDebtorClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(button1);
            Controls.Add(textBoxAverage);
            Controls.Add(label4);
            Controls.Add(textBoxDebts);
            Controls.Add(label3);
            Controls.Add(textBoxTotalClientes);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dataGridViewClients);
            Name = "ListDebtorClients";
            Text = "Listado de clientes deudores";
            Load += ListDebtorClients_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
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
    }
}