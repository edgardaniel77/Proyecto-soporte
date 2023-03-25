namespace Vista
{
    partial class TicketsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.UsuariotextBox = new System.Windows.Forms.TextBox();
            this.ClientetextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DescripcionStextBox = new System.Windows.Forms.TextBox();
            this.DescripcionRtextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.ImpuestotextBox = new System.Windows.Forms.TextBox();
            this.DescuentpotextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.GenerarTicketbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrpcion respuesta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion solicitud";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descuento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Impuesto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(517, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tipo soporte";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cliente";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // UsuariotextBox
            // 
            this.UsuariotextBox.Location = new System.Drawing.Point(142, 94);
            this.UsuariotextBox.Name = "UsuariotextBox";
            this.UsuariotextBox.Size = new System.Drawing.Size(200, 20);
            this.UsuariotextBox.TabIndex = 12;
            // 
            // ClientetextBox
            // 
            this.ClientetextBox.Location = new System.Drawing.Point(142, 137);
            this.ClientetextBox.Name = "ClientetextBox";
            this.ClientetextBox.Size = new System.Drawing.Size(200, 20);
            this.ClientetextBox.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Telefono",
            "Equipo de computo"});
            this.comboBox1.Location = new System.Drawing.Point(152, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // DescripcionStextBox
            // 
            this.DescripcionStextBox.Location = new System.Drawing.Point(152, 244);
            this.DescripcionStextBox.Name = "DescripcionStextBox";
            this.DescripcionStextBox.Size = new System.Drawing.Size(200, 20);
            this.DescripcionStextBox.TabIndex = 15;
            // 
            // DescripcionRtextBox
            // 
            this.DescripcionRtextBox.Location = new System.Drawing.Point(152, 292);
            this.DescripcionRtextBox.Name = "DescripcionRtextBox";
            this.DescripcionRtextBox.Size = new System.Drawing.Size(200, 20);
            this.DescripcionRtextBox.TabIndex = 16;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(560, 47);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(102, 20);
            this.PreciotextBox.TabIndex = 17;
            // 
            // ImpuestotextBox
            // 
            this.ImpuestotextBox.Location = new System.Drawing.Point(560, 91);
            this.ImpuestotextBox.Name = "ImpuestotextBox";
            this.ImpuestotextBox.Size = new System.Drawing.Size(102, 20);
            this.ImpuestotextBox.TabIndex = 18;
            // 
            // DescuentpotextBox
            // 
            this.DescuentpotextBox.Location = new System.Drawing.Point(560, 141);
            this.DescuentpotextBox.Name = "DescuentpotextBox";
            this.DescuentpotextBox.Size = new System.Drawing.Size(102, 20);
            this.DescuentpotextBox.TabIndex = 19;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(560, 188);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(102, 20);
            this.TotaltextBox.TabIndex = 20;
            // 
            // GenerarTicketbtn
            // 
            this.GenerarTicketbtn.Location = new System.Drawing.Point(579, 348);
            this.GenerarTicketbtn.Name = "GenerarTicketbtn";
            this.GenerarTicketbtn.Size = new System.Drawing.Size(115, 34);
            this.GenerarTicketbtn.TabIndex = 21;
            this.GenerarTicketbtn.Text = "Generar ticket";
            this.GenerarTicketbtn.UseVisualStyleBackColor = true;
            this.GenerarTicketbtn.Click += new System.EventHandler(this.GenerarTicketbtn_Click);
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GenerarTicketbtn);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.DescuentpotextBox);
            this.Controls.Add(this.ImpuestotextBox);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.DescripcionRtextBox);
            this.Controls.Add(this.DescripcionStextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ClientetextBox);
            this.Controls.Add(this.UsuariotextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketsForm";
            this.Text = "TicketsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox UsuariotextBox;
        private System.Windows.Forms.TextBox ClientetextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox DescripcionStextBox;
        private System.Windows.Forms.TextBox DescripcionRtextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox ImpuestotextBox;
        private System.Windows.Forms.TextBox DescuentpotextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Button GenerarTicketbtn;
    }
}