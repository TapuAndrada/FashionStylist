namespace FashionStylist
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_new_outfit = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(147, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "YOUR FASHION STYLIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(80, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(655, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hi! Do you need help with which outfit to choose today? ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.label3.Location = new System.Drawing.Point(292, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "If so, please select:";
            // 
            // button_new_outfit
            // 
            this.button_new_outfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.button_new_outfit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_new_outfit.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold);
            this.button_new_outfit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.button_new_outfit.Location = new System.Drawing.Point(176, 273);
            this.button_new_outfit.Name = "button_new_outfit";
            this.button_new_outfit.Size = new System.Drawing.Size(102, 61);
            this.button_new_outfit.TabIndex = 4;
            this.button_new_outfit.Text = "NEW OUTFIT";
            this.button_new_outfit.UseVisualStyleBackColor = false;
            this.button_new_outfit.Click += new System.EventHandler(this.button_new_outfit_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.button_exit.Location = new System.Drawing.Point(465, 273);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(101, 61);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(833, 441);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_new_outfit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Fashion Stylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_new_outfit;
        private System.Windows.Forms.Button button_exit;
    }
}

