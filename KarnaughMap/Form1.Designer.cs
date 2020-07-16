namespace KarnaughMap
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCalculator = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxVars = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBXFunction = new System.Windows.Forms.TextBox();
            this.BTNNnegacion = new System.Windows.Forms.Button();
            this.BTNnew = new System.Windows.Forms.Button();
            this.BTNresultado = new System.Windows.Forms.Button();
            this.BTNor = new System.Windows.Forms.Button();
            this.BTNand = new System.Windows.Forms.Button();
            this.BTNParentesis2 = new System.Windows.Forms.Button();
            this.BTNParentesis1 = new System.Windows.Forms.Button();
            this.BTNw = new System.Windows.Forms.Button();
            this.BTNz = new System.Windows.Forms.Button();
            this.BTNy = new System.Windows.Forms.Button();
            this.BTNx = new System.Windows.Forms.Button();
            this.DGVTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DGVMap = new System.Windows.Forms.DataGridView();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMap)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 28);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(430, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Map";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::KarnaughMap.Properties.Resources.min_icon;
            this.pictureBox2.Location = new System.Drawing.Point(772, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 12);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KarnaughMap.Properties.Resources.close_icon;
            this.pictureBox1.Location = new System.Drawing.Point(790, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(372, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Karnaugh";
            // 
            // panelCalculator
            // 
            this.panelCalculator.BackColor = System.Drawing.Color.Black;
            this.panelCalculator.Controls.Add(this.button1);
            this.panelCalculator.Controls.Add(this.cbxVars);
            this.panelCalculator.Controls.Add(this.label6);
            this.panelCalculator.Controls.Add(this.label3);
            this.panelCalculator.Controls.Add(this.TBXFunction);
            this.panelCalculator.Controls.Add(this.BTNNnegacion);
            this.panelCalculator.Controls.Add(this.BTNnew);
            this.panelCalculator.Controls.Add(this.BTNresultado);
            this.panelCalculator.Controls.Add(this.BTNor);
            this.panelCalculator.Controls.Add(this.BTNand);
            this.panelCalculator.Controls.Add(this.BTNParentesis2);
            this.panelCalculator.Controls.Add(this.BTNParentesis1);
            this.panelCalculator.Controls.Add(this.BTNw);
            this.panelCalculator.Controls.Add(this.BTNz);
            this.panelCalculator.Controls.Add(this.BTNy);
            this.panelCalculator.Controls.Add(this.BTNx);
            this.panelCalculator.Location = new System.Drawing.Point(0, 26);
            this.panelCalculator.Name = "panelCalculator";
            this.panelCalculator.Size = new System.Drawing.Size(252, 502);
            this.panelCalculator.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(27)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(183, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 56;
            this.button1.Text = "<|";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxVars
            // 
            this.cbxVars.BackColor = System.Drawing.Color.White;
            this.cbxVars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxVars.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVars.FormattingEnabled = true;
            this.cbxVars.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbxVars.Location = new System.Drawing.Point(128, 23);
            this.cbxVars.Name = "cbxVars";
            this.cbxVars.Size = new System.Drawing.Size(106, 26);
            this.cbxVars.TabIndex = 55;
            this.cbxVars.SelectedIndexChanged += new System.EventHandler(this.cbxVars_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "Input";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Variables";
            // 
            // TBXFunction
            // 
            this.TBXFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBXFunction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBXFunction.Enabled = false;
            this.TBXFunction.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXFunction.Location = new System.Drawing.Point(18, 123);
            this.TBXFunction.Name = "TBXFunction";
            this.TBXFunction.Size = new System.Drawing.Size(215, 23);
            this.TBXFunction.TabIndex = 49;
            this.TBXFunction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBXFunction_KeyPress);
            // 
            // BTNNnegacion
            // 
            this.BTNNnegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(27)))));
            this.BTNNnegacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNNnegacion.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNnegacion.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNNnegacion.Location = new System.Drawing.Point(129, 286);
            this.BTNNnegacion.Name = "BTNNnegacion";
            this.BTNNnegacion.Size = new System.Drawing.Size(105, 50);
            this.BTNNnegacion.TabIndex = 48;
            this.BTNNnegacion.Text = "~";
            this.BTNNnegacion.UseVisualStyleBackColor = false;
            this.BTNNnegacion.Click += new System.EventHandler(this.BTNNnegacion_Click);
            this.BTNNnegacion.MouseEnter += new System.EventHandler(this.BTNNnegacion_MouseEnter);
            this.BTNNnegacion.MouseLeave += new System.EventHandler(this.BTNNnegacion_MouseLeave);
            // 
            // BTNnew
            // 
            this.BTNnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(27)))));
            this.BTNnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNnew.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNnew.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNnew.Location = new System.Drawing.Point(129, 162);
            this.BTNnew.Name = "BTNnew";
            this.BTNnew.Size = new System.Drawing.Size(50, 50);
            this.BTNnew.TabIndex = 47;
            this.BTNnew.Text = "AC";
            this.BTNnew.UseVisualStyleBackColor = false;
            this.BTNnew.Click += new System.EventHandler(this.BTNnew_Click);
            this.BTNnew.MouseEnter += new System.EventHandler(this.BTNnew_MouseEnter);
            this.BTNnew.MouseLeave += new System.EventHandler(this.BTNnew_MouseLeave);
            // 
            // BTNresultado
            // 
            this.BTNresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(27)))));
            this.BTNresultado.Enabled = false;
            this.BTNresultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNresultado.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNresultado.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNresultado.Location = new System.Drawing.Point(128, 346);
            this.BTNresultado.Name = "BTNresultado";
            this.BTNresultado.Size = new System.Drawing.Size(105, 50);
            this.BTNresultado.TabIndex = 46;
            this.BTNresultado.Text = "=";
            this.BTNresultado.UseVisualStyleBackColor = false;
            this.BTNresultado.Click += new System.EventHandler(this.BTNresultado_Click);
            this.BTNresultado.MouseEnter += new System.EventHandler(this.BTNresultado_MouseEnter);
            this.BTNresultado.MouseLeave += new System.EventHandler(this.BTNresultado_MouseLeave);
            // 
            // BTNor
            // 
            this.BTNor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(27)))));
            this.BTNor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNor.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNor.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNor.Location = new System.Drawing.Point(17, 346);
            this.BTNor.Name = "BTNor";
            this.BTNor.Size = new System.Drawing.Size(105, 50);
            this.BTNor.TabIndex = 45;
            this.BTNor.Text = "OR";
            this.BTNor.UseVisualStyleBackColor = false;
            this.BTNor.Click += new System.EventHandler(this.BTNor_Click);
            this.BTNor.MouseEnter += new System.EventHandler(this.BTNor_MouseEnter);
            this.BTNor.MouseLeave += new System.EventHandler(this.BTNor_MouseLeave);
            // 
            // BTNand
            // 
            this.BTNand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(27)))));
            this.BTNand.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNand.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNand.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNand.Location = new System.Drawing.Point(18, 286);
            this.BTNand.Name = "BTNand";
            this.BTNand.Size = new System.Drawing.Size(105, 50);
            this.BTNand.TabIndex = 44;
            this.BTNand.Text = "AND";
            this.BTNand.UseVisualStyleBackColor = false;
            this.BTNand.Click += new System.EventHandler(this.BTNand_Click);
            this.BTNand.MouseEnter += new System.EventHandler(this.BTNand_MouseEnter);
            this.BTNand.MouseLeave += new System.EventHandler(this.BTNand_MouseLeave);
            // 
            // BTNParentesis2
            // 
            this.BTNParentesis2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(27)))));
            this.BTNParentesis2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNParentesis2.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNParentesis2.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNParentesis2.Location = new System.Drawing.Point(183, 224);
            this.BTNParentesis2.Name = "BTNParentesis2";
            this.BTNParentesis2.Size = new System.Drawing.Size(50, 50);
            this.BTNParentesis2.TabIndex = 43;
            this.BTNParentesis2.Text = ")";
            this.BTNParentesis2.UseVisualStyleBackColor = false;
            this.BTNParentesis2.Click += new System.EventHandler(this.BTNParentesis2_Click);
            this.BTNParentesis2.MouseEnter += new System.EventHandler(this.BTNParentesis2_MouseEnter);
            this.BTNParentesis2.MouseLeave += new System.EventHandler(this.BTNParentesis2_MouseLeave);
            // 
            // BTNParentesis1
            // 
            this.BTNParentesis1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(27)))));
            this.BTNParentesis1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNParentesis1.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNParentesis1.ForeColor = System.Drawing.SystemColors.Control;
            this.BTNParentesis1.Location = new System.Drawing.Point(129, 224);
            this.BTNParentesis1.Name = "BTNParentesis1";
            this.BTNParentesis1.Size = new System.Drawing.Size(50, 50);
            this.BTNParentesis1.TabIndex = 42;
            this.BTNParentesis1.Text = "(";
            this.BTNParentesis1.UseVisualStyleBackColor = false;
            this.BTNParentesis1.Click += new System.EventHandler(this.BTNParentesis1_Click);
            this.BTNParentesis1.MouseEnter += new System.EventHandler(this.BTNParentesis1_MouseEnter);
            this.BTNParentesis1.MouseLeave += new System.EventHandler(this.BTNParentesis1_MouseLeave);
            // 
            // BTNw
            // 
            this.BTNw.BackColor = System.Drawing.Color.DarkRed;
            this.BTNw.Enabled = false;
            this.BTNw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNw.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNw.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNw.Location = new System.Drawing.Point(73, 224);
            this.BTNw.Name = "BTNw";
            this.BTNw.Size = new System.Drawing.Size(50, 50);
            this.BTNw.TabIndex = 41;
            this.BTNw.Text = "D";
            this.BTNw.UseVisualStyleBackColor = false;
            this.BTNw.Click += new System.EventHandler(this.BTNw_Click);
            // 
            // BTNz
            // 
            this.BTNz.BackColor = System.Drawing.Color.DarkRed;
            this.BTNz.Enabled = false;
            this.BTNz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNz.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNz.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNz.Location = new System.Drawing.Point(18, 224);
            this.BTNz.Name = "BTNz";
            this.BTNz.Size = new System.Drawing.Size(50, 50);
            this.BTNz.TabIndex = 40;
            this.BTNz.Text = "C";
            this.BTNz.UseVisualStyleBackColor = false;
            this.BTNz.Click += new System.EventHandler(this.BTNz_Click);
            // 
            // BTNy
            // 
            this.BTNy.BackColor = System.Drawing.Color.DarkRed;
            this.BTNy.Enabled = false;
            this.BTNy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNy.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNy.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNy.Location = new System.Drawing.Point(73, 162);
            this.BTNy.Name = "BTNy";
            this.BTNy.Size = new System.Drawing.Size(50, 50);
            this.BTNy.TabIndex = 39;
            this.BTNy.Text = "B";
            this.BTNy.UseVisualStyleBackColor = false;
            this.BTNy.Click += new System.EventHandler(this.BTNy_Click);
            // 
            // BTNx
            // 
            this.BTNx.BackColor = System.Drawing.Color.DarkRed;
            this.BTNx.Enabled = false;
            this.BTNx.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNx.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNx.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BTNx.Location = new System.Drawing.Point(18, 162);
            this.BTNx.Name = "BTNx";
            this.BTNx.Size = new System.Drawing.Size(50, 50);
            this.BTNx.TabIndex = 38;
            this.BTNx.Text = "A";
            this.BTNx.UseVisualStyleBackColor = false;
            this.BTNx.Click += new System.EventHandler(this.BTNx_Click);
            // 
            // DGVTable
            // 
            this.DGVTable.AllowUserToAddRows = false;
            this.DGVTable.AllowUserToDeleteRows = false;
            this.DGVTable.AllowUserToResizeColumns = false;
            this.DGVTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DGVTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.DGVTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVTable.EnableHeadersVisualStyles = false;
            this.DGVTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DGVTable.Location = new System.Drawing.Point(23, 3);
            this.DGVTable.MultiSelect = false;
            this.DGVTable.Name = "DGVTable";
            this.DGVTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVTable.RowHeadersVisible = false;
            this.DGVTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DGVTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DGVTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVTable.Size = new System.Drawing.Size(67, 376);
            this.DGVTable.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVTable);
            this.panel2.Location = new System.Drawing.Point(258, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 403);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DGVMap);
            this.panel3.Location = new System.Drawing.Point(415, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(361, 356);
            this.panel3.TabIndex = 42;
            // 
            // DGVMap
            // 
            this.DGVMap.AllowUserToAddRows = false;
            this.DGVMap.AllowUserToDeleteRows = false;
            this.DGVMap.AllowUserToResizeColumns = false;
            this.DGVMap.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DGVMap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGVMap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.DGVMap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVMap.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DGVMap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DGVMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVMap.DefaultCellStyle = dataGridViewCellStyle8;
            this.DGVMap.EnableHeadersVisualStyles = false;
            this.DGVMap.GridColor = System.Drawing.Color.White;
            this.DGVMap.Location = new System.Drawing.Point(19, 45);
            this.DGVMap.MultiSelect = false;
            this.DGVMap.Name = "DGVMap";
            this.DGVMap.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVMap.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DGVMap.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.DGVMap.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVMap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVMap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGVMap.Size = new System.Drawing.Size(264, 248);
            this.DGVMap.TabIndex = 42;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(478, 378);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(90, 24);
            this.lblOutput.TabIndex = 55;
            this.lblOutput.Text = "Output:";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblResult);
            this.panel4.Controls.Add(this.lblOutput);
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(806, 435);
            this.panel4.TabIndex = 56;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(567, 380);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(72, 24);
            this.lblResult.TabIndex = 56;
            this.lblResult.Text = "label4";
            this.lblResult.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(811, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCalculator);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KarnaughMap";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCalculator.ResumeLayout(false);
            this.panelCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMap)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCalculator;
        private System.Windows.Forms.TextBox TBXFunction;
        private System.Windows.Forms.Button BTNNnegacion;
        private System.Windows.Forms.Button BTNnew;
        private System.Windows.Forms.Button BTNresultado;
        private System.Windows.Forms.Button BTNor;
        private System.Windows.Forms.Button BTNand;
        private System.Windows.Forms.Button BTNParentesis2;
        private System.Windows.Forms.Button BTNParentesis1;
        private System.Windows.Forms.Button BTNw;
        private System.Windows.Forms.Button BTNz;
        private System.Windows.Forms.Button BTNy;
        private System.Windows.Forms.Button BTNx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView DGVMap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxVars;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblResult;
    }
}

