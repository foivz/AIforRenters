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
            this.dataGridViewEmailTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmailTemplates.Location = new System.Drawing.Point(16, 28);
            this.dataGridViewEmailTemplates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEmailTemplates.Name = "dataGridViewEmailTemplates";
            this.dataGridViewEmailTemplates.RowHeadersWidth = 51;
            this.dataGridViewEmailTemplates.Size = new System.Drawing.Size(1035, 358);
            this.dataGridViewEmailTemplates.TabIndex = 0;
            this.dataGridViewEmailTemplates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmailTemplates_CellClick);
            // 
            // buttonEditTemplate
            // 
            this.buttonEditTemplate.Location = new System.Drawing.Point(741, 409);
            this.buttonEditTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditTemplate.Name = "buttonEditTemplate";
            this.buttonEditTemplate.Size = new System.Drawing.Size(145, 28);
            this.buttonEditTemplate.TabIndex = 4;
            this.buttonEditTemplate.Text = "Edit template";
            this.buttonEditTemplate.UseVisualStyleBackColor = true;
            this.buttonEditTemplate.Click += new System.EventHandler(this.buttonEditTemplate_Click);
            // 
            // richTextBoxEditEmailTemplate
            // 
            this.richTextBoxEditEmailTemplate.Location = new System.Drawing.Point(16, 500);
            this.richTextBoxEditEmailTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxEditEmailTemplate.Name = "richTextBoxEditEmailTemplate";
            this.richTextBoxEditEmailTemplate.Size = new System.Drawing.Size(1032, 326);
            this.richTextBoxEditEmailTemplate.TabIndex = 2;
            this.richTextBoxEditEmailTemplate.Text = "";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(741, 444);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(145, 28);
            this.buttonSaveChanges.TabIndex = 5;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // buttonAddTemplate
            // 
            this.buttonAddTemplate.Location = new System.Drawing.Point(895, 409);
            this.buttonAddTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTemplate.Name = "buttonAddTemplate";
            this.buttonAddTemplate.Size = new System.Drawing.Size(156, 28);
            this.buttonAddTemplate.TabIndex = 3;
            this.buttonAddTemplate.Text = "Add new template";
            this.buttonAddTemplate.UseVisualStyleBackColor = true;
            this.buttonAddTemplate.Click += new System.EventHandler(this.buttonAddTemplate_Click);
            // 
            // textBoxTemplateName
            // 
            this.textBoxTemplateName.Location = new System.Drawing.Point(131, 468);
            this.textBoxTemplateName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTemplateName.Name = "textBoxTemplateName";
            this.textBoxTemplateName.Size = new System.Drawing.Size(132, 22);
            this.textBoxTemplateName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Template name";
            // 
            // buttonProperties
            // 
            this.buttonProperties.Location = new System.Drawing.Point(1091, 95);
            this.buttonProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(161, 59);
            this.buttonProperties.TabIndex = 8;
            this.buttonProperties.Text = "Properties / units";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // buttonRequests
            // 
            this.buttonRequests.Location = new System.Drawing.Point(1091, 28);
            this.buttonRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(161, 59);
            this.buttonRequests.TabIndex = 9;
            this.buttonRequests.Text = "Requests / responses";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonDeleteTemplate
            // 
            this.buttonDeleteTemplate.Location = new System.Drawing.Point(588, 409);
            this.buttonDeleteTemplate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteTemplate.Name = "buttonDeleteTemplate";
            this.buttonDeleteTemplate.Size = new System.Drawing.Size(145, 28);
            this.buttonDeleteTemplate.TabIndex = 4;
            this.buttonDeleteTemplate.Text = "Delete template";
            this.buttonDeleteTemplate.UseVisualStyleBackColor = true;
            this.buttonDeleteTemplate.Click += new System.EventHandler(this.buttonDeleteTemplate_Click);
            // 
            // EmailTemplatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 842);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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