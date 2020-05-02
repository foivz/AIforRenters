﻿namespace AIForRentersApp
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmailTemplates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmailTemplates
            // 
            this.dataGridViewEmailTemplates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmailTemplates.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewEmailTemplates.Name = "dataGridViewEmailTemplates";
            this.dataGridViewEmailTemplates.Size = new System.Drawing.Size(776, 291);
            this.dataGridViewEmailTemplates.TabIndex = 0;
            // 
            // buttonEditTemplate
            // 
            this.buttonEditTemplate.Location = new System.Drawing.Point(556, 332);
            this.buttonEditTemplate.Name = "buttonEditTemplate";
            this.buttonEditTemplate.Size = new System.Drawing.Size(109, 23);
            this.buttonEditTemplate.TabIndex = 4;
            this.buttonEditTemplate.Text = "Edit template";
            this.buttonEditTemplate.UseVisualStyleBackColor = true;
            // 
            // richTextBoxEditEmailTemplate
            // 
            this.richTextBoxEditEmailTemplate.Location = new System.Drawing.Point(12, 406);
            this.richTextBoxEditEmailTemplate.Name = "richTextBoxEditEmailTemplate";
            this.richTextBoxEditEmailTemplate.Size = new System.Drawing.Size(775, 266);
            this.richTextBoxEditEmailTemplate.TabIndex = 2;
            this.richTextBoxEditEmailTemplate.Text = "";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(556, 361);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(109, 23);
            this.buttonSaveChanges.TabIndex = 5;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // buttonAddTemplate
            // 
            this.buttonAddTemplate.Location = new System.Drawing.Point(671, 332);
            this.buttonAddTemplate.Name = "buttonAddTemplate";
            this.buttonAddTemplate.Size = new System.Drawing.Size(117, 23);
            this.buttonAddTemplate.TabIndex = 3;
            this.buttonAddTemplate.Text = "Add new template";
            this.buttonAddTemplate.UseVisualStyleBackColor = true;
            // 
            // textBoxTemplateName
            // 
            this.textBoxTemplateName.Location = new System.Drawing.Point(98, 380);
            this.textBoxTemplateName.Name = "textBoxTemplateName";
            this.textBoxTemplateName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemplateName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Template name";
            // 
            // EmailTemplatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTemplateName);
            this.Controls.Add(this.richTextBoxEditEmailTemplate);
            this.Controls.Add(this.buttonAddTemplate);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.buttonEditTemplate);
            this.Controls.Add(this.dataGridViewEmailTemplates);
            this.Name = "EmailTemplatesForm";
            this.Text = "Email templates";
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
    }
}