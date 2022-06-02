
namespace database_changer
{
    partial class product1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label proportionsLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label producer_priceLabel;
            System.Windows.Forms.Label final_priceLabel;
            System.Windows.Forms.Label manufacturer_idLabel;
            this.shopDataSet = new database_changer.shopDataSet();
            this.product1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product1TableAdapter = new database_changer.shopDataSetTableAdapters.product1TableAdapter();
            this.tableAdapterManager = new database_changer.shopDataSetTableAdapters.TableAdapterManager();
            this.product1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.product1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.product1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.proportionsTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.producer_priceTextBox = new System.Windows.Forms.TextBox();
            this.final_priceTextBox = new System.Windows.Forms.TextBox();
            this.manufacturer_idTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            proportionsLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            producer_priceLabel = new System.Windows.Forms.Label();
            final_priceLabel = new System.Windows.Forms.Label();
            manufacturer_idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1BindingNavigator)).BeginInit();
            this.product1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product1BindingSource
            // 
            this.product1BindingSource.DataMember = "product1";
            this.product1BindingSource.DataSource = this.shopDataSet;
            // 
            // product1TableAdapter
            // 
            this.product1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cartTableAdapter = null;
            this.tableAdapterManager.manufacturer1TableAdapter = null;
            this.tableAdapterManager.order1TableAdapter = null;
            this.tableAdapterManager.product1TableAdapter = this.product1TableAdapter;
            this.tableAdapterManager.UpdateOrder = database_changer.shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user1TableAdapter = null;
            // 
            // product1BindingNavigator
            // 
            this.product1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.product1BindingNavigator.BindingSource = this.product1BindingSource;
            this.product1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.product1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.product1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.product1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.product1BindingNavigatorSaveItem});
            this.product1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.product1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.product1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.product1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.product1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.product1BindingNavigator.Name = "product1BindingNavigator";
            this.product1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.product1BindingNavigator.Size = new System.Drawing.Size(1140, 27);
            this.product1BindingNavigator.TabIndex = 0;
            this.product1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // product1BindingNavigatorSaveItem
            // 
            this.product1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.product1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("product1BindingNavigatorSaveItem.Image")));
            this.product1BindingNavigatorSaveItem.Name = "product1BindingNavigatorSaveItem";
            this.product1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.product1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.product1BindingNavigatorSaveItem.Click += new System.EventHandler(this.product1BindingNavigatorSaveItem_Click);
            // 
            // product1DataGridView
            // 
            this.product1DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.product1DataGridView.AutoGenerateColumns = false;
            this.product1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.product1DataGridView.DataSource = this.product1BindingSource;
            this.product1DataGridView.Location = new System.Drawing.Point(0, 258);
            this.product1DataGridView.Name = "product1DataGridView";
            this.product1DataGridView.RowHeadersWidth = 51;
            this.product1DataGridView.RowTemplate.Height = 24;
            this.product1DataGridView.Size = new System.Drawing.Size(1140, 265);
            this.product1DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn2.HeaderText = "type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "proportions";
            this.dataGridViewTextBoxColumn3.HeaderText = "proportions";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "weight";
            this.dataGridViewTextBoxColumn4.HeaderText = "weight";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "rating";
            this.dataGridViewTextBoxColumn5.HeaderText = "rating";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "producer_price";
            this.dataGridViewTextBoxColumn6.HeaderText = "producer_price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "final_price";
            this.dataGridViewTextBoxColumn7.HeaderText = "final_price";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "manufacturer_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "manufacturer_id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product1BindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(129, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(12, 65);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(39, 17);
            typeLabel.TabIndex = 4;
            typeLabel.Text = "type:";
            // 
            // typeTextBox
            // 
            this.typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product1BindingSource, "type", true));
            this.typeTextBox.Location = new System.Drawing.Point(129, 62);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(100, 22);
            this.typeTextBox.TabIndex = 5;
            // 
            // proportionsLabel
            // 
            proportionsLabel.AutoSize = true;
            proportionsLabel.Location = new System.Drawing.Point(12, 93);
            proportionsLabel.Name = "proportionsLabel";
            proportionsLabel.Size = new System.Drawing.Size(84, 17);
            proportionsLabel.TabIndex = 6;
            proportionsLabel.Text = "proportions:";
            // 
            // proportionsTextBox
            // 
            this.proportionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product1BindingSource, "proportions", true));
            this.proportionsTextBox.Location = new System.Drawing.Point(129, 90);
            this.proportionsTextBox.Name = "proportionsTextBox";
            this.proportionsTextBox.Size = new System.Drawing.Size(100, 22);
            this.proportionsTextBox.TabIndex = 7;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(12, 121);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(52, 17);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "weight:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product1BindingSource, "weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(129, 118);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 22);
            this.weightTextBox.TabIndex = 9;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(12, 149);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(48, 17);
            ratingLabel.TabIndex = 10;
            ratingLabel.Text = "rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product1BindingSource, "rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(129, 146);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(100, 22);
            this.ratingTextBox.TabIndex = 11;
            // 
            // producer_priceLabel
            // 
            producer_priceLabel.AutoSize = true;
            producer_priceLabel.Location = new System.Drawing.Point(12, 177);
            producer_priceLabel.Name = "producer_priceLabel";
            producer_priceLabel.Size = new System.Drawing.Size(104, 17);
            producer_priceLabel.TabIndex = 12;
            producer_priceLabel.Text = "producer price:";
            // 
            // producer_priceTextBox
            // 
            this.producer_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product1BindingSource, "producer_price", true));
            this.producer_priceTextBox.Location = new System.Drawing.Point(129, 174);
            this.producer_priceTextBox.Name = "producer_priceTextBox";
            this.producer_priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.producer_priceTextBox.TabIndex = 13;
            // 
            // final_priceLabel
            // 
            final_priceLabel.AutoSize = true;
            final_priceLabel.Location = new System.Drawing.Point(12, 205);
            final_priceLabel.Name = "final_priceLabel";
            final_priceLabel.Size = new System.Drawing.Size(73, 17);
            final_priceLabel.TabIndex = 14;
            final_priceLabel.Text = "final price:";
            // 
            // final_priceTextBox
            // 
            this.final_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product1BindingSource, "final_price", true));
            this.final_priceTextBox.Location = new System.Drawing.Point(129, 202);
            this.final_priceTextBox.Name = "final_priceTextBox";
            this.final_priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.final_priceTextBox.TabIndex = 15;
            // 
            // manufacturer_idLabel
            // 
            manufacturer_idLabel.AutoSize = true;
            manufacturer_idLabel.Location = new System.Drawing.Point(12, 233);
            manufacturer_idLabel.Name = "manufacturer_idLabel";
            manufacturer_idLabel.Size = new System.Drawing.Size(111, 17);
            manufacturer_idLabel.TabIndex = 16;
            manufacturer_idLabel.Text = "manufacturer id:";
            // 
            // manufacturer_idTextBox
            // 
            this.manufacturer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product1BindingSource, "manufacturer_id", true));
            this.manufacturer_idTextBox.Location = new System.Drawing.Point(129, 230);
            this.manufacturer_idTextBox.Name = "manufacturer_idTextBox";
            this.manufacturer_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.manufacturer_idTextBox.TabIndex = 17;
            // 
            // product1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 521);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(proportionsLabel);
            this.Controls.Add(this.proportionsTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(producer_priceLabel);
            this.Controls.Add(this.producer_priceTextBox);
            this.Controls.Add(final_priceLabel);
            this.Controls.Add(this.final_priceTextBox);
            this.Controls.Add(manufacturer_idLabel);
            this.Controls.Add(this.manufacturer_idTextBox);
            this.Controls.Add(this.product1DataGridView);
            this.Controls.Add(this.product1BindingNavigator);
            this.Name = "product1";
            this.Text = "product1";
            this.Load += new System.EventHandler(this.product1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product1BindingNavigator)).EndInit();
            this.product1BindingNavigator.ResumeLayout(false);
            this.product1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource product1BindingSource;
        private shopDataSetTableAdapters.product1TableAdapter product1TableAdapter;
        private shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator product1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton product1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView product1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.TextBox proportionsTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox producer_priceTextBox;
        private System.Windows.Forms.TextBox final_priceTextBox;
        private System.Windows.Forms.TextBox manufacturer_idTextBox;
    }
}