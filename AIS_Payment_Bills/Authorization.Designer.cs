﻿namespace Payment_Bills
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonAcceptEntry = new System.Windows.Forms.Button();
            this.buttonExitProgram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(59, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(158, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 29);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(158, 150);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(163, 29);
            this.textBox2.TabIndex = 4;
            // 
            // buttonAcceptEntry
            // 
            this.buttonAcceptEntry.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonAcceptEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceptEntry.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcceptEntry.Location = new System.Drawing.Point(78, 202);
            this.buttonAcceptEntry.Name = "buttonAcceptEntry";
            this.buttonAcceptEntry.Size = new System.Drawing.Size(105, 35);
            this.buttonAcceptEntry.TabIndex = 5;
            this.buttonAcceptEntry.Text = "Войти";
            this.buttonAcceptEntry.UseVisualStyleBackColor = false;
            this.buttonAcceptEntry.Click += new System.EventHandler(this.buttonAcceptEntry_Click);
            // 
            // buttonExitProgram
            // 
            this.buttonExitProgram.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExitProgram.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExitProgram.Location = new System.Drawing.Point(233, 202);
            this.buttonExitProgram.Name = "buttonExitProgram";
            this.buttonExitProgram.Size = new System.Drawing.Size(105, 35);
            this.buttonExitProgram.TabIndex = 6;
            this.buttonExitProgram.Text = "Выйти";
            this.buttonExitProgram.UseVisualStyleBackColor = false;
            this.buttonExitProgram.Click += new System.EventHandler(this.button2_Click);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonAcceptEntry;
        private System.Windows.Forms.Button buttonExitProgram;
    }
}

