
namespace database_changer
{
    partial class order1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(order1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label id_cartLabel;
            System.Windows.Forms.Label total_priceLabel;
            System.Windows.Forms.Label date_of_paymentLabel;
            this.shopDataSet = new database_changer.shopDataSet();
            this.order1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order1TableAdapter = new database_changer.shopDataSetTableAdapters.order1TableAdapter();
            this.tableAdapterManager = new database_changer.shopDataSetTableAdapters.TableAdapterManager();
            this.order1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.order1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.id_cartTextBox = new System.Windows.Forms.TextBox();
            this.total_priceTextBox = new System.Windows.Forms.TextBox();
            this.date_of_paymentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            id_cartLabel = new System.Windows.Forms.Label();
            total_priceLabel = new System.Windows.Forms.Label();
            date_of_paymentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingNavigator)).BeginInit();
            this.order1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order1BindingSource
            // 
            this.order1BindingSource.DataMember = "order1";
            this.order1BindingSource.DataSource = this.shopDataSet;
            // 
            // order1TableAdapter
            // 
            this.order1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cartTableAdapter = null;
            this.tableAdapterManager.manufacturer1TableAdapter = null;
            this.tableAdapterManager.order1TableAdapter = this.order1TableAdapter;
            this.tableAdapterManager.product1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = database_changer.shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user1TableAdapter = null;
            // 
            // order1BindingNavigator
            // 
            this.order1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.order1BindingNavigator.BindingSource = this.order1BindingSource;
            this.order1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.order1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.order1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.order1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.order1BindingNavigatorSaveItem});
            this.order1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.order1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.order1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.order1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.order1BindingNavigator.Name = "order1BindingNavigator";
            this.order1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.order1BindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.order1BindingNavigator.TabIndex = 0;
            this.order1BindingNavigator.Text = "bindingNavigator1";
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
            // order1BindingNavigatorSaveItem
            // 
            this.order1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.order1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("order1BindingNavigatorSaveItem.Image")));
            this.order1BindingNavigatorSaveItem.Name = "order1BindingNavigatorSaveItem";
            this.order1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.order1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.order1BindingNavigatorSaveItem.Click += new System.EventHandler(this.order1BindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 38);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order1BindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(132, 35);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // id_cartLabel
            // 
            id_cartLabel.AutoSize = true;
            id_cartLabel.Location = new System.Drawing.Point(12, 66);
            id_cartLabel.Name = "id_cartLabel";
            id_cartLabel.Size = new System.Drawing.Size(51, 17);
            id_cartLabel.TabIndex = 3;
            id_cartLabel.Text = "id cart:";
            // 
            // id_cartTextBox
            // 
            this.id_cartTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order1BindingSource, "id_cart", true));
            this.id_cartTextBox.Location = new System.Drawing.Point(132, 63);
            this.id_cartTextBox.Name = "id_cartTextBox";
            this.id_cartTextBox.Size = new System.Drawing.Size(200, 22);
            this.id_cartTextBox.TabIndex = 4;
            // 
            // total_priceLabel
            // 
            total_priceLabel.AutoSize = true;
            total_priceLabel.Location = new System.Drawing.Point(12, 94);
            total_priceLabel.Name = "total_priceLabel";
            total_priceLabel.Size = new System.Drawing.Size(74, 17);
            total_priceLabel.TabIndex = 5;
            total_priceLabel.Text = "total price:";
            // 
            // total_priceTextBox
            // 
            this.total_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order1BindingSource, "total_price", true));
            this.total_priceTextBox.Location = new System.Drawing.Point(132, 91);
            this.total_priceTextBox.Name = "total_priceTextBox";
            this.total_priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.total_priceTextBox.TabIndex = 6;
            // 
            // date_of_paymentLabel
            // 
            date_of_paymentLabel.AutoSize = true;
            date_of_paymentLabel.Location = new System.Drawing.Point(12, 123);
            date_of_paymentLabel.Name = "date_of_paymentLabel";
            date_of_paymentLabel.Size = new System.Drawing.Size(114, 17);
            date_of_paymentLabel.TabIndex = 7;
            date_of_paymentLabel.Text = "date of payment:";
            // 
            // date_of_paymentDateTimePicker
            // 
            this.date_of_paymentDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order1BindingSource, "date_of_payment", true));
            this.date_of_paymentDateTimePicker.Location = new System.Drawing.Point(132, 119);
            this.date_of_paymentDateTimePicker.Name = "date_of_paymentDateTimePicker";
            this.date_of_paymentDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.date_of_paymentDateTimePicker.TabIndex = 8;
            // 
            // order1DataGridView
            // 
            this.order1DataGridView.AutoGenerateColumns = false;
            this.order1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.order1DataGridView.DataSource = this.order1BindingSource;
            this.order1DataGridView.Location = new System.Drawing.Point(0, 157);
            this.order1DataGridView.Name = "order1DataGridView";
            this.order1DataGridView.RowHeadersWidth = 51;
            this.order1DataGridView.RowTemplate.Height = 24;
            this.order1DataGridView.Size = new System.Drawing.Size(800, 294);
            this.order1DataGridView.TabIndex = 9;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_cart";
            this.dataGridViewTextBoxColumn2.HeaderText = "id_cart";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "total_price";
            this.dataGridViewTextBoxColumn3.HeaderText = "total_price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date_of_payment";
            this.dataGridViewTextBoxColumn4.HeaderText = "date_of_payment";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // order1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.order1DataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(id_cartLabel);
            this.Controls.Add(this.id_cartTextBox);
            this.Controls.Add(total_priceLabel);
            this.Controls.Add(this.total_priceTextBox);
            this.Controls.Add(date_of_paymentLabel);
            this.Controls.Add(this.date_of_paymentDateTimePicker);
            this.Controls.Add(this.order1BindingNavigator);
            this.Name = "order1";
            this.Text = "order1";
            this.Load += new System.EventHandler(this.order1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order1BindingNavigator)).EndInit();
            this.order1BindingNavigator.ResumeLayout(false);
            this.order1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource order1BindingSource;
        private shopDataSetTableAdapters.order1TableAdapter order1TableAdapter;
        private shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator order1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton order1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox id_cartTextBox;
        private System.Windows.Forms.TextBox total_priceTextBox;
        private System.Windows.Forms.DateTimePicker date_of_paymentDateTimePicker;
        private System.Windows.Forms.DataGridView order1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}