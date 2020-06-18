namespace AIForRentersApp
{
    partial class EmailTemplatesForm
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
            this.dataGridViewEmailTemplates = new System.Windows.Forms.DataGridView();
            this.buttonEditTemplate = new System.Windows.Forms.Button();
            this.richTextBoxEditEmailTemplate = new System.Windows.Forms.RichTextBox();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.buttonAddTemplate = new System.Windows.Forms.Button();
            this.textBoxTemplateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonProperties = new System.Windows.Forms.Button();
            this.buttonRequests = new System.Windows.Forms.Button();
            this.buttonDeleteTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmailTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmailTemplates
            // 
            this.dataGridViewEmailTemplates.AllowUserToAddRows = false;
            this.dataGridViewEmailTemplates.AllowUserToDeleteRows = false;
            this.dataGridViewEmailTemplates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmailTemplates.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmailTemplates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmailTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmailTemplates.Location = new System.Drawing.Point(12, 77);
            this.dataGridViewEmailTemplates.Name = "dataGridViewEmailTemplates";
            this.dataGridViewEmailTemplates.RowHeadersWidth = 51;
            this.dataGridViewEmailTemplates.Size = new System.Drawing.Size(927, 180);
            this.dataGridViewEmailTemplates.TabIndex = 0;
            this.dataGridViewEmailTemplates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmailTemplates_CellClick);
            // 
            // buttonEditTemplate
            // 
            this.buttonEditTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditTemplate.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTemplate.Location = new System.Drawing.Point(565, 527);
            this.buttonEditTemplate.Name = "buttonEditTemplate";
            this.buttonEditTemplate.Size = new System.Drawing.Size(120, 48);
            this.buttonEditTemplate.TabIndex = 4;
            this.buttonEditTemplate.Text = "Edit template";
            this.buttonEditTemplate.UseVisualStyleBackColor = true;
            this.buttonEditTemplate.Click += new System.EventHandler(this.buttonEditTemplate_Click);
            // 
            // richTextBoxEditEmailTemplate
            // 
            this.richTextBoxEditEmailTemplate.Location = new System.Drawing.Point(12, 276);
            this.richTextBoxEditEmailTemplate.Name = "richTextBoxEditEmailTemplate";
            this.richTextBoxEditEmailTemplate.Size = new System.Drawing.Size(927, 230);
            this.richTextBoxEditEmailTemplate.TabIndex = 2;
            this.richTextBoxEditEmailTemplate.Text = "";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(818, 527);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(120, 48);
            this.buttonSaveChanges.TabIndex = 5;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonAddTemplate
            // 
            this.buttonAddTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTemplate.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTemplate.Location = new System.Drawing.Point(439, 527);
            this.buttonAddTemplate.Name = "buttonAddTemplate";
            this.buttonAddTemplate.Size = new System.Drawing.Size(120, 48);
            this.buttonAddTemplate.TabIndex = 3;
            this.buttonAddTemplate.Text = "Add new template";
            this.buttonAddTemplate.UseVisualStyleBackColor = true;
            this.buttonAddTemplate.Click += new System.EventHandler(this.buttonAddTemplate_Click);
            // 
            // textBoxTemplateName
            // 
            this.textBoxTemplateName.Location = new System.Drawing.Point(12, 555);
            this.textBoxTemplateName.Name = "textBoxTemplateName";
            this.textBoxTemplateName.Size = new System.Drawing.Size(296, 20);
            this.textBoxTemplateName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Template name";
            // 
            // buttonProperties
            // 
            this.buttonProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProperties.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProperties.Location = new System.Drawing.Point(691, 15);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(121, 48);
            this.buttonProperties.TabIndex = 8;
            this.buttonProperties.Text = "Properties / units";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // buttonRequests
            // 
            this.buttonRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequests.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRequests.Location = new System.Drawing.Point(818, 15);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(121, 48);
            this.buttonRequests.TabIndex = 9;
            this.buttonRequests.Text = "Requests / responses";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonDeleteTemplate
            // 
            this.buttonDeleteTemplate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTemplate.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteTemplate.Location = new System.Drawing.Point(691, 527);
            this.buttonDeleteTemplate.Name = "buttonDeleteTemplate";
            this.buttonDeleteTemplate.Size = new System.Drawing.Size(121, 48);
            this.buttonDeleteTemplate.TabIndex = 4;
            this.buttonDeleteTemplate.Text = "Delete template";
            this.buttonDeleteTemplate.UseVisualStyleBackColor = true;
            this.buttonDeleteTemplate.Click += new System.EventHandler(this.buttonDeleteTemplate_Click);
            // 
            // EmailTemplatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 596);
            this.Controls.Add(this.buttonProperties);
            this.Controls.Add(this.buttonRequests);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTemplateName);
            this.Controls.Add(this.richTextBoxEditEmailTemplate);
            this.Controls.Add(this.buttonAddTemplate);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonDeleteTemplate);
            this.Controls.Add(this.buttonEditTemplate);
            this.Controls.Add(this.dataGridViewEmailTemplates);
            this.Name = "EmailTemplatesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email templates";
            this.Load += new System.EventHandler(this.EmailTemplatesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EmailTemplatesForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmailTemplates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmailTemplates;
        private System.Windows.Forms.Button buttonEditTemplate;
        private System.Windows.Forms.RichTextBox richTextBoxEditEmailTemplate;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.Button buttonAddTemplate;
        private System.Windows.Forms.TextBox textBoxTemplateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonRequests;
        private System.Windows.Forms.Button buttonDeleteTemplate;
    }
}