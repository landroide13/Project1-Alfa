namespace Project1_Alfa
{
    partial class Form1
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
            this.lstCountry = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCountry
            // 
            this.lstCountry.FormattingEnabled = true;
            this.lstCountry.ItemHeight = 15;
            this.lstCountry.Location = new System.Drawing.Point(121, 123);
            this.lstCountry.Name = "lstCountry";
            this.lstCountry.Size = new System.Drawing.Size(120, 49);
            this.lstCountry.TabIndex = 0;
            this.lstCountry.SelectedIndexChanged += new System.EventHandler(this.lstCountry_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(116, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cbCities
            // 
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Location = new System.Drawing.Point(122, 207);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(115, 23);
            this.cbCities.TabIndex = 2;
            this.cbCities.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(122, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "City\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(121, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(121, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Country";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn1.Location = new System.Drawing.Point(122, 264);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 32);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Submit\r\n\r\n";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 338);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCities);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstCountry;
        private TextBox txtName;
        private ComboBox cbCities;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn1;
    }
}