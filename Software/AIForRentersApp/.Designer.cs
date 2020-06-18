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
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncomingRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.White;
            this.buttonSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSend.Location = new System.Drawing.Point(1110, 548);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(121, 48);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send response";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Incoming requests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rubik", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Draft response";
            // 
            // dataGridViewIncomingRequests
            // 
            this.dataGridViewIncomingRequests.AllowUserToAddRows = false;
            this.dataGridViewIncomingRequests.AllowUserToDeleteRows = false;
            this.dataGridViewIncomingRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewIncomingRequests.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewIncomingRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewIncomingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncomingRequests.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewIncomingRequests.Name = "dataGridViewIncomingRequests";
            this.dataGridViewIncomingRequests.ReadOnly = true;
            this.dataGridViewIncomingRequests.Size = new System.Drawing.Size(1076, 312);
            this.dataGridViewIncomingRequests.TabIndex = 0;
            this.dataGridViewIncomingRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewIncomingRequests_CellClick);
            this.dataGridViewIncomingRequests.SelectionChanged += new System.EventHandler(this.dataGridViewIncomingRequests_SelectionChanged);
            // 
            // richTextBoxResponse
            // 
            this.richTextBoxResponse.BackColor = System.Drawing.Color.White;
            this.richTextBoxResponse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResponse.Enabled = false;
            this.richTextBoxResponse.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxResponse.Location = new System.Drawing.Point(12, 406);
            this.richTextBoxResponse.Name = "richTextBoxResponse";
            this.richTextBoxResponse.Size = new System.Drawing.Size(1076, 190);
            this.richTextBoxResponse.TabIndex = 1;
            this.richTextBoxResponse.Text = "";
            // 
            // buttonEditResponse
            // 
            this.buttonEditResponse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditResponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditResponse.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditResponse.Location = new System.Drawing.Point(1110, 406);
            this.buttonEditResponse.Name = "buttonEditResponse";
            this.buttonEditResponse.Size = new System.Drawing.Size(121, 48);
            this.buttonEditResponse.TabIndex = 2;
            this.buttonEditResponse.Text = "Edit response";
            this.buttonEditResponse.UseVisualStyleBackColor = true;
            this.buttonEditResponse.Click += new System.EventHandler(this.buttonEditResponse_Click);
            // 
            // buttonProperties
            // 
            this.buttonProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProperties.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonEmailTemplates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEmailTemplates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmailTemplates.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonRefreshRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshRequests.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefreshRequests.Location = new System.Drawing.Point(1110, 304);
            this.buttonRefreshRequests.Name = "buttonRefreshRequests";
            this.buttonRefreshRequests.Size = new System.Drawing.Size(121, 48);
            this.buttonRefreshRequests.TabIndex = 3;
            this.buttonRefreshRequests.Text = "Refresh requests";
            this.buttonRefreshRequests.UseVisualStyleBackColor = true;
            this.buttonRefreshRequests.Click += new System.EventHandler(this.buttonRefreshRequests_Click);
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveChanges.Font = new System.Drawing.Font("Rubik", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveChanges.Location = new System.Drawing.Point(1110, 460);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(121, 48);
            this.buttonSaveChanges.TabIndex = 6;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // FormRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 619);
            this.Controls.Add(this.buttonSaveChanges);
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
        private System.Windows.Forms.Button buttonSaveChanges;
    }
}

