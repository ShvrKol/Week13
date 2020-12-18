
namespace PraktikumWeek14
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxinput = new System.Windows.Forms.TextBox();
            this.buttonrev = new System.Windows.Forms.Button();
            this.buttonurut = new System.Windows.Forms.Button();
            this.labelout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input";
            // 
            // textBoxinput
            // 
            this.textBoxinput.Location = new System.Drawing.Point(38, 55);
            this.textBoxinput.Name = "textBoxinput";
            this.textBoxinput.Size = new System.Drawing.Size(178, 20);
            this.textBoxinput.TabIndex = 1;
            // 
            // buttonrev
            // 
            this.buttonrev.Location = new System.Drawing.Point(38, 95);
            this.buttonrev.Name = "buttonrev";
            this.buttonrev.Size = new System.Drawing.Size(75, 23);
            this.buttonrev.TabIndex = 2;
            this.buttonrev.Text = "REVERSE";
            this.buttonrev.UseVisualStyleBackColor = true;
            this.buttonrev.Click += new System.EventHandler(this.buttonrev_Click);
            // 
            // buttonurut
            // 
            this.buttonurut.Location = new System.Drawing.Point(141, 95);
            this.buttonurut.Name = "buttonurut";
            this.buttonurut.Size = new System.Drawing.Size(75, 23);
            this.buttonurut.TabIndex = 3;
            this.buttonurut.Text = "URUTKAN";
            this.buttonurut.UseVisualStyleBackColor = true;
            this.buttonurut.Click += new System.EventHandler(this.buttonurut_Click);
            // 
            // labelout
            // 
            this.labelout.AutoSize = true;
            this.labelout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelout.Location = new System.Drawing.Point(35, 158);
            this.labelout.Name = "labelout";
            this.labelout.Size = new System.Drawing.Size(61, 16);
            this.labelout.TabIndex = 4;
            this.labelout.Text = "OUTPUT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 295);
            this.Controls.Add(this.labelout);
            this.Controls.Add(this.buttonurut);
            this.Controls.Add(this.buttonrev);
            this.Controls.Add(this.textBoxinput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxinput;
        private System.Windows.Forms.Button buttonrev;
        private System.Windows.Forms.Button buttonurut;
        private System.Windows.Forms.Label labelout;
    }
}

