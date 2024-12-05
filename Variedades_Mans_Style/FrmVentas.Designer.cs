namespace Variedades_Man_s_Style
{
    partial class FrmVentas
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
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtpagocon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotalpagar = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbempleadoventa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAgregarVentaProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Panel_txtProveedor = new System.Windows.Forms.Panel();
            this.Label_Proveedores = new System.Windows.Forms.Label();
            this.btn_WF_CerrarEmpleado = new System.Windows.Forms.Button();
            this.btnLlenarCampos = new System.Windows.Forms.Button();
            this.dgvdataVenta = new System.Windows.Forms.DataGridView();
            this.datetpFechaVenta = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.Panel_txtProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcambio
            // 
            this.txtcambio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcambio.Location = new System.Drawing.Point(944, 461);
            this.txtcambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.ReadOnly = true;
            this.txtcambio.Size = new System.Drawing.Size(125, 24);
            this.txtcambio.TabIndex = 221;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.MintCream;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label16.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label16.Location = new System.Drawing.Point(944, 423);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 25);
            this.label16.TabIndex = 216;
            this.label16.Text = "Cambio:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.MintCream;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label13.Location = new System.Drawing.Point(944, 320);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 25);
            this.label13.TabIndex = 217;
            this.label13.Text = "Paga con:";
            // 
            // txtpagocon
            // 
            this.txtpagocon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpagocon.Location = new System.Drawing.Point(943, 354);
            this.txtpagocon.Margin = new System.Windows.Forms.Padding(4);
            this.txtpagocon.Name = "txtpagocon";
            this.txtpagocon.Size = new System.Drawing.Size(125, 24);
            this.txtpagocon.TabIndex = 220;
            this.txtpagocon.TextChanged += new System.EventHandler(this.txtpagocon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(944, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 218;
            this.label1.Text = "Total a Pagar:";
            // 
            // txttotalpagar
            // 
            this.txttotalpagar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txttotalpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar.Location = new System.Drawing.Point(944, 249);
            this.txttotalpagar.Margin = new System.Windows.Forms.Padding(4);
            this.txttotalpagar.Name = "txttotalpagar";
            this.txttotalpagar.ReadOnly = true;
            this.txttotalpagar.Size = new System.Drawing.Size(125, 24);
            this.txttotalpagar.TabIndex = 219;
            this.txttotalpagar.Text = "0";
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombrecliente.Location = new System.Drawing.Point(517, 112);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(267, 24);
            this.txtnombrecliente.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Location = new System.Drawing.Point(353, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "Precio:";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(340, 238);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(103, 22);
            this.txtprecio.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Location = new System.Drawing.Point(530, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 100;
            this.label7.Text = "Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Location = new System.Drawing.Point(51, 209);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 97;
            this.label8.Text = "Producto:";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(510, 238);
            this.txtstock.Margin = new System.Windows.Forms.Padding(4);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(103, 22);
            this.txtstock.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(682, 209);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 98;
            this.label5.Text = "Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(680, 239);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtcantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(104, 22);
            this.txtcantidad.TabIndex = 6;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(33, 238);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.ReadOnly = true;
            this.txtproducto.Size = new System.Drawing.Size(259, 22);
            this.txtproducto.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.MintCream;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(280, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "Vendedor";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbempleadoventa
            // 
            this.cbempleadoventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbempleadoventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbempleadoventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbempleadoventa.FormattingEnabled = true;
            this.cbempleadoventa.Location = new System.Drawing.Point(246, 112);
            this.cbempleadoventa.Margin = new System.Windows.Forms.Padding(4);
            this.cbempleadoventa.Name = "cbempleadoventa";
            this.cbempleadoventa.Size = new System.Drawing.Size(249, 26);
            this.cbempleadoventa.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MintCream;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(51, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "Fecha:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.MintCream;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label15.Location = new System.Drawing.Point(530, 74);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 25);
            this.label15.TabIndex = 83;
            this.label15.Text = "Nombre Cliente:";
            // 
            // btnAgregarVentaProducto
            // 
            this.btnAgregarVentaProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarVentaProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarVentaProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarVentaProducto.FlatAppearance.BorderSize = 2;
            this.btnAgregarVentaProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAgregarVentaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVentaProducto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVentaProducto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarVentaProducto.Location = new System.Drawing.Point(893, 516);
            this.btnAgregarVentaProducto.Name = "btnAgregarVentaProducto";
            this.btnAgregarVentaProducto.Size = new System.Drawing.Size(238, 46);
            this.btnAgregarVentaProducto.TabIndex = 225;
            this.btnAgregarVentaProducto.Text = "Agregar";
            this.btnAgregarVentaProducto.UseVisualStyleBackColor = false;
            this.btnAgregarVentaProducto.Click += new System.EventHandler(this.btnAgregarVentaProducto_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(893, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 46);
            this.button1.TabIndex = 226;
            this.button1.Text = "Generar Venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Panel_txtProveedor
            // 
            this.Panel_txtProveedor.BackColor = System.Drawing.Color.Black;
            this.Panel_txtProveedor.Controls.Add(this.Label_Proveedores);
            this.Panel_txtProveedor.Controls.Add(this.btn_WF_CerrarEmpleado);
            this.Panel_txtProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_txtProveedor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_txtProveedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_txtProveedor.Name = "Panel_txtProveedor";
            this.Panel_txtProveedor.Size = new System.Drawing.Size(1155, 44);
            this.Panel_txtProveedor.TabIndex = 227;
            // 
            // Label_Proveedores
            // 
            this.Label_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Proveedores.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_Proveedores.Location = new System.Drawing.Point(245, 0);
            this.Label_Proveedores.Name = "Label_Proveedores";
            this.Label_Proveedores.Size = new System.Drawing.Size(685, 44);
            this.Label_Proveedores.TabIndex = 2;
            this.Label_Proveedores.Text = "Realizar Ventas";
            this.Label_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_WF_CerrarEmpleado
            // 
            this.btn_WF_CerrarEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_WF_CerrarEmpleado.BackColor = System.Drawing.Color.Black;
            this.btn_WF_CerrarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WF_CerrarEmpleado.FlatAppearance.BorderSize = 0;
            this.btn_WF_CerrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_CerrarEmpleado.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_CerrarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btn_WF_CerrarEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btn_WF_CerrarEmpleado.Name = "btn_WF_CerrarEmpleado";
            this.btn_WF_CerrarEmpleado.Size = new System.Drawing.Size(51, 44);
            this.btn_WF_CerrarEmpleado.TabIndex = 1;
            this.btn_WF_CerrarEmpleado.Text = "X";
            this.btn_WF_CerrarEmpleado.UseVisualStyleBackColor = false;
            this.btn_WF_CerrarEmpleado.Click += new System.EventHandler(this.btn_WF_CerrarEmpleado_Click);
            // 
            // btnLlenarCampos
            // 
            this.btnLlenarCampos.BackColor = System.Drawing.Color.Green;
            this.btnLlenarCampos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLlenarCampos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLlenarCampos.FlatAppearance.BorderSize = 2;
            this.btnLlenarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnLlenarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlenarCampos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenarCampos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLlenarCampos.Location = new System.Drawing.Point(893, 61);
            this.btnLlenarCampos.Name = "btnLlenarCampos";
            this.btnLlenarCampos.Size = new System.Drawing.Size(238, 46);
            this.btnLlenarCampos.TabIndex = 228;
            this.btnLlenarCampos.Text = "Llenar Campos";
            this.btnLlenarCampos.UseVisualStyleBackColor = false;
            this.btnLlenarCampos.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvdataVenta
            // 
            this.dgvdataVenta.AllowUserToAddRows = false;
            this.dgvdataVenta.AllowUserToDeleteRows = false;
            this.dgvdataVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvdataVenta.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvdataVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvdataVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdataVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdataVenta.ColumnHeadersHeight = 30;
            this.dgvdataVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdataVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdataVenta.EnableHeadersVisualStyles = false;
            this.dgvdataVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvdataVenta.Location = new System.Drawing.Point(33, 291);
            this.dgvdataVenta.MultiSelect = false;
            this.dgvdataVenta.Name = "dgvdataVenta";
            this.dgvdataVenta.ReadOnly = true;
            this.dgvdataVenta.RowHeadersVisible = false;
            this.dgvdataVenta.RowHeadersWidth = 51;
            this.dgvdataVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdataVenta.Size = new System.Drawing.Size(751, 372);
            this.dgvdataVenta.TabIndex = 229;
            // 
            // datetpFechaVenta
            // 
            this.datetpFechaVenta.Location = new System.Drawing.Point(12, 110);
            this.datetpFechaVenta.Name = "datetpFechaVenta";
            this.datetpFechaVenta.Size = new System.Drawing.Size(205, 22);
            this.datetpFechaVenta.TabIndex = 230;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1155, 675);
            this.Controls.Add(this.datetpFechaVenta);
            this.Controls.Add(this.dgvdataVenta);
            this.Controls.Add(this.btnLlenarCampos);
            this.Controls.Add(this.Panel_txtProveedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarVentaProducto);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.cbempleadoventa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.txtpagocon);
            this.Controls.Add(this.txttotalpagar);
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.Panel_txtProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdataVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtpagocon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotalpagar;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbempleadoventa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAgregarVentaProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel Panel_txtProveedor;
        private System.Windows.Forms.Label Label_Proveedores;
        private System.Windows.Forms.Button btn_WF_CerrarEmpleado;
        private System.Windows.Forms.Button btnLlenarCampos;
        private System.Windows.Forms.DataGridView dgvdataVenta;
        private System.Windows.Forms.DateTimePicker datetpFechaVenta;
    }
}