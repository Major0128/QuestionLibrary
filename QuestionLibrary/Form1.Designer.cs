namespace QuestionLibrary
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionContent = new System.Windows.Forms.Label();
            this.Btn_NextQuestion = new System.Windows.Forms.Button();
            this.OptionList = new System.Windows.Forms.CheckedListBox();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionContent
            // 
            this.QuestionContent.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QuestionContent.Location = new System.Drawing.Point(97, 35);
            this.QuestionContent.Name = "QuestionContent";
            this.QuestionContent.Size = new System.Drawing.Size(400, 174);
            this.QuestionContent.TabIndex = 0;
            this.QuestionContent.Text = "label1";
            this.QuestionContent.Click += new System.EventHandler(this.label1_Click);
            // 
            // Btn_NextQuestion
            // 
            this.Btn_NextQuestion.Location = new System.Drawing.Point(583, 12);
            this.Btn_NextQuestion.Name = "Btn_NextQuestion";
            this.Btn_NextQuestion.Size = new System.Drawing.Size(75, 23);
            this.Btn_NextQuestion.TabIndex = 1;
            this.Btn_NextQuestion.Text = "下一题";
            this.Btn_NextQuestion.UseVisualStyleBackColor = true;
            this.Btn_NextQuestion.Click += new System.EventHandler(this.Btn_NextQuestion_Click);
            // 
            // OptionList
            // 
            this.OptionList.CheckOnClick = true;
            this.OptionList.FormattingEnabled = true;
            this.OptionList.Location = new System.Drawing.Point(101, 212);
            this.OptionList.Name = "OptionList";
            this.OptionList.Size = new System.Drawing.Size(396, 180);
            this.OptionList.TabIndex = 2;
            this.OptionList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OptionList_ItemCheck);
            this.OptionList.SelectedIndexChanged += new System.EventHandler(this.OptionList_SelectedIndexChanged);
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("宋体", 10.5F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Message.ForeColor = System.Drawing.Color.Red;
            this.Message.Location = new System.Drawing.Point(101, 412);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(396, 41);
            this.Message.TabIndex = 3;
            this.Message.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.OptionList);
            this.Controls.Add(this.Btn_NextQuestion);
            this.Controls.Add(this.QuestionContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label QuestionContent;
        private System.Windows.Forms.Button Btn_NextQuestion;
        private System.Windows.Forms.CheckedListBox OptionList;
        private System.Windows.Forms.Label Message;
    }
}

