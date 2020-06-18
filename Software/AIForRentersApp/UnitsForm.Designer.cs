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
            this.textBoxUnitName.Location = new System.Drawing.Point(12, 340);
            this.textBoxUnitName.Name = "textBoxUnitName";
            this.textBoxUnitName.Size = new System.Drawing.Size(280, 20);
            this.textBoxUnitName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unit name";
            // 
            // buttonAddUnit
            // 
            this.buttonAddUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddUnit.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUnit.Location = new System.Drawing.Point(491, 362);
            this.buttonAddUnit.Name = "buttonAddUnit";
            this.buttonAddUnit.Size = new System.Drawing.Size(121, 48);
            this.buttonAddUnit.TabIndex = 3;
            this.buttonAddUnit.Text = "Add new unit";
            this.buttonAddUnit.UseVisualStyleBackColor = true;
            this.buttonAddUnit.Click += new System.EventHandler(this.buttonAddUnit_Click);
            // 
            // textBoxPropertyName
            // 
            this.textBoxPropertyName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPropertyName.Enabled = false;
            this.textBoxPropertyName.Location = new System.Drawing.Point(12, 42);
            this.textBoxPropertyName.Multiline = true;
            this.textBoxPropertyName.Name = "textBoxPropertyName";
            this.textBoxPropertyName.Size = new System.Drawing.Size(280, 22);
            this.textBoxPropertyName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Property name";
            // 
            // textBoxUnitCapacity
            // 
            this.textBoxUnitCapacity.Location = new System.Drawing.Point(12, 394);
            this.textBoxUnitCapacity.Name = "textBoxUnitCapacity";
            this.textBoxUnitCapacity.Size = new System.Drawing.Size(278, 20);
            this.textBoxUnitCapacity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unit capacity";
            // 
            // buttonDeleteUnit
            // 
            this.buttonDeleteUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUnit.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteUnit.Location = new System.Drawing.Point(491, 416);
            this.buttonDeleteUnit.Name = "buttonDeleteUnit";
            this.buttonDeleteUnit.Size = new System.Drawing.Size(121, 48);
            this.buttonDeleteUnit.TabIndex = 4;
            this.buttonDeleteUnit.Text = "Delete unit";
            this.buttonDeleteUnit.UseVisualStyleBackColor = true;
            this.buttonDeleteUnit.Click += new System.EventHandler(this.buttonDeleteUnit_Click);
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(12, 442);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(278, 20);
            this.textBoxUnitPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unit price";
            // 
            // buttonProperties
            // 
            this.buttonProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProperties.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProperties.Location = new System.Drawing.Point(364, 14);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(121, 48);
            this.buttonProperties.TabIndex = 10;
            this.buttonProperties.Text = "Properties";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // buttonRequests
            // 
            this.buttonRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequests.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequests.Location = new System.Drawing.Point(618, 14);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(121, 48);
            this.buttonRequests.TabIndex = 11;
            this.buttonRequests.Text = "Requests / responses";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonEmailTemplates
            // 
            this.buttonEmailTemplates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmailTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmailTemplates.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmailTemplates.Location = new System.Drawing.Point(491, 14);
            this.buttonEmailTemplates.Name = "buttonEmailTemplates";
            this.buttonEmailTemplates.Size = new System.Drawing.Size(121, 48);
            this.buttonEmailTemplates.TabIndex = 10;
            this.buttonEmailTemplates.Text = "Email templates";
            this.buttonEmailTemplates.UseVisualStyleBackColor = true;
            this.buttonEmailTemplates.Click += new System.EventHandler(this.buttonEmailTemplates_Click);
            // 
            // buttonEditUnit
            // 
            this.buttonEditUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditUnit.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditUnit.Location = new System.Drawing.Point(618, 362);
            this.buttonEditUnit.Name = "buttonEditUnit";
            this.buttonEditUnit.Size = new System.Drawing.Size(121, 48);
            this.buttonEditUnit.TabIndex = 4;
            this.buttonEditUnit.Text = "Edit unit";
            this.buttonEditUnit.UseVisualStyleBackColor = true;
            this.buttonEditUnit.Click += new System.EventHandler(this.buttonEditUnit_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(618, 416);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(121, 48);
            this.buttonSaveChanges.TabIndex = 4;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // dataGridViewUnits
            // 
            this.dataGridViewUnits.AllowUserToAddRows = false;
            this.dataGridViewUnits.AllowUserToDeleteRows = false;
            this.dataGridViewUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUnits.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnits.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewUnits.Name = "dataGridViewUnits";
            this.dataGridViewUnits.RowHeadersWidth = 51;
            this.dataGridViewUnits.Size = new System.Drawing.Size(727, 232);
            this.dataGridViewUnits.TabIndex = 12;
            this.dataGridViewUnits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUnits_CellClick);
            // 
            // UnitsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 478);
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