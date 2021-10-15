namespace Calculator
{
	partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBKS = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnsign = new System.Windows.Forms.Button();
            this.btnSQRT = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpoint = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btninvers = new System.Windows.Forms.Button();
            this.btnminus = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btneq = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.programmerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.scientificToolStripMenuItem.Text = "Scientific";
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmerToolStripMenuItem.Text = "Programmer";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(85, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBKS
            // 
            this.btnBKS.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnBKS.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBKS.Location = new System.Drawing.Point(25, 103);
            this.btnBKS.Name = "btnBKS";
            this.btnBKS.Size = new System.Drawing.Size(42, 36);
            this.btnBKS.TabIndex = 2;
            this.btnBKS.Text = "<-";
            this.btnBKS.UseVisualStyleBackColor = false;
            this.btnBKS.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCE.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(71, 103);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(42, 36);
            this.btnCE.TabIndex = 3;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnC.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(117, 103);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(42, 36);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnsign
            // 
            this.btnsign.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnsign.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsign.Location = new System.Drawing.Point(163, 103);
            this.btnsign.Name = "btnsign";
            this.btnsign.Size = new System.Drawing.Size(42, 36);
            this.btnsign.TabIndex = 5;
            this.btnsign.Text = "+/-";
            this.btnsign.UseVisualStyleBackColor = false;
            // 
            // btnSQRT
            // 
            this.btnSQRT.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSQRT.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSQRT.Location = new System.Drawing.Point(209, 103);
            this.btnSQRT.Name = "btnSQRT";
            this.btnSQRT.Size = new System.Drawing.Size(42, 36);
            this.btnSQRT.TabIndex = 6;
            this.btnSQRT.Text = "SQRT";
            this.btnSQRT.UseVisualStyleBackColor = false;
            this.btnSQRT.Click += new System.EventHandler(this.btnSQRT_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(25, 135);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(42, 42);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn8.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(71, 135);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(42, 42);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(117, 135);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(42, 42);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(117, 171);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(42, 42);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(71, 171);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(42, 42);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(25, 171);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(42, 42);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(117, 208);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(42, 42);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(71, 208);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(42, 42);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(25, 208);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(42, 42);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn0.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(25, 245);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(88, 42);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnpoint
            // 
            this.btnpoint.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnpoint.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoint.Location = new System.Drawing.Point(117, 245);
            this.btnpoint.Name = "btnpoint";
            this.btnpoint.Size = new System.Drawing.Size(42, 42);
            this.btnpoint.TabIndex = 17;
            this.btnpoint.Text = ".";
            this.btnpoint.UseVisualStyleBackColor = false;
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btndivide.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivide.Location = new System.Drawing.Point(163, 135);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(42, 42);
            this.btndivide.TabIndex = 18;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = false;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnmod.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.Location = new System.Drawing.Point(209, 135);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(42, 42);
            this.btnmod.TabIndex = 19;
            this.btnmod.Text = "%";
            this.btnmod.UseVisualStyleBackColor = false;
            this.btnmod.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnmultiply.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiply.Location = new System.Drawing.Point(163, 172);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(42, 42);
            this.btnmultiply.TabIndex = 20;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = false;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btninvers
            // 
            this.btninvers.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btninvers.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvers.Location = new System.Drawing.Point(209, 172);
            this.btninvers.Name = "btninvers";
            this.btninvers.Size = new System.Drawing.Size(42, 42);
            this.btninvers.TabIndex = 21;
            this.btninvers.Text = "1/x";
            this.btninvers.UseVisualStyleBackColor = false;
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnminus.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminus.Location = new System.Drawing.Point(163, 208);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(42, 42);
            this.btnminus.TabIndex = 22;
            this.btnminus.Text = "-";
            this.btnminus.UseVisualStyleBackColor = false;
            this.btnminus.Click += new System.EventHandler(this.btnminus_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnplus.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplus.Location = new System.Drawing.Point(163, 245);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(42, 42);
            this.btnplus.TabIndex = 23;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btneq
            // 
            this.btneq.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btneq.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneq.Location = new System.Drawing.Point(209, 209);
            this.btneq.Name = "btneq";
            this.btneq.Size = new System.Drawing.Size(42, 78);
            this.btneq.TabIndex = 24;
            this.btneq.Text = "=";
            this.btneq.UseVisualStyleBackColor = false;
            this.btneq.Click += new System.EventHandler(this.btneq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(280, 357);
            this.Controls.Add(this.btneq);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btninvers);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnpoint);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSQRT);
            this.Controls.Add(this.btnsign);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnBKS);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnBKS;
		private System.Windows.Forms.Button btnCE;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnsign;
		private System.Windows.Forms.Button btnSQRT;
		private System.Windows.Forms.Button btn7;
		private System.Windows.Forms.Button btn8;
		private System.Windows.Forms.Button btn9;
		private System.Windows.Forms.Button btn6;
		private System.Windows.Forms.Button btn5;
		private System.Windows.Forms.Button btn4;
		private System.Windows.Forms.Button btn3;
		private System.Windows.Forms.Button btn2;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn0;
		private System.Windows.Forms.Button btnpoint;
		private System.Windows.Forms.Button btndivide;
		private System.Windows.Forms.Button btnmod;
		private System.Windows.Forms.Button btnmultiply;
		private System.Windows.Forms.Button btninvers;
		private System.Windows.Forms.Button btnminus;
		private System.Windows.Forms.Button btnplus;
		private System.Windows.Forms.Button btneq;
	}
}

