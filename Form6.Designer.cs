namespace Mobile
{
    partial class Form6
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
            this.searchBar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBar
            // 
            this.searchBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.searchBar.Location = new System.Drawing.Point(280, 30);
            this.searchBar.Name = "searchBar";
            this.searchBar.PlaceholderText = "Contact to send message";
            this.searchBar.Size = new System.Drawing.Size(180, 27);
            this.searchBar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 344);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_woc1
            // 
            this.button_woc1.BorderColor = System.Drawing.Color.Gray;
            this.button_woc1.ButtonColor = System.Drawing.Color.Gray;
            this.button_woc1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_woc1.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_woc1.Location = new System.Drawing.Point(240, 484);
            this.button_woc1.Name = "button_woc1";
            this.button_woc1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_woc1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_woc1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_woc1.Size = new System.Drawing.Size(230, 57);
            this.button_woc1.TabIndex = 5;
            this.button_woc1.Text = "Send";
            this.button_woc1.TextColor = System.Drawing.Color.White;
            this.button_woc1.UseVisualStyleBackColor = true;
            this.button_woc1.Click += new System.EventHandler(this.button_woc1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 27);
            this.textBox2.TabIndex = 6;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_woc1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBar);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox searchBar;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private TextBox textBox2;
    }
}