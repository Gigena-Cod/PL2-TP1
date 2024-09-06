namespace _2_varias_columnas_de_datos.Feature.ListClients
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
            dataGridViewClients = new DataGridView();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnFullName = new DataGridViewTextBoxColumn();
            ColumnDebt = new DataGridViewTextBoxColumn();
            ColumnCredit = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnFullName, ColumnDebt, ColumnCredit });
            dataGridViewClients.Location = new Point(21, 83);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(530, 250);
            dataGridViewClients.TabIndex = 1;
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
            // buttonSave
            // 
            buttonSave.Location = new Point(446, 372);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(105, 35);
            buttonSave.TabIndex = 18;
            buttonSave.Text = "Listar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 21);
            label2.MaximumSize = new Size(540, 0);
            label2.Name = "label2";
            label2.Size = new Size(531, 30);
            label2.TabIndex = 19;
            label2.Text = "Este formulario te permite consultar los datos de los clientes. Facilita la visualización y organización de la información de manera eficiente.";
            // 
            // ListClients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 427);
            Controls.Add(label2);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewClients);
            Name = "ListClients";
            Text = "Listado de clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewClients;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnFullName;
        private DataGridViewTextBoxColumn ColumnDebt;
        private DataGridViewTextBoxColumn ColumnCredit;
        private Button buttonSave;
        private Label label2;
    }
}