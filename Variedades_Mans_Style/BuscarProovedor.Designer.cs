namespace Variedades_Man_s_Style
{
    partial class BuscarProovedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarProovedor));
            this.Panel_WF_Info_Proveedor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarPROV = new System.Windows.Forms.Button();
            this.Panel_txtProveedor = new System.Windows.Forms.Panel();
            this.Label_Proveedores = new System.Windows.Forms.Label();
            this.btn_WF_CerrarBucarProveedor = new System.Windows.Forms.Button();
            this.btn_WF_ListoProveedor = new System.Windows.Forms.Button();
            this.txt_Busqueda_Proveedor = new System.Windows.Forms.TextBox();
            this.DGV_WF_Proveedor = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_WF_Info_Proveedor.SuspendLayout();
            this.Panel_txtProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_WF_Proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_WF_Info_Proveedor
            // 
            this.Panel_WF_Info_Proveedor.BackColor = System.Drawing.Color.Snow;
            this.Panel_WF_Info_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel_WF_Info_Proveedor.Controls.Add(this.pictureBox1);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.label2);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.label1);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.btnAgregarPROV);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.Panel_txtProveedor);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.btn_WF_ListoProveedor);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.txt_Busqueda_Proveedor);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.DGV_WF_Proveedor);
            this.Panel_WF_Info_Proveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_WF_Info_Proveedor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_WF_Info_Proveedor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Panel_WF_Info_Proveedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_WF_Info_Proveedor.Name = "Panel_WF_Info_Proveedor";
            this.Panel_WF_Info_Proveedor.Size = new System.Drawing.Size(976, 562);
            this.Panel_WF_Info_Proveedor.TabIndex = 11;
            this.Panel_WF_Info_Proveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_WF_Info_Proveedor_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(160, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 5);
            this.label2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(753, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "¿No tienes?, Agrega uno";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarPROV
            // 
            this.btnAgregarPROV.BackColor = System.Drawing.Color.Navy;
            this.btnAgregarPROV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarPROV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPROV.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarPROV.FlatAppearance.BorderSize = 2;
            this.btnAgregarPROV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAgregarPROV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPROV.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPROV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarPROV.Location = new System.Drawing.Point(783, 63);
            this.btnAgregarPROV.Name = "btnAgregarPROV";
            this.btnAgregarPROV.Size = new System.Drawing.Size(153, 48);
            this.btnAgregarPROV.TabIndex = 10;
            this.btnAgregarPROV.Text = "Agregar";
            this.btnAgregarPROV.UseVisualStyleBackColor = false;
            // 
            // Panel_txtProveedor
            // 
            this.Panel_txtProveedor.BackColor = System.Drawing.Color.Navy;
            this.Panel_txtProveedor.Controls.Add(this.Label_Proveedores);
            this.Panel_txtProveedor.Controls.Add(this.btn_WF_CerrarBucarProveedor);
            this.Panel_txtProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_txtProveedor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_txtProveedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_txtProveedor.Name = "Panel_txtProveedor";
            this.Panel_txtProveedor.Size = new System.Drawing.Size(976, 44);
            this.Panel_txtProveedor.TabIndex = 9;
            // 
            // Label_Proveedores
            // 
            this.Label_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Proveedores.AutoSize = true;
            this.Label_Proveedores.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_Proveedores.Location = new System.Drawing.Point(326, 2);
            this.Label_Proveedores.Name = "Label_Proveedores";
            this.Label_Proveedores.Size = new System.Drawing.Size(329, 37);
            this.Label_Proveedores.TabIndex = 2;
            this.Label_Proveedores.Text = "Selccionar Proveedor";
            // 
            // btn_WF_CerrarBucarProveedor
            // 
            this.btn_WF_CerrarBucarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_WF_CerrarBucarProveedor.BackColor = System.Drawing.Color.Navy;
            this.btn_WF_CerrarBucarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WF_CerrarBucarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_WF_CerrarBucarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_CerrarBucarProveedor.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_CerrarBucarProveedor.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_WF_CerrarBucarProveedor.Location = new System.Drawing.Point(1, 0);
            this.btn_WF_CerrarBucarProveedor.Name = "btn_WF_CerrarBucarProveedor";
            this.btn_WF_CerrarBucarProveedor.Size = new System.Drawing.Size(51, 44);
            this.btn_WF_CerrarBucarProveedor.TabIndex = 1;
            this.btn_WF_CerrarBucarProveedor.Text = "X";
            this.btn_WF_CerrarBucarProveedor.UseVisualStyleBackColor = false;
            // 
            // btn_WF_ListoProveedor
            // 
            this.btn_WF_ListoProveedor.BackColor = System.Drawing.Color.Navy;
            this.btn_WF_ListoProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_WF_ListoProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WF_ListoProveedor.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_WF_ListoProveedor.FlatAppearance.BorderSize = 2;
            this.btn_WF_ListoProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_WF_ListoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_ListoProveedor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_ListoProveedor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_WF_ListoProveedor.Location = new System.Drawing.Point(595, 63);
            this.btn_WF_ListoProveedor.Name = "btn_WF_ListoProveedor";
            this.btn_WF_ListoProveedor.Size = new System.Drawing.Size(169, 48);
            this.btn_WF_ListoProveedor.TabIndex = 8;
            this.btn_WF_ListoProveedor.Text = "Seleccionar";
            this.btn_WF_ListoProveedor.UseVisualStyleBackColor = false;
            // 
            // txt_Busqueda_Proveedor
            // 
            this.txt_Busqueda_Proveedor.BackColor = System.Drawing.Color.Snow;
            this.txt_Busqueda_Proveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Busqueda_Proveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Busqueda_Proveedor.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.txt_Busqueda_Proveedor.Location = new System.Drawing.Point(160, 93);
            this.txt_Busqueda_Proveedor.Multiline = true;
            this.txt_Busqueda_Proveedor.Name = "txt_Busqueda_Proveedor";
            this.txt_Busqueda_Proveedor.Size = new System.Drawing.Size(323, 38);
            this.txt_Busqueda_Proveedor.TabIndex = 1;
            // 
            // DGV_WF_Proveedor
            // 
            this.DGV_WF_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_WF_Proveedor.Location = new System.Drawing.Point(73, 161);
            this.DGV_WF_Proveedor.Name = "DGV_WF_Proveedor";
            this.DGV_WF_Proveedor.RowHeadersWidth = 51;
            this.DGV_WF_Proveedor.RowTemplate.Height = 24;
            this.DGV_WF_Proveedor.Size = new System.Drawing.Size(815, 359);
            this.DGV_WF_Proveedor.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BuscarProovedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 562);
            this.Controls.Add(this.Panel_WF_Info_Proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarProovedor";
            this.Text = "BuscarProovedor";
            this.Panel_WF_Info_Proveedor.ResumeLayout(false);
            this.Panel_WF_Info_Proveedor.PerformLayout();
            this.Panel_txtProveedor.ResumeLayout(false);
            this.Panel_txtProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_WF_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_WF_Info_Proveedor;
        private System.Windows.Forms.Button btn_WF_ListoProveedor;
        private System.Windows.Forms.TextBox txt_Busqueda_Proveedor;
        private System.Windows.Forms.DataGridView DGV_WF_Proveedor;
        private System.Windows.Forms.Panel Panel_txtProveedor;
        private System.Windows.Forms.Label Label_Proveedores;
        private System.Windows.Forms.Button btn_WF_CerrarBucarProveedor;
        private System.Windows.Forms.Button btnAgregarPROV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}