namespace MegaDesk_Goodale
{
    partial class MainMenu
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SearchQuotesBtn = new System.Windows.Forms.Button();
            this.ViewQuotesBtn = new System.Windows.Forms.Button();
            this.AddQuoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(12, 99);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(100, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SearchQuotesBtn
            // 
            this.SearchQuotesBtn.Location = new System.Drawing.Point(12, 70);
            this.SearchQuotesBtn.Name = "SearchQuotesBtn";
            this.SearchQuotesBtn.Size = new System.Drawing.Size(100, 23);
            this.SearchQuotesBtn.TabIndex = 6;
            this.SearchQuotesBtn.Text = "Search Quotes";
            this.SearchQuotesBtn.UseVisualStyleBackColor = true;
            this.SearchQuotesBtn.Click += new System.EventHandler(this.SearchQuotesBtn_Click);
            // 
            // ViewQuotesBtn
            // 
            this.ViewQuotesBtn.Location = new System.Drawing.Point(12, 41);
            this.ViewQuotesBtn.Name = "ViewQuotesBtn";
            this.ViewQuotesBtn.Size = new System.Drawing.Size(100, 23);
            this.ViewQuotesBtn.TabIndex = 5;
            this.ViewQuotesBtn.Text = "&View Quotes";
            this.ViewQuotesBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
            // 
            // AddQuoteBtn
            // 
            this.AddQuoteBtn.Location = new System.Drawing.Point(12, 12);
            this.AddQuoteBtn.Name = "AddQuoteBtn";
            this.AddQuoteBtn.Size = new System.Drawing.Size(100, 23);
            this.AddQuoteBtn.TabIndex = 4;
            this.AddQuoteBtn.Text = "Add New Quote";
            this.AddQuoteBtn.UseVisualStyleBackColor = true;
            this.AddQuoteBtn.Click += new System.EventHandler(this.AddQuoteBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.SearchQuotesBtn);
            this.Controls.Add(this.ViewQuotesBtn);
            this.Controls.Add(this.AddQuoteBtn);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button SearchQuotesBtn;
        private System.Windows.Forms.Button ViewQuotesBtn;
        private System.Windows.Forms.Button AddQuoteBtn;
    }
}

