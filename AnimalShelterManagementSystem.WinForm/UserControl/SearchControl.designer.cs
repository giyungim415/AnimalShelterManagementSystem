namespace AnimalShelterManagementSystem.WinForm.UserControls
{
    partial class SearchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dteFoundDateTo = new DevExpress.XtraEditors.DateEdit();
            this.dteFoundDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.sexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.luAnimalshelter = new DevExpress.XtraEditors.LookUpEdit();
            this.animalShelterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.luSpecies = new DevExpress.XtraEditors.LookUpEdit();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rdgSex = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luAnimalshelter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSpecies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(733, 414);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "검색";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rdgSex);
            this.layoutControl1.Controls.Add(this.dteFoundDateTo);
            this.layoutControl1.Controls.Add(this.dteFoundDateFrom);
            this.layoutControl1.Controls.Add(this.btnLoad);
            this.layoutControl1.Controls.Add(this.luAnimalshelter);
            this.layoutControl1.Controls.Add(this.luSpecies);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 32);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(729, 380);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtaLastestFindingReportDate
            // 
            this.dteFoundDateTo.EditValue = null;
            this.dteFoundDateTo.Location = new System.Drawing.Point(443, 110);
            this.dteFoundDateTo.Name = "dtaLastestFindingReportDate";
            this.dteFoundDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFoundDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFoundDateTo.Size = new System.Drawing.Size(173, 27);
            this.dteFoundDateTo.StyleController = this.layoutControl1;
            this.dteFoundDateTo.TabIndex = 10;
            // 
            // dtaFindingReportDate
            // 
            this.dteFoundDateFrom.EditValue = null;
            this.dteFoundDateFrom.Location = new System.Drawing.Point(139, 110);
            this.dteFoundDateFrom.Name = "dtaFindingReportDate";
            this.dteFoundDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFoundDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteFoundDateFrom.Size = new System.Drawing.Size(173, 27);
            this.dteFoundDateFrom.StyleController = this.layoutControl1;
            this.dteFoundDateFrom.TabIndex = 9;
            // 
            // sexBindingSource
            // 
            this.sexBindingSource.DataSource = typeof(AnimalShelterManagementSystem.Sex);
            // 
            // btnLoad
            // 
            this.btnLoad.Appearance.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.btnLoad.Appearance.Options.UseFont = true;
            this.btnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.ImageOptions.Image")));
            this.btnLoad.Location = new System.Drawing.Point(620, 12);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(97, 40);
            this.btnLoad.StyleController = this.layoutControl1;
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "검색";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // luAnimalshelter
            // 
            this.luAnimalshelter.AllowDrop = true;
            this.luAnimalshelter.Location = new System.Drawing.Point(139, 12);
            this.luAnimalshelter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.luAnimalshelter.Name = "luAnimalshelter";
            this.luAnimalshelter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luAnimalshelter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name1")});
            this.luAnimalshelter.Properties.DataSource = this.animalShelterBindingSource;
            this.luAnimalshelter.Properties.DisplayMember = "Name";
            this.luAnimalshelter.Properties.ValueMember = "AnimalShelterId";
            this.luAnimalshelter.Size = new System.Drawing.Size(477, 27);
            this.luAnimalshelter.StyleController = this.layoutControl1;
            this.luAnimalshelter.TabIndex = 4;
            this.luAnimalshelter.UseWaitCursor = true;
            // 
            // animalShelterBindingSource
            // 
            this.animalShelterBindingSource.DataSource = typeof(AnimalShelterManagementSystem.AnimalShelter);
            // 
            // luSpecies
            // 
            this.luSpecies.AllowDrop = true;
            this.luSpecies.Location = new System.Drawing.Point(139, 43);
            this.luSpecies.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.luSpecies.Name = "luSpecies";
            this.luSpecies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luSpecies.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Species1", "Name9")});
            this.luSpecies.Properties.DataSource = this.speciesBindingSource;
            this.luSpecies.Properties.DisplayMember = "Species1";
            this.luSpecies.Properties.ValueMember = "SpeciesCode";
            this.luSpecies.Size = new System.Drawing.Size(477, 27);
            this.luSpecies.StyleController = this.layoutControl1;
            this.luSpecies.TabIndex = 4;
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataSource = typeof(AnimalShelterManagementSystem.Species);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(729, 380);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.luAnimalshelter;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(608, 31);
            this.layoutControlItem1.Text = "       보호센터";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(124, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 129);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(608, 231);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.luSpecies;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "보호센터";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(608, 31);
            this.layoutControlItem2.Text = "          축종";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(124, 18);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnLoad;
            this.layoutControlItem3.Location = new System.Drawing.Point(608, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(101, 360);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dteFoundDateFrom;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(304, 31);
            this.layoutControlItem4.Text = "신고일(부터)";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(124, 18);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.dteFoundDateTo;
            this.layoutControlItem5.Location = new System.Drawing.Point(304, 98);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(304, 31);
            this.layoutControlItem5.Text = "신고일(까지)";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(124, 18);
            // 
            // rdgSex
            // 
            this.rdgSex.EditValue = 0;
            this.rdgSex.Location = new System.Drawing.Point(139, 74);
            this.rdgSex.Name = "rdgSex";
            this.rdgSex.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "전체"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "수컷"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "암컷")});
            this.rdgSex.Size = new System.Drawing.Size(477, 32);
            this.rdgSex.StyleController = this.layoutControl1;
            this.rdgSex.TabIndex = 11;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.rdgSex;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(608, 36);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(124, 18);
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(733, 414);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteFoundDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luAnimalshelter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalShelterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luSpecies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit luAnimalshelter;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit luSpecies;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource animalShelterBindingSource;
        private System.Windows.Forms.BindingSource speciesBindingSource;
        private DevExpress.XtraEditors.DateEdit dteFoundDateTo;
        private DevExpress.XtraEditors.DateEdit dteFoundDateFrom;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource sexBindingSource;
        private DevExpress.XtraEditors.RadioGroup rdgSex;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}
