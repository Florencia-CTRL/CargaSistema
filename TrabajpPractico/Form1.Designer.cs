
namespace TrabajpPractico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridArticulos = new System.Windows.Forms.DataGridView();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.desplegableCategoria = new System.Windows.Forms.ComboBox();
            this.desplegablaMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValorPrecio = new System.Windows.Forms.Label();
            this.ValorDescripcion = new System.Windows.Forms.Label();
            this.ValorMarca = new System.Windows.Forms.Label();
            this.ValorNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CajaDeImagen = new System.Windows.Forms.PictureBox();
            this.BotonRESTABLECER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CajaDeImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridArticulos
            // 
            this.dataGridArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticulos.Location = new System.Drawing.Point(63, 337);
            this.dataGridArticulos.Name = "dataGridArticulos";
            this.dataGridArticulos.Size = new System.Drawing.Size(697, 296);
            this.dataGridArticulos.TabIndex = 0;
            this.dataGridArticulos.SelectionChanged += new System.EventHandler(this.dataGridArticulos_SelectionChanged);
            // 
            // botonAgregar
            // 
            this.botonAgregar.BackColor = System.Drawing.Color.DimGray;
            this.botonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonAgregar.Location = new System.Drawing.Point(786, 380);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(255, 35);
            this.botonAgregar.TabIndex = 1;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = false;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // botonModificar
            // 
            this.botonModificar.BackColor = System.Drawing.Color.DimGray;
            this.botonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonModificar.Location = new System.Drawing.Point(786, 421);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(255, 32);
            this.botonModificar.TabIndex = 2;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = false;
            this.botonModificar.Click += new System.EventHandler(this.botonModificar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.DimGray;
            this.botonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEliminar.Location = new System.Drawing.Point(786, 459);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(255, 35);
            this.botonEliminar.TabIndex = 3;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.botonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.botonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscar.Location = new System.Drawing.Point(857, 169);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(129, 29);
            this.botonBuscar.TabIndex = 4;
            this.botonBuscar.Text = "BUSCAR";
            this.botonBuscar.UseVisualStyleBackColor = false;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // desplegableCategoria
            // 
            this.desplegableCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desplegableCategoria.FormattingEnabled = true;
            this.desplegableCategoria.Location = new System.Drawing.Point(835, 74);
            this.desplegableCategoria.Name = "desplegableCategoria";
            this.desplegableCategoria.Size = new System.Drawing.Size(169, 21);
            this.desplegableCategoria.TabIndex = 5;
            // 
            // desplegablaMarca
            // 
            this.desplegablaMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desplegablaMarca.FormattingEnabled = true;
            this.desplegablaMarca.Location = new System.Drawing.Point(835, 122);
            this.desplegablaMarca.Name = "desplegablaMarca";
            this.desplegablaMarca.Size = new System.Drawing.Size(169, 21);
            this.desplegablaMarca.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(832, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Categoria";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ValorPrecio);
            this.groupBox1.Controls.Add(this.ValorDescripcion);
            this.groupBox1.Controls.Add(this.ValorMarca);
            this.groupBox1.Controls.Add(this.ValorNombre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CajaDeImagen);
            this.groupBox1.Location = new System.Drawing.Point(41, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 240);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ValorPrecio
            // 
            this.ValorPrecio.AutoSize = true;
            this.ValorPrecio.Location = new System.Drawing.Point(377, 126);
            this.ValorPrecio.Name = "ValorPrecio";
            this.ValorPrecio.Size = new System.Drawing.Size(41, 13);
            this.ValorPrecio.TabIndex = 8;
            this.ValorPrecio.Text = "label10";
            // 
            // ValorDescripcion
            // 
            this.ValorDescripcion.Location = new System.Drawing.Point(377, 163);
            this.ValorDescripcion.Name = "ValorDescripcion";
            this.ValorDescripcion.Size = new System.Drawing.Size(273, 40);
            this.ValorDescripcion.TabIndex = 7;
            this.ValorDescripcion.Text = "label9";
            // 
            // ValorMarca
            // 
            this.ValorMarca.AutoSize = true;
            this.ValorMarca.Location = new System.Drawing.Point(377, 96);
            this.ValorMarca.Name = "ValorMarca";
            this.ValorMarca.Size = new System.Drawing.Size(35, 13);
            this.ValorMarca.TabIndex = 6;
            this.ValorMarca.Text = "label8";
            // 
            // ValorNombre
            // 
            this.ValorNombre.AutoSize = true;
            this.ValorNombre.Location = new System.Drawing.Point(377, 57);
            this.ValorNombre.Name = "ValorNombre";
            this.ValorNombre.Size = new System.Drawing.Size(35, 13);
            this.ValorNombre.TabIndex = 5;
            this.ValorNombre.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "PRECIO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "DESCRIPCION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "MARCA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NOMBRE:";
            // 
            // CajaDeImagen
            // 
            this.CajaDeImagen.Location = new System.Drawing.Point(43, 40);
            this.CajaDeImagen.Name = "CajaDeImagen";
            this.CajaDeImagen.Size = new System.Drawing.Size(174, 163);
            this.CajaDeImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CajaDeImagen.TabIndex = 0;
            this.CajaDeImagen.TabStop = false;
            // 
            // BotonRESTABLECER
            // 
            this.BotonRESTABLECER.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BotonRESTABLECER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BotonRESTABLECER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonRESTABLECER.Location = new System.Drawing.Point(867, 216);
            this.BotonRESTABLECER.Name = "BotonRESTABLECER";
            this.BotonRESTABLECER.Size = new System.Drawing.Size(110, 21);
            this.BotonRESTABLECER.TabIndex = 10;
            this.BotonRESTABLECER.Text = "Reestablecer";
            this.BotonRESTABLECER.UseVisualStyleBackColor = false;
            this.BotonRESTABLECER.Click += new System.EventHandler(this.BotonRESTABLECER_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1096, 696);
            this.Controls.Add(this.BotonRESTABLECER);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desplegablaMarca);
            this.Controls.Add(this.desplegableCategoria);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.dataGridArticulos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CajaDeImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridArticulos;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.ComboBox desplegableCategoria;
        private System.Windows.Forms.ComboBox desplegablaMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox CajaDeImagen;
        private System.Windows.Forms.Label ValorPrecio;
        private System.Windows.Forms.Label ValorDescripcion;
        private System.Windows.Forms.Label ValorMarca;
        private System.Windows.Forms.Label ValorNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BotonRESTABLECER;
    }
}

