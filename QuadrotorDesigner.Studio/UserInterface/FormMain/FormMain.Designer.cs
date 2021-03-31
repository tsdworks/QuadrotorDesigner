
namespace QuadrotorDesigner.Workspace.UserInterface
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new DarkUI.Controls.DarkMenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewDesign = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewModel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSplit0 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSplit1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGotoLine = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSplit2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSplit3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSplit4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRunAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemComponentsExplorer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSplit5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarMain = new DarkUI.Controls.DarkToolStrip();
            this.buttonNew = new System.Windows.Forms.ToolStripDropDownButton();
            this.subMenuItemNewDesign = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuItemNewModel = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.ToolStripButton();
            this.buttonSaveAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonCut = new System.Windows.Forms.ToolStripButton();
            this.buttonCopy = new System.Windows.Forms.ToolStripButton();
            this.buttonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonUndo = new System.Windows.Forms.ToolStripButton();
            this.buttonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonRunAnalysis = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonComponentsExplorer = new System.Windows.Forms.ToolStripButton();
            this.buttonProperties = new System.Windows.Forms.ToolStripButton();
            this.buttonOutput = new System.Windows.Forms.ToolStripButton();
            this.statusStripMain = new DarkUI.Controls.DarkStatusStrip();
            this.toolStripStatusLabelState = new System.Windows.Forms.ToolStripStatusLabel();
            this.dockPanelMain = new DarkUI.Docking.DarkDockPanel();
            this.separatorMain = new DarkUI.Controls.DarkSeparator();
            this.contextMenuTreeView = new DarkUI.Controls.DarkContextMenu();
            this.contextMenuTreeViewSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuTreeViewModel = new System.Windows.Forms.ToolStripMenuItem();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.toolbarMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.contextMenuTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuStripMain.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStripMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuItemEdit,
            this.menuItemAnalysis,
            this.menuItemWindow,
            this.menuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1049, 27);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "darkMenuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNew,
            this.menuItemOpen,
            this.menuItemSplit0,
            this.menuItemSave,
            this.menuItemSaveAs,
            this.menuItemSaveAll,
            this.menuItemSplit1,
            this.menuItemExit});
            this.menuFile.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuFile.Name = "menuFile";
            this.menuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.menuFile.Size = new System.Drawing.Size(39, 23);
            this.menuFile.Text = "&File";
            // 
            // menuItemNew
            // 
            this.menuItemNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewDesign,
            this.menuItemNewModel});
            this.menuItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemNew.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.new_icon;
            this.menuItemNew.Name = "menuItemNew";
            this.menuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuItemNew.Size = new System.Drawing.Size(199, 22);
            this.menuItemNew.Text = "&New";
            // 
            // menuItemNewDesign
            // 
            this.menuItemNewDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemNewDesign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemNewDesign.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.design_icon;
            this.menuItemNewDesign.Name = "menuItemNewDesign";
            this.menuItemNewDesign.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.menuItemNewDesign.Size = new System.Drawing.Size(269, 22);
            this.menuItemNewDesign.Text = "&Drone Design";
            this.menuItemNewDesign.Click += new System.EventHandler(this.menuItemNewDesign_Click);
            // 
            // menuItemNewModel
            // 
            this.menuItemNewModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemNewModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemNewModel.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.component_file;
            this.menuItemNewModel.Name = "menuItemNewModel";
            this.menuItemNewModel.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.menuItemNewModel.Size = new System.Drawing.Size(269, 22);
            this.menuItemNewModel.Text = "&Component Model";
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemOpen.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.folder_open;
            this.menuItemOpen.Name = "menuItemOpen";
            this.menuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpen.Size = new System.Drawing.Size(199, 22);
            this.menuItemOpen.Text = "&Open File";
            this.menuItemOpen.Visible = false;
            // 
            // menuItemSplit0
            // 
            this.menuItemSplit0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSplit0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSplit0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuItemSplit0.Name = "menuItemSplit0";
            this.menuItemSplit0.Size = new System.Drawing.Size(196, 6);
            this.menuItemSplit0.Visible = false;
            // 
            // menuItemSave
            // 
            this.menuItemSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSave.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.save_icon;
            this.menuItemSave.Name = "menuItemSave";
            this.menuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSave.Size = new System.Drawing.Size(199, 22);
            this.menuItemSave.Text = "&Save";
            this.menuItemSave.Visible = false;
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSaveAs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.Size = new System.Drawing.Size(199, 22);
            this.menuItemSaveAs.Text = "&Save As";
            this.menuItemSaveAs.Visible = false;
            // 
            // menuItemSaveAll
            // 
            this.menuItemSaveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSaveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSaveAll.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.save_all_icon;
            this.menuItemSaveAll.Name = "menuItemSaveAll";
            this.menuItemSaveAll.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuItemSaveAll.Size = new System.Drawing.Size(199, 22);
            this.menuItemSaveAll.Text = "&Save All";
            this.menuItemSaveAll.Visible = false;
            // 
            // menuItemSplit1
            // 
            this.menuItemSplit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSplit1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSplit1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuItemSplit1.Name = "menuItemSplit1";
            this.menuItemSplit1.Size = new System.Drawing.Size(196, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemExit.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.exit_icon;
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuItemExit.Size = new System.Drawing.Size(199, 22);
            this.menuItemExit.Text = "&Exit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGotoLine,
            this.menuItemSplit2,
            this.menuItemFind,
            this.menuItemReplace,
            this.menuItemSplit3,
            this.menuItemUndo,
            this.menuItemRedo,
            this.menuItemSplit4,
            this.menuItemCut,
            this.menuItemCopy,
            this.menuItemPaste,
            this.menuItemDelete});
            this.menuItemEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.menuItemEdit.Size = new System.Drawing.Size(44, 23);
            this.menuItemEdit.Text = "&Edit";
            // 
            // menuItemGotoLine
            // 
            this.menuItemGotoLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemGotoLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemGotoLine.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.goto_line_icon;
            this.menuItemGotoLine.Name = "menuItemGotoLine";
            this.menuItemGotoLine.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.menuItemGotoLine.Size = new System.Drawing.Size(199, 24);
            this.menuItemGotoLine.Text = "&Goto Line";
            // 
            // menuItemSplit2
            // 
            this.menuItemSplit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSplit2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSplit2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuItemSplit2.Name = "menuItemSplit2";
            this.menuItemSplit2.Size = new System.Drawing.Size(196, 6);
            // 
            // menuItemFind
            // 
            this.menuItemFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemFind.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemFind.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.find_icon;
            this.menuItemFind.Name = "menuItemFind";
            this.menuItemFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemFind.Size = new System.Drawing.Size(199, 24);
            this.menuItemFind.Text = "&Find";
            // 
            // menuItemReplace
            // 
            this.menuItemReplace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemReplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemReplace.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.replace_icon;
            this.menuItemReplace.Name = "menuItemReplace";
            this.menuItemReplace.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuItemReplace.Size = new System.Drawing.Size(199, 24);
            this.menuItemReplace.Text = "&Replace";
            // 
            // menuItemSplit3
            // 
            this.menuItemSplit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSplit3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSplit3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuItemSplit3.Name = "menuItemSplit3";
            this.menuItemSplit3.Size = new System.Drawing.Size(196, 6);
            // 
            // menuItemUndo
            // 
            this.menuItemUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemUndo.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.undo_icon;
            this.menuItemUndo.Name = "menuItemUndo";
            this.menuItemUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.menuItemUndo.Size = new System.Drawing.Size(199, 24);
            this.menuItemUndo.Text = "&Undo";
            // 
            // menuItemRedo
            // 
            this.menuItemRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRedo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRedo.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.redo_icon;
            this.menuItemRedo.Name = "menuItemRedo";
            this.menuItemRedo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.menuItemRedo.Size = new System.Drawing.Size(199, 24);
            this.menuItemRedo.Text = "&Redo";
            // 
            // menuItemSplit4
            // 
            this.menuItemSplit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSplit4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSplit4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuItemSplit4.Name = "menuItemSplit4";
            this.menuItemSplit4.Size = new System.Drawing.Size(196, 6);
            // 
            // menuItemCut
            // 
            this.menuItemCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemCut.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.cut_icon;
            this.menuItemCut.Name = "menuItemCut";
            this.menuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItemCut.Size = new System.Drawing.Size(199, 24);
            this.menuItemCut.Text = "&Cut";
            // 
            // menuItemCopy
            // 
            this.menuItemCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemCopy.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.copy_icon;
            this.menuItemCopy.Name = "menuItemCopy";
            this.menuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.menuItemCopy.Size = new System.Drawing.Size(199, 24);
            this.menuItemCopy.Text = "&Copy";
            // 
            // menuItemPaste
            // 
            this.menuItemPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemPaste.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.paste_icon;
            this.menuItemPaste.Name = "menuItemPaste";
            this.menuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItemPaste.Size = new System.Drawing.Size(199, 24);
            this.menuItemPaste.Text = "&Paste";
            // 
            // menuItemDelete
            // 
            this.menuItemDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemDelete.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.delete_icon;
            this.menuItemDelete.Name = "menuItemDelete";
            this.menuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItemDelete.Size = new System.Drawing.Size(199, 24);
            this.menuItemDelete.Text = "&Delete";
            // 
            // menuItemAnalysis
            // 
            this.menuItemAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemAnalysis.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRunAnalysis});
            this.menuItemAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemAnalysis.Name = "menuItemAnalysis";
            this.menuItemAnalysis.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menuItemAnalysis.Size = new System.Drawing.Size(70, 23);
            this.menuItemAnalysis.Text = "&Analysis";
            // 
            // menuItemRunAnalysis
            // 
            this.menuItemRunAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemRunAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemRunAnalysis.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.run_icon;
            this.menuItemRunAnalysis.Name = "menuItemRunAnalysis";
            this.menuItemRunAnalysis.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuItemRunAnalysis.Size = new System.Drawing.Size(180, 24);
            this.menuItemRunAnalysis.Text = "&Run Analysis";
            this.menuItemRunAnalysis.Click += new System.EventHandler(this.menuItemRunAnalysis_Click);
            // 
            // menuItemWindow
            // 
            this.menuItemWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemComponentsExplorer,
            this.menuItemProperties,
            this.menuItemOutput});
            this.menuItemWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemWindow.Name = "menuItemWindow";
            this.menuItemWindow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.menuItemWindow.Size = new System.Drawing.Size(71, 23);
            this.menuItemWindow.Text = "&Window";
            // 
            // menuItemComponentsExplorer
            // 
            this.menuItemComponentsExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemComponentsExplorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemComponentsExplorer.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.component_docking_icon;
            this.menuItemComponentsExplorer.Name = "menuItemComponentsExplorer";
            this.menuItemComponentsExplorer.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.menuItemComponentsExplorer.Size = new System.Drawing.Size(292, 24);
            this.menuItemComponentsExplorer.Text = "&Componets Explorer";
            this.menuItemComponentsExplorer.Click += new System.EventHandler(this.menuItemComponentsExplorer_Click);
            // 
            // menuItemProperties
            // 
            this.menuItemProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemProperties.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.properties_docking_icon;
            this.menuItemProperties.Name = "menuItemProperties";
            this.menuItemProperties.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.menuItemProperties.Size = new System.Drawing.Size(292, 24);
            this.menuItemProperties.Text = "&Properties";
            this.menuItemProperties.Click += new System.EventHandler(this.menuItemProperties_Click);
            // 
            // menuItemOutput
            // 
            this.menuItemOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemOutput.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.console_docking_icon;
            this.menuItemOutput.Name = "menuItemOutput";
            this.menuItemOutput.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.menuItemOutput.Size = new System.Drawing.Size(292, 24);
            this.menuItemOutput.Text = "&Output";
            this.menuItemOutput.Click += new System.EventHandler(this.menuItemOutput_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGithub,
            this.menuItemSplit5,
            this.menuItemAbout});
            this.menuItemHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.menuItemHelp.Size = new System.Drawing.Size(49, 23);
            this.menuItemHelp.Text = "&Help";
            // 
            // menuItemGithub
            // 
            this.menuItemGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemGithub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemGithub.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.web_page_icon;
            this.menuItemGithub.Name = "menuItemGithub";
            this.menuItemGithub.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.menuItemGithub.Size = new System.Drawing.Size(257, 24);
            this.menuItemGithub.Text = "&Project Github";
            this.menuItemGithub.Click += new System.EventHandler(this.menuItemGithub_Click);
            // 
            // menuItemSplit5
            // 
            this.menuItemSplit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemSplit5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemSplit5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.menuItemSplit5.Name = "menuItemSplit5";
            this.menuItemSplit5.Size = new System.Drawing.Size(254, 6);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.menuItemAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.menuItemAbout.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.info_icon;
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.menuItemAbout.Size = new System.Drawing.Size(257, 24);
            this.menuItemAbout.Text = "&About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // toolbarMain
            // 
            this.toolbarMain.AutoSize = false;
            this.toolbarMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolbarMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolbarMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonNew,
            this.buttonSave,
            this.buttonSaveAll,
            this.toolStripSeparator0,
            this.buttonCut,
            this.buttonCopy,
            this.buttonPaste,
            this.toolStripSeparator1,
            this.buttonUndo,
            this.buttonRedo,
            this.toolStripSeparator2,
            this.buttonRunAnalysis,
            this.toolStripSeparator3,
            this.buttonComponentsExplorer,
            this.buttonProperties,
            this.buttonOutput});
            this.toolbarMain.Location = new System.Drawing.Point(0, 29);
            this.toolbarMain.Name = "toolbarMain";
            this.toolbarMain.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolbarMain.Size = new System.Drawing.Size(1049, 28);
            this.toolbarMain.TabIndex = 2;
            this.toolbarMain.Text = "darkToolStrip1";
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuItemNewDesign,
            this.subMenuItemNewModel});
            this.buttonNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonNew.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.new_icon;
            this.buttonNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(29, 25);
            this.buttonNew.Text = "New";
            // 
            // subMenuItemNewDesign
            // 
            this.subMenuItemNewDesign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.subMenuItemNewDesign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.subMenuItemNewDesign.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.design_icon;
            this.subMenuItemNewDesign.Name = "subMenuItemNewDesign";
            this.subMenuItemNewDesign.Size = new System.Drawing.Size(186, 22);
            this.subMenuItemNewDesign.Text = "&Drone Design";
            // 
            // subMenuItemNewModel
            // 
            this.subMenuItemNewModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.subMenuItemNewModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.subMenuItemNewModel.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.component_file;
            this.subMenuItemNewModel.Name = "subMenuItemNewModel";
            this.subMenuItemNewModel.Size = new System.Drawing.Size(186, 22);
            this.subMenuItemNewModel.Text = "&Component Model";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonSave.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.save_icon;
            this.buttonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(23, 25);
            this.buttonSave.Text = "Save";
            this.buttonSave.Visible = false;
            // 
            // buttonSaveAll
            // 
            this.buttonSaveAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonSaveAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSaveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonSaveAll.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.save_all_icon;
            this.buttonSaveAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSaveAll.Name = "buttonSaveAll";
            this.buttonSaveAll.Size = new System.Drawing.Size(23, 25);
            this.buttonSaveAll.Text = "Save All";
            this.buttonSaveAll.Visible = false;
            // 
            // toolStripSeparator0
            // 
            this.toolStripSeparator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator0.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator0.Name = "toolStripSeparator0";
            this.toolStripSeparator0.Size = new System.Drawing.Size(6, 28);
            // 
            // buttonCut
            // 
            this.buttonCut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonCut.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.cut_icon;
            this.buttonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(23, 25);
            this.buttonCut.Text = "Cut";
            // 
            // buttonCopy
            // 
            this.buttonCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonCopy.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.copy_icon;
            this.buttonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(23, 25);
            this.buttonCopy.Text = "Copy";
            // 
            // buttonPaste
            // 
            this.buttonPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonPaste.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.paste_icon;
            this.buttonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(23, 25);
            this.buttonPaste.Text = "Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // buttonUndo
            // 
            this.buttonUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonUndo.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.undo_icon;
            this.buttonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(23, 25);
            this.buttonUndo.Text = "Undo";
            // 
            // buttonRedo
            // 
            this.buttonRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRedo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonRedo.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.redo_icon;
            this.buttonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(23, 25);
            this.buttonRedo.Text = "Undo";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // buttonRunAnalysis
            // 
            this.buttonRunAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonRunAnalysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRunAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonRunAnalysis.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.run_icon;
            this.buttonRunAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRunAnalysis.Name = "buttonRunAnalysis";
            this.buttonRunAnalysis.Size = new System.Drawing.Size(23, 25);
            this.buttonRunAnalysis.Text = "Run Analysis";
            this.buttonRunAnalysis.Click += new System.EventHandler(this.buttonRunAnalysis_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // buttonComponentsExplorer
            // 
            this.buttonComponentsExplorer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonComponentsExplorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonComponentsExplorer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonComponentsExplorer.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.component_docking_icon;
            this.buttonComponentsExplorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonComponentsExplorer.Name = "buttonComponentsExplorer";
            this.buttonComponentsExplorer.Size = new System.Drawing.Size(23, 25);
            this.buttonComponentsExplorer.Text = "Components Explorer";
            this.buttonComponentsExplorer.Click += new System.EventHandler(this.menuItemComponentsExplorer_Click);
            // 
            // buttonProperties
            // 
            this.buttonProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonProperties.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.properties_docking_icon;
            this.buttonProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(23, 25);
            this.buttonProperties.Text = "Properties";
            this.buttonProperties.Click += new System.EventHandler(this.menuItemProperties_Click);
            // 
            // buttonOutput
            // 
            this.buttonOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.buttonOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.buttonOutput.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.console_docking_icon;
            this.buttonOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(23, 25);
            this.buttonOutput.Text = "Output";
            this.buttonOutput.Click += new System.EventHandler(this.menuItemOutput_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.AutoSize = false;
            this.statusStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.statusStripMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelState});
            this.statusStripMain.Location = new System.Drawing.Point(0, 631);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.statusStripMain.Size = new System.Drawing.Size(1049, 30);
            this.statusStripMain.SizingGrip = false;
            this.statusStripMain.TabIndex = 3;
            this.statusStripMain.Text = "darkStatusStrip1";
            // 
            // toolStripStatusLabelState
            // 
            this.toolStripStatusLabelState.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStripStatusLabelState.Name = "toolStripStatusLabelState";
            this.toolStripStatusLabelState.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabelState.Text = "Ready";
            // 
            // dockPanelMain
            // 
            this.dockPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.dockPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanelMain.Location = new System.Drawing.Point(0, 57);
            this.dockPanelMain.Name = "dockPanelMain";
            this.dockPanelMain.Size = new System.Drawing.Size(1049, 574);
            this.dockPanelMain.TabIndex = 4;
            this.dockPanelMain.ContentAdded += new System.EventHandler<DarkUI.Docking.DockContentEventArgs>(this.dockPanelMain_ContentAdded);
            this.dockPanelMain.ContentRemoved += new System.EventHandler<DarkUI.Docking.DockContentEventArgs>(this.dockPanelMain_ContentRemoved);
            // 
            // separatorMain
            // 
            this.separatorMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.separatorMain.Location = new System.Drawing.Point(0, 27);
            this.separatorMain.Name = "separatorMain";
            this.separatorMain.Size = new System.Drawing.Size(1049, 2);
            this.separatorMain.TabIndex = 1;
            // 
            // contextMenuTreeView
            // 
            this.contextMenuTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.contextMenuTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.contextMenuTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuTreeViewSelect,
            this.toolStripMenuItem1,
            this.contextMenuTreeViewModel});
            this.contextMenuTreeView.Name = "contextMenuTreeView";
            this.contextMenuTreeView.Size = new System.Drawing.Size(146, 55);
            this.contextMenuTreeView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuTreeView_Opening);
            // 
            // contextMenuTreeViewSelect
            // 
            this.contextMenuTreeViewSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.contextMenuTreeViewSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.contextMenuTreeViewSelect.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.component_selected;
            this.contextMenuTreeViewSelect.Name = "contextMenuTreeViewSelect";
            this.contextMenuTreeViewSelect.Size = new System.Drawing.Size(145, 22);
            this.contextMenuTreeViewSelect.Text = "Select";
            this.contextMenuTreeViewSelect.Click += new System.EventHandler(this.contextMenuTreeViewSelect_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // contextMenuTreeViewModel
            // 
            this.contextMenuTreeViewModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.contextMenuTreeViewModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.contextMenuTreeViewModel.Image = global::QuadrotorDesigner.Workspace.Properties.Resources.component_file;
            this.contextMenuTreeViewModel.Name = "contextMenuTreeViewModel";
            this.contextMenuTreeViewModel.Size = new System.Drawing.Size(145, 22);
            this.contextMenuTreeViewModel.Text = "View Model";
            // 
            // timerMenu
            // 
            this.timerMenu.Enabled = true;
            this.timerMenu.Interval = 200;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 661);
            this.Controls.Add(this.dockPanelMain);
            this.Controls.Add(this.toolbarMain);
            this.Controls.Add(this.separatorMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadrotor Designer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolbarMain.ResumeLayout(false);
            this.toolbarMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.contextMenuTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkMenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemNew;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewDesign;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewModel;
        private System.Windows.Forms.ToolStripSeparator menuItemSplit0;
        private System.Windows.Forms.ToolStripMenuItem menuItemSave;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAll;
        private System.Windows.Forms.ToolStripSeparator menuItemSplit1;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemEdit;
        private System.Windows.Forms.ToolStripMenuItem menuItemGotoLine;
        private System.Windows.Forms.ToolStripSeparator menuItemSplit2;
        private System.Windows.Forms.ToolStripMenuItem menuItemFind;
        private System.Windows.Forms.ToolStripMenuItem menuItemReplace;
        private System.Windows.Forms.ToolStripSeparator menuItemSplit3;
        private System.Windows.Forms.ToolStripMenuItem menuItemUndo;
        private System.Windows.Forms.ToolStripMenuItem menuItemRedo;
        private System.Windows.Forms.ToolStripSeparator menuItemSplit4;
        private System.Windows.Forms.ToolStripMenuItem menuItemCut;
        private System.Windows.Forms.ToolStripMenuItem menuItemCopy;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaste;
        private System.Windows.Forms.ToolStripMenuItem menuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuItemAnalysis;
        private System.Windows.Forms.ToolStripMenuItem menuItemRunAnalysis;
        private System.Windows.Forms.ToolStripMenuItem menuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem menuItemComponentsExplorer;
        private System.Windows.Forms.ToolStripMenuItem menuItemProperties;
        private System.Windows.Forms.ToolStripMenuItem menuItemOutput;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemGithub;
        private System.Windows.Forms.ToolStripSeparator menuItemSplit5;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private DarkUI.Controls.DarkToolStrip toolbarMain;
        private System.Windows.Forms.ToolStripDropDownButton buttonNew;
        private System.Windows.Forms.ToolStripMenuItem subMenuItemNewDesign;
        private System.Windows.Forms.ToolStripMenuItem subMenuItemNewModel;
        private System.Windows.Forms.ToolStripButton buttonSave;
        private System.Windows.Forms.ToolStripButton buttonSaveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator0;
        private System.Windows.Forms.ToolStripButton buttonCut;
        private System.Windows.Forms.ToolStripButton buttonCopy;
        private System.Windows.Forms.ToolStripButton buttonPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton buttonUndo;
        private System.Windows.Forms.ToolStripButton buttonRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton buttonRunAnalysis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton buttonComponentsExplorer;
        private System.Windows.Forms.ToolStripButton buttonProperties;
        private System.Windows.Forms.ToolStripButton buttonOutput;
        private DarkUI.Controls.DarkStatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelState;
        private DarkUI.Docking.DarkDockPanel dockPanelMain;
        private DarkUI.Controls.DarkSeparator separatorMain;
        private System.Windows.Forms.ToolStripMenuItem contextMenuTreeViewSelect;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuTreeViewModel;
        public DarkUI.Controls.DarkContextMenu contextMenuTreeView;
        private System.Windows.Forms.Timer timerMenu;
    }
}

