namespace Item_Master_Export_SQL
{
    partial class ItemMasterExport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemMasterExport));
            this.MainButton = new System.Windows.Forms.Button();
            this.WelcomeInfoBox = new System.Windows.Forms.TextBox();
            this.SuccessFailLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemMasterRButton = new System.Windows.Forms.RadioButton();
            this.InventoryExportRButton = new System.Windows.Forms.RadioButton();
            this.StoredProcedureGBox = new System.Windows.Forms.GroupBox();
            this.ServerChoiceGBox = new System.Windows.Forms.GroupBox();
            this.ProdRButton = new System.Windows.Forms.RadioButton();
            this.DevRButton = new System.Windows.Forms.RadioButton();
            this.CommunicorpLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StoredProcedureGBox.SuspendLayout();
            this.ServerChoiceGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommunicorpLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.AccessibleDescription = "The main button that when pushed will run a query that then saves returned data t" +
    "o the users desktop in a excel or CSV file";
            this.MainButton.AccessibleName = "Main Button";
            this.MainButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MainButton.Location = new System.Drawing.Point(118, 218);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(85, 25);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Push To Start";
            this.MainButton.UseVisualStyleBackColor = false;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // WelcomeInfoBox
            // 
            this.WelcomeInfoBox.AccessibleDescription = "Text box that describes what will happen when the main button is pressed";
            this.WelcomeInfoBox.AccessibleName = "Welcome Info Box";
            this.WelcomeInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WelcomeInfoBox.BackColor = System.Drawing.Color.White;
            this.WelcomeInfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeInfoBox.Location = new System.Drawing.Point(12, 12);
            this.WelcomeInfoBox.Multiline = true;
            this.WelcomeInfoBox.Name = "WelcomeInfoBox";
            this.WelcomeInfoBox.ReadOnly = true;
            this.WelcomeInfoBox.Size = new System.Drawing.Size(305, 75);
            this.WelcomeInfoBox.TabIndex = 1;
            this.WelcomeInfoBox.TabStop = false;
            this.WelcomeInfoBox.Text = "Hi, Welcome to the Item Master Export Program:\r\n\r\n1.) Select Server \r\n2.) Select " +
    "Stored Procedure\r\n3.) Click to export Item Master/Inventory from [Site]";
            // 
            // SuccessFailLabel
            // 
            this.SuccessFailLabel.AccessibleDescription = "This label will show up and display whether a succesful pull and save happened  o" +
    "r not";
            this.SuccessFailLabel.AccessibleName = "Success Fail Label";
            this.SuccessFailLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.SuccessFailLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SuccessFailLabel.Location = new System.Drawing.Point(105, 246);
            this.SuccessFailLabel.Name = "SuccessFailLabel";
            this.SuccessFailLabel.Size = new System.Drawing.Size(116, 13);
            this.SuccessFailLabel.TabIndex = 2;
            this.SuccessFailLabel.Text = "Button Not Pushed Yet";
            this.SuccessFailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SuccessFailLabel.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // ItemMasterRButton
            // 
            this.ItemMasterRButton.AccessibleDescription = "Item Master Radio Button";
            this.ItemMasterRButton.AccessibleName = "Item Master Radio Button";
            this.ItemMasterRButton.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.ItemMasterRButton.AutoSize = true;
            this.ItemMasterRButton.Checked = true;
            this.ItemMasterRButton.Location = new System.Drawing.Point(5, 19);
            this.ItemMasterRButton.Name = "ItemMasterRButton";
            this.ItemMasterRButton.Size = new System.Drawing.Size(80, 17);
            this.ItemMasterRButton.TabIndex = 7;
            this.ItemMasterRButton.TabStop = true;
            this.ItemMasterRButton.Text = "Item Master";
            this.ItemMasterRButton.UseVisualStyleBackColor = true;
            this.ItemMasterRButton.CheckedChanged += new System.EventHandler(this.ItemMasterRButton_CheckedChanged);
            // 
            // InventoryExportRButton
            // 
            this.InventoryExportRButton.AccessibleDescription = "Inventory Export Radio Button";
            this.InventoryExportRButton.AccessibleName = "Inventory Export Radio Button";
            this.InventoryExportRButton.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.InventoryExportRButton.AutoSize = true;
            this.InventoryExportRButton.Location = new System.Drawing.Point(5, 42);
            this.InventoryExportRButton.Name = "InventoryExportRButton";
            this.InventoryExportRButton.Size = new System.Drawing.Size(102, 17);
            this.InventoryExportRButton.TabIndex = 8;
            this.InventoryExportRButton.Text = "Inventory Export";
            this.InventoryExportRButton.UseVisualStyleBackColor = true;
            this.InventoryExportRButton.CheckedChanged += new System.EventHandler(this.InventoryExportRButton_CheckedChanged);
            // 
            // StoredProcedureGBox
            // 
            this.StoredProcedureGBox.Controls.Add(this.ItemMasterRButton);
            this.StoredProcedureGBox.Controls.Add(this.InventoryExportRButton);
            this.StoredProcedureGBox.Location = new System.Drawing.Point(207, 93);
            this.StoredProcedureGBox.Name = "StoredProcedureGBox";
            this.StoredProcedureGBox.Size = new System.Drawing.Size(110, 65);
            this.StoredProcedureGBox.TabIndex = 12;
            this.StoredProcedureGBox.TabStop = false;
            this.StoredProcedureGBox.Text = "Stored Procedure:";
            // 
            // ServerChoiceGBox
            // 
            this.ServerChoiceGBox.AccessibleDescription = "Group box for server choice";
            this.ServerChoiceGBox.AccessibleName = "Group box for server choice";
            this.ServerChoiceGBox.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.ServerChoiceGBox.Controls.Add(this.ProdRButton);
            this.ServerChoiceGBox.Controls.Add(this.DevRButton);
            this.ServerChoiceGBox.Location = new System.Drawing.Point(12, 93);
            this.ServerChoiceGBox.Name = "ServerChoiceGBox";
            this.ServerChoiceGBox.Size = new System.Drawing.Size(100, 65);
            this.ServerChoiceGBox.TabIndex = 11;
            this.ServerChoiceGBox.TabStop = false;
            this.ServerChoiceGBox.Text = "Server Choice:";
            // 
            // ProdRButton
            // 
            this.ProdRButton.AccessibleDescription = "Prod Radio Button";
            this.ProdRButton.AccessibleName = "Prod Radio Button";
            this.ProdRButton.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.ProdRButton.AutoSize = true;
            this.ProdRButton.Checked = true;
            this.ProdRButton.Location = new System.Drawing.Point(6, 19);
            this.ProdRButton.Name = "ProdRButton";
            this.ProdRButton.Size = new System.Drawing.Size(74, 17);
            this.ProdRButton.TabIndex = 9;
            this.ProdRButton.TabStop = true;
            this.ProdRButton.Text = "[Site] Prod";
            this.ProdRButton.UseVisualStyleBackColor = true;
            this.ProdRButton.CheckedChanged += new System.EventHandler(this.AvantiProdRButton_CheckedChanged);
            // 
            // DevRButton
            // 
            this.DevRButton.AccessibleDescription = "Dev Radio Button";
            this.DevRButton.AccessibleName = "Dev Radio Button";
            this.DevRButton.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.DevRButton.AutoSize = true;
            this.DevRButton.Location = new System.Drawing.Point(6, 42);
            this.DevRButton.Name = "DevRButton";
            this.DevRButton.Size = new System.Drawing.Size(72, 17);
            this.DevRButton.TabIndex = 10;
            this.DevRButton.Text = "[Site] Dev";
            this.DevRButton.UseVisualStyleBackColor = true;
            this.DevRButton.CheckedChanged += new System.EventHandler(this.AvantiDevRButton_CheckedChanged);
            // 
            // CommunicorpLogoPictureBox
            // 
            this.CommunicorpLogoPictureBox.AccessibleDescription = "Communicorp logo Picture Box";
            this.CommunicorpLogoPictureBox.AccessibleName = "Communicorp logo Picture Box";
            this.CommunicorpLogoPictureBox.BackColor = System.Drawing.Color.White;
            this.CommunicorpLogoPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("CommunicorpLogoPictureBox.ErrorImage")));
            this.CommunicorpLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CommunicorpLogoPictureBox.Image")));
            this.CommunicorpLogoPictureBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("CommunicorpLogoPictureBox.InitialImage")));
            this.CommunicorpLogoPictureBox.Location = new System.Drawing.Point(118, 98);
            this.CommunicorpLogoPictureBox.Name = "CommunicorpLogoPictureBox";
            this.CommunicorpLogoPictureBox.Size = new System.Drawing.Size(83, 60);
            this.CommunicorpLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CommunicorpLogoPictureBox.TabIndex = 13;
            this.CommunicorpLogoPictureBox.TabStop = false;
            // 
            // ItemMasterExport
            // 
            this.AccessibleDescription = "A form that exports items from the DB and saves them in an excel file on the user" +
    "\'s desktop when main button on the form is pushed.";
            this.AccessibleName = "Item Master Export";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 261);
            this.Controls.Add(this.CommunicorpLogoPictureBox);
            this.Controls.Add(this.ServerChoiceGBox);
            this.Controls.Add(this.StoredProcedureGBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SuccessFailLabel);
            this.Controls.Add(this.WelcomeInfoBox);
            this.Controls.Add(this.MainButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemMasterExport";
            this.Text = "Item Master Export";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StoredProcedureGBox.ResumeLayout(false);
            this.StoredProcedureGBox.PerformLayout();
            this.ServerChoiceGBox.ResumeLayout(false);
            this.ServerChoiceGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CommunicorpLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.TextBox WelcomeInfoBox;
        private System.Windows.Forms.Label SuccessFailLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton ItemMasterRButton;
        private System.Windows.Forms.RadioButton InventoryExportRButton;
        private System.Windows.Forms.GroupBox StoredProcedureGBox;
        private System.Windows.Forms.GroupBox ServerChoiceGBox;
        private System.Windows.Forms.RadioButton ProdRButton;
        private System.Windows.Forms.RadioButton DevRButton;
        private System.Windows.Forms.PictureBox CommunicorpLogoPictureBox;
    }
}

