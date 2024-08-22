namespace Dos_Vectores
{
    partial class expenseManager
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBoxAmount = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            ColumnMonth = new DataGridViewTextBoxColumn();
            ColumnAmount = new DataGridViewTextBoxColumn();
            button3 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBoxAmount);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargar gasto";
            // 
            // button1
            // 
            button1.Location = new Point(185, 99);
            button1.Name = "button1";
            button1.Size = new Size(84, 29);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxAmount
            // 
            comboBoxAmount.FormattingEnabled = true;
            comboBoxAmount.Location = new Point(72, 27);
            comboBoxAmount.Name = "comboBoxAmount";
            comboBoxAmount.Size = new Size(197, 23);
            comboBoxAmount.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 64);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Importe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Mes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(12, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(285, 267);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de gastos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnMonth, ColumnAmount });
            dataGridView1.Location = new Point(15, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(255, 184);
            dataGridView1.TabIndex = 7;
            // 
            // ColumnMonth
            // 
            ColumnMonth.HeaderText = "Mes";
            ColumnMonth.Name = "ColumnMonth";
            // 
            // ColumnAmount
            // 
            ColumnAmount.HeaderText = "Importe";
            ColumnAmount.Name = "ColumnAmount";
            // 
            // button3
            // 
            button3.Location = new Point(167, 222);
            button3.Name = "button3";
            button3.Size = new Size(102, 29);
            button3.TabIndex = 6;
            button3.Text = "Listar con while";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(15, 222);
            button2.Name = "button2";
            button2.Size = new Size(102, 29);
            button2.TabIndex = 5;
            button2.Text = "Listar con for";
            button2.UseVisualStyleBackColor = true;
            // 
            // expenseManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 456);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "expenseManager";
            Text = "Administrador de gastos";
            Load += expenseManager_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private ComboBox comboBoxAmount;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnMonth;
        private DataGridViewTextBoxColumn ColumnAmount;
        private Button button3;
        private Button button2;
    }
}
