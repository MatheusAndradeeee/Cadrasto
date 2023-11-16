namespace Cadrasto
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tx_Nome = new TextBox();
            label14 = new Label();
            tx_Cpf = new MaskedTextBox();
            tx_Rg = new TextBox();
            tx_Telefone = new TextBox();
            tx_Email = new TextBox();
            tx_endereco = new TextBox();
            tx_Estado_civ = new ComboBox();
            tx_cidade = new TextBox();
            tx_Estado = new TextBox();
            tx_Data_Nasc = new TextBox();
            tx_Salario = new TextBox();
            tx_funcao = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label15 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 0;
            label1.Text = "Cadastro Funcionário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 89);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 0;
            label2.Text = "CPF:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 132);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "Estado civil:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 277);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 0;
            label4.Text = "Data Nascimento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 164);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 0;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 204);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 0;
            label6.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 242);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 0;
            label7.Text = "Cidade:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(151, 9);
            label8.Name = "label8";
            label8.Size = new Size(158, 21);
            label8.TabIndex = 0;
            label8.Text = "Cadastro Funcionário";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(255, 89);
            label9.Name = "label9";
            label9.Size = new Size(25, 15);
            label9.TabIndex = 0;
            label9.Text = "RG:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(255, 132);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 0;
            label10.Text = "Telefone:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(235, 242);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 0;
            label11.Text = "Estado:";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(255, 277);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 0;
            label12.Text = "Salário:";
            label12.Click += label11_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(29, 312);
            label13.Name = "label13";
            label13.Size = new Size(49, 15);
            label13.TabIndex = 0;
            label13.Text = "Função:";
            label13.Click += label11_Click;
            // 
            // tx_Nome
            // 
            tx_Nome.BorderStyle = BorderStyle.FixedSingle;
            tx_Nome.Location = new Point(82, 55);
            tx_Nome.Name = "tx_Nome";
            tx_Nome.Size = new Size(353, 23);
            tx_Nome.TabIndex = 1;
            tx_Nome.TextChanged += textBox1_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(29, 57);
            label14.Name = "label14";
            label14.Size = new Size(43, 15);
            label14.TabIndex = 0;
            label14.Text = "Nome:";
            // 
            // tx_Cpf
            // 
            tx_Cpf.Location = new Point(66, 84);
            tx_Cpf.Mask = "000-000-000,00";
            tx_Cpf.Name = "tx_Cpf";
            tx_Cpf.Size = new Size(98, 23);
            tx_Cpf.TabIndex = 2;
            // 
            // tx_Rg
            // 
            tx_Rg.BorderStyle = BorderStyle.FixedSingle;
            tx_Rg.Location = new Point(295, 87);
            tx_Rg.Name = "tx_Rg";
            tx_Rg.Size = new Size(140, 23);
            tx_Rg.TabIndex = 1;
            tx_Rg.TextChanged += textBox1_TextChanged;
            // 
            // tx_Telefone
            // 
            tx_Telefone.BorderStyle = BorderStyle.FixedSingle;
            tx_Telefone.Location = new Point(315, 130);
            tx_Telefone.Name = "tx_Telefone";
            tx_Telefone.Size = new Size(120, 23);
            tx_Telefone.TabIndex = 1;
            tx_Telefone.TextChanged += textBox1_TextChanged;
            // 
            // tx_Email
            // 
            tx_Email.BorderStyle = BorderStyle.FixedSingle;
            tx_Email.Location = new Point(74, 162);
            tx_Email.Name = "tx_Email";
            tx_Email.Size = new Size(361, 23);
            tx_Email.TabIndex = 1;
            tx_Email.TextChanged += textBox1_TextChanged;
            // 
            // tx_endereco
            // 
            tx_endereco.BorderStyle = BorderStyle.FixedSingle;
            tx_endereco.Location = new Point(94, 202);
            tx_endereco.Name = "tx_endereco";
            tx_endereco.Size = new Size(341, 23);
            tx_endereco.TabIndex = 1;
            tx_endereco.TextChanged += textBox1_TextChanged;
            // 
            // tx_Estado_civ
            // 
            tx_Estado_civ.DisplayMember = "Solteiro";
            tx_Estado_civ.FormattingEnabled = true;
            tx_Estado_civ.Items.AddRange(new object[] { "Solteiro/a", "Casado/a", "Viuvo/a" });
            tx_Estado_civ.Location = new Point(104, 129);
            tx_Estado_civ.Name = "tx_Estado_civ";
            tx_Estado_civ.Size = new Size(121, 23);
            tx_Estado_civ.TabIndex = 3;
            // 
            // tx_cidade
            // 
            tx_cidade.BorderStyle = BorderStyle.FixedSingle;
            tx_cidade.Location = new Point(82, 240);
            tx_cidade.Name = "tx_cidade";
            tx_cidade.Size = new Size(143, 23);
            tx_cidade.TabIndex = 1;
            tx_cidade.TextChanged += textBox1_TextChanged;
            // 
            // tx_Estado
            // 
            tx_Estado.BorderStyle = BorderStyle.FixedSingle;
            tx_Estado.Location = new Point(286, 240);
            tx_Estado.Name = "tx_Estado";
            tx_Estado.Size = new Size(149, 23);
            tx_Estado.TabIndex = 1;
            tx_Estado.TextChanged += textBox1_TextChanged;
            // 
            // tx_Data_Nasc
            // 
            tx_Data_Nasc.BorderStyle = BorderStyle.FixedSingle;
            tx_Data_Nasc.Location = new Point(136, 275);
            tx_Data_Nasc.Name = "tx_Data_Nasc";
            tx_Data_Nasc.Size = new Size(105, 23);
            tx_Data_Nasc.TabIndex = 1;
            tx_Data_Nasc.TextChanged += textBox1_TextChanged;
            // 
            // tx_Salario
            // 
            tx_Salario.BorderStyle = BorderStyle.FixedSingle;
            tx_Salario.Location = new Point(315, 275);
            tx_Salario.Name = "tx_Salario";
            tx_Salario.Size = new Size(120, 23);
            tx_Salario.TabIndex = 1;
            tx_Salario.TextChanged += textBox1_TextChanged;
            // 
            // tx_funcao
            // 
            tx_funcao.BorderStyle = BorderStyle.FixedSingle;
            tx_funcao.Location = new Point(94, 310);
            tx_funcao.Name = "tx_funcao";
            tx_funcao.Size = new Size(115, 23);
            tx_funcao.TabIndex = 1;
            tx_funcao.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(94, 353);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(266, 353);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(170, 89);
            label15.Name = "label15";
            label15.Size = new Size(44, 15);
            label15.TabIndex = 6;
            label15.Text = "label15";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(471, 403);
            Controls.Add(label15);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tx_Estado_civ);
            Controls.Add(tx_Cpf);
            Controls.Add(tx_Estado);
            Controls.Add(tx_funcao);
            Controls.Add(tx_Salario);
            Controls.Add(tx_Data_Nasc);
            Controls.Add(tx_cidade);
            Controls.Add(tx_endereco);
            Controls.Add(tx_Email);
            Controls.Add(tx_Telefone);
            Controls.Add(tx_Rg);
            Controls.Add(tx_Nome);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label14);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox tx_Nome;
        private Label label14;
        private MaskedTextBox tx_Cpf;
        private TextBox tx_Rg;
        private TextBox tx_Telefone;
        private TextBox tx_Email;
        private TextBox tx_endereco;
        private ComboBox tx_Estado_civ;
        private TextBox tx_cidade;
        private TextBox tx_Estado;
        private TextBox tx_Data_Nasc;
        private TextBox tx_Salario;
        private TextBox tx_funcao;
        private Button button1;
        private Button button2;
        private Label label15;
    }
}