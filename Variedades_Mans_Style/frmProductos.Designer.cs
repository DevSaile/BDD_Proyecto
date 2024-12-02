namespace Variedades_Man_s_Style
{
    partial class frmProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVerProductos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.label_Numero = new System.Windows.Forms.Label();
            this.cbBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBuscarPorSucursal = new System.Windows.Forms.ComboBox();
            this.Panel_txtProveedor = new System.Windows.Forms.Panel();
            this.Label_CompraEntrada = new System.Windows.Forms.Label();
            this.btn_WF_CerraProductos = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnDesactivarProducto = new System.Windows.Forms.Button();
            this.btnBuscarSucursal = new System.Windows.Forms.Button();
            this.BuscarPorCategoria = new System.Windows.Forms.Button();
            this.btnBucarProduID = new System.Windows.Forms.Button();
            this.btnBuscarProduNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProductos)).BeginInit();
            this.Panel_txtProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerProductos
            // 
            this.dgvVerProductos.AllowUserToAddRows = false;
            this.dgvVerProductos.AllowUserToDeleteRows = false;
            this.dgvVerProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerProductos.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvVerProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvVerProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVerProductos.ColumnHeadersHeight = 30;
            this.dgvVerProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerProductos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVerProductos.EnableHeadersVisualStyles = false;
            this.dgvVerProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVerProductos.Location = new System.Drawing.Point(17, 273);
            this.dgvVerProductos.MultiSelect = false;
            this.dgvVerProductos.Name = "dgvVerProductos";
            this.dgvVerProductos.ReadOnly = true;
            this.dgvVerProductos.RowHeadersVisible = false;
            this.dgvVerProductos.RowHeadersWidth = 51;
            this.dgvVerProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerProductos.Size = new System.Drawing.Size(858, 372);
            this.dgvVerProductos.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(858, 46);
            this.label5.TabIndex = 44;
            this.label5.Text = "Informacion de Productos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(190, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 5);
            this.label4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(192, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 5);
            this.label2.TabIndex = 9;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_IdProducto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_IdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdProducto.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdProducto.ForeColor = System.Drawing.Color.Black;
            this.txt_IdProducto.Location = new System.Drawing.Point(192, 127);
            this.txt_IdProducto.Multiline = true;
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(220, 32);
            this.txt_IdProducto.TabIndex = 6;
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NombreProducto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_NombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NombreProducto.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProducto.ForeColor = System.Drawing.Color.Black;
            this.txt_NombreProducto.Location = new System.Drawing.Point(191, 62);
            this.txt_NombreProducto.Multiline = true;
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_NombreProducto.TabIndex = 5;
            // 
            // label_Nombre
            // 
            this.label_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Nombre.BackColor = System.Drawing.Color.White;
            this.label_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Nombre.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Nombre.ForeColor = System.Drawing.Color.MediumBlue;
            this.label_Nombre.Location = new System.Drawing.Point(12, 61);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(152, 35);
            this.label_Nombre.TabIndex = 2;
            this.label_Nombre.Text = "Producto";
            this.label_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Nombre.Click += new System.EventHandler(this.label_Nombre_Click);
            // 
            // label_Numero
            // 
            this.label_Numero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Numero.BackColor = System.Drawing.Color.White;
            this.label_Numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Numero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Numero.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Numero.ForeColor = System.Drawing.Color.MediumBlue;
            this.label_Numero.Location = new System.Drawing.Point(12, 120);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(151, 38);
            this.label_Numero.TabIndex = 3;
            this.label_Numero.Text = "ID_producto";
            this.label_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Numero.Click += new System.EventHandler(this.label_Numero_Click);
            // 
            // cbBuscarCategoria
            // 
            this.cbBuscarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscarCategoria.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbBuscarCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBuscarCategoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarCategoria.FormattingEnabled = true;
            this.cbBuscarCategoria.Location = new System.Drawing.Point(770, 66);
            this.cbBuscarCategoria.Name = "cbBuscarCategoria";
            this.cbBuscarCategoria.Size = new System.Drawing.Size(207, 35);
            this.cbBuscarCategoria.TabIndex = 91;
            this.cbBuscarCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBuscarCategoria_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(574, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 38);
            this.label3.TabIndex = 92;
            this.label3.Text = "Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(574, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 40);
            this.label6.TabIndex = 95;
            this.label6.Text = "Sucursal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBuscarPorSucursal
            // 
            this.cbBuscarPorSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscarPorSucursal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbBuscarPorSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBuscarPorSucursal.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarPorSucursal.FormattingEnabled = true;
            this.cbBuscarPorSucursal.Location = new System.Drawing.Point(770, 139);
            this.cbBuscarPorSucursal.Name = "cbBuscarPorSucursal";
            this.cbBuscarPorSucursal.Size = new System.Drawing.Size(207, 35);
            this.cbBuscarPorSucursal.TabIndex = 94;
            this.cbBuscarPorSucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBuscarPorSucursal_KeyPress);
            // 
            // Panel_txtProveedor
            // 
            this.Panel_txtProveedor.BackColor = System.Drawing.SystemColors.WindowText;
            this.Panel_txtProveedor.Controls.Add(this.Label_CompraEntrada);
            this.Panel_txtProveedor.Controls.Add(this.btn_WF_CerraProductos);
            this.Panel_txtProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_txtProveedor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_txtProveedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_txtProveedor.Name = "Panel_txtProveedor";
            this.Panel_txtProveedor.Size = new System.Drawing.Size(1099, 44);
            this.Panel_txtProveedor.TabIndex = 97;
            // 
            // Label_CompraEntrada
            // 
            this.Label_CompraEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_CompraEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label_CompraEntrada.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_CompraEntrada.Location = new System.Drawing.Point(378, -1);
            this.Label_CompraEntrada.Name = "Label_CompraEntrada";
            this.Label_CompraEntrada.Size = new System.Drawing.Size(346, 44);
            this.Label_CompraEntrada.TabIndex = 2;
            this.Label_CompraEntrada.Text = "Busqueda Productos";
            this.Label_CompraEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_WF_CerraProductos
            // 
            this.btn_WF_CerraProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_WF_CerraProductos.BackColor = System.Drawing.Color.Black;
            this.btn_WF_CerraProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WF_CerraProductos.FlatAppearance.BorderSize = 0;
            this.btn_WF_CerraProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btn_WF_CerraProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_CerraProductos.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_CerraProductos.ForeColor = System.Drawing.Color.White;
            this.btn_WF_CerraProductos.Location = new System.Drawing.Point(0, -1);
            this.btn_WF_CerraProductos.Name = "btn_WF_CerraProductos";
            this.btn_WF_CerraProductos.Size = new System.Drawing.Size(51, 44);
            this.btn_WF_CerraProductos.TabIndex = 1;
            this.btn_WF_CerraProductos.Text = "X";
            this.btn_WF_CerraProductos.UseVisualStyleBackColor = false;
            this.btn_WF_CerraProductos.Click += new System.EventHandler(this.btn_WF_CerraProductos_Click);
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarProducto.BackColor = System.Drawing.Color.LawnGreen;
            this.btnActualizarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizarProducto.FlatAppearance.BorderSize = 2;
            this.btnActualizarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnActualizarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarProducto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProducto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnActualizarProducto.Location = new System.Drawing.Point(902, 478);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(170, 46);
            this.btnActualizarProducto.TabIndex = 103;
            this.btnActualizarProducto.Text = "Actualizar";
            this.btnActualizarProducto.UseVisualStyleBackColor = false;
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 2;
            this.btnAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarProducto.Location = new System.Drawing.Point(902, 342);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(170, 46);
            this.btnAgregarProducto.TabIndex = 104;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // btnDesactivarProducto
            // 
            this.btnDesactivarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesactivarProducto.BackColor = System.Drawing.Color.Red;
            this.btnDesactivarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDesactivarProducto.FlatAppearance.BorderSize = 2;
            this.btnDesactivarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnDesactivarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivarProducto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarProducto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDesactivarProducto.Location = new System.Drawing.Point(902, 412);
            this.btnDesactivarProducto.Name = "btnDesactivarProducto";
            this.btnDesactivarProducto.Size = new System.Drawing.Size(170, 46);
            this.btnDesactivarProducto.TabIndex = 102;
            this.btnDesactivarProducto.Text = "Remover";
            this.btnDesactivarProducto.UseVisualStyleBackColor = false;
            this.btnDesactivarProducto.Click += new System.EventHandler(this.btnDesactivarProducto_Click);
            // 
            // btnBuscarSucursal
            // 
            this.btnBuscarSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarSucursal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarSucursal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarSucursal.FlatAppearance.BorderSize = 0;
            this.btnBuscarSucursal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscarSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSucursal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarSucursal.ForeColor = System.Drawing.Color.White;
            this.btnBuscarSucursal.Image = global::Variedades_Man_s_Style.Properties.Resources.search__1_;
            this.btnBuscarSucursal.Location = new System.Drawing.Point(1006, 138);
            this.btnBuscarSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarSucursal.Name = "btnBuscarSucursal";
            this.btnBuscarSucursal.Size = new System.Drawing.Size(64, 41);
            this.btnBuscarSucursal.TabIndex = 101;
            this.btnBuscarSucursal.UseVisualStyleBackColor = false;
            this.btnBuscarSucursal.Click += new System.EventHandler(this.btnBuscarSucursal_Click);
            // 
            // BuscarPorCategoria
            // 
            this.BuscarPorCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarPorCategoria.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BuscarPorCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BuscarPorCategoria.FlatAppearance.BorderSize = 0;
            this.BuscarPorCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.BuscarPorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarPorCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarPorCategoria.ForeColor = System.Drawing.Color.White;
            this.BuscarPorCategoria.Image = global::Variedades_Man_s_Style.Properties.Resources.search__1_;
            this.BuscarPorCategoria.Location = new System.Drawing.Point(1006, 65);
            this.BuscarPorCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarPorCategoria.Name = "BuscarPorCategoria";
            this.BuscarPorCategoria.Size = new System.Drawing.Size(64, 41);
            this.BuscarPorCategoria.TabIndex = 100;
            this.BuscarPorCategoria.UseVisualStyleBackColor = false;
            this.BuscarPorCategoria.Click += new System.EventHandler(this.BuscarPorCategoria_Click);
            // 
            // btnBucarProduID
            // 
            this.btnBucarProduID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBucarProduID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBucarProduID.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBucarProduID.FlatAppearance.BorderSize = 0;
            this.btnBucarProduID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBucarProduID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBucarProduID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBucarProduID.ForeColor = System.Drawing.Color.White;
            this.btnBucarProduID.Image = global::Variedades_Man_s_Style.Properties.Resources.search__1_;
            this.btnBucarProduID.Location = new System.Drawing.Point(438, 125);
            this.btnBucarProduID.Margin = new System.Windows.Forms.Padding(4);
            this.btnBucarProduID.Name = "btnBucarProduID";
            this.btnBucarProduID.Size = new System.Drawing.Size(69, 41);
            this.btnBucarProduID.TabIndex = 99;
            this.btnBucarProduID.UseVisualStyleBackColor = false;
            this.btnBucarProduID.Click += new System.EventHandler(this.btnBucarProduID_Click);
            // 
            // btnBuscarProduNombre
            // 
            this.btnBuscarProduNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProduNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarProduNombre.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarProduNombre.FlatAppearance.BorderSize = 0;
            this.btnBuscarProduNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscarProduNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProduNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProduNombre.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProduNombre.Image = global::Variedades_Man_s_Style.Properties.Resources.search__1_;
            this.btnBuscarProduNombre.Location = new System.Drawing.Point(438, 66);
            this.btnBuscarProduNombre.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProduNombre.Name = "btnBuscarProduNombre";
            this.btnBuscarProduNombre.Size = new System.Drawing.Size(69, 41);
            this.btnBuscarProduNombre.TabIndex = 98;
            this.btnBuscarProduNombre.UseVisualStyleBackColor = false;
            this.btnBuscarProduNombre.Click += new System.EventHandler(this.btnBuscarProduNombre_Click);
            this.btnBuscarProduNombre.MouseLeave += new System.EventHandler(this.btnBuscarProduNombre_MouseLeave);
            this.btnBuscarProduNombre.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBuscarProduNombre_MouseMove);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1099, 657);
            this.Controls.Add(this.btnActualizarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnDesactivarProducto);
            this.Controls.Add(this.btnBuscarSucursal);
            this.Controls.Add(this.BuscarPorCategoria);
            this.Controls.Add(this.btnBucarProduID);
            this.Controls.Add(this.btnBuscarProduNombre);
            this.Controls.Add(this.Panel_txtProveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBuscarPorSucursal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBuscarCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Numero);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.dgvVerProductos);
            this.Controls.Add(this.label4);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProductos)).EndInit();
            this.Panel_txtProveedor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVerProductos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdProducto;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.Label label_Nombre;
        private System.Windows.Forms.Label label_Numero;
        private System.Windows.Forms.ComboBox cbBuscarCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBuscarPorSucursal;
        private System.Windows.Forms.Panel Panel_txtProveedor;
        private System.Windows.Forms.Label Label_CompraEntrada;
        private System.Windows.Forms.Button btn_WF_CerraProductos;
        private System.Windows.Forms.Button btnBuscarProduNombre;
        private System.Windows.Forms.Button btnBucarProduID;
        private System.Windows.Forms.Button BuscarPorCategoria;
        private System.Windows.Forms.Button btnBuscarSucursal;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnDesactivarProducto;
    }
}