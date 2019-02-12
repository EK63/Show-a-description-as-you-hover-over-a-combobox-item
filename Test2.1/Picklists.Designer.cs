namespace Test2._1
{
    partial class Picklist
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
            this.lblPickListValue = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPickList = new System.Windows.Forms.Label();
            this.cboPickList = new Custom.PickListComboBox();
            this.SuspendLayout();
            // 
            // lblPickListValue
            // 
            this.lblPickListValue.AutoSize = true;
            this.lblPickListValue.Location = new System.Drawing.Point(123, 196);
            this.lblPickListValue.Name = "lblPickListValue";
            this.lblPickListValue.Size = new System.Drawing.Size(13, 13);
            this.lblPickListValue.TabIndex = 0;
            this.lblPickListValue.Text = "?";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(434, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "E&xit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblPickList
            // 
            this.lblPickList.AutoSize = true;
            this.lblPickList.Location = new System.Drawing.Point(12, 20);
            this.lblPickList.Name = "lblPickList";
            this.lblPickList.Size = new System.Drawing.Size(78, 13);
            this.lblPickList.TabIndex = 9;
            this.lblPickList.Text = "Choose a topic";
            // 
            // cboPickList
            // 
            this.cboPickList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPickList.FormattingEnabled = true;
            this.cboPickList.Location = new System.Drawing.Point(126, 12);
            this.cboPickList.Name = "cboPickList";
            this.cboPickList.Size = new System.Drawing.Size(242, 21);
            this.cboPickList.TabIndex = 7;
            this.cboPickList.Hover += new Custom.HoverEventHandler(this.cboUtility_Hover);
            // 
            // Picklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 282);
            this.Controls.Add(this.lblPickList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboPickList);
            this.Controls.Add(this.lblPickListValue);
            this.Name = "Picklist";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.PickListComboBox cboPickList;
        private System.Windows.Forms.Label lblPickListValue;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPickList;
        //private System.Windows.Forms.ComboBox cboUtility;
    }
}

