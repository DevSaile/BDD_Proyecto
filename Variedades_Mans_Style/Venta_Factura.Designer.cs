namespace Variedades_Man_s_Style
{
    partial class Venta_Factura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel_txtVentaFactura = new System.Windows.Forms.Panel();
            this.Label_CompraEntrada = new System.Windows.Forms.Label();
            this.btn_WF_CerrarCompraEntrada = new System.Windows.Forms.Button();
            this.Panel_WF_Info_VentaFactura = new System.Windows.Forms.Panel();
            this.label_Agregar = new System.Windows.Forms.Label();
            this.Fecha2_Venta_Factura = new System.Windows.Forms.DateTimePicker();
            this.Fecha1_Venta_Factura = new System.Windows.Forms.DateTimePicker();
            this.btn_BuscarVentaFactura = new System.Windows.Forms.Button();
            this.DGV_WF_VentaFactura = new System.Windows.Forms.DataGridView();
            this.Panel_txtVentaFactura.SuspendLayout();
            this.Panel_WF_Info_VentaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_WF_VentaFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_txtVentaFactura
            // 
            this.Panel_txtVentaFactura.BackColor = System.Drawing.Color.Navy;
            this.Panel_txtVentaFactura.Controls.Add(this.Label_CompraEntrada);
            this.Panel_txtVentaFactura.Controls.Add(this.btn_WF_CerrarCompraEntrada);
            this.Panel_txtVentaFactura.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_txtVentaFactura.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_txtVentaFactura.Location = new System.Drawing.Point(0, 0);
            this.Panel_txtVentaFactura.Name = "Panel_txtVentaFactura";
            this.Panel_txtVentaFactura.Size = new System.Drawing.Size(1180, 44);
            this.Panel_txtVentaFactura.TabIndex = 6;
            // 
            // Label_CompraEntrada
            // 
            this.Label_CompraEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CompraEntrada.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_CompraEntrada.Location = new System.Drawing.Point(275, 0);
            this.Label_CompraEntrada.Name = "Label_CompraEntrada";
            this.Label_CompraEntrada.Size = new System.Drawing.Size(610, 44);
            this.Label_CompraEntrada.TabIndex = 2;
            this.Label_CompraEntrada.Text = "Registros de Ventas";
            this.Label_CompraEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_WF_CerrarCompraEntrada
            // 
            this.btn_WF_CerrarCompraEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_WF_CerrarCompraEntrada.BackColor = System.Drawing.Color.Navy;
            this.btn_WF_CerrarCompraEntrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WF_CerrarCompraEntrada.FlatAppearance.BorderSize = 0;
            this.btn_WF_CerrarCompraEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_CerrarCompraEntrada.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_CerrarCompraEntrada.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_WF_CerrarCompraEntrada.Location = new System.Drawing.Point(1, 0);
            this.btn_WF_CerrarCompraEntrada.Name = "btn_WF_CerrarCompraEntrada";
            this.btn_WF_CerrarCompraEntrada.Size = new System.Drawing.Size(51, 44);
            this.btn_WF_CerrarCompraEntrada.TabIndex = 1;
            this.btn_WF_CerrarCompraEntrada.Text = "X";
            this.btn_WF_CerrarCompraEntrada.UseVisualStyleBackColor = false;
            this.btn_WF_CerrarCompraEntrada.Click += new System.EventHandler(this.btn_WF_CerrarCompraEntrada_Click);
            // 
            // Panel_WF_Info_VentaFactura
            // 
            this.Panel_WF_Info_VentaFactura.BackColor = System.Drawing.Color.White;
            this.Panel_WF_Info_VentaFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel_WF_Info_VentaFactura.Controls.Add(this.DGV_WF_VentaFactura);
            this.Panel_WF_Info_VentaFactura.Controls.Add(this.label_Agregar);
            this.Panel_WF_Info_VentaFactura.Controls.Add(this.Fecha2_Venta_Factura);
            this.Panel_WF_Info_VentaFactura.Controls.Add(this.Fecha1_Venta_Factura);
            this.Panel_WF_Info_VentaFactura.Controls.Add(this.btn_BuscarVentaFactura);
            this.Panel_WF_Info_VentaFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_WF_Info_VentaFactura.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_WF_Info_VentaFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Panel_WF_Info_VentaFactura.Location = new System.Drawing.Point(0, 44);
            this.Panel_WF_Info_VentaFactura.Name = "Panel_WF_Info_VentaFactura";
            this.Panel_WF_Info_VentaFactura.Size = new System.Drawing.Size(1180, 541);
            this.Panel_WF_Info_VentaFactura.TabIndex = 12;
            // 
            // label_Agregar
            // 
            this.label_Agregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Agregar.BackColor = System.Drawing.Color.White;
            this.label_Agregar.Font = new System.Drawing.Font("Yu Gothic", 15.2F);
            this.label_Agregar.ForeColor = System.Drawing.Color.Black;
            this.label_Agregar.Location = new System.Drawing.Point(451, 28);
            this.label_Agregar.Name = "label_Agregar";
            this.label_Agregar.Size = new System.Drawing.Size(142, 40);
            this.label_Agregar.TabIndex = 11;
            this.label_Agregar.Text = "Entre";
            this.label_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fecha2_Venta_Factura
            // 
            this.Fecha2_Venta_Factura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fecha2_Venta_Factura.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.Fecha2_Venta_Factura.Location = new System.Drawing.Point(622, 28);
            this.Fecha2_Venta_Factura.Name = "Fecha2_Venta_Factura";
            this.Fecha2_Venta_Factura.Size = new System.Drawing.Size(402, 40);
            this.Fecha2_Venta_Factura.TabIndex = 10;
            // 
            // Fecha1_Venta_Factura
            // 
            this.Fecha1_Venta_Factura.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Fecha1_Venta_Factura.CalendarFont = new System.Drawing.Font("Yu Gothic", 12F);
            this.Fecha1_Venta_Factura.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.Fecha1_Venta_Factura.Location = new System.Drawing.Point(21, 28);
            this.Fecha1_Venta_Factura.Name = "Fecha1_Venta_Factura";
            this.Fecha1_Venta_Factura.Size = new System.Drawing.Size(403, 40);
            this.Fecha1_Venta_Factura.TabIndex = 9;
            // 
            // btn_BuscarVentaFactura
            // 
            this.btn_BuscarVentaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BuscarVentaFactura.BackColor = System.Drawing.Color.Navy;
            this.btn_BuscarVentaFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BuscarVentaFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarVentaFactura.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_BuscarVentaFactura.FlatAppearance.BorderSize = 2;
            this.btn_BuscarVentaFactura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_BuscarVentaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarVentaFactura.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarVentaFactura.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_BuscarVentaFactura.Location = new System.Drawing.Point(1006, 138);
            this.btn_BuscarVentaFactura.Name = "btn_BuscarVentaFactura";
            this.btn_BuscarVentaFactura.Size = new System.Drawing.Size(149, 48);
            this.btn_BuscarVentaFactura.TabIndex = 8;
            this.btn_BuscarVentaFactura.Text = "Buscar";
            this.btn_BuscarVentaFactura.UseVisualStyleBackColor = false;
            // 
            // DGV_WF_VentaFactura
            // 
            this.DGV_WF_VentaFactura.AllowUserToAddRows = false;
            this.DGV_WF_VentaFactura.AllowUserToDeleteRows = false;
            this.DGV_WF_VentaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_WF_VentaFactura.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DGV_WF_VentaFactura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.DGV_WF_VentaFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_WF_VentaFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_WF_VentaFactura.ColumnHeadersHeight = 30;
            this.DGV_WF_VentaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_WF_VentaFactura.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_WF_VentaFactura.EnableHeadersVisualStyles = false;
            this.DGV_WF_VentaFactura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_WF_VentaFactura.Location = new System.Drawing.Point(21, 99);
            this.DGV_WF_VentaFactura.MultiSelect = false;
            this.DGV_WF_VentaFactura.Name = "DGV_WF_VentaFactura";
            this.DGV_WF_VentaFactura.ReadOnly = true;
            this.DGV_WF_VentaFactura.RowHeadersVisible = false;
            this.DGV_WF_VentaFactura.RowHeadersWidth = 51;
            this.DGV_WF_VentaFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_WF_VentaFactura.Size = new System.Drawing.Size(962, 372);
            this.DGV_WF_VentaFactura.TabIndex = 106;
            // 
            // Venta_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 585);
            this.Controls.Add(this.Panel_WF_Info_VentaFactura);
            this.Controls.Add(this.Panel_txtVentaFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Venta_Factura";
            this.Text = "Venta_Factura";
            this.Load += new System.EventHandler(this.Venta_Factura_Load);
            this.Panel_txtVentaFactura.ResumeLayout(false);
            this.Panel_WF_Info_VentaFactura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_WF_VentaFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_txtVentaFactura;
        private System.Windows.Forms.Label Label_CompraEntrada;
        private System.Windows.Forms.Button btn_WF_CerrarCompraEntrada;
        private System.Windows.Forms.Panel Panel_WF_Info_VentaFactura;
        private System.Windows.Forms.Label label_Agregar;
        private System.Windows.Forms.DateTimePicker Fecha2_Venta_Factura;
        private System.Windows.Forms.DateTimePicker Fecha1_Venta_Factura;
        private System.Windows.Forms.Button btn_BuscarVentaFactura;
        private System.Windows.Forms.DataGridView DGV_WF_VentaFactura;
    }
}