
namespace Atividade11_03
{
    partial class FrmPizzaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPizzaria));
            txtNome = new TextBox();
            txtPreco = new TextBox();
            btnSalvar = new Button();
            lblNome = new Label();
            label1 = new Label();
            lblId = new Label();
            txtId = new TextBox();
            dtgPizzaria = new DataGridView();
            pictureBox1 = new PictureBox();
            btnExcluir = new Button();
            btnEditar = new Button();
            txtPesquisa = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgPizzaria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Location = new Point(100, 326);
            txtNome.Multiline = true;
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Insira o Nome da Pizza";
            txtNome.Size = new Size(181, 22);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.BorderStyle = BorderStyle.None;
            txtPreco.Location = new Point(100, 402);
            txtPreco.Multiline = true;
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Insira o Preço da Pizza";
            txtPreco.Size = new Size(181, 22);
            txtPreco.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleGreen;
            btnSalvar.Location = new Point(23, 473);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 24);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(100, 299);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 377);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Preço";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(127, 218);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 6;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlDarkDark;
            txtId.Location = new Point(123, 250);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(127, 23);
            txtId.TabIndex = 5;
            // 
            // dtgPizzaria
            // 
            dtgPizzaria.BackgroundColor = SystemColors.ActiveCaption;
            dtgPizzaria.BorderStyle = BorderStyle.None;
            dtgPizzaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPizzaria.Location = new Point(450, 272);
            dtgPizzaria.Name = "dtgPizzaria";
            dtgPizzaria.Size = new Size(353, 178);
            dtgPizzaria.TabIndex = 7;
            dtgPizzaria.CellMouseDoubleClick += dtgPizzaria_CellMouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(198, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Location = new Point(136, 473);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(117, 24);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightBlue;
            btnEditar.ForeColor = SystemColors.ActiveCaptionText;
            btnEditar.Location = new Point(259, 473);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(108, 24);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(484, 217);
            txtPesquisa.Multiline = true;
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.PlaceholderText = "Pesquisa";
            txtPesquisa.Size = new Size(257, 29);
            txtPesquisa.TabIndex = 11;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            // 
            // FrmPizzaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(921, 520);
            Controls.Add(txtPesquisa);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(pictureBox1);
            Controls.Add(dtgPizzaria);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPizzaria";
            Text = "Form1";
            Load += FrmPizzaria_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPizzaria).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox txtNome;
        private TextBox txtPreco;
        private Button btnSalvar;
        private Label lblNome;
        private Label label1;
        private Label lblId;
        private TextBox txtId;
        private DataGridView dtgPizzaria;
        private PictureBox pictureBox1;
        private Button btnExcluir;
        private Button btnEditar;
        private TextBox txtPesquisa;
    }
}
