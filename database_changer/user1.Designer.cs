
namespace database_changer
{
    partial class user1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label addressLabel;
            this.shopDataSet = new database_changer.shopDataSet();
            this.user1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user1TableAdapter = new database_changer.shopDataSetTableAdapters.user1TableAdapter();
            this.tableAdapterManager = new database_changer.shopDataSetTableAdapters.TableAdapterManager();
            this.user1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.user1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.user1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingNavigator)).BeginInit();
            this.user1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // shopDataSet
            // 
            this.shopDataSet.DataSetName = "shopDataSet";
            this.shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user1BindingSource
            // 
            this.user1BindingSource.DataMember = "user1";
            this.user1BindingSource.DataSource = this.shopDataSet;
            // 
            // user1TableAdapter
            // 
            this.user1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cartTableAdapter = null;
            this.tableAdapterManager.manufacturer1TableAdapter = null;
            this.tableAdapterManager.order1TableAdapter = null;
            this.tableAdapterManager.product1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = database_changer.shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.user1TableAdapter = this.user1TableAdapter;
            // 
            // user1BindingNavigator
            // 
            this.user1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.user1BindingNavigator.BindingSource = this.user1BindingSource;
            this.user1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.user1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.user1BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.user1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.user1BindingNavigatorSaveItem});
            this.user1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.user1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.user1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.user1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.user1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.user1BindingNavigator.Name = "user1BindingNavigator";
            this.user1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.user1BindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.user1BindingNavigator.TabIndex = 0;
            this.user1BindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
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
            // user1BindingNavigatorSaveItem
            // 
            this.user1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.user1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("user1BindingNavigatorSaveItem.Image")));
            this.user1BindingNavigatorSaveItem.Name = "user1BindingNavigatorSaveItem";
            this.user1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.user1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.user1BindingNavigatorSaveItem.Click += new System.EventHandler(this.user1BindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user1BindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(90, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 68);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(47, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user1BindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(90, 65);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 96);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(72, 17);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user1BindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(90, 93);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 22);
            this.passwordTextBox.TabIndex = 6;
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Location = new System.Drawing.Point(12, 124);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(37, 17);
            mailLabel.TabIndex = 7;
            mailLabel.Text = "mail:";
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user1BindingSource, "mail", true));
            this.mailTextBox.Location = new System.Drawing.Point(90, 121);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(100, 22);
            this.mailTextBox.TabIndex = 8;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 152);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 17);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "address:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user1BindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(90, 149);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 22);
            this.addressTextBox.TabIndex = 10;
            // 
            // user1DataGridView
            // 
            this.user1DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user1DataGridView.AutoGenerateColumns = false;
            this.user1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.user1DataGridView.DataSource = this.user1BindingSource;
            this.user1DataGridView.Location = new System.Drawing.Point(0, 177);
            this.user1DataGridView.Name = "user1DataGridView";
            this.user1DataGridView.RowHeadersWidth = 51;
            this.user1DataGridView.RowTemplate.Height = 24;
            this.user1DataGridView.Size = new System.Drawing.Size(800, 275);
            this.user1DataGridView.TabIndex = 11;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "password";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "mail";
            this.dataGridViewTextBoxColumn4.HeaderText = "mail";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn5.HeaderText = "address";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // user1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.user1DataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.user1BindingNavigator);
            this.Name = "user1";
            this.Text = "user1";
            this.Load += new System.EventHandler(this.user1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingNavigator)).EndInit();
            this.user1BindingNavigator.ResumeLayout(false);
            this.user1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private shopDataSet shopDataSet;
        private System.Windows.Forms.BindingSource user1BindingSource;
        private shopDataSetTableAdapters.user1TableAdapter user1TableAdapter;
        private shopDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator user1BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton user1BindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.DataGridView user1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}