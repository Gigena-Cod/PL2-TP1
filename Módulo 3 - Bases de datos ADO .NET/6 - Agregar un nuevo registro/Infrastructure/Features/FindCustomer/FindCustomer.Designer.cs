namespace Infrastructure.Features
{
    partial class FindCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCustomer));
            label1 = new Label();
            textBoxCustomerId = new TextBox();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            textBoxLimitCredt = new TextBox();
            comboBoxProvince = new ComboBox();
            buttonFindCustomer = new Button();
            label3 = new Label();
            buttonUpdateCustomer = new Button();
            buttonDeleteCustome = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(17, 10);
            label1.Name = "label1";
            label1.Size = new Size(409, 68);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Location = new Point(9, 33);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.Size = new Size(185, 23);
            textBoxCustomerId.TabIndex = 2;
            textBoxCustomerId.TextChanged += textBoxCustomerId_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Enabled = false;
            textBoxName.Location = new Point(24, 203);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(183, 23);
            textBoxName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Enabled = false;
            textBoxLastName.Location = new Point(236, 203);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(190, 23);
            textBoxLastName.TabIndex = 4;
            // 
            // textBoxLimitCredt
            // 
            textBoxLimitCredt.Enabled = false;
            textBoxLimitCredt.Location = new Point(22, 267);
            textBoxLimitCredt.Name = "textBoxLimitCredt";
            textBoxLimitCredt.Size = new Size(185, 23);
            textBoxLimitCredt.TabIndex = 5;
            // 
            // comboBoxProvince
            // 
            comboBoxProvince.Enabled = false;
            comboBoxProvince.FormattingEnabled = true;
            comboBoxProvince.Location = new Point(236, 267);
            comboBoxProvince.Name = "comboBoxProvince";
            comboBoxProvince.Size = new Size(190, 23);
            comboBoxProvince.TabIndex = 6;
            // 
            // buttonFindCustomer
            // 
            buttonFindCustomer.Location = new Point(290, 28);
            buttonFindCustomer.Name = "buttonFindCustomer";
            buttonFindCustomer.Size = new Size(115, 30);
            buttonFindCustomer.TabIndex = 7;
            buttonFindCustomer.Text = "Buscar";
            buttonFindCustomer.UseVisualStyleBackColor = true;
            buttonFindCustomer.Click += buttonFindCustomer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 179);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            // 
            // buttonUpdateCustomer
            // 
            buttonUpdateCustomer.Location = new Point(311, 325);
            buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            buttonUpdateCustomer.Size = new Size(115, 30);
            buttonUpdateCustomer.TabIndex = 9;
            buttonUpdateCustomer.Text = "Modificar";
            buttonUpdateCustomer.UseVisualStyleBackColor = true;
            buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
            // 
            // buttonDeleteCustome
            // 
            buttonDeleteCustome.Location = new Point(190, 325);
            buttonDeleteCustome.Name = "buttonDeleteCustome";
            buttonDeleteCustome.Size = new Size(115, 30);
            buttonDeleteCustome.TabIndex = 10;
            buttonDeleteCustome.Text = "Eliminar";
            buttonDeleteCustome.UseVisualStyleBackColor = true;
            buttonDeleteCustome.Click += buttonDeleteCustome_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 245);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 12;
            label4.Text = "Limite crediticio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 179);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 13;
            label5.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(236, 245);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 14;
            label6.Text = "Provincia";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxCustomerId);
            groupBox1.Controls.Add(buttonFindCustomer);
            groupBox1.Location = new Point(15, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 71);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar por ID";
            // 
            // FindCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 368);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonDeleteCustome);
            Controls.Add(buttonUpdateCustomer);
            Controls.Add(label3);
            Controls.Add(comboBoxProvince);
            Controls.Add(textBoxLimitCredt);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Name = "FindCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar un cliente";
            Load += ViewCustomers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCustomerId;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private TextBox textBoxLimitCredt;
        private ComboBox comboBoxProvince;
        private Button buttonFindCustomer;
        private Label label3;
        private Button buttonUpdateCustomer;
        private Button buttonDeleteCustome;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
    }
}