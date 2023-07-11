namespace ChoboLauncher
{
    partial class EditConfigure
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
            applyBtn = new Button();
            saveBtn = new Button();
            cancelBtn = new Button();
            clearTarget = new Button();
            clearName = new Button();
            btnList3 = new ComboBox();
            btnList2 = new ComboBox();
            btnList1 = new ComboBox();
            btnNameText = new TextBox();
            btnTargetText = new TextBox();
            btnId = new Label();
            btnName = new Label();
            btnTarget = new Label();
            SuspendLayout();
            // 
            // applyBtn
            // 
            applyBtn.Location = new Point(409, 104);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(94, 25);
            applyBtn.TabIndex = 0;
            applyBtn.Text = "Apply";
            applyBtn.UseVisualStyleBackColor = true;
            applyBtn.Click += applyBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(309, 104);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 25);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(209, 104);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 25);
            cancelBtn.TabIndex = 0;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // clearTarget
            // 
            clearTarget.Location = new Point(409, 73);
            clearTarget.Name = "clearTarget";
            clearTarget.Size = new Size(94, 25);
            clearTarget.TabIndex = 0;
            clearTarget.Text = "Clear";
            clearTarget.UseVisualStyleBackColor = true;
            clearTarget.Click += clearBtnTarget_Click;
            // 
            // clearName
            // 
            clearName.Location = new Point(409, 42);
            clearName.Name = "clearName";
            clearName.Size = new Size(94, 25);
            clearName.TabIndex = 0;
            clearName.Text = "&Clear";
            clearName.UseVisualStyleBackColor = true;
            clearName.Click += clearBtnName_Click;
            // 
            // btnList3
            // 
            btnList3.FormattingEnabled = true;
            btnList3.Location = new Point(373, 13);
            btnList3.Name = "btnList3";
            btnList3.Size = new Size(130, 23);
            btnList3.TabIndex = 1;
            btnList3.SelectedIndexChanged += btnList3_SelectedIndexChanged;
            // 
            // btnList2
            // 
            btnList2.FormattingEnabled = true;
            btnList2.Location = new Point(225, 13);
            btnList2.Name = "btnList2";
            btnList2.Size = new Size(130, 23);
            btnList2.TabIndex = 1;
            btnList2.SelectedIndexChanged += btnList2_SelectedIndexChanged;
            // 
            // btnList1
            // 
            btnList1.FormattingEnabled = true;
            btnList1.Location = new Point(76, 13);
            btnList1.Name = "btnList1";
            btnList1.Size = new Size(130, 23);
            btnList1.TabIndex = 1;
            btnList1.SelectedIndexChanged += btnList1_SelectedIndexChanged;
            // 
            // btnNameText
            // 
            btnNameText.Location = new Point(76, 44);
            btnNameText.Name = "btnNameText";
            btnNameText.Size = new Size(327, 23);
            btnNameText.TabIndex = 2;
            // 
            // btnTargetText
            // 
            btnTargetText.Location = new Point(76, 73);
            btnTargetText.Name = "btnTargetText";
            btnTargetText.Size = new Size(327, 23);
            btnTargetText.TabIndex = 2;
            // 
            // btnId
            // 
            btnId.AutoSize = true;
            btnId.Location = new Point(12, 16);
            btnId.Name = "btnId";
            btnId.Size = new Size(59, 15);
            btnId.TabIndex = 3;
            btnId.Text = "Button ID";
            // 
            // btnName
            // 
            btnName.AutoSize = true;
            btnName.Location = new Point(12, 47);
            btnName.Name = "btnName";
            btnName.Size = new Size(39, 15);
            btnName.TabIndex = 3;
            btnName.Text = "Name";
            // 
            // btnTarget
            // 
            btnTarget.AutoSize = true;
            btnTarget.Location = new Point(12, 76);
            btnTarget.Name = "btnTarget";
            btnTarget.Size = new Size(40, 15);
            btnTarget.TabIndex = 3;
            btnTarget.Text = "Target";
            // 
            // EditConfigure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 139);
            Controls.Add(btnTarget);
            Controls.Add(btnName);
            Controls.Add(btnId);
            Controls.Add(btnTargetText);
            Controls.Add(btnNameText);
            Controls.Add(btnList1);
            Controls.Add(btnList2);
            Controls.Add(btnList3);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(clearName);
            Controls.Add(clearTarget);
            Controls.Add(applyBtn);
            Name = "EditConfigure";
            Text = "EditConfigure";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button applyBtn;
        private Button saveBtn;
        private Button cancelBtn;
        private Button clearTarget;
        private Button clearName;
        private ComboBox btnList3;
        private ComboBox btnList2;
        private ComboBox btnList1;
        private TextBox btnNameText;
        private TextBox btnTargetText;
        private Label btnId;
        private Label btnName;
        private Label btnTarget;
    }
}