namespace _5__Método_de_burbuja_para_ordenar_datos_de_un_vector
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
            comboBoxField = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxSortBy = new ComboBox();
            groupBox1 = new GroupBox();
            dataGridViewClients = new DataGridView();
            ColumnCode = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnDebts = new DataGridViewTextBoxColumn();
            ColumnLimitCredit = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // comboBoxField
            // 
            comboBoxField.FormattingEnabled = true;
            comboBoxField.Items.AddRange(new object[] { "Codigo", "Nombre completo", "Deuda", "Limite de credito" });
            comboBoxField.Location = new Point(15, 57);
            comboBoxField.Name = "comboBoxField";
            comboBoxField.Size = new Size(176, 23);
            comboBoxField.TabIndex = 0;
            comboBoxField.SelectedIndexChanged += comboBoxField_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Campo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 30);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Ordenar por";
            // 
            // comboBoxSortBy
            // 
            comboBoxSortBy.FormattingEnabled = true;
            comboBoxSortBy.Items.AddRange(new object[] { "Ascendente", "Descendente" });
            comboBoxSortBy.Location = new Point(216, 57);
            comboBoxSortBy.Name = "comboBoxSortBy";
            comboBoxSortBy.Size = new Size(176, 23);
            comboBoxSortBy.TabIndex = 2;
            comboBoxSortBy.SelectedIndexChanged += comboBoxSortBy_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewClients);
            groupBox1.Controls.Add(comboBoxSortBy);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(comboBoxField);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(491, 414);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Consulta de datos";
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Columns.AddRange(new DataGridViewColumn[] { ColumnCode, ColumnName, ColumnDebts, ColumnLimitCredit });
            dataGridViewClients.Location = new Point(15, 111);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(460, 289);
            dataGridViewClients.TabIndex = 4;
            // 
            // ColumnCode
            // 
            ColumnCode.HeaderText = "Codigo";
            ColumnCode.Name = "ColumnCode";
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Nombre completo";
            ColumnName.Name = "ColumnName";
            // 
            // ColumnDebts
            // 
            ColumnDebts.HeaderText = "Deuda";
            ColumnDebts.Name = "ColumnDebts";
            // 
            // ColumnLimitCredit
            // 
            ColumnLimitCredit.HeaderText = "Liite de credito";
            ColumnLimitCredit.Name = "ColumnLimitCredit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 436);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Administracion de clientes";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxField;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxSortBy;
        private GroupBox groupBox1;
        private DataGridView dataGridViewClients;
        private DataGridViewTextBoxColumn ColumnCode;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnDebts;
        private DataGridViewTextBoxColumn ColumnLimitCredit;
    }
}
