namespace cft.Gui.CatGui
{
    partial class AddCategoryXtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategoryXtraForm));
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            textEditName = new DevExpress.XtraEditors.TextEdit();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            textEditCategory = new DevExpress.XtraEditors.ComboBoxEdit();
            richTextBoxDetailes = new System.Windows.Forms.RichTextBox();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            textEditBalance = new DevExpress.XtraEditors.TextEdit();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            simpleButtonSaveAndClose = new DevExpress.XtraEditors.SimpleButton();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditCategory.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditBalance.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.Controls.Add(simpleButtonSave);
            dataLayoutControl1.Controls.Add(simpleButtonSaveAndClose);
            dataLayoutControl1.Controls.Add(textEditBalance);
            dataLayoutControl1.Controls.Add(richTextBoxDetailes);
            dataLayoutControl1.Controls.Add(textEditName);
            dataLayoutControl1.Controls.Add(textEditCategory);
            dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(891, 327, 650, 400);
            dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            dataLayoutControl1.Root = Root;
            dataLayoutControl1.Size = new System.Drawing.Size(378, 316);
            dataLayoutControl1.TabIndex = 0;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, emptySpaceItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(378, 316);
            Root.TextVisible = false;
            // 
            // textEditName
            // 
            textEditName.Location = new System.Drawing.Point(12, 12);
            textEditName.Name = "textEditName";
            textEditName.Size = new System.Drawing.Size(288, 20);
            textEditName.StyleController = dataLayoutControl1;
            textEditName.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEditName;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(358, 24);
            layoutControlItem1.Text = "اسم الصنف";
            // 
            // emptySpaceItem1
            // 
            emptySpaceItem1.Location = new System.Drawing.Point(119, 270);
            emptySpaceItem1.Name = "emptySpaceItem1";
            emptySpaceItem1.Size = new System.Drawing.Size(119, 26);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEditCategory;
            layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(358, 24);
            layoutControlItem2.Text = "نوع الصنف";
            // 
            // textEditCategory
            // 
            textEditCategory.EditValue = "<Null>";
            textEditCategory.Location = new System.Drawing.Point(12, 36);
            textEditCategory.Name = "textEditCategory";
            textEditCategory.Properties.BeepOnError = true;
            textEditCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            textEditCategory.Properties.Items.AddRange(new object[] { "صرف", "قبض" });
            textEditCategory.Properties.Sorted = true;
            textEditCategory.Size = new System.Drawing.Size(288, 20);
            textEditCategory.StyleController = dataLayoutControl1;
            textEditCategory.TabIndex = 5;
            // 
            // richTextBoxDetailes
            // 
            richTextBoxDetailes.Location = new System.Drawing.Point(12, 60);
            richTextBoxDetailes.Name = "richTextBoxDetailes";
            richTextBoxDetailes.Size = new System.Drawing.Size(288, 194);
            richTextBoxDetailes.TabIndex = 6;
            richTextBoxDetailes.Text = "";
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = richTextBoxDetailes;
            layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(358, 198);
            layoutControlItem3.Text = "تفاصيل";
            // 
            // textEditBalance
            // 
            textEditBalance.Enabled = false;
            textEditBalance.Location = new System.Drawing.Point(12, 258);
            textEditBalance.Name = "textEditBalance";
            textEditBalance.Size = new System.Drawing.Size(288, 20);
            textEditBalance.StyleController = dataLayoutControl1;
            textEditBalance.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = textEditBalance;
            layoutControlItem4.Location = new System.Drawing.Point(0, 246);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(358, 24);
            layoutControlItem4.Text = "الرصيد";
            // 
            // simpleButtonSaveAndClose
            // 
            simpleButtonSaveAndClose.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton1.ImageOptions.Image");
            simpleButtonSaveAndClose.Location = new System.Drawing.Point(250, 282);
            simpleButtonSaveAndClose.Name = "simpleButtonSaveAndClose";
            simpleButtonSaveAndClose.Size = new System.Drawing.Size(116, 22);
            simpleButtonSaveAndClose.StyleController = dataLayoutControl1;
            simpleButtonSaveAndClose.TabIndex = 8;
            simpleButtonSaveAndClose.Text = "حفض و غلق";
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = simpleButtonSaveAndClose;
            layoutControlItem5.Location = new System.Drawing.Point(238, 270);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(120, 26);
            layoutControlItem5.TextVisible = false;
            // 
            // simpleButtonSave
            // 
            simpleButtonSave.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButton2.ImageOptions.Image");
            simpleButtonSave.Location = new System.Drawing.Point(12, 282);
            simpleButtonSave.Name = "simpleButtonSave";
            simpleButtonSave.Size = new System.Drawing.Size(115, 22);
            simpleButtonSave.StyleController = dataLayoutControl1;
            simpleButtonSave.TabIndex = 9;
            simpleButtonSave.Text = "حفض";
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = simpleButtonSave;
            layoutControlItem6.Location = new System.Drawing.Point(0, 270);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(119, 26);
            layoutControlItem6.TextVisible = false;
            // 
            // AddCategoryXtraForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(378, 316);
            Controls.Add(dataLayoutControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryXtraForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "اضافة/ تعديل صنف";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emptySpaceItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditCategory.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditBalance.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.ComboBoxEdit textEditCategory;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit textEditBalance;
        private System.Windows.Forms.RichTextBox richTextBoxDetailes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSaveAndClose;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}