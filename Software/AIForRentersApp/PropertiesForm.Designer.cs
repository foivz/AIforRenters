namespace AIForRentersApp
{
    partial class PropertiesForm
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
            this.buttonAddProperty = new System.Windows.Forms.Button();
            this.buttonShowListOfUnits = new System.Windows.Forms.Button();
            this.textBoxPropertyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteProperty = new System.Windows.Forms.Button();
            this.textBoxPropertyLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEmailTemplates = new System.Windows.Forms.Button();
            this.buttonRequests = new System.Windows.Forms.Button();
            this.buttonEditProperty = new System.Windows.Forms.Button();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.dataGridViewProperties = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddProperty
            // 
            this.buttonAddProperty.Location = new System.Drawing.Point(466, 288);
            this.buttonAddProperty.Name = "buttonAddProperty";
            this.buttonAddProperty.Size = new System.Drawing.Size(100, 46);
            this.buttonAddProperty.TabIndex = 3;
            this.buttonAddProperty.Text = "Add new property";
            this.buttonAddProperty.UseVisualStyleBackColor = true;
            this.buttonAddProperty.Click += new System.EventHandler(this.buttonAddProperty_Click);
            // 
            // buttonShowListOfUnits
            // 
            this.buttonShowListOfUnits.Location = new System.Drawing.Point(603, 176);
            this.buttonShowListOfUnits.Name = "buttonShowListOfUnits";
            this.buttonShowListOfUnits.Size = new System.Drawing.Size(121, 48);
            this.buttonShowListOfUnits.TabIndex = 6;
            this.buttonShowListOfUnits.Text = "Units of a property";
            this.buttonShowListOfUnits.UseVisualStyleBackColor = true;
            this.buttonShowListOfUnits.Click += new System.EventHandler(this.buttonShowListOfUnits_Click);
            // 
            // textBoxPropertyName
            // 
            this.textBoxPropertyName.Location = new System.Drawing.Point(363, 288);
            this.textBoxPropertyName.Name = "textBoxPropertyName";
            this.textBoxPropertyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropertyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Property name";
            // 
            // buttonDeleteProperty
            // 
            this.buttonDeleteProperty.Location = new System.Drawing.Point(209, 230);
            this.buttonDeleteProperty.Name = "buttonDeleteProperty";
            this.buttonDeleteProperty.Size = new System.Drawing.Size(115, 23);
            this.buttonDeleteProperty.TabIndex = 9;
            this.buttonDeleteProperty.Text = "Delete property";
            this.buttonDeleteProperty.UseVisualStyleBackColor = true;
            this.buttonDeleteProperty.Click += new System.EventHandler(this.buttonDeleteProperty_Click);
            // 
            // textBoxPropertyLocation
            // 
            this.textBoxPropertyLocation.Location = new System.Drawing.Point(363, 314);
            this.textBoxPropertyLocation.Name = "textBoxPropertyLocation";
            this.textBoxPropertyLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropertyLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Property location";
            // 
            // buttonEmailTemplates
            // 
            this.buttonEmailTemplates.Location = new System.Drawing.Point(603, 66);
            this.buttonEmailTemplates.Name = "buttonEmailTemplates";
            this.buttonEmailTemplates.Size = new System.Drawing.Size(121, 48);
            this.buttonEmailTemplates.TabIndex = 5;
            this.buttonEmailTemplates.Text = "Email templates";
            this.buttonEmailTemplates.UseVisualStyleBackColor = true;
            this.buttonEmailTemplates.Click += new System.EventHandler(this.buttonEmailTemplates_Click);
            // 
            // buttonRequests
            // 
            this.buttonRequests.Location = new System.Drawing.Point(603, 12);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(121, 48);
            this.buttonRequests.TabIndex = 4;
            this.buttonRequests.Text = "Requests / responses";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonEditProperty
            // 
            this.buttonEditProperty.Location = new System.Drawing.Point(330, 230);
            this.buttonEditProperty.Name = "buttonEditProperty";
            this.buttonEditProperty.Size = new System.Drawing.Size(115, 23);
            this.buttonEditProperty.TabIndex = 8;
            this.buttonEditProperty.Text = "Edit property";
            this.buttonEditProperty.UseVisualStyleBackColor = true;
            this.buttonEditProperty.Click += new System.EventHandler(this.buttonEditProperty_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(451, 230);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(115, 23);
            this.buttonSaveChanges.TabIndex = 7;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.AllowUserToAddRows = false;
            this.dataGridViewProperties.AllowUserToDeleteRows = false;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.Size = new System.Drawing.Size(554, 212);
            this.dataGridViewProperties.TabIndex = 0;
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 361);
            this.Controls.Add(this.dataGridViewProperties);
            this.Controls.Add(this.buttonEmailTemplates);
            this.Controls.Add(this.buttonRequests);
            this.Controls.Add(this.textBoxPropertyLocation);
            this.Controls.Add(this.textBoxPropertyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonEditProperty);
            this.Controls.Add(this.buttonDeleteProperty);
            this.Controls.Add(this.buttonShowListOfUnits);
            this.Controls.Add(this.buttonAddProperty);
            this.Name = "PropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.PropertiesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PropertiesForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddProperty;
        private System.Windows.Forms.Button buttonShowListOfUnits;
        private System.Windows.Forms.TextBox textBoxPropertyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteProperty;
        private System.Windows.Forms.TextBox textBoxPropertyLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEmailTemplates;
        private System.Windows.Forms.Button buttonRequests;
        private System.Windows.Forms.Button buttonEditProperty;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.DataGridView dataGridViewProperties;
    }
}