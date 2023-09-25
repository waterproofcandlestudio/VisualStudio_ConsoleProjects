
namespace Apartado2_Práctica01_MiguelRodríguezGallego
{
    partial class MenuListarJugadores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDelantero = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbDefensa = new System.Windows.Forms.RadioButton();
            this.rbPortero = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbGolesAnotados = new System.Windows.Forms.TextBox();
            this.tbMinJugados = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNumUniforme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDelantero);
            this.groupBox1.Controls.Add(this.rbMedio);
            this.groupBox1.Controls.Add(this.rbDefensa);
            this.groupBox1.Controls.Add(this.rbPortero);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posición del jugador";
            // 
            // rbDelantero
            // 
            this.rbDelantero.AutoSize = true;
            this.rbDelantero.Location = new System.Drawing.Point(16, 129);
            this.rbDelantero.Name = "rbDelantero";
            this.rbDelantero.Size = new System.Drawing.Size(96, 24);
            this.rbDelantero.TabIndex = 3;
            this.rbDelantero.TabStop = true;
            this.rbDelantero.Text = "Delantero";
            this.rbDelantero.UseVisualStyleBackColor = true;
            this.rbDelantero.CheckedChanged += new System.EventHandler(this.rbDelantero_CheckedChanged);
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Location = new System.Drawing.Point(16, 99);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(73, 24);
            this.rbMedio.TabIndex = 2;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Medio";
            this.rbMedio.UseVisualStyleBackColor = true;
            this.rbMedio.CheckedChanged += new System.EventHandler(this.rbMedio_CheckedChanged);
            // 
            // rbDefensa
            // 
            this.rbDefensa.AutoSize = true;
            this.rbDefensa.Location = new System.Drawing.Point(16, 69);
            this.rbDefensa.Name = "rbDefensa";
            this.rbDefensa.Size = new System.Drawing.Size(84, 24);
            this.rbDefensa.TabIndex = 1;
            this.rbDefensa.TabStop = true;
            this.rbDefensa.Text = "Defensa";
            this.rbDefensa.UseVisualStyleBackColor = true;
            this.rbDefensa.CheckedChanged += new System.EventHandler(this.rbDefensa_CheckedChanged);
            // 
            // rbPortero
            // 
            this.rbPortero.AutoSize = true;
            this.rbPortero.Location = new System.Drawing.Point(16, 39);
            this.rbPortero.Name = "rbPortero";
            this.rbPortero.Size = new System.Drawing.Size(78, 24);
            this.rbPortero.TabIndex = 0;
            this.rbPortero.TabStop = true;
            this.rbPortero.Text = "Portero";
            this.rbPortero.UseVisualStyleBackColor = true;
            this.rbPortero.CheckedChanged += new System.EventHandler(this.rbPortero_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbGolesAnotados);
            this.groupBox2.Controls.Add(this.tbMinJugados);
            this.groupBox2.Controls.Add(this.tbNombre);
            this.groupBox2.Controls.Add(this.tbNumUniforme);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(191, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del jugador";
            // 
            // tbGolesAnotados
            // 
            this.tbGolesAnotados.Location = new System.Drawing.Point(144, 150);
            this.tbGolesAnotados.Name = "tbGolesAnotados";
            this.tbGolesAnotados.Size = new System.Drawing.Size(199, 27);
            this.tbGolesAnotados.TabIndex = 7;
            // 
            // tbMinJugados
            // 
            this.tbMinJugados.Location = new System.Drawing.Point(144, 111);
            this.tbMinJugados.Name = "tbMinJugados";
            this.tbMinJugados.Size = new System.Drawing.Size(199, 27);
            this.tbMinJugados.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(144, 72);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(370, 27);
            this.tbNombre.TabIndex = 5;
            // 
            // tbNumUniforme
            // 
            this.tbNumUniforme.Location = new System.Drawing.Point(144, 33);
            this.tbNumUniforme.Name = "tbNumUniforme";
            this.tbNumUniforme.Size = new System.Drawing.Size(199, 27);
            this.tbNumUniforme.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goles anotados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min. jugados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Núm. uniforme";
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(12, 213);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(341, 121);
            this.btnCapturarDatos.TabIndex = 2;
            this.btnCapturarDatos.Text = "Capturar datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(359, 213);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(352, 121);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 618);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(699, 125);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 340);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.Size = new System.Drawing.Size(699, 272);
            this.dgv.TabIndex = 5;
            // 
            // MenuListarJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 755);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuListarJugadores";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDelantero;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbDefensa;
        private System.Windows.Forms.RadioButton rbPortero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNumUniforme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox tbGolesAnotados;
        private System.Windows.Forms.TextBox tbMinJugados;
        private System.Windows.Forms.DataGridView dgv;
    }
}

