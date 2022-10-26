namespace Canoppus.UI
{
    partial class FrmCadastrarTarefa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarTarefa));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrazoTarefa = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricaoTarefa = new System.Windows.Forms.TextBox();
            this.txtNomeTarefa = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCarrega = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(119, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 54);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cadastrar Tarefa";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCadastrar.Location = new System.Drawing.Point(800, 831);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(171, 70);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancelar.Location = new System.Drawing.Point(1009, 831);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(171, 70);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.cBox1);
            this.panel1.Controls.Add(this.btnCarrega);
            this.panel1.Controls.Add(this.gb1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPrazoTarefa);
            this.panel1.Controls.Add(this.txtDescricaoTarefa);
            this.panel1.Controls.Add(this.txtNomeTarefa);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 985);
            this.panel1.TabIndex = 31;
            // 
            // cBox1
            // 
            this.cBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Location = new System.Drawing.Point(983, 525);
            this.cBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(204, 28);
            this.cBox1.TabIndex = 5;
            this.cBox1.SelectedValueChanged += new System.EventHandler(this.cBox1_SelectedValueChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rb2);
            this.gb1.Controls.Add(this.rb1);
            this.gb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb1.Location = new System.Drawing.Point(793, 341);
            this.gb1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.gb1.Size = new System.Drawing.Size(387, 84);
            this.gb1.TabIndex = 55;
            this.gb1.TabStop = false;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(224, 34);
            this.rb2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(78, 24);
            this.rb2.TabIndex = 4;
            this.rb2.TabStop = true;
            this.rb2.Text = "Inativo";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(20, 34);
            this.rb1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(67, 24);
            this.rb1.TabIndex = 3;
            this.rb1.TabStop = true;
            this.rb1.Text = "Ativo";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(979, 483);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Responsável Tarefa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Status Tarefa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(789, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Prazo Tarefa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(788, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Descrição Tarefa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nome Tarefa";
            // 
            // txtPrazoTarefa
            // 
            this.txtPrazoTarefa.Culture = new System.Globalization.CultureInfo("en-001");
            this.txtPrazoTarefa.Location = new System.Drawing.Point(793, 272);
            this.txtPrazoTarefa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPrazoTarefa.Mask = "00/00/0000";
            this.txtPrazoTarefa.Name = "txtPrazoTarefa";
            this.txtPrazoTarefa.Size = new System.Drawing.Size(165, 26);
            this.txtPrazoTarefa.TabIndex = 2;
            this.txtPrazoTarefa.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescricaoTarefa
            // 
            this.txtDescricaoTarefa.Location = new System.Drawing.Point(793, 132);
            this.txtDescricaoTarefa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtDescricaoTarefa.MaxLength = 150;
            this.txtDescricaoTarefa.Multiline = true;
            this.txtDescricaoTarefa.Name = "txtDescricaoTarefa";
            this.txtDescricaoTarefa.Size = new System.Drawing.Size(385, 104);
            this.txtDescricaoTarefa.TabIndex = 1;
            // 
            // txtNomeTarefa
            // 
            this.txtNomeTarefa.Location = new System.Drawing.Point(793, 66);
            this.txtNomeTarefa.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNomeTarefa.MaxLength = 150;
            this.txtNomeTarefa.Name = "txtNomeTarefa";
            this.txtNomeTarefa.Size = new System.Drawing.Size(385, 26);
            this.txtNomeTarefa.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFechar.BackgroundImage")));
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(1252, 7);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 69);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 985);
            this.panel2.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(338, 54);
            this.label7.TabIndex = 43;
            this.label7.Text = "Excluir Usuário";
            // 
            // btnCarrega
            // 
            this.btnCarrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCarrega.FlatAppearance.BorderSize = 0;
            this.btnCarrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCarrega.Location = new System.Drawing.Point(800, 483);
            this.btnCarrega.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarrega.Name = "btnCarrega";
            this.btnCarrega.Size = new System.Drawing.Size(171, 70);
            this.btnCarrega.TabIndex = 6;
            this.btnCarrega.Text = "Carregar";
            this.btnCarrega.UseVisualStyleBackColor = false;
            this.btnCarrega.Click += new System.EventHandler(this.btnCarrega_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(1005, 275);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(53, 20);
            this.lblResult.TabIndex = 56;
            this.lblResult.Text = "label8";
            // 
            // FrmCadastrarTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 985);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCadastrarTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarTarefa";
            this.Load += new System.EventHandler(this.FrmCadastrarTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPrazoTarefa;
        private System.Windows.Forms.TextBox txtDescricaoTarefa;
        private System.Windows.Forms.TextBox txtNomeTarefa;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.ComboBox cBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCarrega;
        private System.Windows.Forms.Label lblResult;
    }
}