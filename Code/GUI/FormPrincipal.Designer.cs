
namespace Projeto_Login_MySQL.Code.GUI
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.labelDashboard = new System.Windows.Forms.Label();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.buttonPlanejamento = new System.Windows.Forms.Button();
            this.buttonFluxo = new System.Windows.Forms.Button();
            this.buttonCartao = new System.Windows.Forms.Button();
            this.buttonEmprestimo = new System.Windows.Forms.Button();
            this.buttonUsuario = new System.Windows.Forms.Button();
            this.buttonSobre = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonConfigs = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelBarraTitulo.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(219)))));
            this.panelBarraTitulo.Controls.Add(this.labelTitulo);
            this.panelBarraTitulo.Controls.Add(this.labelDashboard);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(1760, 50);
            this.panelBarraTitulo.TabIndex = 0;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelLateral.Controls.Add(this.buttonSair);
            this.panelLateral.Controls.Add(this.buttonConfigs);
            this.panelLateral.Controls.Add(this.buttonSobre);
            this.panelLateral.Controls.Add(this.buttonUsuario);
            this.panelLateral.Controls.Add(this.buttonEmprestimo);
            this.panelLateral.Controls.Add(this.buttonCartao);
            this.panelLateral.Controls.Add(this.buttonFluxo);
            this.panelLateral.Controls.Add(this.buttonPlanejamento);
            this.panelLateral.Controls.Add(this.panelSelecao);
            this.panelLateral.Controls.Add(this.buttonHome);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 50);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(260, 940);
            this.panelLateral.TabIndex = 1;
            // 
            // labelDashboard
            // 
            this.labelDashboard.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.labelDashboard.Location = new System.Drawing.Point(50, 10);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(200, 30);
            this.labelDashboard.TabIndex = 1;
            this.labelDashboard.Text = "P Login MySQL";
            this.labelDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(10, 100);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(0);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonHome.Size = new System.Drawing.Size(250, 50);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "     Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(82)))), ((int)(((byte)(219)))));
            this.panelSelecao.Location = new System.Drawing.Point(0, 100);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(10, 50);
            this.panelSelecao.TabIndex = 2;
            // 
            // buttonPlanejamento
            // 
            this.buttonPlanejamento.FlatAppearance.BorderSize = 0;
            this.buttonPlanejamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlanejamento.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlanejamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.buttonPlanejamento.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlanejamento.Image")));
            this.buttonPlanejamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlanejamento.Location = new System.Drawing.Point(10, 160);
            this.buttonPlanejamento.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlanejamento.Name = "buttonPlanejamento";
            this.buttonPlanejamento.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonPlanejamento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonPlanejamento.Size = new System.Drawing.Size(250, 50);
            this.buttonPlanejamento.TabIndex = 3;
            this.buttonPlanejamento.Text = "     Planejamento";
            this.buttonPlanejamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlanejamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPlanejamento.UseVisualStyleBackColor = true;
            this.buttonPlanejamento.Click += new System.EventHandler(this.buttonPlanejamento_Click);
            // 
            // buttonFluxo
            // 
            this.buttonFluxo.FlatAppearance.BorderSize = 0;
            this.buttonFluxo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFluxo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFluxo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.buttonFluxo.Image = ((System.Drawing.Image)(resources.GetObject("buttonFluxo.Image")));
            this.buttonFluxo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFluxo.Location = new System.Drawing.Point(10, 220);
            this.buttonFluxo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFluxo.Name = "buttonFluxo";
            this.buttonFluxo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonFluxo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonFluxo.Size = new System.Drawing.Size(250, 50);
            this.buttonFluxo.TabIndex = 4;
            this.buttonFluxo.Text = "     Fluxo de Caixa";
            this.buttonFluxo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFluxo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFluxo.UseVisualStyleBackColor = true;
            this.buttonFluxo.Click += new System.EventHandler(this.buttonFluxo_Click);
            // 
            // buttonCartao
            // 
            this.buttonCartao.FlatAppearance.BorderSize = 0;
            this.buttonCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCartao.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCartao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.buttonCartao.Image = ((System.Drawing.Image)(resources.GetObject("buttonCartao.Image")));
            this.buttonCartao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCartao.Location = new System.Drawing.Point(10, 280);
            this.buttonCartao.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCartao.Name = "buttonCartao";
            this.buttonCartao.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonCartao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCartao.Size = new System.Drawing.Size(250, 50);
            this.buttonCartao.TabIndex = 5;
            this.buttonCartao.Text = "     Cartão de Crédito";
            this.buttonCartao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCartao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCartao.UseVisualStyleBackColor = true;
            this.buttonCartao.Click += new System.EventHandler(this.buttonCartao_Click);
            // 
            // buttonEmprestimo
            // 
            this.buttonEmprestimo.FlatAppearance.BorderSize = 0;
            this.buttonEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmprestimo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmprestimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.buttonEmprestimo.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmprestimo.Image")));
            this.buttonEmprestimo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmprestimo.Location = new System.Drawing.Point(10, 340);
            this.buttonEmprestimo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEmprestimo.Name = "buttonEmprestimo";
            this.buttonEmprestimo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonEmprestimo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonEmprestimo.Size = new System.Drawing.Size(250, 50);
            this.buttonEmprestimo.TabIndex = 6;
            this.buttonEmprestimo.Text = "     Empréstimos";
            this.buttonEmprestimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmprestimo.UseVisualStyleBackColor = true;
            this.buttonEmprestimo.Click += new System.EventHandler(this.buttonEmprestimo_Click);
            // 
            // buttonUsuario
            // 
            this.buttonUsuario.FlatAppearance.BorderSize = 0;
            this.buttonUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.buttonUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttonUsuario.Image")));
            this.buttonUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsuario.Location = new System.Drawing.Point(10, 400);
            this.buttonUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUsuario.Name = "buttonUsuario";
            this.buttonUsuario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonUsuario.Size = new System.Drawing.Size(250, 50);
            this.buttonUsuario.TabIndex = 7;
            this.buttonUsuario.Text = "     Usuários";
            this.buttonUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUsuario.UseVisualStyleBackColor = true;
            this.buttonUsuario.Click += new System.EventHandler(this.buttonUsuario_Click);
            // 
            // buttonSobre
            // 
            this.buttonSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSobre.FlatAppearance.BorderSize = 0;
            this.buttonSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSobre.Image = ((System.Drawing.Image)(resources.GetObject("buttonSobre.Image")));
            this.buttonSobre.Location = new System.Drawing.Point(5, 890);
            this.buttonSobre.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSobre.Name = "buttonSobre";
            this.buttonSobre.Size = new System.Drawing.Size(40, 40);
            this.buttonSobre.TabIndex = 8;
            this.buttonSobre.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.FlatAppearance.BorderSize = 0;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSair.Image = ((System.Drawing.Image)(resources.GetObject("buttonSair.Image")));
            this.buttonSair.Location = new System.Drawing.Point(215, 890);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(40, 40);
            this.buttonSair.TabIndex = 10;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonConfigs
            // 
            this.buttonConfigs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonConfigs.FlatAppearance.BorderSize = 0;
            this.buttonConfigs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigs.Image = ((System.Drawing.Image)(resources.GetObject("buttonConfigs.Image")));
            this.buttonConfigs.Location = new System.Drawing.Point(110, 890);
            this.buttonConfigs.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfigs.Name = "buttonConfigs";
            this.buttonConfigs.Size = new System.Drawing.Size(40, 40);
            this.buttonConfigs.TabIndex = 9;
            this.buttonConfigs.UseVisualStyleBackColor = true;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(260, 50);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1500, 940);
            this.panelDesktop.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.labelTitulo.Location = new System.Drawing.Point(310, 10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(1400, 30);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Tq";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1760, 990);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelBarraTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelSelecao;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonSobre;
        private System.Windows.Forms.Button buttonUsuario;
        private System.Windows.Forms.Button buttonEmprestimo;
        private System.Windows.Forms.Button buttonCartao;
        private System.Windows.Forms.Button buttonFluxo;
        private System.Windows.Forms.Button buttonPlanejamento;
        private System.Windows.Forms.Button buttonConfigs;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label labelTitulo;
    }
}