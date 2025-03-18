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
            ((System.ComponentModel.ISupportInitialize)dtgPizzaria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(100, 235);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(127, 23);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(100, 308);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(127, 23);
            txtPreco.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.PaleGreen;
            btnSalvar.Location = new Point(121, 356);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(103, 203);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 281);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 4;
            label1.Text = "Preço";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(103, 122);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 6;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 154);
            txtId.Name = "txtId";
            txtId.Size = new Size(127, 23);
            txtId.TabIndex = 5;
            // 
            // dtgPizzaria
            // 
            dtgPizzaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPizzaria.Location = new Point(388, 146);
            dtgPizzaria.Name = "dtgPizzaria";
            dtgPizzaria.Size = new Size(471, 258);
            dtgPizzaria.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(735, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Location = new Point(121, 395);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 9;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FrmPizzaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 491);
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
    }
}
