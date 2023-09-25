
namespace CorreccionEj01
{
    partial class FormEj01
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPlayerHealth = new System.Windows.Forms.Label();
            this.lblPlayerDamage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEnemyHealth = new System.Windows.Forms.Label();
            this.lblEnemyDamage = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.RbPlayer = new System.Windows.Forms.RadioButton();
            this.RbEnemy = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPlayerDamage);
            this.groupBox1.Controls.Add(this.lblPlayerHealth);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEnemyDamage);
            this.groupBox2.Controls.Add(this.lblEnemyHealth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lblPlayerHealth
            // 
            this.lblPlayerHealth.AutoSize = true;
            this.lblPlayerHealth.Location = new System.Drawing.Point(113, 49);
            this.lblPlayerHealth.Name = "lblPlayerHealth";
            this.lblPlayerHealth.Size = new System.Drawing.Size(12, 20);
            this.lblPlayerHealth.TabIndex = 0;
            this.lblPlayerHealth.Text = ".";
            this.lblPlayerHealth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayerDamage
            // 
            this.lblPlayerDamage.AutoSize = true;
            this.lblPlayerDamage.Location = new System.Drawing.Point(113, 90);
            this.lblPlayerDamage.Name = "lblPlayerDamage";
            this.lblPlayerDamage.Size = new System.Drawing.Size(12, 20);
            this.lblPlayerDamage.TabIndex = 1;
            this.lblPlayerDamage.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Damage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Health";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Damage";
            // 
            // lblEnemyHealth
            // 
            this.lblEnemyHealth.AutoSize = true;
            this.lblEnemyHealth.Location = new System.Drawing.Point(125, 49);
            this.lblEnemyHealth.Name = "lblEnemyHealth";
            this.lblEnemyHealth.Size = new System.Drawing.Size(12, 20);
            this.lblEnemyHealth.TabIndex = 2;
            this.lblEnemyHealth.Text = ".";
            // 
            // lblEnemyDamage
            // 
            this.lblEnemyDamage.AutoSize = true;
            this.lblEnemyDamage.Location = new System.Drawing.Point(125, 90);
            this.lblEnemyDamage.Name = "lblEnemyDamage";
            this.lblEnemyDamage.Size = new System.Drawing.Size(12, 20);
            this.lblEnemyDamage.TabIndex = 3;
            this.lblEnemyDamage.Text = ".";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(162, 395);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(104, 59);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // RbPlayer
            // 
            this.RbPlayer.AutoSize = true;
            this.RbPlayer.Location = new System.Drawing.Point(179, 299);
            this.RbPlayer.Name = "RbPlayer";
            this.RbPlayer.Size = new System.Drawing.Size(33, 24);
            this.RbPlayer.TabIndex = 3;
            this.RbPlayer.TabStop = true;
            this.RbPlayer.Text = ".";
            this.RbPlayer.UseVisualStyleBackColor = true;
            // 
            // RbEnemy
            // 
            this.RbEnemy.AutoSize = true;
            this.RbEnemy.Location = new System.Drawing.Point(179, 339);
            this.RbEnemy.Name = "RbEnemy";
            this.RbEnemy.Size = new System.Drawing.Size(33, 24);
            this.RbEnemy.TabIndex = 4;
            this.RbEnemy.TabStop = true;
            this.RbEnemy.Text = ".";
            this.RbEnemy.UseVisualStyleBackColor = true;
            // 
            // FormEj01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 488);
            this.Controls.Add(this.RbEnemy);
            this.Controls.Add(this.RbPlayer);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEj01";
            this.Text = "Ejercicio01";
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerDamage;
        private System.Windows.Forms.Label lblEnemyDamage;
        private System.Windows.Forms.Label lblEnemyHealth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RadioButton RbPlayer;
        private System.Windows.Forms.RadioButton RbEnemy;
    }
}

