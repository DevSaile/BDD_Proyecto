namespace Variedades_Man_s_Style
{
    partial class VentaInformacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvVerCoincidencias = new System.Windows.Forms.DataGridView();
            this.txt_BuscarProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SeleccionarProducto = new System.Windows.Forms.Button();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.cbElegirBusqueda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCoincidencias)).BeginInit();
            this.SuspendLayout();
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
            this.label5.Location = new System.Drawing.Point(63, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(724, 46);
            this.label5.TabIndex = 106;
            this.label5.Text = "Coincidencias";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvVerCoincidencias
            // 
            this.dgvVerCoincidencias.AllowUserToAddRows = false;
            this.dgvVerCoincidencias.AllowUserToDeleteRows = false;
            this.dgvVerCoincidencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVerCoincidencias.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvVerCoincidencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvVerCoincidencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVerCoincidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVerCoincidencias.ColumnHeadersHeight = 30;
            this.dgvVerCoincidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVerCoincidencias.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVerCoincidencias.EnableHeadersVisualStyles = false;
            this.dgvVerCoincidencias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvVerCoincidencias.Location = new System.Drawing.Point(63, 155);
            this.dgvVerCoincidencias.MultiSelect = false;
            this.dgvVerCoincidencias.Name = "dgvVerCoincidencias";
            this.dgvVerCoincidencias.ReadOnly = true;
            this.dgvVerCoincidencias.RowHeadersVisible = false;
            this.dgvVerCoincidencias.RowHeadersWidth = 51;
            this.dgvVerCoincidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerCoincidencias.Size = new System.Drawing.Size(724, 350);
            this.dgvVerCoincidencias.TabIndex = 107;
            // 
            // txt_BuscarProducto
            // 
            this.txt_BuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_BuscarProducto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_BuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BuscarProducto.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.txt_BuscarProducto.Location = new System.Drawing.Point(264, 42);
            this.txt_BuscarProducto.Multiline = true;
            this.txt_BuscarProducto.Name = "txt_BuscarProducto";
            this.txt_BuscarProducto.Size = new System.Drawing.Size(329, 34);
            this.txt_BuscarProducto.TabIndex = 109;
            this.txt_BuscarProducto.TextChanged += new System.EventHandler(this.txt_BuscarProducto_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(263, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(330, 5);
            this.label4.TabIndex = 110;
            // 
            // btn_SeleccionarProducto
            // 
            this.btn_SeleccionarProducto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_SeleccionarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SeleccionarProducto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SeleccionarProducto.FlatAppearance.BorderSize = 2;
            this.btn_SeleccionarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_SeleccionarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SeleccionarProducto.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SeleccionarProducto.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_SeleccionarProducto.Location = new System.Drawing.Point(609, 41);
            this.btn_SeleccionarProducto.Name = "btn_SeleccionarProducto";
            this.btn_SeleccionarProducto.Size = new System.Drawing.Size(178, 46);
            this.btn_SeleccionarProducto.TabIndex = 111;
            this.btn_SeleccionarProducto.Text = "Seleccionar";
            this.btn_SeleccionarProducto.UseVisualStyleBackColor = false;
            this.btn_SeleccionarProducto.Click += new System.EventHandler(this.btn_SeleccionarProducto_Click);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // cbElegirBusqueda
            // 
            this.cbElegirBusqueda.FormattingEnabled = true;
            this.cbElegirBusqueda.Location = new System.Drawing.Point(63, 52);
            this.cbElegirBusqueda.Name = "cbElegirBusqueda";
            this.cbElegirBusqueda.Size = new System.Drawing.Size(184, 24);
            this.cbElegirBusqueda.TabIndex = 112;
            this.cbElegirBusqueda.SelectedIndexChanged += new System.EventHandler(this.cbElegirBusqueda_SelectedIndexChanged);
            // 
            // VentaInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 554);
            this.Controls.Add(this.cbElegirBusqueda);
            this.Controls.Add(this.btn_SeleccionarProducto);
            this.Controls.Add(this.txt_BuscarProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvVerCoincidencias);
            this.Name = "VentaInformacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarProductoExistente";
            this.Load += new System.EventHandler(this.BuscarProductoExistente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerCoincidencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvVerCoincidencias;
        private System.Windows.Forms.TextBox txt_BuscarProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_SeleccionarProducto;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.ComboBox cbElegirBusqueda;
    }
}