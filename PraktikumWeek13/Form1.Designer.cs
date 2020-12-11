
namespace PraktikumWeek13
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
            this.buttonproses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelpesan = new System.Windows.Forms.Label();
            this.textname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonproses
            // 
            this.buttonproses.Location = new System.Drawing.Point(43, 79);
            this.buttonproses.Name = "buttonproses";
            this.buttonproses.Size = new System.Drawing.Size(75, 23);
            this.buttonproses.TabIndex = 1;
            this.buttonproses.Text = "Process";
            this.buttonproses.UseVisualStyleBackColor = true;
            this.buttonproses.Click += new System.EventHandler(this.buttonproses_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input data :";
            // 
            // labelpesan
            // 
            this.labelpesan.AutoSize = true;
            this.labelpesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpesan.Location = new System.Drawing.Point(38, 117);
            this.labelpesan.Name = "labelpesan";
            this.labelpesan.Size = new System.Drawing.Size(98, 25);
            this.labelpesan.TabIndex = 3;
            this.labelpesan.Text = "[EMPTY]";
            this.labelpesan.Click += new System.EventHandler(this.labelpesan_Click);
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(43, 53);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(251, 20);
            this.textname.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 177);
            this.Controls.Add(this.textname);
            this.Controls.Add(this.labelpesan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonproses);
            this.Name = "Form1";
            this.Text = "Form Pengaturan Warna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonproses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelpesan;
        private System.Windows.Forms.TextBox textname;
    }
}

