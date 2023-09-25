
namespace Práctica01_MiguelRodríguezGallego
{
    partial class MenuCoordenadas
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.btnCaptCord = new System.Windows.Forms.Button();
            this.btnCalDist = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(15, 33);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(104, 20);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "Coordenada X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(16, 79);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(103, 20);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Coordenada Y";
            // 
            // btnCaptCord
            // 
            this.btnCaptCord.Location = new System.Drawing.Point(295, 26);
            this.btnCaptCord.Name = "btnCaptCord";
            this.btnCaptCord.Size = new System.Drawing.Size(135, 65);
            this.btnCaptCord.TabIndex = 2;
            this.btnCaptCord.Text = "Capturar coordenadas";
            this.btnCaptCord.UseVisualStyleBackColor = true;
            this.btnCaptCord.Click += new System.EventHandler(this.btnCapturarCoordenadas_Click);
            // 
            // btnCalDist
            // 
            this.btnCalDist.Location = new System.Drawing.Point(295, 121);
            this.btnCalDist.Name = "btnCalDist";
            this.btnCalDist.Size = new System.Drawing.Size(135, 65);
            this.btnCalDist.TabIndex = 3;
            this.btnCalDist.Text = "Calcular distancia";
            this.btnCalDist.UseVisualStyleBackColor = true;
            this.btnCalDist.Click += new System.EventHandler(this.btnCalDist_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(295, 219);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 57);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(58, 40);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(33, 24);
            this.rb1.TabIndex = 5;
            this.rb1.TabStop = true;
            this.rb1.Text = ".";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(58, 80);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(33, 24);
            this.rb2.TabIndex = 6;
            this.rb2.TabStop = true;
            this.rb2.Text = ".";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbY);
            this.groupBox1.Controls.Add(this.tbX);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas del punto";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(125, 79);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(108, 27);
            this.tbY.TabIndex = 3;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(125, 33);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(108, 27);
            this.tbX.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb1);
            this.groupBox2.Controls.Add(this.rb2);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccione un punto";
            // 
            // MenuCoordenadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 290);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalDist);
            this.Controls.Add(this.btnCaptCord);
            this.Name = "MenuCoordenadas";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Button btnCaptCord;
        private System.Windows.Forms.Button btnCalDist;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

