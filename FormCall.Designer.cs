namespace Mobile
{
    partial class FormCall
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
            this.button_woc13 = new ePOSOne.btnProduct.Button_WOC();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(183, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calling...";
            // 
            // button_woc13
            // 
            this.button_woc13.BorderColor = System.Drawing.Color.Red;
            this.button_woc13.ButtonColor = System.Drawing.Color.Red;
            this.button_woc13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_woc13.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_woc13.Location = new System.Drawing.Point(200, 446);
            this.button_woc13.Name = "button_woc13";
            this.button_woc13.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_woc13.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_woc13.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_woc13.Size = new System.Drawing.Size(77, 74);
            this.button_woc13.TabIndex = 16;
            this.button_woc13.Text = "End";
            this.button_woc13.TextColor = System.Drawing.Color.White;
            this.button_woc13.UseVisualStyleBackColor = true;
            this.button_woc13.Click += new System.EventHandler(this.button_woc13_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "0";
            // 
            // FormCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_woc13);
            this.Controls.Add(this.label1);
            this.Name = "FormCall";
            this.Text = "FormCall";
            this.Load += new System.EventHandler(this.FormCall_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ePOSOne.btnProduct.Button_WOC button_woc13;
        private Label label2;
    }
}