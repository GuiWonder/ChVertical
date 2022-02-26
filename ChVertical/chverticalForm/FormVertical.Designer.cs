
namespace chvertical
{
    partial class FormVertical
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
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.numericUpDownx = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowny = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTC = new System.Windows.Forms.ComboBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFont = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowny)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxOut
            // 
            this.textBoxOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut.Location = new System.Drawing.Point(3, 298);
            this.textBoxOut.MaxLength = 0;
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut.Size = new System.Drawing.Size(658, 260);
            this.textBoxOut.TabIndex = 1;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConvert.Location = new System.Drawing.Point(465, 3);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(53, 24);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "开始";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.Convert_Click);
            // 
            // numericUpDownx
            // 
            this.numericUpDownx.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownx.Location = new System.Drawing.Point(69, 4);
            this.numericUpDownx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownx.Name = "numericUpDownx";
            this.numericUpDownx.Size = new System.Drawing.Size(60, 21);
            this.numericUpDownx.TabIndex = 3;
            this.numericUpDownx.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDowny
            // 
            this.numericUpDowny.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDowny.Location = new System.Drawing.Point(201, 4);
            this.numericUpDowny.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDowny.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDowny.Name = "numericUpDowny";
            this.numericUpDowny.Size = new System.Drawing.Size(60, 21);
            this.numericUpDowny.TabIndex = 4;
            this.numericUpDowny.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBoxTC
            // 
            this.comboBoxTC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTC.FormattingEnabled = true;
            this.comboBoxTC.Items.AddRange(new object[] {
            "粗实线+细实",
            "双实线+细实",
            "细实线+细虚",
            "蝌蚪往回游",
            "一切向上看",
            "清风竹节型",
            "密码错乱型",
            "红星闪闪型",
            "霓虹灯闪烁",
            "我心依旧型",
            "大圈套小圈",
            "鱼儿水中游",
            "阿米佗佛型",
            "清爽空白型"});
            this.comboBoxTC.Location = new System.Drawing.Point(267, 5);
            this.comboBoxTC.Name = "comboBoxTC";
            this.comboBoxTC.Size = new System.Drawing.Size(106, 20);
            this.comboBoxTC.TabIndex = 5;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCopy.Location = new System.Drawing.Point(524, 3);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(73, 24);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "拷贝结果";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(379, 7);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "转换为繁体";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxIn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOut, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(664, 561);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // textBoxIn
            // 
            this.textBoxIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIn.Location = new System.Drawing.Point(3, 3);
            this.textBoxIn.MaxLength = 0;
            this.textBoxIn.Multiline = true;
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn.Size = new System.Drawing.Size(658, 259);
            this.textBoxIn.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownx, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonConvert, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCopy, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDowny, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxTC, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonFont, 8, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 265);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "每页列数";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "每列字数";
            // 
            // buttonFont
            // 
            this.buttonFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFont.Location = new System.Drawing.Point(603, 3);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(58, 24);
            this.buttonFont.TabIndex = 9;
            this.buttonFont.Text = "字体";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // FormVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormVertical";
            this.Text = "文字竖排转换器";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowny)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.NumericUpDown numericUpDownx;
        private System.Windows.Forms.NumericUpDown numericUpDowny;
        private System.Windows.Forms.ComboBox comboBoxTC;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFont;
        private System.Windows.Forms.FontDialog fontDialog;
    }
}

