namespace MediaAritmeticaSimples
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
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            txtValor3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            lbMedia = new Label();
            SuspendLayout();
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(4, 87);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(108, 23);
            txtValor1.TabIndex = 0;
            txtValor1.TextChanged += txtValor1_TextChanged;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(118, 87);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(104, 23);
            txtValor2.TabIndex = 1;
            // 
            // txtValor3
            // 
            txtValor3.Location = new Point(228, 87);
            txtValor3.Name = "txtValor3";
            txtValor3.Size = new Size(104, 23);
            txtValor3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 69);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Valor 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 69);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 69);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Valor 3";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(118, 166);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular Média";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 147);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Media";
           
            // 
            // lbMedia
            // 
            lbMedia.AutoSize = true;
            lbMedia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMedia.Location = new Point(58, 141);
            lbMedia.Name = "lbMedia";
            lbMedia.Size = new Size(0, 21);
            lbMedia.TabIndex = 8;
            lbMedia.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 338);
            Controls.Add(lbMedia);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValor3);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtValor3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label lbMedia;
    }
}
