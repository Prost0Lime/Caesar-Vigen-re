/*
 * Created by SharpDevelop.
 * User: adfgh
 * Date: Вс, 22 ноя 2020
 * Time: 19:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shifri
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button6);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(9, 10);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(340, 150);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Шифр Цезаря / Caesar\'s cipher";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(109, 109);
			this.button6.Margin = new System.Windows.Forms.Padding(2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(127, 28);
			this.button6.TabIndex = 7;
			this.button6.Text = "Очистить / Clear";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(224, 73);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(111, 27);
			this.button2.TabIndex = 3;
			this.button2.Text = "Decipher";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(224, 30);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(111, 26);
			this.button1.TabIndex = 2;
			this.button1.Text = "Encrypt";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(4, 67);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(216, 38);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(4, 24);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(216, 38);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.textBox5);
			this.groupBox2.Controls.Add(this.textBox4);
			this.groupBox2.Controls.Add(this.textBox3);
			this.groupBox2.Location = new System.Drawing.Point(9, 164);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(340, 150);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Шифр Виженера / Vigenère cipher";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(225, 28);
			this.button5.Margin = new System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(110, 30);
			this.button5.TabIndex = 4;
			this.button5.Text = "Очистить / Clear";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(224, 105);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(111, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Decipher";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(224, 69);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(111, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Encrypt";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "Ключ / Key:";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(4, 97);
			this.textBox5.Margin = new System.Windows.Forms.Padding(2);
			this.textBox5.Multiline = true;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(216, 41);
			this.textBox5.TabIndex = 4;
			this.textBox5.TextChanged += new System.EventHandler(this.TextBox5TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(4, 54);
			this.textBox4.Margin = new System.Windows.Forms.Padding(2);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(216, 38);
			this.textBox4.TabIndex = 3;
			this.textBox4.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(94, 28);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(127, 23);
			this.textBox3.TabIndex = 2;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(13, 318);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(331, 37);
			this.panel1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(245, 11);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 19);
			this.label4.TabIndex = 4;
			this.label4.Text = "Shishkov S.V.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(11, 11);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "created by:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(362, 364);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Caesar | Vigenère";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
