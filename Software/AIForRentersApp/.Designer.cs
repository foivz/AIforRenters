namespace AIForRentersApp
{
    partial class FormRequests
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
            this.buttonSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewIncomingRequests = new System.Windows.Forms.DataGridView();
            this.richTextBoxResponse = new System.Windows.Forms.RichTextBox();
            this.buttonEditResponse = new System.Windows.Forms.Button();
            this.buttonProperties = new System.Windows.Forms.Button();
            this.buttonEmailTemplates = new System.Windows.Forms.Button();
            this.buttonRefreshRequests = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(980, 480);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(108, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send response";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incoming requests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Draft response";
            // 
            // dataGridViewIncomingRequests
            // 
            this.dataGridViewIncomingRequests.AllowUserToAddRows = false;
            this.dataGridViewIncomingRequests.AllowUserToDeleteRows = false;
            this.dataGridViewIncomingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomingRequests.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewIncomingRequests.Name = "dataGridViewIncomingRequests";
            this.dataGridViewIncomingRequests.ReadOnly = true;
            this.dataGridViewIncomingRequests.Size = new System.Drawing.Size(1076, 191);
            this.dataGridViewIncomingRequests.TabIndex = 0;
            this.dataGridViewIncomingRequests.SelectionChanged += new System.EventHandler(this.dataGridViewIncomingRequests_SelectionChanged);
            // 
            // richTextBoxResponse
            // 
            this.richTextBoxResponse.Enabled = false;
            this.richTextBoxResponse.Location = new System.Drawing.Point(12, 284);
            this.richTextBoxResponse.Name = "richTextBoxResponse";
            this.richTextBoxResponse.Size = new System.Drawing.Size(1076, 190);
            this.richTextBoxResponse.TabIndex = 1;
            this.richTextBoxResponse.Text = "";
            // 
            // buttonEditResponse
            // 
            this.buttonEditResponse.Location = new System.Drawing.Point(877, 480);
            this.buttonEditResponse.Name = "buttonEditResponse";
            this.buttonEditResponse.Size = new System.Drawing.Size(97, 23);
            this.buttonEditResponse.TabIndex = 2;
            this.buttonEditResponse.Text = "Edit response";
            this.buttonEditResponse.UseVisualStyleBackColor = true;
            this.buttonEditResponse.Click += new System.EventHandler(this.buttonEditResponse_Click);
            // 
            // buttonProperties
            // 
            this.buttonProperties.Location = new System.Drawing.Point(1110, 40);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(121, 48);
            this.buttonProperties.TabIndex = 3;
            this.buttonProperties.Text = "Properties / units";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // buttonEmailTemplates
            // 
            this.buttonEmailTemplates.Location = new System.Drawing.Point(1110, 94);
            this.buttonEmailTemplates.Name = "buttonEmailTemplates";
            this.buttonEmailTemplates.Size = new System.Drawing.Size(121, 48);
            this.buttonEmailTemplates.TabIndex = 3;
            this.buttonEmailTemplates.Text = "Email templates";
            this.buttonEmailTemplates.UseVisualStyleBackColor = true;
            this.buttonEmailTemplates.Click += new System.EventHandler(this.buttonEmailTemplates_Click);
            // 
            // buttonRefreshRequests
            // 
            this.buttonRefreshRequests.Location = new System.Drawing.Point(1110, 183);
            this.buttonRefreshRequests.Name = "buttonRefreshRequests";
            this.buttonRefreshRequests.Size = new System.Drawing.Size(121, 48);
            this.buttonRefreshRequests.TabIndex = 3;
            this.buttonRefreshRequests.Text = "Refresh requests";
            this.buttonRefreshRequests.UseVisualStyleBackColor = true;
            this.buttonRefreshRequests.Click += new System.EventHandler(this.buttonRefreshRequests_Click);
            // 
            // FormRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 530);
            this.Controls.Add(this.buttonEditResponse);
            this.Controls.Add(this.richTextBoxResponse);
            this.Controls.Add(this.buttonRefreshRequests);
            this.Controls.Add(this.buttonEmailTemplates);
            this.Controls.Add(this.buttonProperties);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewIncomingRequests);
            this.Name = "FormRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Requests";
            this.Load += new System.EventHandler(this.FormRequests_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormRequests_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewIncomingRequests;
        private System.Windows.Forms.RichTextBox richTextBoxResponse;
        private System.Windows.Forms.Button buttonEditResponse;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonEmailTemplates;
        private System.Windows.Forms.Button buttonRefreshRequests;
    }
}

