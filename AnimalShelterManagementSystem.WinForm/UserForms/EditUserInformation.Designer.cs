﻿namespace AnimalShelterManagementSystem.WinForm
{
    partial class EditUserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserInformation));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.boxId = new DevExpress.XtraEditors.TextEdit();
            this.boxPassword = new DevExpress.XtraEditors.TextEdit();
            this.boxName = new DevExpress.XtraEditors.TextEdit();
            this.boxPhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.boxAddress = new DevExpress.XtraEditors.TextEdit();
            this.boxPasswordCheck = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSignup = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPasswordCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(582, 279);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.btnSignup);
            this.layoutControl2.Controls.Add(this.boxId);
            this.layoutControl2.Controls.Add(this.boxPassword);
            this.layoutControl2.Controls.Add(this.boxName);
            this.layoutControl2.Controls.Add(this.boxPhoneNumber);
            this.layoutControl2.Controls.Add(this.boxAddress);
            this.layoutControl2.Controls.Add(this.boxPasswordCheck);
            this.layoutControl2.Location = new System.Drawing.Point(12, 12);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1021, 0, 812, 500);
            this.layoutControl2.Padding = new System.Windows.Forms.Padding(50);
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(558, 255);
            this.layoutControl2.TabIndex = 4;
            this.layoutControl2.Text = "layoutControl1";
            // 
            // boxId
            // 
            this.boxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindingSource, "Id", true));
            this.boxId.Location = new System.Drawing.Point(131, 12);
            this.boxId.Name = "boxId";
            this.boxId.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.boxId.Properties.ReadOnly = true;
            this.boxId.Size = new System.Drawing.Size(415, 24);
            this.boxId.StyleController = this.layoutControl2;
            this.boxId.TabIndex = 4;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(131, 68);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Properties.NullText = "새 비밀번호를 입력해주세요";
            this.boxPassword.Size = new System.Drawing.Size(415, 24);
            this.boxPassword.StyleController = this.layoutControl2;
            this.boxPassword.TabIndex = 4;
            this.boxPassword.EditValueChanged += new System.EventHandler(this.textEdit11_EditValueChanged);
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(131, 40);
            this.boxName.Name = "boxName";
            this.boxName.Properties.ReadOnly = true;
            this.boxName.Size = new System.Drawing.Size(415, 24);
            this.boxName.StyleController = this.layoutControl2;
            this.boxName.TabIndex = 4;
            // 
            // boxPhoneNumber
            // 
            this.boxPhoneNumber.Location = new System.Drawing.Point(131, 124);
            this.boxPhoneNumber.Name = "boxPhoneNumber";
            this.boxPhoneNumber.Size = new System.Drawing.Size(415, 24);
            this.boxPhoneNumber.StyleController = this.layoutControl2;
            this.boxPhoneNumber.TabIndex = 4;
            // 
            // boxAddress
            // 
            this.boxAddress.Location = new System.Drawing.Point(131, 152);
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(415, 24);
            this.boxAddress.StyleController = this.layoutControl2;
            this.boxAddress.TabIndex = 4;
            // 
            // boxPasswordCheck
            // 
            this.boxPasswordCheck.Location = new System.Drawing.Point(131, 96);
            this.boxPasswordCheck.Name = "boxPasswordCheck";
            this.boxPasswordCheck.Properties.NullText = "비밀번호 확인";
            this.boxPasswordCheck.Size = new System.Drawing.Size(415, 24);
            this.boxPasswordCheck.StyleController = this.layoutControl2;
            this.boxPasswordCheck.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem8,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(558, 255);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.boxId;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(538, 28);
            this.layoutControlItem1.Text = "아이디 : ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(116, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 168);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(341, 67);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.boxPassword;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(538, 28);
            this.layoutControlItem2.Text = "새 비밀번호 :    ";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(116, 18);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.boxPhoneNumber;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 112);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(538, 28);
            this.layoutControlItem4.Text = "핸드폰 번호 :";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(116, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.boxAddress;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 140);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(538, 28);
            this.layoutControlItem5.Text = "주소 :";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(116, 18);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.boxPasswordCheck;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(538, 28);
            this.layoutControlItem8.Text = "새 비밀번호 확인 : ";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(116, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.boxName;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(538, 28);
            this.layoutControlItem3.Text = "이름 :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(116, 18);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(582, 279);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.layoutControl2;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(562, 259);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // btnSignup
            // 
            this.btnSignup.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnSignup.Appearance.Options.UseFont = true;
            this.btnSignup.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSignup.ImageOptions.Image")));
            this.btnSignup.Location = new System.Drawing.Point(353, 180);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(193, 53);
            this.btnSignup.StyleController = this.layoutControl2;
            this.btnSignup.TabIndex = 5;
            this.btnSignup.Text = "수정";
            this.btnSignup.Click += new System.EventHandler(this.btnEdit_Clicked);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnSignup;
            this.layoutControlItem6.Location = new System.Drawing.Point(341, 168);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(197, 57);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(197, 57);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(197, 67);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // UserBindingSource
            // 
            this.UserBindingSource.DataSource = typeof(AnimalShelterManagementSystem.User);
            // 
            // EditUserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 279);
            this.Controls.Add(this.layoutControl1);
            this.Name = "EditUserInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "유저정보수정";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boxId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxPasswordCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton btnSignup;
        private DevExpress.XtraEditors.TextEdit boxPassword;
        private DevExpress.XtraEditors.TextEdit boxName;
        private DevExpress.XtraEditors.TextEdit boxPhoneNumber;
        private DevExpress.XtraEditors.TextEdit boxAddress;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TextEdit boxId;
        private DevExpress.XtraEditors.TextEdit boxPasswordCheck;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private System.Windows.Forms.BindingSource UserBindingSource;
    }
}