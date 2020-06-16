namespace AgendaTelefonica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.Label();
            this.txtSalvar = new System.Windows.Forms.Button();
            this.txtPessoa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdddPessoa = new System.Windows.Forms.TextBox();
            this.Número = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.TxtLabelCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numCasa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.opcaoCpfOuNome = new System.Windows.Forms.ComboBox();
            this.pesquisaNome = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ListaDeDados = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.AutoSize = true;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(41, 107);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(53, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome";
            // 
            // txtSalvar
            // 
            this.txtSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalvar.Location = new System.Drawing.Point(46, 390);
            this.txtSalvar.Name = "txtSalvar";
            this.txtSalvar.Size = new System.Drawing.Size(123, 50);
            this.txtSalvar.TabIndex = 1;
            this.txtSalvar.Text = "Cadastrar";
            this.txtSalvar.UseVisualStyleBackColor = true;
            this.txtSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPessoa
            // 
            this.txtPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPessoa.Location = new System.Drawing.Point(45, 126);
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.Size = new System.Drawing.Size(260, 27);
            this.txtPessoa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DDD";
            // 
            // txtdddPessoa
            // 
            this.txtdddPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdddPessoa.Location = new System.Drawing.Point(46, 290);
            this.txtdddPessoa.Name = "txtdddPessoa";
            this.txtdddPessoa.Size = new System.Drawing.Size(124, 27);
            this.txtdddPessoa.TabIndex = 4;
            this.txtdddPessoa.TextChanged += new System.EventHandler(this.txtdddPessoa_TextChanged);
            // 
            // Número
            // 
            this.Número.AutoSize = true;
            this.Número.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Número.Location = new System.Drawing.Point(176, 270);
            this.Número.Name = "Número";
            this.Número.Size = new System.Drawing.Size(73, 20);
            this.Número.TabIndex = 5;
            this.Número.Text = "Telefone";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(179, 290);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(127, 27);
            this.txtNumero.TabIndex = 6;
            // 
            // TxtLabelCidade
            // 
            this.TxtLabelCidade.AutoSize = true;
            this.TxtLabelCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLabelCidade.Location = new System.Drawing.Point(360, 220);
            this.TxtLabelCidade.Name = "TxtLabelCidade";
            this.TxtLabelCidade.Size = new System.Drawing.Size(61, 20);
            this.TxtLabelCidade.TabIndex = 7;
            this.TxtLabelCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(363, 240);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(249, 27);
            this.txtCidade.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(360, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bairro";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(363, 178);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(249, 27);
            this.txtBairro.TabIndex = 10;
            this.txtBairro.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(360, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(363, 126);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(249, 27);
            this.txtRua.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(177, 390);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 50);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Limpar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1021, 110);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(51, 38);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "@";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cadastre um Novo Funcionario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(710, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Pesquise um Funcionário Existente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cpf";
            // 
            // txtCpf
            // 
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(45, 177);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(260, 27);
            this.txtCpf.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(360, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Numero da casa";
            // 
            // numCasa
            // 
            this.numCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCasa.Location = new System.Drawing.Point(363, 343);
            this.numCasa.Name = "numCasa";
            this.numCasa.Size = new System.Drawing.Size(249, 27);
            this.numCasa.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(174, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Departamento";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(46, 343);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(123, 27);
            this.txtSalario.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 30;
            this.label10.Text = "Salario";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.FormattingEnabled = true;
            this.txtDepartamento.Items.AddRange(new object[] {
            "Vendas",
            "Estoque",
            "Caixa",
            "Gerencia",
            "Financeiro",
            "Compras"});
            this.txtDepartamento.Location = new System.Drawing.Point(178, 343);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(128, 28);
            this.txtDepartamento.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(710, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tipo";
            // 
            // opcaoCpfOuNome
            // 
            this.opcaoCpfOuNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcaoCpfOuNome.FormattingEnabled = true;
            this.opcaoCpfOuNome.Items.AddRange(new object[] {
            "Nome",
            "Cpf"});
            this.opcaoCpfOuNome.Location = new System.Drawing.Point(714, 121);
            this.opcaoCpfOuNome.Name = "opcaoCpfOuNome";
            this.opcaoCpfOuNome.Size = new System.Drawing.Size(97, 28);
            this.opcaoCpfOuNome.TabIndex = 34;
            this.opcaoCpfOuNome.Text = "Nome";
            // 
            // pesquisaNome
            // 
            this.pesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaNome.Location = new System.Drawing.Point(830, 121);
            this.pesquisaNome.Name = "pesquisaNome";
            this.pesquisaNome.Size = new System.Drawing.Size(184, 27);
            this.pesquisaNome.TabIndex = 35;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(365, 390);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(118, 50);
            this.btnAtualizar.TabIndex = 36;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(499, 390);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(115, 50);
            this.btnApagar.TabIndex = 37;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(826, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Digite aqui";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(364, 290);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(249, 27);
            this.txtCep.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(363, 270);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Cep";
            // 
            // ListaDeDados
            // 
            this.ListaDeDados.Location = new System.Drawing.Point(714, 192);
            this.ListaDeDados.Name = "ListaDeDados";
            this.ListaDeDados.Size = new System.Drawing.Size(357, 178);
            this.ListaDeDados.TabIndex = 41;
            this.ListaDeDados.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(715, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 50);
            this.button1.TabIndex = 42;
            this.button1.Text = "Listar todos os cadastrados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "Estado civil";
            // 
            // estadoCivil
            // 
            this.estadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Divorciado(a)",
            "União estável",
            "Viuvo(a)"});
            this.estadoCivil.Location = new System.Drawing.Point(46, 239);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(123, 28);
            this.estadoCivil.TabIndex = 44;
            // 
            // txtSexo
            // 
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.txtSexo.Location = new System.Drawing.Point(178, 239);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(128, 28);
            this.txtSexo.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(175, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 46;
            this.label14.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 555);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.estadoCivil);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaDeDados);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.pesquisaNome);
            this.Controls.Add(this.opcaoCpfOuNome);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numCasa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.TxtLabelCidade);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.Número);
            this.Controls.Add(this.txtdddPessoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPessoa);
            this.Controls.Add(this.txtSalvar);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNome;
        private System.Windows.Forms.Button txtSalvar;
        private System.Windows.Forms.TextBox txtPessoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdddPessoa;
        private System.Windows.Forms.Label Número;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label TxtLabelCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox numCasa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtDepartamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox opcaoCpfOuNome;
        private System.Windows.Forms.TextBox pesquisaNome;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox ListaDeDados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.Label label14;
    }
}

