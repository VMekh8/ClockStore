namespace OOPLab15_16
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.годинникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCalculatePriceWithTax = new System.Windows.Forms.ToolStripButton();
            this.textNameBrand = new System.Windows.Forms.ToolStripTextBox();
            this.textboxNameModel = new System.Windows.Forms.ToolStripTextBox();
            this.btnChangeBracelet = new System.Windows.Forms.ToolStripButton();
            this.textboxChangeBracelet = new System.Windows.Forms.ToolStripTextBox();
            this.btnGetInfo = new System.Windows.Forms.ToolStripButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.tss1lFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStudent = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss1Clock = new System.Windows.Forms.ToolStripStatusLabel();
            this.tss1PriceWithTax = new System.Windows.Forms.ToolStripStatusLabel();
            this.GridClock = new System.Windows.Forms.DataGridView();
            this.bindSrcClock = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuMain.SuspendLayout();
            this.toolBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcClock)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.годинникToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOpen,
            this.MenuSave,
            this.MenuAbout,
            this.MenuExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MenuOpen
            // 
            this.MenuOpen.Image = global::OOPLab15_16.Properties.Resources._3643772_archive_archives_document_folder_open_113445;
            this.MenuOpen.Name = "MenuOpen";
            this.MenuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuOpen.Size = new System.Drawing.Size(165, 22);
            this.MenuOpen.Text = "Відкрити";
            this.MenuOpen.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // MenuSave
            // 
            this.MenuSave.Image = global::OOPLab15_16.Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509;
            this.MenuSave.Name = "MenuSave";
            this.MenuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuSave.Size = new System.Drawing.Size(165, 22);
            this.MenuSave.Text = "Зберегти";
            this.MenuSave.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Image = global::OOPLab15_16.Properties.Resources.emblemimportant_93499;
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(165, 22);
            this.MenuAbout.Text = "Про програму";
            this.MenuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Image = global::OOPLab15_16.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.MenuExit.Size = new System.Drawing.Size(165, 22);
            this.MenuExit.Text = "Вихід ";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // годинникToolStripMenuItem
            // 
            this.годинникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAdd,
            this.MenuEdit,
            this.MenuDelete});
            this.годинникToolStripMenuItem.Name = "годинникToolStripMenuItem";
            this.годинникToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.годинникToolStripMenuItem.Text = "Годинник";
            // 
            // MenuAdd
            // 
            this.MenuAdd.Image = global::OOPLab15_16.Properties.Resources.Plus_icon_icons_com_71848;
            this.MenuAdd.Name = "MenuAdd";
            this.MenuAdd.Size = new System.Drawing.Size(134, 22);
            this.MenuAdd.Text = "Додати";
            this.MenuAdd.Click += new System.EventHandler(this.MenuAdd_Click);
            // 
            // MenuEdit
            // 
            this.MenuEdit.Image = global::OOPLab15_16.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.Size = new System.Drawing.Size(134, 22);
            this.MenuEdit.Text = "Редагувати";
            this.MenuEdit.Click += new System.EventHandler(this.MenuEdit_Click);
            // 
            // MenuDelete
            // 
            this.MenuDelete.Image = global::OOPLab15_16.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.MenuDelete.Name = "MenuDelete";
            this.MenuDelete.Size = new System.Drawing.Size(134, 22);
            this.MenuDelete.Text = "Видалити";
            this.MenuDelete.Click += new System.EventHandler(this.MenuDelete_Click);
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel,
            this.btnClear,
            this.toolStripSeparator1,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator2,
            this.btnCalculatePriceWithTax,
            this.textNameBrand,
            this.textboxNameModel,
            this.btnChangeBracelet,
            this.textboxChangeBracelet,
            this.btnGetInfo});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(800, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::OOPLab15_16.Properties.Resources.Plus_icon_icons_com_71848;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Додати запис про студента";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::OOPLab15_16.Properties.Resources.pencil_striped_symbol_for_interface_edit_buttons_icon_icons_com_56782;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Редагувати запис про студента»";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::OOPLab15_16.Properties.Resources.trash_bin_icon_icons_com_67981;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "Видалити запис про студента";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 22);
            this.btnClear.Text = "Очистити дані";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::OOPLab15_16.Properties.Resources._3643772_archive_archives_document_folder_open_113445;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Завантажити з текстового файлу";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::OOPLab15_16.Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Зберегти у текстовому файлі";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCalculatePriceWithTax
            // 
            this.btnCalculatePriceWithTax.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalculatePriceWithTax.Image = global::OOPLab15_16.Properties.Resources.bagofmoney_5108;
            this.btnCalculatePriceWithTax.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalculatePriceWithTax.Name = "btnCalculatePriceWithTax";
            this.btnCalculatePriceWithTax.Size = new System.Drawing.Size(23, 22);
            this.btnCalculatePriceWithTax.Text = "Обчислити ціну з податком";
            this.btnCalculatePriceWithTax.Click += new System.EventHandler(this.btnCalculatePriceWithTax_Click);
            // 
            // textNameBrand
            // 
            this.textNameBrand.Name = "textNameBrand";
            this.textNameBrand.Size = new System.Drawing.Size(100, 25);
            this.textNameBrand.ToolTipText = "Введіть назву марки";
            // 
            // textboxNameModel
            // 
            this.textboxNameModel.Name = "textboxNameModel";
            this.textboxNameModel.Size = new System.Drawing.Size(100, 25);
            this.textboxNameModel.ToolTipText = "Введіть модель годинника";
            // 
            // btnChangeBracelet
            // 
            this.btnChangeBracelet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChangeBracelet.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeBracelet.Image")));
            this.btnChangeBracelet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangeBracelet.Name = "btnChangeBracelet";
            this.btnChangeBracelet.Size = new System.Drawing.Size(23, 22);
            this.btnChangeBracelet.Text = "toolStripButton8";
            this.btnChangeBracelet.Click += new System.EventHandler(this.btnChangeBracelet_Click);
            // 
            // textboxChangeBracelet
            // 
            this.textboxChangeBracelet.Name = "textboxChangeBracelet";
            this.textboxChangeBracelet.Size = new System.Drawing.Size(100, 25);
            this.textboxChangeBracelet.ToolTipText = "Введіть інший браслет";
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGetInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnGetInfo.Image")));
            this.btnGetInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(23, 22);
            this.btnGetInfo.Text = "Вивести інформацію про годинник";
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tss1lFileName,
            this.tsslStudent,
            this.tss1Clock,
            this.tss1PriceWithTax});
            this.statusBar.Location = new System.Drawing.Point(0, 428);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(800, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // tss1lFileName
            // 
            this.tss1lFileName.AutoSize = false;
            this.tss1lFileName.Name = "tss1lFileName";
            this.tss1lFileName.Size = new System.Drawing.Size(200, 17);
            this.tss1lFileName.Text = "tss1lFileName";
            this.tss1lFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslStudent
            // 
            this.tsslStudent.Name = "tsslStudent";
            this.tsslStudent.Size = new System.Drawing.Size(0, 17);
            // 
            // tss1Clock
            // 
            this.tss1Clock.AutoSize = false;
            this.tss1Clock.Name = "tss1Clock";
            this.tss1Clock.Size = new System.Drawing.Size(250, 17);
            this.tss1Clock.Text = "tss1Clock";
            this.tss1Clock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tss1PriceWithTax
            // 
            this.tss1PriceWithTax.AutoSize = false;
            this.tss1PriceWithTax.Name = "tss1PriceWithTax";
            this.tss1PriceWithTax.Size = new System.Drawing.Size(200, 17);
            this.tss1PriceWithTax.Text = "tss1PriceWithTax";
            this.tss1PriceWithTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GridClock
            // 
            this.GridClock.AllowUserToAddRows = false;
            this.GridClock.AllowUserToDeleteRows = false;
            this.GridClock.AutoGenerateColumns = false;
            this.GridClock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridClock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridClock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridClock.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridClock.DataSource = this.bindSrcClock;
            this.GridClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridClock.Location = new System.Drawing.Point(0, 49);
            this.GridClock.MultiSelect = false;
            this.GridClock.Name = "GridClock";
            this.GridClock.ReadOnly = true;
            this.GridClock.Size = new System.Drawing.Size(800, 379);
            this.GridClock.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridClock);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSrcClock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.DataGridView GridClock;
        private System.Windows.Forms.BindingSource bindSrcClock;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuOpen;
        private System.Windows.Forms.ToolStripMenuItem MenuSave;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem годинникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAdd;
        private System.Windows.Forms.ToolStripMenuItem MenuEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuDelete;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCalculatePriceWithTax;
        private System.Windows.Forms.ToolStripTextBox textNameBrand;
        private System.Windows.Forms.ToolStripButton btnChangeBracelet;
        private System.Windows.Forms.ToolStripTextBox textboxChangeBracelet;
        private System.Windows.Forms.ToolStripButton btnGetInfo;
        private System.Windows.Forms.ToolStripTextBox textboxNameModel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripStatusLabel tss1lFileName;
        private System.Windows.Forms.ToolStripStatusLabel tsslStudent;
        private System.Windows.Forms.ToolStripStatusLabel tss1Clock;
        private System.Windows.Forms.ToolStripStatusLabel tss1PriceWithTax;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

