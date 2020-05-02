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
            this.listBoxProperties = new System.Windows.Forms.ListBox();
            this.textBoxPropertyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteProperty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddProperty
            // 
            this.buttonAddProperty.Location = new System.Drawing.Point(93, 302);
            this.buttonAddProperty.Name = "buttonAddProperty";
            this.buttonAddProperty.Size = new System.Drawing.Size(100, 23);
            this.buttonAddProperty.TabIndex = 2;
            this.buttonAddProperty.Text = "Add new property";
            this.buttonAddProperty.UseVisualStyleBackColor = true;
            // 
            // buttonShowListOfUnits
            // 
            this.buttonShowListOfUnits.Location = new System.Drawing.Point(197, 230);
            this.buttonShowListOfUnits.Name = "buttonShowListOfUnits";
            this.buttonShowListOfUnits.Size = new System.Drawing.Size(115, 23);
            this.buttonShowListOfUnits.TabIndex = 3;
            this.buttonShowListOfUnits.Text = "Units of a property";
            this.buttonShowListOfUnits.UseVisualStyleBackColor = true;
            this.buttonShowListOfUnits.Click += new System.EventHandler(this.buttonShowListOfUnits_Click);
            // 
            // listBoxProperties
            // 
            this.listBoxProperties.FormattingEnabled = true;
            this.listBoxProperties.Location = new System.Drawing.Point(12, 12);
            this.listBoxProperties.Name = "listBoxProperties";
            this.listBoxProperties.Size = new System.Drawing.Size(300, 212);
            this.listBoxProperties.TabIndex = 0;
            // 
            // textBoxPropertyName
            // 
            this.textBoxPropertyName.Location = new System.Drawing.Point(93, 276);
            this.textBoxPropertyName.Name = "textBoxPropertyName";
            this.textBoxPropertyName.Size = new System.Drawing.Size(100, 20);
            this.textBoxPropertyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Property name";
            // 
            // buttonDeleteProperty
            // 
            this.buttonDeleteProperty.Location = new System.Drawing.Point(78, 230);
            this.buttonDeleteProperty.Name = "buttonDeleteProperty";
            this.buttonDeleteProperty.Size = new System.Drawing.Size(115, 23);
            this.buttonDeleteProperty.TabIndex = 4;
            this.buttonDeleteProperty.Text = "Delete property";
            this.buttonDeleteProperty.UseVisualStyleBackColor = true;
            // 
            // PropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 345);
            this.Controls.Add(this.textBoxPropertyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxProperties);
            this.Controls.Add(this.buttonDeleteProperty);
            this.Controls.Add(this.buttonShowListOfUnits);
            this.Controls.Add(this.buttonAddProperty);
            this.Name = "PropertiesForm";
            this.Text = "Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddProperty;
        private System.Windows.Forms.Button buttonShowListOfUnits;
        private System.Windows.Forms.ListBox listBoxProperties;
        private System.Windows.Forms.TextBox textBoxPropertyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteProperty;
    }
}