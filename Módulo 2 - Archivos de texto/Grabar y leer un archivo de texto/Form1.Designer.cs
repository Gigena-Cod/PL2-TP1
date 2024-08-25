namespace Grabar_y_leer_un_archivo_de_texto
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.MaximumSize = new Size(350, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 45);
            label1.TabIndex = 0;
            label1.Text = "Este formulario le permite guardar los datos ingresados de manera segura y eficiente. Asegúrese de que toda la información es correcta antes de confirmar el guardado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Texto";
            // 
            // button1
            // 
            button1.Location = new Point(259, 159);
            button1.Name = "button1";
            button1.Size = new Size(101, 33);
            button1.TabIndex = 2;
            button1.Text = "Grabar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            textBox.ForeColor = Color.Gray;
            textBox.Location = new Point(12, 116);
            textBox.Name = "textBox";
            textBox.Size = new Size(348, 23);
            textBox.TabIndex = 3;
            textBox.Text = "Ingrese un texto";
            textBox.Enter += textBox_Enter;
            textBox.Leave += textBox_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 206);
            Controls.Add(textBox);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Grabar datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox;
    }
}
