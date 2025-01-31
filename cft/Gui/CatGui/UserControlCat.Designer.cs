namespace cft.Gui
{
    partial class UserControlCat
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCat));
            simpleButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            simpleButtonEdit = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            searchControl1 = new DevExpress.XtraEditors.SearchControl();
            simpleButtonExport = new DevExpress.XtraEditors.SimpleButton();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
            dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)searchControl1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).BeginInit();
            SuspendLayout();
            // 
            // simpleButtonAdd
            // 
            simpleButtonAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            simpleButtonAdd.Appearance.Options.UseFont = true;
            simpleButtonAdd.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButtonAdd.ImageOptions.Image");
            simpleButtonAdd.Location = new System.Drawing.Point(1146, 12);
            simpleButtonAdd.Name = "simpleButtonAdd";
            simpleButtonAdd.Size = new System.Drawing.Size(91, 23);
            simpleButtonAdd.StyleController = dataLayoutControl1;
            simpleButtonAdd.TabIndex = 1;
            simpleButtonAdd.Text = "إضافة";
            simpleButtonAdd.Click += simpleButtonAdd_Click;
            // 
            // dataLayoutControl1
            // 
            dataLayoutControl1.Controls.Add(gridControl1);
            dataLayoutControl1.Controls.Add(simpleButtonAdd);
            dataLayoutControl1.Controls.Add(simpleButtonEdit);
            dataLayoutControl1.Controls.Add(simpleButtonDelete);
            dataLayoutControl1.Controls.Add(searchControl1);
            dataLayoutControl1.Controls.Add(simpleButtonExport);
            dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            dataLayoutControl1.Name = "dataLayoutControl1";
            dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2382, 281, 650, 400);
            dataLayoutControl1.OptionsView.RightToLeftMirroringApplied = true;
            dataLayoutControl1.Root = Root;
            dataLayoutControl1.Size = new System.Drawing.Size(1249, 666);
            dataLayoutControl1.TabIndex = 5;
            dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            gridControl1.EmbeddedNavigator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridControl1.Location = new System.Drawing.Point(12, 40);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(1225, 614);
            gridControl1.TabIndex = 5;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowAutoFilterRow = true;
            gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButtonEdit
            // 
            simpleButtonEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            simpleButtonEdit.Appearance.Options.UseFont = true;
            simpleButtonEdit.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButtonEdit.ImageOptions.Image");
            simpleButtonEdit.Location = new System.Drawing.Point(1019, 12);
            simpleButtonEdit.Name = "simpleButtonEdit";
            simpleButtonEdit.Size = new System.Drawing.Size(123, 23);
            simpleButtonEdit.StyleController = dataLayoutControl1;
            simpleButtonEdit.TabIndex = 3;
            simpleButtonEdit.Text = "تعديل";
            // 
            // simpleButtonDelete
            // 
            simpleButtonDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            simpleButtonDelete.Appearance.Options.UseFont = true;
            simpleButtonDelete.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButtonDelete.ImageOptions.Image");
            simpleButtonDelete.Location = new System.Drawing.Point(893, 12);
            simpleButtonDelete.Name = "simpleButtonDelete";
            simpleButtonDelete.Size = new System.Drawing.Size(122, 23);
            simpleButtonDelete.StyleController = dataLayoutControl1;
            simpleButtonDelete.TabIndex = 2;
            simpleButtonDelete.Text = "حدف";
            // 
            // searchControl1
            // 
            searchControl1.Location = new System.Drawing.Point(12, 12);
            searchControl1.Name = "searchControl1";
            searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            searchControl1.Properties.Appearance.Options.UseFont = true;
            searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Repository.ClearButton(), new DevExpress.XtraEditors.Repository.SearchButton(), new DevExpress.XtraEditors.Repository.MRUButton() });
            searchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoShowClear;
            searchControl1.Properties.ShowMRUButton = true;
            searchControl1.Size = new System.Drawing.Size(690, 24);
            searchControl1.StyleController = dataLayoutControl1;
            searchControl1.TabIndex = 0;
            // 
            // simpleButtonExport
            // 
            simpleButtonExport.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            simpleButtonExport.Appearance.Options.UseFont = true;
            simpleButtonExport.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("simpleButtonExport.ImageOptions.Image");
            simpleButtonExport.Location = new System.Drawing.Point(746, 12);
            simpleButtonExport.Name = "simpleButtonExport";
            simpleButtonExport.Size = new System.Drawing.Size(143, 23);
            simpleButtonExport.StyleController = dataLayoutControl1;
            simpleButtonExport.TabIndex = 4;
            simpleButtonExport.Text = "تصدير";
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4, layoutControlItem5, layoutControlItem6 });
            Root.Name = "Root";
            Root.Size = new System.Drawing.Size(1249, 666);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            layoutControlItem1.Control = searchControl1;
            layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new System.Drawing.Size(734, 28);
            layoutControlItem1.Text = "بحث";
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = simpleButtonExport;
            layoutControlItem2.Location = new System.Drawing.Point(734, 0);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new System.Drawing.Size(147, 28);
            layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = simpleButtonDelete;
            layoutControlItem3.Location = new System.Drawing.Point(881, 0);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new System.Drawing.Size(126, 28);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = simpleButtonEdit;
            layoutControlItem4.Location = new System.Drawing.Point(1007, 0);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new System.Drawing.Size(127, 28);
            layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            layoutControlItem5.Control = simpleButtonAdd;
            layoutControlItem5.Location = new System.Drawing.Point(1134, 0);
            layoutControlItem5.Name = "layoutControlItem5";
            layoutControlItem5.Size = new System.Drawing.Size(95, 28);
            layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            layoutControlItem6.Control = gridControl1;
            layoutControlItem6.Location = new System.Drawing.Point(0, 28);
            layoutControlItem6.Name = "layoutControlItem6";
            layoutControlItem6.Size = new System.Drawing.Size(1229, 618);
            layoutControlItem6.TextVisible = false;
            // 
            // UserControlCat
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(dataLayoutControl1);
            Name = "UserControlCat";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1249, 666);
            Load += UserControlCat_Load;
            ((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
            dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)searchControl1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem5).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButtonAdd;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonExport;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDelete;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEdit;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
