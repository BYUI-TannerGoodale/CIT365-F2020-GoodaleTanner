namespace MegaDesk_Goodale
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            this.BackBtn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CustName = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DeskWidth = new System.Windows.Forms.TextBox();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DeskDepth = new System.Windows.Forms.TextBox();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.DrawersNum = new System.Windows.Forms.ComboBox();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.SurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.RushShippingLabel = new System.Windows.Forms.Label();
            this.RushShipping = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.QuoteDate = new System.Windows.Forms.Label();
            this.SubmitOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(118, 415);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(100, 23);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "&< Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(123, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Please Enter Your Name";
            // 
            // CustName
            // 
            this.CustName.Location = new System.Drawing.Point(12, 25);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(123, 20);
            this.CustName.TabIndex = 1;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(9, 62);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(103, 13);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Enter Width of Desk";
            // 
            // DeskWidth
            // 
            this.DeskWidth.Location = new System.Drawing.Point(12, 78);
            this.DeskWidth.Name = "DeskWidth";
            this.DeskWidth.Size = new System.Drawing.Size(123, 20);
            this.DeskWidth.TabIndex = 3;
            this.DeskWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskWidth_KeyPress);
            this.DeskWidth.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidth_Validating);
            this.DeskWidth.Validated += new System.EventHandler(this.DeskWidth_Validated);
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Location = new System.Drawing.Point(9, 119);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(104, 13);
            this.DepthLabel.TabIndex = 4;
            this.DepthLabel.Text = "Enter Depth of Desk";
            // 
            // DeskDepth
            // 
            this.DeskDepth.Location = new System.Drawing.Point(12, 135);
            this.DeskDepth.Name = "DeskDepth";
            this.DeskDepth.Size = new System.Drawing.Size(123, 20);
            this.DeskDepth.TabIndex = 5;
            this.DeskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskDepth_KeyPress);
            this.DeskDepth.Validating += new System.ComponentModel.CancelEventHandler(this.DeskDepth_Validating);
            this.DeskDepth.Validated += new System.EventHandler(this.DeskDepth_Validated);
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Location = new System.Drawing.Point(9, 181);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(126, 13);
            this.DrawersLabel.TabIndex = 6;
            this.DrawersLabel.Text = "Enter Number of Drawers";
            // 
            // DrawersNum
            // 
            this.DrawersNum.FormattingEnabled = true;
            this.DrawersNum.Location = new System.Drawing.Point(12, 197);
            this.DrawersNum.Name = "DrawersNum";
            this.DrawersNum.Size = new System.Drawing.Size(123, 21);
            this.DrawersNum.TabIndex = 7;
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(9, 245);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(130, 13);
            this.SurfaceMaterialLabel.TabIndex = 8;
            this.SurfaceMaterialLabel.Text = "Enter the Surface Material";
            // 
            // SurfaceMaterial
            // 
            this.SurfaceMaterial.FormattingEnabled = true;
            this.SurfaceMaterial.Location = new System.Drawing.Point(12, 261);
            this.SurfaceMaterial.Name = "SurfaceMaterial";
            this.SurfaceMaterial.Size = new System.Drawing.Size(123, 21);
            this.SurfaceMaterial.TabIndex = 9;
            // 
            // RushShippingLabel
            // 
            this.RushShippingLabel.AutoSize = true;
            this.RushShippingLabel.Location = new System.Drawing.Point(9, 307);
            this.RushShippingLabel.Name = "RushShippingLabel";
            this.RushShippingLabel.Size = new System.Drawing.Size(107, 13);
            this.RushShippingLabel.TabIndex = 10;
            this.RushShippingLabel.Text = "Select Shipping Rate";
            // 
            // RushShipping
            // 
            this.RushShipping.FormattingEnabled = true;
            this.RushShipping.Location = new System.Drawing.Point(12, 323);
            this.RushShipping.Name = "RushShipping";
            this.RushShipping.Size = new System.Drawing.Size(123, 21);
            this.RushShipping.TabIndex = 11;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quote Date";
            // 
            // QuoteDate
            // 
            this.QuoteDate.AutoSize = true;
            this.QuoteDate.Location = new System.Drawing.Point(12, 388);
            this.QuoteDate.Name = "QuoteDate";
            this.QuoteDate.Size = new System.Drawing.Size(0, 13);
            this.QuoteDate.TabIndex = 13;
            // 
            // SubmitOrder
            // 
            this.SubmitOrder.Location = new System.Drawing.Point(12, 415);
            this.SubmitOrder.Name = "SubmitOrder";
            this.SubmitOrder.Size = new System.Drawing.Size(100, 23);
            this.SubmitOrder.TabIndex = 14;
            this.SubmitOrder.Text = "Get Quote";
            this.SubmitOrder.UseVisualStyleBackColor = true;
            this.SubmitOrder.Click += new System.EventHandler(this.SubmitOrder_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.SubmitOrder);
            this.Controls.Add(this.QuoteDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RushShipping);
            this.Controls.Add(this.RushShippingLabel);
            this.Controls.Add(this.SurfaceMaterial);
            this.Controls.Add(this.SurfaceMaterialLabel);
            this.Controls.Add(this.DrawersNum);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DeskDepth);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.DeskWidth);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BackBtn);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox DeskWidth;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.TextBox DeskDepth;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.ComboBox DrawersNum;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.ComboBox SurfaceMaterial;
        private System.Windows.Forms.Label RushShippingLabel;
        private System.Windows.Forms.ComboBox RushShipping;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label QuoteDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitOrder;
    }
}