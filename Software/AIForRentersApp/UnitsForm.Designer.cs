namespace AIForRentersApp
{
    partial class UnitsForm
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
            this.textBoxUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddUnit = new System.Windows.Forms.Button();
            this.textBoxPropertyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnitCapacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeleteUnit = new System.Windows.Forms.Button();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonProperties = new System.Windows.Forms.Button();
            this.buttonRequests = new System.Windows.Forms.Button();
            this.buttonEmailTemplates = new System.Windows.Forms.Button();
            this.buttonEditUnit = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.dataGridViewUnits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUnitName
            // 
            this.textBoxUnitName.Location = new System.Drawing.Point(355, 287);
            this.textBoxUnitName.Name = "textBoxUnitName";
            this.textBoxUnitName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unit name";
            // 
            // buttonAddUnit
            // 
            this.buttonAddUnit.Location = new System.Drawing.Point(461, 337);
            this.buttonAddUnit.Name = "buttonAddUnit";
            this.buttonAddUnit.Size = new System.Drawing.Size(100, 23);
            this.buttonAddUnit.TabIndex = 3;
            this.buttonAddUnit.Text = "Add new unit";
            this.buttonAddUnit.UseVisualStyleBackColor = true;
            this.buttonAddUnit.Click += new System.EventHandler(this.buttonAddUnit_Click);
            // 
            // textBoxPropertyName
            // 
            this.textBoxPropertyName.Enabled = false;
            this.textBoxPropertyName.Location = new System.Drawing.Point(93, 11);
            this.textBoxPropertyName.Name = "textBoxPropertyName";
            this.textBoxPropertyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropertyName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Property name";
            // 
            // textBoxUnitCapacity
            // 
            this.textBoxUnitCapacity.Location = new System.Drawing.Point(355, 313);
            this.textBoxUnitCapacity.Name = "textBoxUnitCapacity";
            this.textBoxUnitCapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitCapacity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unit capacity";
            // 
            // buttonDeleteUnit
            // 
            this.buttonDeleteUnit.Location = new System.Drawing.Point(288, 255);
            this.buttonDeleteUnit.Name = "buttonDeleteUnit";
            this.buttonDeleteUnit.Size = new System.Drawing.Size(81, 23);
            this.buttonDeleteUnit.TabIndex = 4;
            this.buttonDeleteUnit.Text = "Delete unit";
            this.buttonDeleteUnit.UseVisualStyleBackColor = true;
            this.buttonDeleteUnit.Click += new System.EventHandler(this.buttonDeleteUnit_Click);
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(355, 340);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unit price";
            // 
            // buttonProperties
            // 
            this.buttonProperties.Location = new System.Drawing.Point(603, 91);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(121, 48);
            this.buttonProperties.TabIndex = 10;
            this.buttonProperties.Text = "Properties / units";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // buttonRequests
            // 
            this.buttonRequests.Location = new System.Drawing.Point(603, 37);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(121, 48);
            this.buttonRequests.TabIndex = 11;
            this.buttonRequests.Text = "Requests / responses";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonEmailTemplates
            // 
            this.buttonEmailTemplates.Location = new System.Drawing.Point(603, 145);
            this.buttonEmailTemplates.Name = "buttonEmailTemplates";
            this.buttonEmailTemplates.Size = new System.Drawing.Size(121, 48);
            this.buttonEmailTemplates.TabIndex = 10;
            this.buttonEmailTemplates.Text = "Email templates";
            this.buttonEmailTemplates.UseVisualStyleBackColor = true;
            this.buttonEmailTemplates.Click += new System.EventHandler(this.buttonEmailTemplates_Click);
            // 
            // buttonEditUnit
            // 
            this.buttonEditUnit.Location = new System.Drawing.Point(379, 255);
            this.buttonEditUnit.Name = "buttonEditUnit";
            this.buttonEditUnit.Size = new System.Drawing.Size(81, 23);
            this.buttonEditUnit.TabIndex = 4;
            this.buttonEditUnit.Text = "Edit unit";
            this.buttonEditUnit.UseVisualStyleBackColor = true;
            this.buttonEditUnit.Click += new System.EventHandler(this.buttonEditUnit_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(468, 255);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(93, 23);
            this.buttonSaveChanges.TabIndex = 4;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // dataGridViewUnits
            // 
            this.dataGridViewUnits.AllowUserToAddRows = false;
            this.dataGridViewUnits.AllowUserToDeleteRows = false;
            this.dataGridViewUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnits.Location = new System.Drawing.Point(15, 37);
            this.dataGridViewUnits.Name = "dataGridViewUnits";
            this.dataGridViewUnits.Size = new System.Drawing.Size(546, 212);
            this.dataGridViewUnits.TabIndex = 12;
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 373);
            this.Controls.Add(this.dataGridViewUnits);
            this.Controls.Add(this.buttonEmailTemplates);
            this.Controls.Add(this.buttonProperties);
            this.Controls.Add(this.buttonRequests);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.textBoxUnitCapacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPropertyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonEditUnit);
            this.Controls.Add(this.buttonDeleteUnit);
            this.Controls.Add(this.buttonAddUnit);
            this.Name = "UnitsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Units ";
            this.Load += new System.EventHandler(this.UnitsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitsForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddUnit;
        private System.Windows.Forms.TextBox textBoxPropertyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUnitCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteUnit;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonRequests;
        private System.Windows.Forms.Button buttonEmailTemplates;
        private System.Windows.Forms.Button buttonEditUnit;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.DataGridView dataGridViewUnits;
    }
}