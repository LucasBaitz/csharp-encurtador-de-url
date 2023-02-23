namespace URLShortWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Lbl_Title = new Label();
            txtBox_inputKey = new TextBox();
            txtBox_EnterURL = new TextBox();
            btn_CreateShortURL = new Button();
            txtBox_displayShortURL = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Lbl_Title
            // 
            Lbl_Title.AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(Lbl_Title, "Lbl_Title");
            Lbl_Title.Name = "Lbl_Title";
            Lbl_Title.Click += label1_Click;
            // 
            // txtBox_inputKey
            // 
            resources.ApplyResources(txtBox_inputKey, "txtBox_inputKey");
            txtBox_inputKey.Name = "txtBox_inputKey";
            txtBox_inputKey.TextChanged += textBox1_TextChanged;
            // 
            // txtBox_EnterURL
            // 
            resources.ApplyResources(txtBox_EnterURL, "txtBox_EnterURL");
            txtBox_EnterURL.Name = "txtBox_EnterURL";
            txtBox_EnterURL.TextChanged += txtBox_EnterURL_TextChanged;
            // 
            // btn_CreateShortURL
            // 
            resources.ApplyResources(btn_CreateShortURL, "btn_CreateShortURL");
            btn_CreateShortURL.Name = "btn_CreateShortURL";
            btn_CreateShortURL.UseVisualStyleBackColor = true;
            btn_CreateShortURL.Click += btn_CreateShortURL_Click;
            // 
            // txtBox_displayShortURL
            // 
            txtBox_displayShortURL.BackColor = SystemColors.ButtonFace;
            resources.ApplyResources(txtBox_displayShortURL, "txtBox_displayShortURL");
            txtBox_displayShortURL.Name = "txtBox_displayShortURL";
            txtBox_displayShortURL.ReadOnly = true;
            txtBox_displayShortURL.TextChanged += displayShortURL_TextChanged;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBox_displayShortURL);
            Controls.Add(txtBox_EnterURL);
            Controls.Add(btn_CreateShortURL);
            Controls.Add(txtBox_inputKey);
            Controls.Add(Lbl_Title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Lbl_Title;
        private TextBox txtBox_inputKey;
        private TextBox txtBox_EnterURL;
        private Button btn_CreateShortURL;
        private TextBox txtBox_displayShortURL;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}