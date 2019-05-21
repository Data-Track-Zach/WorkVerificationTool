namespace ImageVerificationTool
{
    partial class IVT
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
            this.CheckedListFlags = new System.Windows.Forms.CheckedListBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.Btn_Store = new System.Windows.Forms.Button();
            this.ImageLocationComboBox = new System.Windows.Forms.ComboBox();
            this.BTN_Clear = new System.Windows.Forms.Button();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckedListFlags
            // 
            this.CheckedListFlags.CheckOnClick = true;
            this.CheckedListFlags.ColumnWidth = 600;
            this.CheckedListFlags.Enabled = false;
            this.CheckedListFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedListFlags.FormattingEnabled = true;
            this.CheckedListFlags.Location = new System.Drawing.Point(237, 8);
            this.CheckedListFlags.Name = "CheckedListFlags";
            this.CheckedListFlags.Size = new System.Drawing.Size(397, 340);
            this.CheckedListFlags.TabIndex = 0;
            this.CheckedListFlags.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListFlags_ItemCheck);
            // 
            // OutputText
            // 
            this.OutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputText.Location = new System.Drawing.Point(739, 9);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutputText.Size = new System.Drawing.Size(380, 339);
            this.OutputText.TabIndex = 1;
            this.OutputText.TextChanged += new System.EventHandler(this.OutputText_TextChanged);
            // 
            // Btn_Store
            // 
            this.Btn_Store.Enabled = false;
            this.Btn_Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Store.Location = new System.Drawing.Point(640, 8);
            this.Btn_Store.Name = "Btn_Store";
            this.Btn_Store.Size = new System.Drawing.Size(93, 26);
            this.Btn_Store.TabIndex = 2;
            this.Btn_Store.Text = "Store";
            this.Btn_Store.UseVisualStyleBackColor = true;
            this.Btn_Store.Click += new System.EventHandler(this.Btn_Store_Click);
            // 
            // ImageLocationComboBox
            // 
            this.ImageLocationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageLocationComboBox.FormattingEnabled = true;
            this.ImageLocationComboBox.Location = new System.Drawing.Point(12, 40);
            this.ImageLocationComboBox.Name = "ImageLocationComboBox";
            this.ImageLocationComboBox.Size = new System.Drawing.Size(219, 28);
            this.ImageLocationComboBox.TabIndex = 3;
            this.ImageLocationComboBox.SelectedIndexChanged += new System.EventHandler(this.ImageLocationComboBox_SelectedIndexChanged);
            // 
            // BTN_Clear
            // 
            this.BTN_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Clear.Location = new System.Drawing.Point(640, 321);
            this.BTN_Clear.Name = "BTN_Clear";
            this.BTN_Clear.Size = new System.Drawing.Size(93, 27);
            this.BTN_Clear.TabIndex = 5;
            this.BTN_Clear.Text = "Clear All";
            this.BTN_Clear.UseVisualStyleBackColor = true;
            this.BTN_Clear.Click += new System.EventHandler(this.BTN_Clear_Click);
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.Enabled = false;
            this.Btn_Copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Copy.Location = new System.Drawing.Point(640, 95);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(93, 28);
            this.Btn_Copy.TabIndex = 8;
            this.Btn_Copy.Text = "Copy";
            this.Btn_Copy.UseVisualStyleBackColor = true;
            this.Btn_Copy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(12, 8);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(107, 26);
            this.NameTextBox.TabIndex = 9;
            this.NameTextBox.Text = "Name";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTextBox.Location = new System.Drawing.Point(125, 8);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(106, 26);
            this.DateTextBox.TabIndex = 10;
            this.DateTextBox.Text = "Date";
            // 
            // IVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 360);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Btn_Copy);
            this.Controls.Add(this.BTN_Clear);
            this.Controls.Add(this.ImageLocationComboBox);
            this.Controls.Add(this.Btn_Store);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.CheckedListFlags);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "IVT";
            this.ShowIcon = false;
            this.Text = "Image Verification Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListFlags;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button Btn_Store;
        private System.Windows.Forms.ComboBox ImageLocationComboBox;
        private System.Windows.Forms.Button BTN_Clear;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
    }
}

