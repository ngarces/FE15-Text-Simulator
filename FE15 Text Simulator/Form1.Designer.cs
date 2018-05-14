namespace FE15TextSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox_Text1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Name = new System.Windows.Forms.RichTextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_Left = new System.Windows.Forms.ComboBox();
            this.comboBox_Mid = new System.Windows.Forms.ComboBox();
            this.comboBox_Right = new System.Windows.Forms.ComboBox();
            this.label_Left = new System.Windows.Forms.Label();
            this.label_Mid = new System.Windows.Forms.Label();
            this.label_Right = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ExpressionsLeft = new System.Windows.Forms.ComboBox();
            this.comboBox_ExpressionsMid = new System.Windows.Forms.ComboBox();
            this.comboBox_ExpressionsRight = new System.Windows.Forms.ComboBox();
            this.checkBox_DarkenL = new System.Windows.Forms.CheckBox();
            this.checkBox_DarkenM = new System.Windows.Forms.CheckBox();
            this.checkBox_DarkenR = new System.Windows.Forms.CheckBox();
            this.checkBox_Arrow = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_Line1 = new System.Windows.Forms.Label();
            this.label_Line2 = new System.Windows.Forms.Label();
            this.richTextBox_Text2 = new System.Windows.Forms.RichTextBox();
            this.comboBox_Background = new System.Windows.Forms.ComboBox();
            this.label_Background = new System.Windows.Forms.Label();
            this.checkBox_HideText = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox_Text1
            // 
            this.richTextBox_Text1.Location = new System.Drawing.Point(56, 384);
            this.richTextBox_Text1.Multiline = false;
            this.richTextBox_Text1.Name = "richTextBox_Text1";
            this.richTextBox_Text1.Size = new System.Drawing.Size(340, 20);
            this.richTextBox_Text1.TabIndex = 2;
            this.richTextBox_Text1.Text = "Enter text";
            this.richTextBox_Text1.TextChanged += new System.EventHandler(this.richTextBox_Text1_TextChanged);
            // 
            // richTextBox_Name
            // 
            this.richTextBox_Name.Location = new System.Drawing.Point(17, 358);
            this.richTextBox_Name.Multiline = false;
            this.richTextBox_Name.Name = "richTextBox_Name";
            this.richTextBox_Name.Size = new System.Drawing.Size(118, 20);
            this.richTextBox_Name.TabIndex = 3;
            this.richTextBox_Name.Text = "Name";
            this.richTextBox_Name.TextChanged += new System.EventHandler(this.richTextBox_Name_TextChanged);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(17, 433);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 5;
            this.button_Save.Text = "Save Image";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_Left
            // 
            this.comboBox_Left.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Left.FormattingEnabled = true;
            this.comboBox_Left.Location = new System.Drawing.Point(17, 268);
            this.comboBox_Left.Name = "comboBox_Left";
            this.comboBox_Left.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Left.TabIndex = 6;
            this.comboBox_Left.SelectedIndexChanged += new System.EventHandler(this.comboBox_Left_SelectedIndexChanged);
            // 
            // comboBox_Mid
            // 
            this.comboBox_Mid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Mid.FormattingEnabled = true;
            this.comboBox_Mid.Location = new System.Drawing.Point(146, 268);
            this.comboBox_Mid.Name = "comboBox_Mid";
            this.comboBox_Mid.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Mid.TabIndex = 7;
            this.comboBox_Mid.SelectedIndexChanged += new System.EventHandler(this.comboBox_Mid_SelectedIndexChanged);
            // 
            // comboBox_Right
            // 
            this.comboBox_Right.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Right.FormattingEnabled = true;
            this.comboBox_Right.Location = new System.Drawing.Point(275, 268);
            this.comboBox_Right.Name = "comboBox_Right";
            this.comboBox_Right.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Right.TabIndex = 8;
            this.comboBox_Right.SelectedIndexChanged += new System.EventHandler(this.comboBox_Right_SelectedIndexChanged);
            // 
            // label_Left
            // 
            this.label_Left.AutoSize = true;
            this.label_Left.Location = new System.Drawing.Point(14, 248);
            this.label_Left.Name = "label_Left";
            this.label_Left.Size = new System.Drawing.Size(25, 13);
            this.label_Left.TabIndex = 9;
            this.label_Left.Text = "Left";
            // 
            // label_Mid
            // 
            this.label_Mid.AutoSize = true;
            this.label_Mid.Location = new System.Drawing.Point(143, 248);
            this.label_Mid.Name = "label_Mid";
            this.label_Mid.Size = new System.Drawing.Size(38, 13);
            this.label_Mid.TabIndex = 10;
            this.label_Mid.Text = "Middle";
            // 
            // label_Right
            // 
            this.label_Right.AutoSize = true;
            this.label_Right.Location = new System.Drawing.Point(272, 248);
            this.label_Right.Name = "label_Right";
            this.label_Right.Size = new System.Drawing.Size(32, 13);
            this.label_Right.TabIndex = 11;
            this.label_Right.Text = "Right";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Expressions";
            // 
            // comboBox_ExpressionsLeft
            // 
            this.comboBox_ExpressionsLeft.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ExpressionsLeft.FormattingEnabled = true;
            this.comboBox_ExpressionsLeft.Location = new System.Drawing.Point(17, 308);
            this.comboBox_ExpressionsLeft.Name = "comboBox_ExpressionsLeft";
            this.comboBox_ExpressionsLeft.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ExpressionsLeft.TabIndex = 13;
            this.comboBox_ExpressionsLeft.SelectedIndexChanged += new System.EventHandler(this.comboBox_ExpressionsLeft_SelectedIndexChanged);
            // 
            // comboBox_ExpressionsMid
            // 
            this.comboBox_ExpressionsMid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ExpressionsMid.FormattingEnabled = true;
            this.comboBox_ExpressionsMid.Location = new System.Drawing.Point(146, 308);
            this.comboBox_ExpressionsMid.Name = "comboBox_ExpressionsMid";
            this.comboBox_ExpressionsMid.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ExpressionsMid.TabIndex = 14;
            this.comboBox_ExpressionsMid.SelectedIndexChanged += new System.EventHandler(this.comboBox_ExpressionsMid_SelectedIndexChanged);
            // 
            // comboBox_ExpressionsRight
            // 
            this.comboBox_ExpressionsRight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ExpressionsRight.FormattingEnabled = true;
            this.comboBox_ExpressionsRight.Location = new System.Drawing.Point(275, 308);
            this.comboBox_ExpressionsRight.Name = "comboBox_ExpressionsRight";
            this.comboBox_ExpressionsRight.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ExpressionsRight.TabIndex = 15;
            this.comboBox_ExpressionsRight.SelectedIndexChanged += new System.EventHandler(this.comboBox_ExpressionsRight_SelectedIndexChanged);
            // 
            // checkBox_DarkenL
            // 
            this.checkBox_DarkenL.AutoSize = true;
            this.checkBox_DarkenL.Location = new System.Drawing.Point(17, 335);
            this.checkBox_DarkenL.Name = "checkBox_DarkenL";
            this.checkBox_DarkenL.Size = new System.Drawing.Size(61, 17);
            this.checkBox_DarkenL.TabIndex = 16;
            this.checkBox_DarkenL.Text = "Darken";
            this.checkBox_DarkenL.UseVisualStyleBackColor = true;
            this.checkBox_DarkenL.Click += new System.EventHandler(this.checkBox_DarkenL_Click);
            // 
            // checkBox_DarkenM
            // 
            this.checkBox_DarkenM.AutoSize = true;
            this.checkBox_DarkenM.Location = new System.Drawing.Point(146, 335);
            this.checkBox_DarkenM.Name = "checkBox_DarkenM";
            this.checkBox_DarkenM.Size = new System.Drawing.Size(61, 17);
            this.checkBox_DarkenM.TabIndex = 18;
            this.checkBox_DarkenM.Text = "Darken";
            this.checkBox_DarkenM.UseVisualStyleBackColor = true;
            this.checkBox_DarkenM.CheckedChanged += new System.EventHandler(this.checkBox_DarkenM_CheckedChanged);
            // 
            // checkBox_DarkenR
            // 
            this.checkBox_DarkenR.AutoSize = true;
            this.checkBox_DarkenR.Location = new System.Drawing.Point(275, 335);
            this.checkBox_DarkenR.Name = "checkBox_DarkenR";
            this.checkBox_DarkenR.Size = new System.Drawing.Size(61, 17);
            this.checkBox_DarkenR.TabIndex = 20;
            this.checkBox_DarkenR.Text = "Darken";
            this.checkBox_DarkenR.UseVisualStyleBackColor = true;
            this.checkBox_DarkenR.CheckedChanged += new System.EventHandler(this.checkBox_DarkenR_CheckedChanged);
            // 
            // checkBox_Arrow
            // 
            this.checkBox_Arrow.AutoSize = true;
            this.checkBox_Arrow.Location = new System.Drawing.Point(343, 433);
            this.checkBox_Arrow.Name = "checkBox_Arrow";
            this.checkBox_Arrow.Size = new System.Drawing.Size(53, 17);
            this.checkBox_Arrow.TabIndex = 22;
            this.checkBox_Arrow.Text = "Arrow";
            this.checkBox_Arrow.UseVisualStyleBackColor = true;
            this.checkBox_Arrow.CheckedChanged += new System.EventHandler(this.checkBox_Arrow_CheckedChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.InitialImage = global::FE15TextSimulator.Properties.Resources.TextBox;
            this.pictureBox.Location = new System.Drawing.Point(7, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 240);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_Line1
            // 
            this.label_Line1.AutoSize = true;
            this.label_Line1.Location = new System.Drawing.Point(14, 387);
            this.label_Line1.Name = "label_Line1";
            this.label_Line1.Size = new System.Drawing.Size(36, 13);
            this.label_Line1.TabIndex = 24;
            this.label_Line1.Text = "Line 1";
            // 
            // label_Line2
            // 
            this.label_Line2.AutoSize = true;
            this.label_Line2.Location = new System.Drawing.Point(14, 410);
            this.label_Line2.Name = "label_Line2";
            this.label_Line2.Size = new System.Drawing.Size(36, 13);
            this.label_Line2.TabIndex = 25;
            this.label_Line2.Text = "Line 2";
            // 
            // richTextBox_Text2
            // 
            this.richTextBox_Text2.Location = new System.Drawing.Point(56, 407);
            this.richTextBox_Text2.Multiline = false;
            this.richTextBox_Text2.Name = "richTextBox_Text2";
            this.richTextBox_Text2.Size = new System.Drawing.Size(340, 20);
            this.richTextBox_Text2.TabIndex = 26;
            this.richTextBox_Text2.Text = "";
            this.richTextBox_Text2.TextChanged += new System.EventHandler(this.richTextBox_Text2_TextChanged);
            // 
            // comboBox_Background
            // 
            this.comboBox_Background.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Background.FormattingEnabled = true;
            this.comboBox_Background.Location = new System.Drawing.Point(244, 357);
            this.comboBox_Background.Name = "comboBox_Background";
            this.comboBox_Background.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Background.TabIndex = 27;
            this.comboBox_Background.SelectedIndexChanged += new System.EventHandler(this.comboBox_Background_SelectedIndexChanged);
            // 
            // label_Background
            // 
            this.label_Background.AutoSize = true;
            this.label_Background.Location = new System.Drawing.Point(173, 361);
            this.label_Background.Name = "label_Background";
            this.label_Background.Size = new System.Drawing.Size(65, 13);
            this.label_Background.TabIndex = 28;
            this.label_Background.Text = "Background";
            // 
            // checkBox_HideText
            // 
            this.checkBox_HideText.AutoSize = true;
            this.checkBox_HideText.Location = new System.Drawing.Point(244, 433);
            this.checkBox_HideText.Name = "checkBox_HideText";
            this.checkBox_HideText.Size = new System.Drawing.Size(93, 17);
            this.checkBox_HideText.TabIndex = 29;
            this.checkBox_HideText.Text = "Hide Text Box";
            this.checkBox_HideText.UseVisualStyleBackColor = true;
            this.checkBox_HideText.CheckedChanged += new System.EventHandler(this.checkBox_HideText_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 461);
            this.Controls.Add(this.checkBox_HideText);
            this.Controls.Add(this.label_Background);
            this.Controls.Add(this.comboBox_Background);
            this.Controls.Add(this.richTextBox_Text2);
            this.Controls.Add(this.label_Line2);
            this.Controls.Add(this.label_Line1);
            this.Controls.Add(this.checkBox_Arrow);
            this.Controls.Add(this.checkBox_DarkenR);
            this.Controls.Add(this.checkBox_DarkenM);
            this.Controls.Add(this.checkBox_DarkenL);
            this.Controls.Add(this.comboBox_ExpressionsRight);
            this.Controls.Add(this.comboBox_ExpressionsMid);
            this.Controls.Add(this.comboBox_ExpressionsLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Right);
            this.Controls.Add(this.label_Mid);
            this.Controls.Add(this.label_Left);
            this.Controls.Add(this.comboBox_Right);
            this.Controls.Add(this.comboBox_Mid);
            this.Controls.Add(this.comboBox_Left);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.richTextBox_Name);
            this.Controls.Add(this.richTextBox_Text1);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(430, 500);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "FE15 Text Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox richTextBox_Text1;
        private System.Windows.Forms.RichTextBox richTextBox_Name;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ComboBox comboBox_Left;
        private System.Windows.Forms.ComboBox comboBox_Mid;
        private System.Windows.Forms.ComboBox comboBox_Right;
        private System.Windows.Forms.Label label_Left;
        private System.Windows.Forms.Label label_Mid;
        private System.Windows.Forms.Label label_Right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ExpressionsLeft;
        private System.Windows.Forms.ComboBox comboBox_ExpressionsMid;
        private System.Windows.Forms.ComboBox comboBox_ExpressionsRight;
        private System.Windows.Forms.CheckBox checkBox_DarkenL;
        private System.Windows.Forms.CheckBox checkBox_DarkenM;
        private System.Windows.Forms.CheckBox checkBox_DarkenR;
        private System.Windows.Forms.CheckBox checkBox_Arrow;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_Line1;
        private System.Windows.Forms.Label label_Line2;
        private System.Windows.Forms.RichTextBox richTextBox_Text2;
        private System.Windows.Forms.ComboBox comboBox_Background;
        private System.Windows.Forms.Label label_Background;
        private System.Windows.Forms.CheckBox checkBox_HideText;
    }
}

