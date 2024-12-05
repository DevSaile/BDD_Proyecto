namespace Variedades_Man_s_Style
{
    partial class WF_CompraEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_txtProveedor = new System.Windows.Forms.Panel();
            this.Label_CompraEntrada = new System.Windows.Forms.Label();
            this.btn_WF_CerrarProveedor = new System.Windows.Forms.Button();
            this.Panel_WF_Info_Proveedor = new System.Windows.Forms.Panel();
            this.label_Agregar = new System.Windows.Forms.Label();
            this.Fecha2_CompraEntrada = new System.Windows.Forms.DateTimePicker();
            this.Fecha1_CompraEntrada = new System.Windows.Forms.DateTimePicker();
            this.btn_BuscarCompraEntrada = new System.Windows.Forms.Button();
            this.DGV_WF_Proveedor = new System.Windows.Forms.DataGridView();
            this.Panel_txtProveedor.SuspendLayout();
            this.Panel_WF_Info_Proveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_WF_Proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_txtProveedor
            // 
            this.Panel_txtProveedor.BackColor = System.Drawing.SystemColors.WindowText;
            this.Panel_txtProveedor.Controls.Add(this.Label_CompraEntrada);
            this.Panel_txtProveedor.Controls.Add(this.btn_WF_CerrarProveedor);
            this.Panel_txtProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_txtProveedor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_txtProveedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_txtProveedor.Name = "Panel_txtProveedor";
            this.Panel_txtProveedor.Size = new System.Drawing.Size(1183, 44);
            this.Panel_txtProveedor.TabIndex = 5;
            // 
            // Label_CompraEntrada
            // 
            this.Label_CompraEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CompraEntrada.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_CompraEntrada.Location = new System.Drawing.Point(421, 0);
            this.Label_CompraEntrada.Name = "Label_CompraEntrada";
            this.Label_CompraEntrada.Size = new System.Drawing.Size(430, 44);
            this.Label_CompraEntrada.TabIndex = 2;
            this.Label_CompraEntrada.Text = "Registro de Compras";
            this.Label_CompraEntrada.Click += new System.EventHandler(this.Label_CompraEntrada_Click);
            // 
            // btn_WF_CerrarProveedor
            // 
            this.btn_WF_CerrarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_WF_CerrarProveedor.BackColor = System.Drawing.Color.Black;
            this.btn_WF_CerrarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WF_CerrarProveedor.FlatAppearance.BorderSize = 0;
            this.btn_WF_CerrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_CerrarProveedor.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_CerrarProveedor.ForeColor = System.Drawing.Color.White;
            this.btn_WF_CerrarProveedor.Location = new System.Drawing.Point(0, 0);
            this.btn_WF_CerrarProveedor.Name = "btn_WF_CerrarProveedor";
            this.btn_WF_CerrarProveedor.Size = new System.Drawing.Size(51, 44);
            this.btn_WF_CerrarProveedor.TabIndex = 1;
            this.btn_WF_CerrarProveedor.Text = "X";
            this.btn_WF_CerrarProveedor.UseVisualStyleBackColor = false;
            this.btn_WF_CerrarProveedor.Click += new System.EventHandler(this.btn_WF_CerrarProveedor_Click);
            // 
            // Panel_WF_Info_Proveedor
            // 
            this.Panel_WF_Info_Proveedor.BackColor = System.Drawing.Color.Snow;
            this.Panel_WF_Info_Proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel_WF_Info_Proveedor.Controls.Add(this.DGV_WF_Proveedor);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.label_Agregar);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.Fecha2_CompraEntrada);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.Fecha1_CompraEntrada);
            this.Panel_WF_Info_Proveedor.Controls.Add(this.btn_BuscarCompraEntrada);
            this.Panel_WF_Info_Proveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_WF_Info_Proveedor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_WF_Info_Proveedor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Panel_WF_Info_Proveedor.Location = new System.Drawing.Point(0, 44);
            this.Panel_WF_Info_Proveedor.Name = "Panel_WF_Info_Proveedor";
            this.Panel_WF_Info_Proveedor.Size = new System.Drawing.Size(1183, 533);
            this.Panel_WF_Info_Proveedor.TabIndex = 11;
            this.Panel_WF_Info_Proveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_WF_Info_Proveedor_Paint);
            // 
            // label_Agregar
            // 
            this.label_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Agregar.BackColor = System.Drawing.Color.Black;
            this.label_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Agregar.Font = new System.Drawing.Font("Yu Gothic", 15.2F);
            this.label_Agregar.ForeColor = System.Drawing.Color.White;
            this.label_Agregar.Location = new System.Drawing.Point(441, 28);
            this.label_Agregar.Name = "label_Agregar";
            this.label_Agregar.Size = new System.Drawing.Size(142, 40);
            this.label_Agregar.TabIndex = 11;
            this.label_Agregar.Text = "Entre";
            this.label_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Agregar.Click += new System.EventHandler(this.label_Agregar_Click);
            // 
            // Fecha2_CompraEntrada
            // 
            this.Fecha2_CompraEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fecha2_CompraEntrada.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.Fecha2_CompraEntrada.Location = new System.Drawing.Point(610, 28);
            this.Fecha2_CompraEntrada.Name = "Fecha2_CompraEntrada";
            this.Fecha2_CompraEntrada.Size = new System.Drawing.Size(391, 40);
            this.Fecha2_CompraEntrada.TabIndex = 10;
            this.Fecha2_CompraEntrada.ValueChanged += new System.EventHandler(this.Fecha2_CompraEntrada_ValueChanged);
            // 
            // Fecha1_CompraEntrada
            // 
            this.Fecha1_CompraEntrada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fecha1_CompraEntrada.CalendarFont = new System.Drawing.Font("Yu Gothic", 12F);
            this.Fecha1_CompraEntrada.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.Fecha1_CompraEntrada.Location = new System.Drawing.Point(12, 28);
            this.Fecha1_CompraEntrada.Name = "Fecha1_CompraEntrada";
            this.Fecha1_CompraEntrada.Size = new System.Drawing.Size(399, 40);
            this.Fecha1_CompraEntrada.TabIndex = 9;
            this.Fecha1_CompraEntrada.ValueChanged += new System.EventHandler(this.Fecha1_CompraEntrada_ValueChanged);
            // 
            // btn_BuscarCompraEntrada
            // 
            this.btn_BuscarCompraEntrada.BackColor = System.Drawing.Color.Black;
            this.btn_BuscarCompraEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BuscarCompraEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarCompraEntrada.FlatAppearance.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_BuscarCompraEntrada.FlatAppearance.BorderSize = 2;
            this.btn_BuscarCompraEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_BuscarCompraEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarCompraEntrada.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarCompraEntrada.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_BuscarCompraEntrada.Location = new System.Drawing.Point(1022, 23);
            this.btn_BuscarCompraEntrada.Name = "btn_BuscarCompraEntrada";
            this.btn_BuscarCompraEntrada.Size = new System.Drawing.Size(149, 48);
            this.btn_BuscarCompraEntrada.TabIndex = 8;
            this.btn_BuscarCompraEntrada.Text = "Buscar";
            this.btn_BuscarCompraEntrada.UseVisualStyleBackColor = false;
            this.btn_BuscarCompraEntrada.Click += new System.EventHandler(this.btn_BuscarCompraEntrada_Click);
            // 
            // DGV_WF_Proveedor
            // 
            this.DGV_WF_Proveedor.AllowUserToAddRows = false;
            this.DGV_WF_Proveedor.AllowUserToDeleteRows = false;
            this.DGV_WF_Proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_WF_Proveedor.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DGV_WF_Proveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_WF_Proveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_WF_Proveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_WF_Proveedor.ColumnHeadersHeight = 30;
            this.DGV_WF_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_WF_Proveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_WF_Proveedor.EnableHeadersVisualStyles = false;
            this.DGV_WF_Proveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_WF_Proveedor.Location = new System.Drawing.Point(12, 94);
            this.DGV_WF_Proveedor.MultiSelect = false;
            this.DGV_WF_Proveedor.Name = "DGV_WF_Proveedor";
            this.DGV_WF_Proveedor.ReadOnly = true;
            this.DGV_WF_Proveedor.RowHeadersVisible = false;
            this.DGV_WF_Proveedor.RowHeadersWidth = 51;
            this.DGV_WF_Proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_WF_Proveedor.Size = new System.Drawing.Size(1159, 427);
            this.DGV_WF_Proveedor.TabIndex = 106;
            // 
            // WF_CompraEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 577);
            this.Controls.Add(this.Panel_WF_Info_Proveedor);
            this.Controls.Add(this.Panel_txtProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WF_CompraEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WF_CompraEntrada";
            this.Load += new System.EventHandler(this.WF_CompraEntrada_Load);
            this.Panel_txtProveedor.ResumeLayout(false);
            this.Panel_WF_Info_Proveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_WF_Proveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_txtProveedor;
        private System.Windows.Forms.Label Label_CompraEntrada;
        private System.Windows.Forms.Button btn_WF_CerrarProveedor;
        private System.Windows.Forms.Panel Panel_WF_Info_Proveedor;
        private System.Windows.Forms.Button btn_BuscarCompraEntrada;
        private System.Windows.Forms.DateTimePicker Fecha2_CompraEntrada;
        private System.Windows.Forms.DateTimePicker Fecha1_CompraEntrada;
        private System.Windows.Forms.Label label_Agregar;
        private System.Windows.Forms.DataGridView DGV_WF_Proveedor;
    }
}