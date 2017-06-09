namespace VeraCrypt_Mounter
{
    partial class ShowCommandWindow
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
            this.richTextBoxCommand = new System.Windows.Forms.RichTextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxCommand
            // 
            this.richTextBoxCommand.Location = new System.Drawing.Point(13, 13);
            this.richTextBoxCommand.Name = "richTextBoxCommand";
            this.richTextBoxCommand.Size = new System.Drawing.Size(259, 43);
            this.richTextBoxCommand.TabIndex = 0;
            this.richTextBoxCommand.Text = "";
            this.richTextBoxCommand.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(197, 62);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "button1";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // ShowCommandWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 92);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.richTextBoxCommand);
            this.Name = "ShowCommandWindow";
            this.Text = "ShowCommandWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCommand;
        private System.Windows.Forms.Button buttonOk;
    }
}