
namespace Apartado2_Práctica01_MiguelRodríguezGallego
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMostrarPosicion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMostrarGolAnot = new System.Windows.Forms.Label();
            this.lblMostrarMinJug = new System.Windows.Forms.Label();
            this.lblMostrarNombre = new System.Windows.Forms.Label();
            this.lblMostrarNumUnif = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox2.Size = new System.Drawing.Size(367, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del jugador";
            // 
            // tbGolesAnotados
            // 
            this.tbGolesAnotados.Location = new System.Drawing.Point(144, 150);
            this.tbGolesAnotados.Name = "tbGolesAnotados";
            this.tbGolesAnotados.Size = new System.Drawing.Size(64, 27);
            this.tbGolesAnotados.TabIndex = 7;
            // 
            // tbMinJugados
            // 
            this.tbMinJugados.Location = new System.Drawing.Point(144, 111);
            this.tbMinJugados.Name = "tbMinJugados";
            this.tbMinJugados.Size = new System.Drawing.Size(64, 27);
            this.tbMinJugados.TabIndex = 6;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(144, 72);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(217, 27);
            this.tbNombre.TabIndex = 5;
            // 
            // tbNumUniforme
            // 
            this.tbNumUniforme.Location = new System.Drawing.Point(144, 33);
            this.tbNumUniforme.Name = "tbNumUniforme";
            this.tbNumUniforme.Size = new System.Drawing.Size(64, 27);
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
            this.btnCapturarDatos.Location = new System.Drawing.Point(12, 214);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(173, 43);
            this.btnCapturarDatos.TabIndex = 2;
            this.btnCapturarDatos.Text = "Capturar datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(12, 274);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(173, 43);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 335);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(173, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMostrarPosicion);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.lblMostrarGolAnot);
            this.groupBox3.Controls.Add(this.lblMostrarMinJug);
            this.groupBox3.Controls.Add(this.lblMostrarNombre);
            this.groupBox3.Controls.Add(this.lblMostrarNumUnif);
            this.groupBox3.Location = new System.Drawing.Point(192, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 193);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar Datos";
            // 
            // lblMostrarPosicion
            // 
            this.lblMostrarPosicion.AutoSize = true;
            this.lblMostrarPosicion.Location = new System.Drawing.Point(127, 31);
            this.lblMostrarPosicion.Name = "lblMostrarPosicion";
            this.lblMostrarPosicion.Size = new System.Drawing.Size(12, 20);
            this.lblMostrarPosicion.TabIndex = 10;
            this.lblMostrarPosicion.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Posición";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Goles anotados";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 131);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Min. jugados";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Núm. uniforme";
            // 
            // lblMostrarGolAnot
            // 
            this.lblMostrarGolAnot.AutoSize = true;
            this.lblMostrarGolAnot.Location = new System.Drawing.Point(129, 165);
            this.lblMostrarGolAnot.Name = "lblMostrarGolAnot";
            this.lblMostrarGolAnot.Size = new System.Drawing.Size(12, 20);
            this.lblMostrarGolAnot.TabIndex = 3;
            this.lblMostrarGolAnot.Text = ".";
            // 
            // lblMostrarMinJug
            // 
            this.lblMostrarMinJug.AutoSize = true;
            this.lblMostrarMinJug.Location = new System.Drawing.Point(129, 131);
            this.lblMostrarMinJug.Name = "lblMostrarMinJug";
            this.lblMostrarMinJug.Size = new System.Drawing.Size(12, 20);
            this.lblMostrarMinJug.TabIndex = 2;
            this.lblMostrarMinJug.Text = ".";
            // 
            // lblMostrarNombre
            // 
            this.lblMostrarNombre.AutoSize = true;
            this.lblMostrarNombre.Location = new System.Drawing.Point(129, 95);
            this.lblMostrarNombre.Name = "lblMostrarNombre";
            this.lblMostrarNombre.Size = new System.Drawing.Size(12, 20);
            this.lblMostrarNombre.TabIndex = 1;
            this.lblMostrarNombre.Text = ".";
            // 
            // lblMostrarNumUnif
            // 
            this.lblMostrarNumUnif.AutoSize = true;
            this.lblMostrarNumUnif.Location = new System.Drawing.Point(129, 63);
            this.lblMostrarNumUnif.Name = "lblMostrarNumUnif";
            this.lblMostrarNumUnif.Size = new System.Drawing.Size(12, 20);
            this.lblMostrarNumUnif.TabIndex = 0;
            this.lblMostrarNumUnif.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblMostrarGolAnot;
        private System.Windows.Forms.Label lblMostrarMinJug;
        private System.Windows.Forms.Label lblMostrarNombre;
        private System.Windows.Forms.Label lblMostrarNumUnif;
        private System.Windows.Forms.Label lblMostrarPosicion;
        private System.Windows.Forms.Label label5;
    }
}

