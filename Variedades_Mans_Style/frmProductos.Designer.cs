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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVerProductos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdProducto = new System.Windows.Forms.TextBox();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProduNombre = new FontAwesome.Sharp.IconButton();
            this.label_Nombre = new System.Windows.Forms.Label();
            this.btnBucarProduID = new FontAwesome.Sharp.IconButton();
            this.label_Numero = new System.Windows.Forms.Label();
            this.cbBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarPorCategoria = new FontAwesome.Sharp.IconButton();
            this.btnBuscarSucursal = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBuscarPorSucursal = new System.Windows.Forms.ComboBox();
            this.Panel_txtProveedor = new System.Windows.Forms.Panel();
            this.Label_CompraEntrada = new System.Windows.Forms.Label();
            this.btn_WF_CerraProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerProductos)).BeginInit();
            this.Panel_txtProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVerProductos
            // 
            this.dgvVerProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVerProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVerProductos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVerProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVerProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvVerProductos.ColumnHeadersHeight = 30;
            this.dgvVerProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerProductos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVerProductos.EnableHeadersVisualStyles = false;
            this.dgvVerProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVerProductos.Location = new System.Drawing.Point(13, 243);
            this.dgvVerProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVerProductos.Name = "dgvVerProductos";
            this.dgvVerProductos.RowHeadersVisible = false;
            this.dgvVerProductos.RowHeadersWidth = 51;
            this.dgvVerProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerProductos.Size = new System.Drawing.Size(743, 401);
            this.dgvVerProductos.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(311, 34);
            this.label5.TabIndex = 44;
            this.label5.Text = "Stock de Productos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(200, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 5);
            this.label4.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(202, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 5);
            this.label2.TabIndex = 9;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_IdProducto
            // 
            this.txt_IdProducto.BackColor = System.Drawing.Color.LightGray;
            this.txt_IdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_IdProducto.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdProducto.Location = new System.Drawing.Point(202, 127);
            this.txt_IdProducto.Multiline = true;
            this.txt_IdProducto.Name = "txt_IdProducto";
            this.txt_IdProducto.Size = new System.Drawing.Size(220, 32);
            this.txt_IdProducto.TabIndex = 6;
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.BackColor = System.Drawing.Color.LightGray;
            this.txt_NombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NombreProducto.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreProducto.Location = new System.Drawing.Point(201, 62);
            this.txt_NombreProducto.Multiline = true;
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(223, 34);
            this.txt_NombreProducto.TabIndex = 5;
            // 
            // btnBuscarProduNombre
            // 
            this.btnBuscarProduNombre.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProduNombre.IconColor = System.Drawing.Color.Black;
            this.btnBuscarProduNombre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProduNombre.IconSize = 18;
            this.btnBuscarProduNombre.Location = new System.Drawing.Point(454, 57);
            this.btnBuscarProduNombre.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProduNombre.Name = "btnBuscarProduNombre";
            this.btnBuscarProduNombre.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnBuscarProduNombre.Size = new System.Drawing.Size(55, 49);
            this.btnBuscarProduNombre.TabIndex = 88;
            this.btnBuscarProduNombre.UseVisualStyleBackColor = true;
            this.btnBuscarProduNombre.Click += new System.EventHandler(this.btnBuscarProduNombre_Click);
            // 
            // label_Nombre
            // 
            this.label_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label_Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Nombre.Font = new System.Drawing.Font("Yu Gothic", 14.2F);
            this.label_Nombre.ForeColor = System.Drawing.Color.White;
            this.label_Nombre.Location = new System.Drawing.Point(25, 66);
            this.label_Nombre.Name = "label_Nombre";
            this.label_Nombre.Size = new System.Drawing.Size(139, 35);
            this.label_Nombre.TabIndex = 2;
            this.label_Nombre.Text = "Producto";
            this.label_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Nombre.Click += new System.EventHandler(this.label_Nombre_Click);
            // 
            // btnBucarProduID
            // 
            this.btnBucarProduID.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBucarProduID.IconColor = System.Drawing.Color.Black;
            this.btnBucarProduID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBucarProduID.IconSize = 18;
            this.btnBucarProduID.Location = new System.Drawing.Point(454, 120);
            this.btnBucarProduID.Margin = new System.Windows.Forms.Padding(4);
            this.btnBucarProduID.Name = "btnBucarProduID";
            this.btnBucarProduID.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnBucarProduID.Size = new System.Drawing.Size(55, 44);
            this.btnBucarProduID.TabIndex = 89;
            this.btnBucarProduID.UseVisualStyleBackColor = true;
            this.btnBucarProduID.Click += new System.EventHandler(this.btnBucarProduID_Click);
            // 
            // label_Numero
            // 
            this.label_Numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label_Numero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Numero.Font = new System.Drawing.Font("Yu Gothic", 14.2F);
            this.label_Numero.ForeColor = System.Drawing.Color.White;
            this.label_Numero.Location = new System.Drawing.Point(23, 125);
            this.label_Numero.Name = "label_Numero";
            this.label_Numero.Size = new System.Drawing.Size(140, 38);
            this.label_Numero.TabIndex = 3;
            this.label_Numero.Text = "ID_producto";
            this.label_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Numero.Click += new System.EventHandler(this.label_Numero_Click);
            // 
            // cbBuscarCategoria
            // 
            this.cbBuscarCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarCategoria.FormattingEnabled = true;
            this.cbBuscarCategoria.Location = new System.Drawing.Point(771, 67);
            this.cbBuscarCategoria.Name = "cbBuscarCategoria";
            this.cbBuscarCategoria.Size = new System.Drawing.Size(207, 35);
            this.cbBuscarCategoria.TabIndex = 91;
            this.cbBuscarCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBuscarCategoria_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 14.2F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(574, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 35);
            this.label3.TabIndex = 92;
            this.label3.Text = "Categoria";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuscarPorCategoria
            // 
            this.BuscarPorCategoria.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.BuscarPorCategoria.IconColor = System.Drawing.Color.Black;
            this.BuscarPorCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BuscarPorCategoria.IconSize = 18;
            this.BuscarPorCategoria.Location = new System.Drawing.Point(1002, 62);
            this.BuscarPorCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarPorCategoria.Name = "BuscarPorCategoria";
            this.BuscarPorCategoria.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.BuscarPorCategoria.Size = new System.Drawing.Size(55, 49);
            this.BuscarPorCategoria.TabIndex = 93;
            this.BuscarPorCategoria.UseVisualStyleBackColor = true;
            this.BuscarPorCategoria.Click += new System.EventHandler(this.BuscarPorCategoria_Click);
            // 
            // btnBuscarSucursal
            // 
            this.btnBuscarSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarSucursal.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarSucursal.IconColor = System.Drawing.Color.Black;
            this.btnBuscarSucursal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarSucursal.IconSize = 18;
            this.btnBuscarSucursal.Location = new System.Drawing.Point(1024, 319);
            this.btnBuscarSucursal.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarSucursal.Name = "btnBuscarSucursal";
            this.btnBuscarSucursal.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.btnBuscarSucursal.Size = new System.Drawing.Size(55, 49);
            this.btnBuscarSucursal.TabIndex = 96;
            this.btnBuscarSucursal.UseVisualStyleBackColor = true;
            this.btnBuscarSucursal.Click += new System.EventHandler(this.btnBuscarSucursal_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 14.2F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(838, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 35);
            this.label6.TabIndex = 95;
            this.label6.Text = "Sucursal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBuscarPorSucursal
            // 
            this.cbBuscarPorSucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscarPorSucursal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBuscarPorSucursal.FormattingEnabled = true;
            this.cbBuscarPorSucursal.Location = new System.Drawing.Point(793, 324);
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
            this.Label_CompraEntrada.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_CompraEntrada.Location = new System.Drawing.Point(419, 0);
            this.Label_CompraEntrada.Name = "Label_CompraEntrada";
            this.Label_CompraEntrada.Size = new System.Drawing.Size(346, 44);
            this.Label_CompraEntrada.TabIndex = 2;
            this.Label_CompraEntrada.Text = "Busqueda Productos";
            // 
            // btn_WF_CerraProductos
            // 
            this.btn_WF_CerraProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_WF_CerraProductos.BackColor = System.Drawing.Color.Black;
            this.btn_WF_CerraProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WF_CerraProductos.FlatAppearance.BorderSize = 0;
            this.btn_WF_CerraProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_CerraProductos.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_CerraProductos.ForeColor = System.Drawing.Color.White;
            this.btn_WF_CerraProductos.Location = new System.Drawing.Point(0, 0);
            this.btn_WF_CerraProductos.Name = "btn_WF_CerraProductos";
            this.btn_WF_CerraProductos.Size = new System.Drawing.Size(51, 44);
            this.btn_WF_CerraProductos.TabIndex = 1;
            this.btn_WF_CerraProductos.Text = "X";
            this.btn_WF_CerraProductos.UseVisualStyleBackColor = false;
            this.btn_WF_CerraProductos.Click += new System.EventHandler(this.btn_WF_CerraProductos_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1099, 657);
            this.Controls.Add(this.Panel_txtProveedor);
            this.Controls.Add(this.btnBuscarSucursal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBuscarPorSucursal);
            this.Controls.Add(this.BuscarPorCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbBuscarCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Numero);
            this.Controls.Add(this.btnBucarProduID);
            this.Controls.Add(this.label_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscarProduNombre);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.txt_IdProducto);
            this.Controls.Add(this.dgvVerProductos);
            this.Controls.Add(this.label4);
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
        private FontAwesome.Sharp.IconButton btnBuscarProduNombre;
        private System.Windows.Forms.Label label_Nombre;
        private FontAwesome.Sharp.IconButton btnBucarProduID;
        private System.Windows.Forms.Label label_Numero;
        private System.Windows.Forms.ComboBox cbBuscarCategoria;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton BuscarPorCategoria;
        private FontAwesome.Sharp.IconButton btnBuscarSucursal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBuscarPorSucursal;
        private System.Windows.Forms.Panel Panel_txtProveedor;
        private System.Windows.Forms.Label Label_CompraEntrada;
        private System.Windows.Forms.Button btn_WF_CerraProductos;
    }
}