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
            this.buttonAddProperty.Location = new System.Drawing.Point(621, 354);
            this.buttonAddProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddProperty.Name = "buttonAddProperty";
            this.buttonAddProperty.Size = new System.Drawing.Size(133, 57);
            this.buttonAddProperty.TabIndex = 3;
            this.buttonAddProperty.Text = "Add new property";
            this.buttonAddProperty.UseVisualStyleBackColor = true;
            this.buttonAddProperty.Click += new System.EventHandler(this.buttonAddProperty_Click);
            // 
            // buttonShowListOfUnits
            // 
            this.buttonShowListOfUnits.Location = new System.Drawing.Point(804, 217);
            this.buttonShowListOfUnits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonShowListOfUnits.Name = "buttonShowListOfUnits";
            this.buttonShowListOfUnits.Size = new System.Drawing.Size(161, 59);
            this.buttonShowListOfUnits.TabIndex = 6;
            this.buttonShowListOfUnits.Text = "Units of a property";
            this.buttonShowListOfUnits.UseVisualStyleBackColor = true;
            this.buttonShowListOfUnits.Click += new System.EventHandler(this.buttonShowListOfUnits_Click);
            // 
            // textBoxPropertyName
            // 
            this.textBoxPropertyName.Location = new System.Drawing.Point(484, 354);
            this.textBoxPropertyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPropertyName.Name = "textBoxPropertyName";
            this.textBoxPropertyName.Size = new System.Drawing.Size(132, 22);
            this.textBoxPropertyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 358);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Property name";
            // 
            // buttonDeleteProperty
            // 
            this.buttonDeleteProperty.Location = new System.Drawing.Point(279, 283);
            this.buttonDeleteProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteProperty.Name = "buttonDeleteProperty";
            this.buttonDeleteProperty.Size = new System.Drawing.Size(153, 28);
            this.buttonDeleteProperty.TabIndex = 9;
            this.buttonDeleteProperty.Text = "Delete property";
            this.buttonDeleteProperty.UseVisualStyleBackColor = true;
            this.buttonDeleteProperty.Click += new System.EventHandler(this.buttonDeleteProperty_Click);
            // 
            // textBoxPropertyLocation
            // 
            this.textBoxPropertyLocation.Location = new System.Drawing.Point(484, 386);
            this.textBoxPropertyLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPropertyLocation.Name = "textBoxPropertyLocation";
            this.textBoxPropertyLocation.Size = new System.Drawing.Size(132, 22);
            this.textBoxPropertyLocation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 390);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Property location";
            // 
            // buttonEmailTemplates
            // 
            this.buttonEmailTemplates.Location = new System.Drawing.Point(804, 81);
            this.buttonEmailTemplates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEmailTemplates.Name = "buttonEmailTemplates";
            this.buttonEmailTemplates.Size = new System.Drawing.Size(161, 59);
            this.buttonEmailTemplates.TabIndex = 5;
            this.buttonEmailTemplates.Text = "Email templates";
            this.buttonEmailTemplates.UseVisualStyleBackColor = true;
            this.buttonEmailTemplates.Click += new System.EventHandler(this.buttonEmailTemplates_Click);
            // 
            // buttonRequests
            // 
            this.buttonRequests.Location = new System.Drawing.Point(804, 15);
            this.buttonRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(161, 59);
            this.buttonRequests.TabIndex = 4;
            this.buttonRequests.Text = "Requests / responses";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonEditProperty
            // 
            this.buttonEditProperty.Location = new System.Drawing.Point(440, 283);
            this.buttonEditProperty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditProperty.Name = "buttonEditProperty";
            this.buttonEditProperty.Size = new System.Drawing.Size(153, 28);
            this.buttonEditProperty.TabIndex = 8;
            this.buttonEditProperty.Text = "Edit property";
            this.buttonEditProperty.UseVisualStyleBackColor = true;
            this.buttonEditProperty.Click += new System.EventHandler(this.buttonEditProperty_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(601, 283);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(153, 28);
            this.buttonSaveChanges.TabIndex = 7;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // dataGridViewProperties
            // 
            this.dataGridViewProperties.AllowUserToAddRows = false;
            this.dataGridViewProperties.AllowUserToDeleteRows = false;
            this.dataGridViewProperties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProperties.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewProperties.Name = "dataGridViewProperties";
            this.dataGridViewProperties.RowHeadersWidth = 51;
            this.dataGridViewProperties.Size = new System.Drawing.Size(739, 261);
            this.dataGridViewProperties.TabIndex = 0;
            this.dataGridViewProperties.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProperties_CellClick);
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 444);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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