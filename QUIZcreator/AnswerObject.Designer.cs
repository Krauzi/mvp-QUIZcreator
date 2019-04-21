namespace QUIZcreator
{
    partial class AnswerObject
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBoxAnswer = new System.Windows.Forms.CheckBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // checkBoxAnswer
            // 
            this.checkBoxAnswer.AutoSize = true;
            this.checkBoxAnswer.Location = new System.Drawing.Point(3, 5);
            this.checkBoxAnswer.Name = "checkBoxAnswer";
            this.checkBoxAnswer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswer.TabIndex = 0;
            this.checkBoxAnswer.UseVisualStyleBackColor = true;
            this.checkBoxAnswer.MouseHover += new System.EventHandler(this.checkBoxAnswer_MouseHover);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(24, 2);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(294, 20);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.MouseHover += new System.EventHandler(this.textBoxAnswer_MouseHover);
            // 
            // AnswerObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.checkBoxAnswer);
            this.Name = "AnswerObject";
            this.Size = new System.Drawing.Size(321, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAnswer;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
