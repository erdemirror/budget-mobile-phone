namespace Mobile
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            this.button_woc1 = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.contactoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_woc2 = new ePOSOne.btnProduct.Button_WOC();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_woc1
            // 
            this.button_woc1.BorderColor = System.Drawing.Color.Gray;
            this.button_woc1.ButtonColor = System.Drawing.Color.Gray;
            this.button_woc1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_woc1.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_woc1.Location = new System.Drawing.Point(240, 339);
            this.button_woc1.Name = "button_woc1";
            this.button_woc1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_woc1.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_woc1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_woc1.Size = new System.Drawing.Size(230, 57);
            this.button_woc1.TabIndex = 4;
            this.button_woc1.Text = "Add contact";
            this.button_woc1.TextColor = System.Drawing.Color.White;
            this.button_woc1.UseVisualStyleBackColor = true;
            this.button_woc1.Click += new System.EventHandler(this.button_woc1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Contact list";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(458, 264);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_woc2
            // 
            this.button_woc2.BorderColor = System.Drawing.Color.Gray;
            this.button_woc2.ButtonColor = System.Drawing.Color.Gray;
            this.button_woc2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_woc2.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_woc2.Location = new System.Drawing.Point(240, 402);
            this.button_woc2.Name = "button_woc2";
            this.button_woc2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_woc2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_woc2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_woc2.Size = new System.Drawing.Size(230, 57);
            this.button_woc2.TabIndex = 8;
            this.button_woc2.Text = "Delete contact";
            this.button_woc2.TextColor = System.Drawing.Color.White;
            this.button_woc2.UseVisualStyleBackColor = true;
            this.button_woc2.Click += new System.EventHandler(this.button_woc2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(148, 402);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(60, 52);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_woc2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_woc1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC button_woc1;
        private Label label1;
        private BindingSource contactoBindingSource;
        private DataGridView dataGridView1;
        private ePOSOne.btnProduct.Button_WOC button_woc2;
        private TextBox textBox1;
    }
}