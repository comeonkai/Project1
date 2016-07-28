
//主窗口，其他窗口还没写
namespace UI
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("图片1", 13, 13);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("图片2", 13, 13);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("图片3", 13, 13);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("图片4", 13, 13);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("文件夹", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.skinToolTip1 = new CCWin.SkinToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageButton6 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton5 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton4 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton3 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton2 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton1 = new LT.WinForm.ImageButton.ImageButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.roundButton1 = new RoundButton.RoundButton();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.imageButton7 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton8 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton9 = new LT.WinForm.ImageButton.ImageButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageButton10 = new LT.WinForm.ImageButton.ImageButton();
            this.imageButton11 = new LT.WinForm.ImageButton.ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();

            // 
            // skinToolTip1
            // 
            this.skinToolTip1.AutoPopDelay = 5000;
            this.skinToolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.skinToolTip1.InitialDelay = 500;
            this.skinToolTip1.OwnerDraw = true;
            this.skinToolTip1.ReshowDelay = 800;

            #region 拆分器控件，用于把界面拆分为几个部分，其中包含拆分器的嵌套
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(4, 28);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(1100, 600);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(190)))), ((int)(((byte)(240)))));
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1192, 600);
            this.splitContainer1.SplitterDistance = 83;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);

            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(200)))), ((int)(((byte)(249)))));
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.roundButton1);
            this.splitContainer2.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel3);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1192, 509);
            this.splitContainer2.SplitterDistance = 905;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            this.splitContainer2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer2_SplitterMoved);
            #endregion

            #region 图片素材imageList1
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "addFolder.png");
            this.imageList1.Images.SetKeyName(1, "addImage.png");
            this.imageList1.Images.SetKeyName(2, "addImage2.jpg");
            this.imageList1.Images.SetKeyName(3, "check.png");
            this.imageList1.Images.SetKeyName(4, "clear.png");
            this.imageList1.Images.SetKeyName(5, "close.png");
            this.imageList1.Images.SetKeyName(6, "comparison.png");
            this.imageList1.Images.SetKeyName(7, "compress.png");
            this.imageList1.Images.SetKeyName(8, "delete.png");
            this.imageList1.Images.SetKeyName(9, "folder.png");
            this.imageList1.Images.SetKeyName(10, "ImageSort.jpg");
            this.imageList1.Images.SetKeyName(11, "maximize.png");
            this.imageList1.Images.SetKeyName(12, "minimize.png");
            this.imageList1.Images.SetKeyName(13, "optimization.png");
            this.imageList1.Images.SetKeyName(14, "person.png");
            this.imageList1.Images.SetKeyName(15, "search.png");
            this.imageList1.Images.SetKeyName(16, "settings.png");
            #endregion

            #region 图片素材imageList2
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "addImage2.jpg");
            #endregion

            #region 添加图片的圆形按钮roundButton1
            // 
            // roundButton1
            // 
            this.roundButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButton1.Diameter = 197;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.ImageEnter = null;
            this.roundButton1.ImageIndex = 0;
            this.roundButton1.ImageList = this.imageList2;
            this.roundButton1.ImageNormal = null;
            this.roundButton1.Location = new System.Drawing.Point(257, 122);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(2);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(197, 197);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.UseVisualStyleBackColor = true;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click_1);
            this.roundButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.roundButton1_KeyDown);
            this.roundButton1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roundButton1_KeyPress);
            #endregion

            #region 显示“添加图片”的label1控件
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(278, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "添加图片";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            #endregion

            #region 表格布局控件tableLayoutPanel，用于布局界面上方6个imageButton
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.imageButton6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1186, 77);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            #endregion

            #region 图片清理的imageButton1
            // 
            // imageButton1
            // 
            this.imageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton1.BackgroundImage = global::UI.Properties.Resources.btn1;
            this.imageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton1.ButtonImage = global::UI.Properties.Resources.btn1;
            this.imageButton1.ButtonText = "";
            this.imageButton1.Location = new System.Drawing.Point(1, 0);
            this.imageButton1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton1.MouseClickImage = null;
            this.imageButton1.MouseOverImage = global::UI.Properties.Resources.button1;
            this.imageButton1.Name = "imageButton1";
            this.imageButton1.Size = new System.Drawing.Size(175, 77);
            this.imageButton1.TabIndex = 0;
            this.imageButton1.Load += new System.EventHandler(this.imageButton1_Load);
            #endregion

            #region 优化图片的imageButton2
            // 
            // imageButton2
            // 
            this.imageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton2.BackgroundImage = global::UI.Properties.Resources.btn2;
            this.imageButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton2.ButtonImage = global::UI.Properties.Resources.btn2;
            this.imageButton2.ButtonText = "";
            this.imageButton2.Location = new System.Drawing.Point(178, 0);
            this.imageButton2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton2.MouseClickImage = null;
            this.imageButton2.MouseOverImage = global::UI.Properties.Resources.button2;
            this.imageButton2.Name = "imageButton2";
            this.imageButton2.Size = new System.Drawing.Size(175, 77);
            this.imageButton2.TabIndex = 1;
            this.imageButton2.Load += new System.EventHandler(this.imageButton2_Load);
            #endregion

            #region 压缩图片的imageButton3
            // 
            // imageButton3
            // 
            this.imageButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton3.BackgroundImage = global::UI.Properties.Resources.btn3;
            this.imageButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton3.ButtonImage = global::UI.Properties.Resources.btn3;
            this.imageButton3.ButtonText = "";
            this.imageButton3.Location = new System.Drawing.Point(355, 0);
            this.imageButton3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton3.MouseClickImage = null;
            this.imageButton3.MouseOverImage = global::UI.Properties.Resources.button3;
            this.imageButton3.Name = "imageButton3";
            this.imageButton3.Size = new System.Drawing.Size(175, 77);
            this.imageButton3.TabIndex = 2;
            this.imageButton3.Load += new System.EventHandler(this.imageButton3_Load);
            #endregion

            #region 图片比较的imageButton4
            // 
            // imageButton4
            // 
            this.imageButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton4.BackgroundImage = global::UI.Properties.Resources.btn4;
            this.imageButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton4.ButtonImage = global::UI.Properties.Resources.btn4;
            this.imageButton4.ButtonText = "";
            this.imageButton4.Location = new System.Drawing.Point(532, 0);
            this.imageButton4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton4.MouseClickImage = null;
            this.imageButton4.MouseOverImage = global::UI.Properties.Resources.button4;
            this.imageButton4.Name = "imageButton4";
            this.imageButton4.Size = new System.Drawing.Size(175, 77);
            this.imageButton4.TabIndex = 3;
            this.imageButton4.Load += new System.EventHandler(this.imageButton4_Load);
            #endregion

            #region 图片评分的imageButton5
            // 
            // imageButton5
            // 
            this.imageButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton5.BackgroundImage = global::UI.Properties.Resources.btn5;
            this.imageButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton5.ButtonImage = global::UI.Properties.Resources.btn5;
            this.imageButton5.ButtonText = "";
            this.imageButton5.Location = new System.Drawing.Point(709, 0);
            this.imageButton5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton5.MouseClickImage = null;
            this.imageButton5.MouseOverImage = global::UI.Properties.Resources.button5;
            this.imageButton5.Name = "imageButton5";
            this.imageButton5.Size = new System.Drawing.Size(175, 77);
            this.imageButton5.TabIndex = 4;
            this.imageButton5.Load += new System.EventHandler(this.imageButton5_Load);
            #endregion

            #region 用户设置的imageButton6
            // 
            // imageButton6
            // 
            this.imageButton6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton6.BackgroundImage = global::UI.Properties.Resources.btn6;
            this.imageButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton6.ButtonImage = global::UI.Properties.Resources.btn6;
            this.imageButton6.ButtonText = "";
            this.imageButton6.Location = new System.Drawing.Point(886, 0);
            this.imageButton6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.imageButton6.MouseClickImage = null;
            this.imageButton6.MouseOverImage = global::UI.Properties.Resources.button6;
            this.imageButton6.Name = "imageButton6";
            this.imageButton6.Size = new System.Drawing.Size(299, 77);
            this.imageButton6.TabIndex = 5;
            this.imageButton6.Load += new System.EventHandler(this.imageButton6_Load);
            #endregion

            #region 表格布局控件tableLayoutPanel2，用于布局右下方三个imageButton
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.Controls.Add(this.imageButton7, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.imageButton8, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.imageButton9, 3, 0);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 439);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(289, 35);
            this.tableLayoutPanel2.TabIndex = 2;
            #endregion

            #region 右下角添加图片的imageButton7
            // 
            // imageButton7
            // 
            this.imageButton7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton7.AutoSize = true;
            this.imageButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton7.ButtonImage = global::UI.Properties.Resources.addImage;
            this.imageButton7.ButtonText = "";
            this.imageButton7.Location = new System.Drawing.Point(221, 3);
            this.imageButton7.MouseClickImage = null;
            this.imageButton7.MouseOverImage = global::UI.Properties.Resources.addImage;
            this.imageButton7.Name = "imageButton7";
            this.imageButton7.Size = new System.Drawing.Size(28, 29);
            this.imageButton7.TabIndex = 0;
            this.imageButton7.Load += new System.EventHandler(this.imageButton7_Load);
            #endregion

            #region 右下角添加文件的imageButton8
            // 
            // imageButton8
            // 
            this.imageButton8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton8.AutoSize = true;
            this.imageButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton8.ButtonImage = global::UI.Properties.Resources.addFolder;
            this.imageButton8.ButtonText = "";
            this.imageButton8.Location = new System.Drawing.Point(187, 3);
            this.imageButton8.MouseClickImage = null;
            this.imageButton8.MouseOverImage = global::UI.Properties.Resources.addFolder_hight;
            this.imageButton8.Name = "imageButton8";
            this.imageButton8.Size = new System.Drawing.Size(28, 29);
            this.imageButton8.TabIndex = 1;
            this.imageButton8.Load += new System.EventHandler(this.imageButton8_Load);
            #endregion

            #region 右下角删除图片的imageButton9
            // 
            // imageButton9
            // 
            this.imageButton9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton9.AutoSize = true;
            this.imageButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.imageButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageButton9.ButtonImage = global::UI.Properties.Resources.delete;
            this.imageButton9.ButtonText = "";
            this.imageButton9.Location = new System.Drawing.Point(255, 3);
            this.imageButton9.MouseClickImage = null;
            this.imageButton9.MouseOverImage = global::UI.Properties.Resources.delete;
            this.imageButton9.Name = "imageButton9";
            this.imageButton9.Size = new System.Drawing.Size(31, 29);
            this.imageButton9.TabIndex = 2;
            this.imageButton9.Load += new System.EventHandler(this.imageButton9_Load);
            #endregion

            #region 表格布局控件tableLayoutPanel3，用于布局右边的目录树和按钮
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(289, 471);
            this.tableLayoutPanel3.TabIndex = 3;
            #endregion

            #region 右边目录树控件treeView1
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.Name = "treeView1";
            treeNode1.ForeColor = System.Drawing.Color.White;
            treeNode1.ImageIndex = 13;
            treeNode1.Name = "node1";
            treeNode1.SelectedImageIndex = 13;
            treeNode1.Text = "图片1";
            treeNode2.ForeColor = System.Drawing.Color.White;
            treeNode2.ImageIndex = 13;
            treeNode2.Name = "node2";
            treeNode2.SelectedImageIndex = 13;
            treeNode2.Text = "图片2";
            treeNode3.ForeColor = System.Drawing.Color.White;
            treeNode3.ImageIndex = 13;
            treeNode3.Name = "node3";
            treeNode3.SelectedImageIndex = 13;
            treeNode3.Text = "图片3";
            treeNode4.ForeColor = System.Drawing.Color.White;
            treeNode4.ImageIndex = 13;
            treeNode4.Name = "node4";
            treeNode4.SelectedImageIndex = 13;
            treeNode4.Text = "图片4";
            treeNode5.ForeColor = System.Drawing.Color.White;
            treeNode5.Name = "Folder";
            treeNode5.NodeFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode5.Text = "文件夹";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(289, 438);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_2);
            #endregion

            #region 右上角设置的imageButton10
            // 
            // imageButton10
            // 
            this.imageButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton10.ButtonImage = global::UI.Properties.Resources.settings;
            this.imageButton10.ButtonText = "";
            this.imageButton10.Location = new System.Drawing.Point(1063, 3);
            this.imageButton10.MouseClickImage = null;
            this.imageButton10.MouseOverImage = global::UI.Properties.Resources.settings;
            this.imageButton10.Name = "imageButton10";
            this.imageButton10.Size = new System.Drawing.Size(25, 17);
            this.imageButton10.TabIndex = 1;
            this.imageButton10.Load += new System.EventHandler(this.imageButton10_Load);
            #endregion

            #region 右上角搜索的imageButton11
            // 
            // imageButton11
            // 
            this.imageButton11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageButton11.ButtonImage = global::UI.Properties.Resources.search;
            this.imageButton11.ButtonText = "";
            this.imageButton11.Location = new System.Drawing.Point(1029, 3);
            this.imageButton11.MouseClickImage = null;
            this.imageButton11.MouseOverImage = global::UI.Properties.Resources.search;
            this.imageButton11.Name = "imageButton11";
            this.imageButton11.Size = new System.Drawing.Size(25, 17);
            this.imageButton11.TabIndex = 2;
            this.imageButton11.Load += new System.EventHandler(this.imageButton11_Load);
            #endregion

            #region 主窗口
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.imageButton11);
            this.Controls.Add(this.imageButton10);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            #endregion

        }

        #endregion

        private CCWin.SkinToolTip skinToolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ImageList imageList1;
        private RoundButton.RoundButton roundButton1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LT.WinForm.ImageButton.ImageButton imageButton1;
        private LT.WinForm.ImageButton.ImageButton imageButton6;
        private LT.WinForm.ImageButton.ImageButton imageButton5;
        private LT.WinForm.ImageButton.ImageButton imageButton4;
        private LT.WinForm.ImageButton.ImageButton imageButton3;
        private LT.WinForm.ImageButton.ImageButton imageButton2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LT.WinForm.ImageButton.ImageButton imageButton7;
        private LT.WinForm.ImageButton.ImageButton imageButton8;
        private LT.WinForm.ImageButton.ImageButton imageButton9;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private LT.WinForm.ImageButton.ImageButton imageButton10;
        private LT.WinForm.ImageButton.ImageButton imageButton11;

    }
}

