namespace Infrastructure.Features
{
    partial class CreateCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateCustomer));
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            textBoxLastName = new TextBox();
            label3 = new Label();
            label6 = new Label();
            textBoxLimitCredit = new TextBox();
            label10 = new Label();
            buttonCreateCustomer = new Button();
            buttonCancel = new Button();
            comboBoxProvince = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(483, 65);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 91);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(15, 119);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(234, 23);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(261, 119);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(234, 23);
            textBoxLastName.TabIndex = 2;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 91);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 171);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "Provincia";
            // 
            // textBoxLimitCredit
            // 
            textBoxLimitCredit.Location = new Point(13, 198);
            textBoxLimitCredit.Name = "textBoxLimitCredit";
            textBoxLimitCredit.Size = new Size(234, 23);
            textBoxLimitCredit.TabIndex = 3;
            textBoxLimitCredit.TextChanged += textBoxLimitCredit_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(10, 171);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 16;
            label10.Text = "Limite";
            // 
            // buttonCreateCustomer
            // 
            buttonCreateCustomer.Location = new Point(261, 277);
            buttonCreateCustomer.Name = "buttonCreateCustomer";
            buttonCreateCustomer.Size = new Size(115, 30);
            buttonCreateCustomer.TabIndex = 8;
            buttonCreateCustomer.Text = "Agregar";
            buttonCreateCustomer.UseVisualStyleBackColor = true;
            buttonCreateCustomer.Click += buttonCreateCustomer_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(134, 277);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(115, 30);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxProvince
            // 
            comboBoxProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProvince.FormattingEnabled = true;
            comboBoxProvince.Location = new Point(261, 198);
            comboBoxProvince.Name = "comboBoxProvince";
            comboBoxProvince.Size = new Size(234, 23);
            comboBoxProvince.TabIndex = 6;
            comboBoxProvince.SelectedIndexChanged += comboBoxProvince_SelectedIndexChanged;
            // 
            // CreateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 331);
            Controls.Add(comboBoxProvince);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreateCustomer);
            Controls.Add(label10);
            Controls.Add(textBoxLimitCredit);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear cliente";
            Load += CreateCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxLastName;
        private Label label3;
        private Label label6;
        private TextBox textBoxLimitCredit;
        private Label label10;
        private Button buttonCreateCustomer;
        private Button buttonCancel;
        private ComboBox comboBoxProvince;
    }
}