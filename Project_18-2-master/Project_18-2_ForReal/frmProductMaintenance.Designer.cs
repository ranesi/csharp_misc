namespace Project_18_2_ForReal {
    partial class frmProductMaintenance {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label versionLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductMaintenance));
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnAdd = new System.Windows.Forms.ToolStripButton();
            this.bnCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bnDelete = new System.Windows.Forms.ToolStripButton();
            this.bnMoveFirst = new System.Windows.Forms.ToolStripButton();
            this.bnMovePrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bnPosition = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bnMoveNext = new System.Windows.Forms.ToolStripButton();
            this.bnMoveLast = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnSave = new System.Windows.Forms.ToolStripButton();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtInput = new System.Windows.Forms.ToolStripTextBox();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnFillRemainder = new System.Windows.Forms.ToolStripButton();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSet = new Project_18_2_ForReal.TechSupportDataSet();
            this.productsTableAdapter = new Project_18_2_ForReal.TechSupportDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new Project_18_2_ForReal.TechSupportDataSetTableAdapters.TableAdapterManager();
            productCodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(11, 73);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(75, 13);
            productCodeLabel.TabIndex = 1;
            productCodeLabel.Text = "Product Code:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(11, 99);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(11, 125);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(45, 13);
            versionLabel.TabIndex = 5;
            versionLabel.Text = "Version:";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(11, 151);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 7;
            releaseDateLabel.Text = "Release Date:";
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bnAdd;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bnCountItem;
            this.productsBindingNavigator.DeleteItem = this.bnDelete;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bnMoveFirst,
            this.bnMovePrevious,
            this.bindingNavigatorSeparator,
            this.bnPosition,
            this.bnCountItem,
            this.bindingNavigatorSeparator1,
            this.bnMoveNext,
            this.bnMoveLast,
            this.bindingNavigatorSeparator2,
            this.bnAdd,
            this.bnDelete,
            this.bnSave});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bnMoveFirst;
            this.productsBindingNavigator.MoveLastItem = this.bnMoveLast;
            this.productsBindingNavigator.MoveNextItem = this.bnMoveNext;
            this.productsBindingNavigator.MovePreviousItem = this.bnMovePrevious;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bnPosition;
            this.productsBindingNavigator.Size = new System.Drawing.Size(356, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bnAdd
            // 
            this.bnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnAdd.Image = ((System.Drawing.Image)(resources.GetObject("bnAdd.Image")));
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.RightToLeftAutoMirrorImage = true;
            this.bnAdd.Size = new System.Drawing.Size(23, 22);
            this.bnAdd.Text = "Add new";
            this.bnAdd.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bnCountItem
            // 
            this.bnCountItem.Name = "bnCountItem";
            this.bnCountItem.Size = new System.Drawing.Size(35, 22);
            this.bnCountItem.Text = "of {0}";
            this.bnCountItem.ToolTipText = "Total number of items";
            // 
            // bnDelete
            // 
            this.bnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnDelete.Image = ((System.Drawing.Image)(resources.GetObject("bnDelete.Image")));
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.RightToLeftAutoMirrorImage = true;
            this.bnDelete.Size = new System.Drawing.Size(23, 22);
            this.bnDelete.Text = "Delete";
            // 
            // bnMoveFirst
            // 
            this.bnMoveFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMoveFirst.Image = ((System.Drawing.Image)(resources.GetObject("bnMoveFirst.Image")));
            this.bnMoveFirst.Name = "bnMoveFirst";
            this.bnMoveFirst.RightToLeftAutoMirrorImage = true;
            this.bnMoveFirst.Size = new System.Drawing.Size(23, 22);
            this.bnMoveFirst.Text = "Move first";
            this.bnMoveFirst.Click += new System.EventHandler(this.bnMoveClick);
            // 
            // bnMovePrevious
            // 
            this.bnMovePrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMovePrevious.Image = ((System.Drawing.Image)(resources.GetObject("bnMovePrevious.Image")));
            this.bnMovePrevious.Name = "bnMovePrevious";
            this.bnMovePrevious.RightToLeftAutoMirrorImage = true;
            this.bnMovePrevious.Size = new System.Drawing.Size(23, 22);
            this.bnMovePrevious.Text = "Move previous";
            this.bnMovePrevious.Click += new System.EventHandler(this.bnMoveClick);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bnPosition
            // 
            this.bnPosition.AccessibleName = "Position";
            this.bnPosition.AutoSize = false;
            this.bnPosition.Name = "bnPosition";
            this.bnPosition.Size = new System.Drawing.Size(50, 23);
            this.bnPosition.Text = "0";
            this.bnPosition.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bnMoveNext
            // 
            this.bnMoveNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMoveNext.Image = ((System.Drawing.Image)(resources.GetObject("bnMoveNext.Image")));
            this.bnMoveNext.Name = "bnMoveNext";
            this.bnMoveNext.RightToLeftAutoMirrorImage = true;
            this.bnMoveNext.Size = new System.Drawing.Size(23, 22);
            this.bnMoveNext.Text = "Move next";
            this.bnMoveNext.Click += new System.EventHandler(this.bnMoveClick);
            // 
            // bnMoveLast
            // 
            this.bnMoveLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnMoveLast.Image = ((System.Drawing.Image)(resources.GetObject("bnMoveLast.Image")));
            this.bnMoveLast.Name = "bnMoveLast";
            this.bnMoveLast.RightToLeftAutoMirrorImage = true;
            this.bnMoveLast.Size = new System.Drawing.Size(23, 22);
            this.bnMoveLast.Text = "Move last";
            this.bnMoveLast.Click += new System.EventHandler(this.bnMoveClick);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bnSave
            // 
            this.bnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnSave.Image = ((System.Drawing.Image)(resources.GetObject("bnSave.Image")));
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(23, 22);
            this.bnSave.Text = "Save Data";
            this.bnSave.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(92, 70);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.ReadOnly = true;
            this.productCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.productCodeTextBox.TabIndex = 2;
            this.productCodeTextBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(92, 96);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(189, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // versionTextBox
            // 
            this.versionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Version", true));
            this.versionTextBox.Location = new System.Drawing.Point(92, 122);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(41, 20);
            this.versionTextBox.TabIndex = 6;
            // 
            // releaseDateTextBox
            // 
            this.releaseDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ReleaseDate", true));
            this.releaseDateTextBox.Location = new System.Drawing.Point(92, 148);
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.Size = new System.Drawing.Size(189, 20);
            this.releaseDateTextBox.TabIndex = 8;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.productsBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtInput,
            this.btnFind,
            this.btnFillRemainder});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 25);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(356, 25);
            this.bindingNavigator1.TabIndex = 9;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "Product Code:";
            // 
            // txtInput
            // 
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 25);
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(34, 22);
            this.btnFind.Text = "Find";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFillRemainder
            // 
            this.btnFillRemainder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFillRemainder.Image = ((System.Drawing.Image)(resources.GetObject("btnFillRemainder.Image")));
            this.btnFillRemainder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFillRemainder.Name = "btnFillRemainder";
            this.btnFillRemainder.Size = new System.Drawing.Size(86, 22);
            this.btnFillRemainder.Text = "Fill Remainder";
            this.btnFillRemainder.Click += new System.EventHandler(this.btnFillRemainder_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Project_18_2_ForReal.TechSupportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 201);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateTextBox);
            this.Controls.Add(versionLabel);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "frmProductMaintenance";
            this.Text = "Product Maintenance";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Click += new System.EventHandler(this.bnMoveClick);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupportDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private TechSupportDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bnAdd;
        private System.Windows.Forms.ToolStripLabel bnCountItem;
        private System.Windows.Forms.ToolStripButton bnDelete;
        private System.Windows.Forms.ToolStripButton bnMoveFirst;
        private System.Windows.Forms.ToolStripButton bnMovePrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bnPosition;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bnMoveNext;
        private System.Windows.Forms.ToolStripButton bnMoveLast;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnSave;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.TextBox releaseDateTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtInput;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton btnFillRemainder;
    }
}

