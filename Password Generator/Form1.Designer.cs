
namespace Password_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_generate_pass = new System.Windows.Forms.Button();
            this.chkbox_special_Char = new System.Windows.Forms.CheckBox();
            this.pass_Length = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_Box = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pass_Length)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_generate_pass
            // 
            this.btn_generate_pass.Location = new System.Drawing.Point(12, 264);
            this.btn_generate_pass.Name = "btn_generate_pass";
            this.btn_generate_pass.Size = new System.Drawing.Size(96, 43);
            this.btn_generate_pass.TabIndex = 4;
            this.btn_generate_pass.Text = "Generate";
            this.btn_generate_pass.UseVisualStyleBackColor = true;
            this.btn_generate_pass.Click += new System.EventHandler(this.btn_generate_pass_Click);
            // 
            // chkbox_special_Char
            // 
            this.chkbox_special_Char.AutoSize = true;
            this.chkbox_special_Char.Location = new System.Drawing.Point(12, 51);
            this.chkbox_special_Char.Name = "chkbox_special_Char";
            this.chkbox_special_Char.Size = new System.Drawing.Size(157, 21);
            this.chkbox_special_Char.TabIndex = 2;
            this.chkbox_special_Char.Text = "Special Characters?";
            this.chkbox_special_Char.UseVisualStyleBackColor = true;
            // 
            // pass_Length
            // 
            this.pass_Length.Location = new System.Drawing.Point(139, 12);
            this.pass_Length.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.pass_Length.Name = "pass_Length";
            this.pass_Length.Size = new System.Drawing.Size(133, 22);
            this.pass_Length.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password Length:";
            // 
            // pass_Box
            // 
            this.pass_Box.Location = new System.Drawing.Point(12, 78);
            this.pass_Box.Name = "pass_Box";
            this.pass_Box.Size = new System.Drawing.Size(293, 180);
            this.pass_Box.TabIndex = 3;
            this.pass_Box.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(317, 313);
            this.Controls.Add(this.pass_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_Length);
            this.Controls.Add(this.chkbox_special_Char);
            this.Controls.Add(this.btn_generate_pass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pass_Length)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate_pass;
        private System.Windows.Forms.CheckBox chkbox_special_Char;
        private System.Windows.Forms.NumericUpDown pass_Length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox pass_Box;
    }
}

