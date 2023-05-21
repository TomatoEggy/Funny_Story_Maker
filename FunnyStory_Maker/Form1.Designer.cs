
namespace FunnyStory_Maker
{
    partial class MainWindow
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
            this.group_baseOptions = new System.Windows.Forms.GroupBox();
            this.text_end = new System.Windows.Forms.TextBox();
            this.label_end = new System.Windows.Forms.Label();
            this.check_isFinished = new System.Windows.Forms.CheckBox();
            this.label_isFinished = new System.Windows.Forms.Label();
            this.text_whenDo = new System.Windows.Forms.TextBox();
            this.label_whenDo = new System.Windows.Forms.Label();
            this.radio_Sex_women = new System.Windows.Forms.RadioButton();
            this.radio_Sex_Man = new System.Windows.Forms.RadioButton();
            this.label_Sex = new System.Windows.Forms.Label();
            this.text_whereDo = new System.Windows.Forms.TextBox();
            this.label_whereDo = new System.Windows.Forms.Label();
            this.text_whyDo = new System.Windows.Forms.TextBox();
            this.label_whyDo = new System.Windows.Forms.Label();
            this.text_unfinishedThing = new System.Windows.Forms.TextBox();
            this.label_unfinishedThing = new System.Windows.Forms.Label();
            this.text_lastTime = new System.Windows.Forms.TextBox();
            this.label_LastTime = new System.Windows.Forms.Label();
            this.text_actor = new System.Windows.Forms.TextBox();
            this.label_actor = new System.Windows.Forms.Label();
            this.group_output = new System.Windows.Forms.GroupBox();
            this.text_output = new System.Windows.Forms.TextBox();
            this.group_baseOptions.SuspendLayout();
            this.group_output.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_baseOptions
            // 
            this.group_baseOptions.Controls.Add(this.text_end);
            this.group_baseOptions.Controls.Add(this.label_end);
            this.group_baseOptions.Controls.Add(this.check_isFinished);
            this.group_baseOptions.Controls.Add(this.label_isFinished);
            this.group_baseOptions.Controls.Add(this.text_whenDo);
            this.group_baseOptions.Controls.Add(this.label_whenDo);
            this.group_baseOptions.Controls.Add(this.radio_Sex_women);
            this.group_baseOptions.Controls.Add(this.radio_Sex_Man);
            this.group_baseOptions.Controls.Add(this.label_Sex);
            this.group_baseOptions.Controls.Add(this.text_whereDo);
            this.group_baseOptions.Controls.Add(this.label_whereDo);
            this.group_baseOptions.Controls.Add(this.text_whyDo);
            this.group_baseOptions.Controls.Add(this.label_whyDo);
            this.group_baseOptions.Controls.Add(this.text_unfinishedThing);
            this.group_baseOptions.Controls.Add(this.label_unfinishedThing);
            this.group_baseOptions.Controls.Add(this.text_lastTime);
            this.group_baseOptions.Controls.Add(this.label_LastTime);
            this.group_baseOptions.Controls.Add(this.text_actor);
            this.group_baseOptions.Controls.Add(this.label_actor);
            this.group_baseOptions.Location = new System.Drawing.Point(13, 4);
            this.group_baseOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_baseOptions.Name = "group_baseOptions";
            this.group_baseOptions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_baseOptions.Size = new System.Drawing.Size(707, 421);
            this.group_baseOptions.TabIndex = 0;
            this.group_baseOptions.TabStop = false;
            this.group_baseOptions.Text = "剧情设置";
            // 
            // text_end
            // 
            this.text_end.Location = new System.Drawing.Point(405, 194);
            this.text_end.Multiline = true;
            this.text_end.Name = "text_end";
            this.text_end.Size = new System.Drawing.Size(261, 201);
            this.text_end.TabIndex = 20;
            this.text_end.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Location = new System.Drawing.Point(343, 194);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(39, 20);
            this.label_end.TabIndex = 19;
            this.label_end.Text = "结局";
            // 
            // check_isFinished
            // 
            this.check_isFinished.AutoSize = true;
            this.check_isFinished.Checked = true;
            this.check_isFinished.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check_isFinished.Location = new System.Drawing.Point(535, 155);
            this.check_isFinished.Name = "check_isFinished";
            this.check_isFinished.Size = new System.Drawing.Size(15, 14);
            this.check_isFinished.TabIndex = 18;
            this.check_isFinished.UseVisualStyleBackColor = true;
            this.check_isFinished.CheckedChanged += new System.EventHandler(this.TextChange);
            // 
            // label_isFinished
            // 
            this.label_isFinished.AutoSize = true;
            this.label_isFinished.Location = new System.Drawing.Point(417, 151);
            this.label_isFinished.Name = "label_isFinished";
            this.label_isFinished.Size = new System.Drawing.Size(99, 20);
            this.label_isFinished.TabIndex = 17;
            this.label_isFinished.Text = "是否完成事情";
            // 
            // text_whenDo
            // 
            this.text_whenDo.Location = new System.Drawing.Point(521, 95);
            this.text_whenDo.Name = "text_whenDo";
            this.text_whenDo.Size = new System.Drawing.Size(130, 27);
            this.text_whenDo.TabIndex = 16;
            this.text_whenDo.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label_whenDo
            // 
            this.label_whenDo.AutoSize = true;
            this.label_whenDo.Location = new System.Drawing.Point(417, 82);
            this.label_whenDo.Name = "label_whenDo";
            this.label_whenDo.Size = new System.Drawing.Size(84, 40);
            this.label_whenDo.TabIndex = 15;
            this.label_whenDo.Text = "完成事情\r\n使用的时间";
            // 
            // radio_Sex_women
            // 
            this.radio_Sex_women.AutoSize = true;
            this.radio_Sex_women.Location = new System.Drawing.Point(215, 95);
            this.radio_Sex_women.Name = "radio_Sex_women";
            this.radio_Sex_women.Size = new System.Drawing.Size(42, 24);
            this.radio_Sex_women.TabIndex = 14;
            this.radio_Sex_women.Text = "女";
            this.radio_Sex_women.UseVisualStyleBackColor = true;
            this.radio_Sex_women.CheckedChanged += new System.EventHandler(this.TextChange);
            // 
            // radio_Sex_Man
            // 
            this.radio_Sex_Man.AutoSize = true;
            this.radio_Sex_Man.Checked = true;
            this.radio_Sex_Man.Location = new System.Drawing.Point(127, 95);
            this.radio_Sex_Man.Name = "radio_Sex_Man";
            this.radio_Sex_Man.Size = new System.Drawing.Size(42, 24);
            this.radio_Sex_Man.TabIndex = 13;
            this.radio_Sex_Man.TabStop = true;
            this.radio_Sex_Man.Text = "男";
            this.radio_Sex_Man.UseVisualStyleBackColor = true;
            this.radio_Sex_Man.CheckedChanged += new System.EventHandler(this.TextChange);
            // 
            // label_Sex
            // 
            this.label_Sex.AutoSize = true;
            this.label_Sex.Location = new System.Drawing.Point(23, 95);
            this.label_Sex.Name = "label_Sex";
            this.label_Sex.Size = new System.Drawing.Size(84, 20);
            this.label_Sex.TabIndex = 12;
            this.label_Sex.Text = "主角的性别";
            // 
            // text_whereDo
            // 
            this.text_whereDo.Location = new System.Drawing.Point(521, 29);
            this.text_whereDo.Name = "text_whereDo";
            this.text_whereDo.Size = new System.Drawing.Size(130, 27);
            this.text_whereDo.TabIndex = 11;
            this.text_whereDo.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label_whereDo
            // 
            this.label_whereDo.AutoSize = true;
            this.label_whereDo.Location = new System.Drawing.Point(417, 16);
            this.label_whereDo.Name = "label_whereDo";
            this.label_whereDo.Size = new System.Drawing.Size(84, 40);
            this.label_whereDo.TabIndex = 10;
            this.label_whereDo.Text = "完成事情\r\n来到的场所";
            // 
            // text_whyDo
            // 
            this.text_whyDo.Location = new System.Drawing.Point(127, 347);
            this.text_whyDo.Name = "text_whyDo";
            this.text_whyDo.Size = new System.Drawing.Size(153, 27);
            this.text_whyDo.TabIndex = 9;
            this.text_whyDo.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label_whyDo
            // 
            this.label_whyDo.AutoSize = true;
            this.label_whyDo.Location = new System.Drawing.Point(23, 334);
            this.label_whyDo.Name = "label_whyDo";
            this.label_whyDo.Size = new System.Drawing.Size(84, 40);
            this.label_whyDo.TabIndex = 8;
            this.label_whyDo.Text = "要完成事情\r\n的原因";
            // 
            // text_unfinishedThing
            // 
            this.text_unfinishedThing.Location = new System.Drawing.Point(127, 261);
            this.text_unfinishedThing.Name = "text_unfinishedThing";
            this.text_unfinishedThing.Size = new System.Drawing.Size(153, 27);
            this.text_unfinishedThing.TabIndex = 5;
            this.text_unfinishedThing.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label_unfinishedThing
            // 
            this.label_unfinishedThing.AutoSize = true;
            this.label_unfinishedThing.Location = new System.Drawing.Point(23, 264);
            this.label_unfinishedThing.Name = "label_unfinishedThing";
            this.label_unfinishedThing.Size = new System.Drawing.Size(84, 20);
            this.label_unfinishedThing.TabIndex = 4;
            this.label_unfinishedThing.Text = "未完成的事";
            // 
            // text_lastTime
            // 
            this.text_lastTime.Location = new System.Drawing.Point(127, 171);
            this.text_lastTime.Name = "text_lastTime";
            this.text_lastTime.Size = new System.Drawing.Size(153, 27);
            this.text_lastTime.TabIndex = 3;
            this.text_lastTime.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label_LastTime
            // 
            this.label_LastTime.AutoSize = true;
            this.label_LastTime.Location = new System.Drawing.Point(23, 174);
            this.label_LastTime.Name = "label_LastTime";
            this.label_LastTime.Size = new System.Drawing.Size(84, 20);
            this.label_LastTime.TabIndex = 2;
            this.label_LastTime.Text = "经过的时间";
            // 
            // text_actor
            // 
            this.text_actor.Location = new System.Drawing.Point(127, 26);
            this.text_actor.Name = "text_actor";
            this.text_actor.Size = new System.Drawing.Size(153, 27);
            this.text_actor.TabIndex = 1;
            this.text_actor.TextChanged += new System.EventHandler(this.TextChange);
            // 
            // label_actor
            // 
            this.label_actor.AutoSize = true;
            this.label_actor.Location = new System.Drawing.Point(23, 29);
            this.label_actor.Name = "label_actor";
            this.label_actor.Size = new System.Drawing.Size(39, 20);
            this.label_actor.TabIndex = 0;
            this.label_actor.Text = "主角";
            // 
            // group_output
            // 
            this.group_output.Controls.Add(this.text_output);
            this.group_output.Location = new System.Drawing.Point(13, 434);
            this.group_output.Name = "group_output";
            this.group_output.Size = new System.Drawing.Size(707, 183);
            this.group_output.TabIndex = 1;
            this.group_output.TabStop = false;
            this.group_output.Text = "输出结果";
            // 
            // text_output
            // 
            this.text_output.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.text_output.Location = new System.Drawing.Point(6, 27);
            this.text_output.Multiline = true;
            this.text_output.Name = "text_output";
            this.text_output.ReadOnly = true;
            this.text_output.Size = new System.Drawing.Size(695, 139);
            this.text_output.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 629);
            this.Controls.Add(this.group_output);
            this.Controls.Add(this.group_baseOptions);
            this.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "沙雕小故事生成器";
            this.group_baseOptions.ResumeLayout(false);
            this.group_baseOptions.PerformLayout();
            this.group_output.ResumeLayout(false);
            this.group_output.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_baseOptions;
        private System.Windows.Forms.Label label_actor;
        private System.Windows.Forms.TextBox text_actor;
        private System.Windows.Forms.TextBox text_whereDo;
        private System.Windows.Forms.Label label_whereDo;
        private System.Windows.Forms.TextBox text_whyDo;
        private System.Windows.Forms.Label label_whyDo;
        private System.Windows.Forms.TextBox text_unfinishedThing;
        private System.Windows.Forms.Label label_unfinishedThing;
        private System.Windows.Forms.TextBox text_lastTime;
        private System.Windows.Forms.Label label_LastTime;
        private System.Windows.Forms.RadioButton radio_Sex_women;
        private System.Windows.Forms.RadioButton radio_Sex_Man;
        private System.Windows.Forms.Label label_Sex;
        private System.Windows.Forms.TextBox text_whenDo;
        private System.Windows.Forms.Label label_whenDo;
        private System.Windows.Forms.CheckBox check_isFinished;
        private System.Windows.Forms.Label label_isFinished;
        private System.Windows.Forms.TextBox text_end;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.GroupBox group_output;
        private System.Windows.Forms.TextBox text_output;
    }
}

