namespace Trabajo_Práctico_1
{
    partial class FormAboutMe
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 20);
            label3.Name = "label3";
            label3.Size = new Size(171, 15);
            label3.TabIndex = 2;
            label3.Text = "Laboratorio de Programación 1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 90);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de alumno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 62);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 3;
            label5.Text = "Christian Nahuel Gigena";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 34);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 2;
            label4.Text = "40419139";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 51);
            label6.Name = "label6";
            label6.Size = new Size(226, 15);
            label6.TabIndex = 4;
            label6.Text = "Actividad de repaso - Vectores y Registros";
            // 
            // FormAboutMe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 189);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Name = "FormAboutMe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acerca de ";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label6;
    }
}