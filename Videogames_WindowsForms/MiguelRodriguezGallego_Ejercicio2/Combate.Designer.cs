
namespace MiguelRodriguezGallego_Ejercicio2
{
    partial class Combate
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
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTipoDeEnemigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblEnemyName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbAtaque1 = new System.Windows.Forms.RadioButton();
            this.rbAtaque2 = new System.Windows.Forms.RadioButton();
            this.rbAtaque3 = new System.Windows.Forms.RadioButton();
            this.rbAtaque4 = new System.Windows.Forms.RadioButton();
            this.btnAttack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPlayerHealth);
            this.groupBox1.Controls.Add(this.lblPlayerName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(112, 65);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(12, 20);
            this.lblPlayerHealth.TabIndex = 3;
            this.lblPlayerHealth.Text = ".";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(112, 37);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(12, 20);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Health";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTipoDeEnemigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblEnemyHealth);
            this.groupBox2.Controls.Add(this.lblEnemyName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enemy";
            // 
            // lblTipoDeEnemigo
            // 
            this.lblTipoDeEnemigo.AutoSize = true;
            this.lblTipoDeEnemigo.Location = new System.Drawing.Point(83, 96);
            this.lblTipoDeEnemigo.Name = "lblTipoDeEnemigo";
            this.lblTipoDeEnemigo.Size = new System.Drawing.Size(12, 20);
            this.lblTipoDeEnemigo.TabIndex = 5;
            this.lblTipoDeEnemigo.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Location = new System.Drawing.Point(83, 65);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(12, 20);
            this.lblEnemyHealth.TabIndex = 3;
            this.lblEnemyHealth.Text = ".";
            // 
            // lblEnemyName
            // 
            this.lblEnemyName.AutoSize = true;
            this.lblEnemyName.Location = new System.Drawing.Point(84, 41);
            this.lblEnemyName.Name = "lblEnemyName";
            this.lblEnemyName.Size = new System.Drawing.Size(12, 20);
            this.lblEnemyName.TabIndex = 2;
            this.lblEnemyName.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Health";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // rbAtaque1
            // 
            this.rbAtaque1.AutoSize = true;
            this.rbAtaque1.Location = new System.Drawing.Point(29, 143);
            this.rbAtaque1.Name = "rbAtaque1";
            this.rbAtaque1.Size = new System.Drawing.Size(80, 24);
            this.rbAtaque1.TabIndex = 2;
            this.rbAtaque1.TabStop = true;
            this.rbAtaque1.Text = "Normal";
            this.rbAtaque1.UseVisualStyleBackColor = true;
            // 
            // rbAtaque2
            // 
            this.rbAtaque2.AutoSize = true;
            this.rbAtaque2.Location = new System.Drawing.Point(141, 143);
            this.rbAtaque2.Name = "rbAtaque2";
            this.rbAtaque2.Size = new System.Drawing.Size(71, 24);
            this.rbAtaque2.TabIndex = 3;
            this.rbAtaque2.TabStop = true;
            this.rbAtaque2.Text = "Fuego";
            this.rbAtaque2.UseVisualStyleBackColor = true;
            // 
            // rbAtaque3
            // 
            this.rbAtaque3.AutoSize = true;
            this.rbAtaque3.Location = new System.Drawing.Point(29, 188);
            this.rbAtaque3.Name = "rbAtaque3";
            this.rbAtaque3.Size = new System.Drawing.Size(65, 24);
            this.rbAtaque3.TabIndex = 4;
            this.rbAtaque3.TabStop = true;
            this.rbAtaque3.Text = "Agua";
            this.rbAtaque3.UseVisualStyleBackColor = true;
            // 
            // rbAtaque4
            // 
            this.rbAtaque4.AutoSize = true;
            this.rbAtaque4.Location = new System.Drawing.Point(141, 188);
            this.rbAtaque4.Name = "rbAtaque4";
            this.rbAtaque4.Size = new System.Drawing.Size(71, 24);
            this.rbAtaque4.TabIndex = 5;
            this.rbAtaque4.TabStop = true;
            this.rbAtaque4.Text = "Planta";
            this.rbAtaque4.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(50, 231);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(109, 56);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "Atack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 301);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.rbAtaque4);
            this.Controls.Add(this.rbAtaque3);
            this.Controls.Add(this.rbAtaque2);
            this.Controls.Add(this.rbAtaque1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPlayerHealth;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.Label lblEnemyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbAtaque1;
        private System.Windows.Forms.RadioButton rbAtaque2;
        private System.Windows.Forms.RadioButton rbAtaque3;
        private System.Windows.Forms.RadioButton rbAtaque4;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblTipoDeEnemigo;
        private System.Windows.Forms.Label label5;
    }
}

