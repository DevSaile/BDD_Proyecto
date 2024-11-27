namespace Variedades_Man_s_Style
{
    partial class Categoria
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
            this.Label_Proveedores = new System.Windows.Forms.Label();
            this.btn_WF_CerrarCategoria = new System.Windows.Forms.Button();
            this.Panel_WF_Controles_Proveedor = new System.Windows.Forms.Panel();
            this.btn_WF_Actualizar = new System.Windows.Forms.Button();
            this.btn_WF_Agregar = new System.Windows.Forms.Button();
            this.btn_WF_Desactivar = new System.Windows.Forms.Button();
            this.panel_dgvCategoria = new System.Windows.Forms.Panel();
            this.dgvVerCategorias = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreCategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_txtProveedor.SuspendLayout();
            this.Panel_WF_Controles_Proveedor.SuspendLayout();
            this.panel_dgvCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_txtProveedor
            // 
            this.Panel_txtProveedor.BackColor = System.Drawing.Color.Black;
            this.Panel_txtProveedor.Controls.Add(this.Label_Proveedores);
            this.Panel_txtProveedor.Controls.Add(this.btn_WF_CerrarCategoria);
            this.Panel_txtProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_txtProveedor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_txtProveedor.Location = new System.Drawing.Point(0, 0);
            this.Panel_txtProveedor.Name = "Panel_txtProveedor";
            this.Panel_txtProveedor.Size = new System.Drawing.Size(906, 44);
            this.Panel_txtProveedor.TabIndex = 5;
            // 
            // Label_Proveedores
            // 
            this.Label_Proveedores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_Proveedores.ForeColor = System.Drawing.SystemColors.Window;
            this.Label_Proveedores.Location = new System.Drawing.Point(245, 0);
            this.Label_Proveedores.Name = "Label_Proveedores";
            this.Label_Proveedores.Size = new System.Drawing.Size(436, 44);
            this.Label_Proveedores.TabIndex = 2;
            this.Label_Proveedores.Text = "Administrar Categorias";
            this.Label_Proveedores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_WF_CerrarCategoria
            // 
            this.btn_WF_CerrarCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_WF_CerrarCategoria.BackColor = System.Drawing.Color.Black;
            this.btn_WF_CerrarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_WF_CerrarCategoria.FlatAppearance.BorderSize = 0;
            this.btn_WF_CerrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_CerrarCategoria.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_CerrarCategoria.ForeColor = System.Drawing.Color.White;
            this.btn_WF_CerrarCategoria.Location = new System.Drawing.Point(1, 0);
            this.btn_WF_CerrarCategoria.Name = "btn_WF_CerrarCategoria";
            this.btn_WF_CerrarCategoria.Size = new System.Drawing.Size(51, 44);
            this.btn_WF_CerrarCategoria.TabIndex = 1;
            this.btn_WF_CerrarCategoria.Text = "X";
            this.btn_WF_CerrarCategoria.UseVisualStyleBackColor = false;
            this.btn_WF_CerrarCategoria.Click += new System.EventHandler(this.btn_WF_CerrarCategoria_Click);
            // 
            // Panel_WF_Controles_Proveedor
            // 
            this.Panel_WF_Controles_Proveedor.BackColor = System.Drawing.SystemColors.Control;
            this.Panel_WF_Controles_Proveedor.Controls.Add(this.btn_WF_Actualizar);
            this.Panel_WF_Controles_Proveedor.Controls.Add(this.btn_WF_Agregar);
            this.Panel_WF_Controles_Proveedor.Controls.Add(this.btn_WF_Desactivar);
            this.Panel_WF_Controles_Proveedor.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_WF_Controles_Proveedor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_WF_Controles_Proveedor.Location = new System.Drawing.Point(657, 44);
            this.Panel_WF_Controles_Proveedor.Name = "Panel_WF_Controles_Proveedor";
            this.Panel_WF_Controles_Proveedor.Size = new System.Drawing.Size(249, 474);
            this.Panel_WF_Controles_Proveedor.TabIndex = 10;
            this.Panel_WF_Controles_Proveedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_WF_Controles_Proveedor_Paint);
            // 
            // btn_WF_Actualizar
            // 
            this.btn_WF_Actualizar.BackColor = System.Drawing.Color.Navy;
            this.btn_WF_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WF_Actualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_WF_Actualizar.FlatAppearance.BorderSize = 2;
            this.btn_WF_Actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_WF_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_Actualizar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_Actualizar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_WF_Actualizar.Location = new System.Drawing.Point(45, 228);
            this.btn_WF_Actualizar.Name = "btn_WF_Actualizar";
            this.btn_WF_Actualizar.Size = new System.Drawing.Size(160, 46);
            this.btn_WF_Actualizar.TabIndex = 6;
            this.btn_WF_Actualizar.Text = "Actualizar";
            this.btn_WF_Actualizar.UseVisualStyleBackColor = false;
            this.btn_WF_Actualizar.Click += new System.EventHandler(this.btn_WF_Actualizar_Click);
            // 
            // btn_WF_Agregar
            // 
            this.btn_WF_Agregar.BackColor = System.Drawing.Color.Navy;
            this.btn_WF_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WF_Agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_WF_Agregar.FlatAppearance.BorderSize = 2;
            this.btn_WF_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_WF_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_Agregar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_Agregar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_WF_Agregar.Location = new System.Drawing.Point(45, 310);
            this.btn_WF_Agregar.Name = "btn_WF_Agregar";
            this.btn_WF_Agregar.Size = new System.Drawing.Size(160, 46);
            this.btn_WF_Agregar.TabIndex = 7;
            this.btn_WF_Agregar.Text = "Agregar";
            this.btn_WF_Agregar.UseVisualStyleBackColor = false;
            this.btn_WF_Agregar.Click += new System.EventHandler(this.btn_WF_Agregar_Click);
            // 
            // btn_WF_Desactivar
            // 
            this.btn_WF_Desactivar.BackColor = System.Drawing.Color.Navy;
            this.btn_WF_Desactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_WF_Desactivar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_WF_Desactivar.FlatAppearance.BorderSize = 2;
            this.btn_WF_Desactivar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_WF_Desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_WF_Desactivar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_WF_Desactivar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_WF_Desactivar.Location = new System.Drawing.Point(45, 145);
            this.btn_WF_Desactivar.Name = "btn_WF_Desactivar";
            this.btn_WF_Desactivar.Size = new System.Drawing.Size(160, 46);
            this.btn_WF_Desactivar.TabIndex = 5;
            this.btn_WF_Desactivar.Text = "Eliminar";
            this.btn_WF_Desactivar.UseVisualStyleBackColor = false;
            this.btn_WF_Desactivar.Click += new System.EventHandler(this.btn_WF_Desactivar_Click);
            // 
            // panel_dgvCategoria
            // 
            this.panel_dgvCategoria.Controls.Add(this.dgvVerCategorias);
            this.panel_dgvCategoria.Controls.Add(this.label3);
            this.panel_dgvCategoria.Controls.Add(this.btnCategorias);
            this.panel_dgvCategoria.Controls.Add(this.label2);
            this.panel_dgvCategoria.Controls.Add(this.txt_NombreCategoria);
            this.panel_dgvCategoria.Controls.Add(this.label1);
            this.panel_dgvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_dgvCategoria.Location = new System.Drawing.Point(0, 44);
            this.panel_dgvCategoria.Name = "panel_dgvCategoria";
            this.panel_dgvCategoria.Size = new System.Drawing.Size(657, 474);
            this.panel_dgvCategoria.TabIndex = 11;
            this.panel_dgvCategoria.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_dgvCategoria_Paint);
            // 
            // dgvVerCategorias
            // 
            this.dgvVerCategorias.AllowUserToAddRows = false;
            this.dgvVerCategorias.AllowUserToDeleteRows = false;
            this.dgvVerCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvVerCategorias.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvVerCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvVerCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVerCategorias.ColumnHeadersHeight = 30;
            this.dgvVerCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerCategorias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVerCategorias.EnableHeadersVisualStyles = false;
            this.dgvVerCategorias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVerCategorias.Location = new System.Drawing.Point(52, 99);
            this.dgvVerCategorias.MultiSelect = false;
            this.dgvVerCategorias.Name = "dgvVerCategorias";
            this.dgvVerCategorias.ReadOnly = true;
            this.dgvVerCategorias.RowHeadersVisible = false;
            this.dgvVerCategorias.RowHeadersWidth = 51;
            this.dgvVerCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerCategorias.Size = new System.Drawing.Size(521, 360);
            this.dgvVerCategorias.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "Buscar:";
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Image = global::Variedades_Man_s_Style.Properties.Resources.search__1_;
            this.btnCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.Location = new System.Drawing.Point(517, 31);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(59, 49);
            this.btnCategorias.TabIndex = 8;
            this.btnCategorias.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(149, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 5);
            this.label2.TabIndex = 18;
            // 
            // txt_NombreCategoria
            // 
            this.txt_NombreCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.txt_NombreCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NombreCategoria.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreCategoria.Location = new System.Drawing.Point(149, 46);
            this.txt_NombreCategoria.Multiline = true;
            this.txt_NombreCategoria.Name = "txt_NombreCategoria";
            this.txt_NombreCategoria.Size = new System.Drawing.Size(361, 34);
            this.txt_NombreCategoria.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(650, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 474);
            this.label1.TabIndex = 1;
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 518);
            this.Controls.Add(this.panel_dgvCategoria);
            this.Controls.Add(this.Panel_WF_Controles_Proveedor);
            this.Controls.Add(this.Panel_txtProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.Panel_txtProveedor.ResumeLayout(false);
            this.Panel_WF_Controles_Proveedor.ResumeLayout(false);
            this.panel_dgvCategoria.ResumeLayout(false);
            this.panel_dgvCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_txtProveedor;
        private System.Windows.Forms.Label Label_Proveedores;
        private System.Windows.Forms.Button btn_WF_CerrarCategoria;
        private System.Windows.Forms.Panel Panel_WF_Controles_Proveedor;
        private System.Windows.Forms.Button btn_WF_Actualizar;
        private System.Windows.Forms.Button btn_WF_Agregar;
        private System.Windows.Forms.Button btn_WF_Desactivar;
        private System.Windows.Forms.Panel panel_dgvCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreCategoria;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvVerCategorias;
    }
}