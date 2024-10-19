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
            label4 = new Label();
            textBoxAddress = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxLimitCredit = new TextBox();
            label10 = new Label();
            label11 = new Label();
            buttonCreateCustomer = new Button();
            buttonCancel = new Button();
            comboBoxCountry = new ComboBox();
            textBoxCity = new TextBox();
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
            label2.Location = new Point(15, 102);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(15, 130);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(234, 23);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBox1_TextChanged;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(261, 130);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(234, 23);
            textBoxLastName.TabIndex = 2;
            textBoxLastName.TextChanged += textBoxLastName_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 102);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 301);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Direccion";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(12, 329);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(237, 23);
            textBoxAddress.TabIndex = 4;
            textBoxAddress.TextChanged += textBoxAddress_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(261, 301);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 7;
            label5.Text = "Ciudad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 364);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 9;
            label6.Text = "Provincia";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(261, 364);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 11;
            label7.Text = "Pais";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 271);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 13;
            label8.Text = "Ubicacion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(15, 74);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 14;
            label9.Text = "Informacion ";
            // 
            // textBoxLimitCredit
            // 
            textBoxLimitCredit.Location = new Point(15, 226);
            textBoxLimitCredit.Name = "textBoxLimitCredit";
            textBoxLimitCredit.Size = new Size(234, 23);
            textBoxLimitCredit.TabIndex = 3;
            textBoxLimitCredit.TextChanged += textBoxLimitCredit_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 197);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 16;
            label10.Text = "Limite";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 170);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 17;
            label11.Text = "Crediticia";
            // 
            // buttonCreateCustomer
            // 
            buttonCreateCustomer.Location = new Point(261, 447);
            buttonCreateCustomer.Name = "buttonCreateCustomer";
            buttonCreateCustomer.Size = new Size(89, 30);
            buttonCreateCustomer.TabIndex = 8;
            buttonCreateCustomer.Text = "Agregar";
            buttonCreateCustomer.UseVisualStyleBackColor = true;
            buttonCreateCustomer.Click += buttonCreateCustomer_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(160, 447);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(89, 30);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.Enabled = false;
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(261, 391);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(234, 23);
            comboBoxCountry.TabIndex = 7;
            comboBoxCountry.SelectedIndexChanged += comboBoxCountry_SelectedIndexChanged;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(261, 329);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(234, 23);
            textBoxCity.TabIndex = 5;
            textBoxCity.TextChanged += textBoxCity_TextChanged;
            // 
            // comboBoxProvince
            // 
            comboBoxProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProvince.FormattingEnabled = true;
            comboBoxProvince.Location = new Point(15, 391);
            comboBoxProvince.Name = "comboBoxProvince";
            comboBoxProvince.Size = new Size(234, 23);
            comboBoxProvince.TabIndex = 6;
            comboBoxProvince.SelectedIndexChanged += comboBoxProvince_SelectedIndexChanged;
            // 
            // CreateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 489);
            Controls.Add(comboBoxProvince);
            Controls.Add(comboBoxCountry);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCreateCustomer);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBoxLimitCredit);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxCity);
            Controls.Add(label5);
            Controls.Add(textBoxAddress);
            Controls.Add(label4);
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
        private Label label4;
        private TextBox textBoxAddress;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxLimitCredit;
        private Label label10;
        private Label label11;
        private Button buttonCreateCustomer;
        private Button buttonCancel;
        private ComboBox comboBoxCountry;
        private TextBox textBoxCity;
        private ComboBox comboBoxProvince;
    }
}