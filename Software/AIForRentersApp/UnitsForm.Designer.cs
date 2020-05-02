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
            this.listBoxUnits = new System.Windows.Forms.ListBox();
            this.buttonAddUnit = new System.Windows.Forms.Button();
            this.textBoxPropertyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnitCapacity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDeleteUnit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUnitName
            // 
            this.textBoxUnitName.Location = new System.Drawing.Point(93, 276);
            this.textBoxUnitName.Name = "textBoxUnitName";
            this.textBoxUnitName.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unit name";
            // 
            // listBoxUnits
            // 
            this.listBoxUnits.FormattingEnabled = true;
            this.listBoxUnits.Location = new System.Drawing.Point(12, 37);
            this.listBoxUnits.Name = "listBoxUnits";
            this.listBoxUnits.Size = new System.Drawing.Size(300, 212);
            this.listBoxUnits.TabIndex = 0;
            // 
            // buttonAddUnit
            // 
            this.buttonAddUnit.Location = new System.Drawing.Point(93, 328);
            this.buttonAddUnit.Name = "buttonAddUnit";
            this.buttonAddUnit.Size = new System.Drawing.Size(100, 23);
            this.buttonAddUnit.TabIndex = 3;
            this.buttonAddUnit.Text = "Add new unit";
            this.buttonAddUnit.UseVisualStyleBackColor = true;
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
            this.textBoxUnitCapacity.Location = new System.Drawing.Point(93, 302);
            this.textBoxUnitCapacity.Name = "textBoxUnitCapacity";
            this.textBoxUnitCapacity.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnitCapacity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unit capacity";
            // 
            // buttonDeleteUnit
            // 
            this.buttonDeleteUnit.Location = new System.Drawing.Point(231, 255);
            this.buttonDeleteUnit.Name = "buttonDeleteUnit";
            this.buttonDeleteUnit.Size = new System.Drawing.Size(81, 23);
            this.buttonDeleteUnit.TabIndex = 4;
            this.buttonDeleteUnit.Text = "Delete unit";
            this.buttonDeleteUnit.UseVisualStyleBackColor = true;
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 381);
            this.Controls.Add(this.textBoxUnitCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPropertyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUnitName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUnits);
            this.Controls.Add(this.buttonDeleteUnit);
            this.Controls.Add(this.buttonAddUnit);
            this.Name = "UnitsForm";
            this.Text = "Units ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxUnits;
        private System.Windows.Forms.Button buttonAddUnit;
        private System.Windows.Forms.TextBox textBoxPropertyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUnitCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDeleteUnit;
    }
}