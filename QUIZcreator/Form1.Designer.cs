namespace QUIZcreator
{
    partial class Form1
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
            this.treeViewQuestions = new System.Windows.Forms.TreeView();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.buttonRmAnswer = new System.Windows.Forms.Button();
            this.buttonSubmitQuestion = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHelloWorld = new System.Windows.Forms.Label();
            this.numericUDpoints = new System.Windows.Forms.NumericUpDown();
            this.labelPoints = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonClearForm = new System.Windows.Forms.Button();
            this.labelTotalPointsInfo = new System.Windows.Forms.Label();
            this.labelTotalPoints = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUDpoints)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewQuestions
            // 
            this.treeViewQuestions.Location = new System.Drawing.Point(339, 9);
            this.treeViewQuestions.Name = "treeViewQuestions";
            this.treeViewQuestions.Size = new System.Drawing.Size(311, 354);
            this.treeViewQuestions.TabIndex = 0;
            this.treeViewQuestions.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewQuestions_NodeMouseClick);
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Location = new System.Drawing.Point(150, 369);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(30, 30);
            this.buttonAddAnswer.TabIndex = 1;
            this.buttonAddAnswer.Text = "+";
            this.buttonAddAnswer.UseVisualStyleBackColor = true;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // buttonRmAnswer
            // 
            this.buttonRmAnswer.Location = new System.Drawing.Point(186, 369);
            this.buttonRmAnswer.Name = "buttonRmAnswer";
            this.buttonRmAnswer.Size = new System.Drawing.Size(30, 30);
            this.buttonRmAnswer.TabIndex = 2;
            this.buttonRmAnswer.Text = "-";
            this.buttonRmAnswer.UseVisualStyleBackColor = true;
            this.buttonRmAnswer.Click += new System.EventHandler(this.buttonRmAnswer_Click);
            // 
            // buttonSubmitQuestion
            // 
            this.buttonSubmitQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSubmitQuestion.Location = new System.Drawing.Point(222, 369);
            this.buttonSubmitQuestion.Name = "buttonSubmitQuestion";
            this.buttonSubmitQuestion.Size = new System.Drawing.Size(111, 30);
            this.buttonSubmitQuestion.TabIndex = 3;
            this.buttonSubmitQuestion.Text = "Submit question";
            this.buttonSubmitQuestion.UseVisualStyleBackColor = true;
            this.buttonSubmitQuestion.Click += new System.EventHandler(this.buttonSubmitQuestion_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLoad.Location = new System.Drawing.Point(575, 369);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 30);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(494, 369);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 30);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 107);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(321, 254);
            this.flowLayoutPanel.TabIndex = 7;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelQuestion.Location = new System.Drawing.Point(11, 36);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(103, 20);
            this.labelQuestion.TabIndex = 8;
            this.labelQuestion.Text = "Add question";
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnswer.Location = new System.Drawing.Point(12, 85);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(65, 18);
            this.labelAnswer.TabIndex = 9;
            this.labelAnswer.Text = "Answers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add/Remove answer";
            // 
            // labelHelloWorld
            // 
            this.labelHelloWorld.AutoSize = true;
            this.labelHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHelloWorld.Location = new System.Drawing.Point(98, 11);
            this.labelHelloWorld.Name = "labelHelloWorld";
            this.labelHelloWorld.Size = new System.Drawing.Size(145, 25);
            this.labelHelloWorld.TabIndex = 11;
            this.labelHelloWorld.Text = "Quiz Creator";
            // 
            // numericUDpoints
            // 
            this.numericUDpoints.Location = new System.Drawing.Point(285, 85);
            this.numericUDpoints.Name = "numericUDpoints";
            this.numericUDpoints.Size = new System.Drawing.Size(48, 20);
            this.numericUDpoints.TabIndex = 12;
            this.numericUDpoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPoints.Location = new System.Drawing.Point(143, 85);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(136, 18);
            this.labelPoints.TabIndex = 13;
            this.labelPoints.Text = "Points for question:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(12, 59);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(321, 20);
            this.textBoxQuestion.TabIndex = 14;
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.Location = new System.Drawing.Point(258, 9);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(75, 30);
            this.buttonClearForm.TabIndex = 16;
            this.buttonClearForm.Text = "Clear form";
            this.buttonClearForm.UseVisualStyleBackColor = true;
            this.buttonClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // labelTotalPointsInfo
            // 
            this.labelTotalPointsInfo.AutoSize = true;
            this.labelTotalPointsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalPointsInfo.Location = new System.Drawing.Point(339, 366);
            this.labelTotalPointsInfo.Name = "labelTotalPointsInfo";
            this.labelTotalPointsInfo.Size = new System.Drawing.Size(73, 15);
            this.labelTotalPointsInfo.TabIndex = 17;
            this.labelTotalPointsInfo.Text = "Total points:";
            // 
            // labelTotalPoints
            // 
            this.labelTotalPoints.AutoSize = true;
            this.labelTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTotalPoints.Location = new System.Drawing.Point(339, 384);
            this.labelTotalPoints.Name = "labelTotalPoints";
            this.labelTotalPoints.Size = new System.Drawing.Size(14, 15);
            this.labelTotalPoints.TabIndex = 18;
            this.labelTotalPoints.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 404);
            this.Controls.Add(this.labelTotalPoints);
            this.Controls.Add(this.labelTotalPointsInfo);
            this.Controls.Add(this.buttonClearForm);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.numericUDpoints);
            this.Controls.Add(this.labelHelloWorld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSubmitQuestion);
            this.Controls.Add(this.buttonRmAnswer);
            this.Controls.Add(this.buttonAddAnswer);
            this.Controls.Add(this.treeViewQuestions);
            this.Name = "Form1";
            this.Text = "Quiz Creator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUDpoints)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewQuestions;
        private System.Windows.Forms.Button buttonAddAnswer;
        private System.Windows.Forms.Button buttonRmAnswer;
        private System.Windows.Forms.Button buttonSubmitQuestion;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHelloWorld;
        private System.Windows.Forms.NumericUpDown numericUDpoints;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonClearForm;
        private System.Windows.Forms.Label labelTotalPointsInfo;
        private System.Windows.Forms.Label labelTotalPoints;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}

