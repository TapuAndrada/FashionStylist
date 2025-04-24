namespace FashionStylist
{
    partial class OutfitSelect
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
            this.label4 = new System.Windows.Forms.Label();
            this.listBox_Sel_Categ = new System.Windows.Forms.ListBox();
            this.button_Select = new System.Windows.Forms.Button();
            this.button_GenOutfit = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "YOUR FASHION STYLIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.label3.Location = new System.Drawing.Point(21, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 62);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Outfits :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.label4.Location = new System.Drawing.Point(27, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(857, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Now that you\'ve selected the categories, please upload the folder with photos for" +
    " each chosen category.";
            // 
            // listBox_Sel_Categ
            // 
            this.listBox_Sel_Categ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(230)))));
            this.listBox_Sel_Categ.Font = new System.Drawing.Font("Sitka Banner", 10.2F, System.Drawing.FontStyle.Bold);
            this.listBox_Sel_Categ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.listBox_Sel_Categ.FormattingEnabled = true;
            this.listBox_Sel_Categ.ItemHeight = 24;
            this.listBox_Sel_Categ.Location = new System.Drawing.Point(32, 186);
            this.listBox_Sel_Categ.Name = "listBox_Sel_Categ";
            this.listBox_Sel_Categ.Size = new System.Drawing.Size(191, 100);
            this.listBox_Sel_Categ.TabIndex = 7;
            this.listBox_Sel_Categ.SelectedIndexChanged += new System.EventHandler(this.listBox_Sel_Categ_SelectedIndexChanged);
            // 
            // button_Select
            // 
            this.button_Select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(234)))), ((int)(((byte)(205)))));
            this.button_Select.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Select.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.button_Select.Location = new System.Drawing.Point(271, 186);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(408, 46);
            this.button_Select.TabIndex = 8;
            this.button_Select.UseVisualStyleBackColor = false;
            this.button_Select.Visible = false;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // button_GenOutfit
            // 
            this.button_GenOutfit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(216)))), ((int)(((byte)(182)))));
            this.button_GenOutfit.Font = new System.Drawing.Font("Sitka Banner", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GenOutfit.Location = new System.Drawing.Point(341, 238);
            this.button_GenOutfit.Name = "button_GenOutfit";
            this.button_GenOutfit.Size = new System.Drawing.Size(276, 48);
            this.button_GenOutfit.TabIndex = 9;
            this.button_GenOutfit.Text = "Generate the Outfit";
            this.button_GenOutfit.UseVisualStyleBackColor = false;
            this.button_GenOutfit.Visible = false;
            this.button_GenOutfit.Click += new System.EventHandler(this.button_GenOutfit_Click_1);
            // 
            // OutfitSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(974, 458);
            this.Controls.Add(this.button_GenOutfit);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.listBox_Sel_Categ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(79)))), ((int)(((byte)(131)))));
            this.Name = "OutfitSelect";
            this.Text = "OutfitSelect";
            this.Load += new System.EventHandler(this.OutfitSelect_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox_Sel_Categ;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_GenOutfit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}