namespace WinFormsTabla
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
            panelprincipal = new Panel();
            label1 = new Label();
            richTextBoxresultados = new RichTextBox();
            buttonver = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.Pink;
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(richTextBoxresultados);
            panelprincipal.Controls.Add(buttonver);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(11, 6);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(777, 432);
            panelprincipal.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 388);
            label1.Name = "label1";
            label1.Size = new Size(352, 24);
            label1.TabIndex = 5;
            label1.Text = "VALERIA BERNAL SALCEDO ID:357658";
            // 
            // richTextBoxresultados
            // 
            richTextBoxresultados.BackColor = Color.LavenderBlush;
            richTextBoxresultados.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBoxresultados.ForeColor = Color.MediumVioletRed;
            richTextBoxresultados.Location = new Point(478, 76);
            richTextBoxresultados.Name = "richTextBoxresultados";
            richTextBoxresultados.Size = new Size(205, 336);
            richTextBoxresultados.TabIndex = 4;
            richTextBoxresultados.Text = "";
            // 
            // buttonver
            // 
            buttonver.BackColor = Color.HotPink;
            buttonver.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonver.ForeColor = SystemColors.ActiveCaptionText;
            buttonver.Location = new Point(284, 176);
            buttonver.Name = "buttonver";
            buttonver.Size = new Size(128, 34);
            buttonver.TabIndex = 3;
            buttonver.Text = "VER TABLA";
            buttonver.UseVisualStyleBackColor = false;
            buttonver.Click += buttonver_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(140, 176);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(125, 27);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelnumero.ForeColor = Color.PaleVioletRed;
            labelnumero.Location = new Point(163, 127);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(249, 28);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cual tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltitulo.ForeColor = Color.MediumVioletRed;
            labeltitulo.Location = new Point(183, 22);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(399, 40);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "TABLA DE MULTIPLICAR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private Label labelnumero;
        private Button buttonver;
        private TextBox textBoxnum;
        private RichTextBox richTextBoxresultados;
        private Label label1;
    }
}
