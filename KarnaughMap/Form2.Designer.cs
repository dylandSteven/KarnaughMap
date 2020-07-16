namespace KarnaughMap
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCalculator = new System.Windows.Forms.Panel();
            this.cbxVars = new System.Windows.Forms.ComboBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel4Variables = new System.Windows.Forms.Panel();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.panel3variables = new System.Windows.Forms.Panel();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.panel2variables = new System.Windows.Forms.Panel();
            this.btn0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCalculator.SuspendLayout();
            this.panel4Variables.SuspendLayout();
            this.panel3variables.SuspendLayout();
            this.panel2variables.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(450, 28);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(236, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Map";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::KarnaughMap.Properties.Resources.min_icon;
            this.pictureBox2.Location = new System.Drawing.Point(409, 8);
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
            this.pictureBox1.Location = new System.Drawing.Point(427, 8);
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
            this.label2.Location = new System.Drawing.Point(178, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Karnaugh";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            // 
            // panelCalculator
            // 
            this.panelCalculator.BackColor = System.Drawing.Color.Black;
            this.panelCalculator.Controls.Add(this.textBox1);
            this.panelCalculator.Controls.Add(this.cbxVars);
            this.panelCalculator.Controls.Add(this.lblOutput);
            this.panelCalculator.Controls.Add(this.panel4Variables);
            this.panelCalculator.Controls.Add(this.panel3variables);
            this.panelCalculator.Controls.Add(this.panel2variables);
            this.panelCalculator.Location = new System.Drawing.Point(0, 27);
            this.panelCalculator.Name = "panelCalculator";
            this.panelCalculator.Size = new System.Drawing.Size(447, 590);
            this.panelCalculator.TabIndex = 39;
            this.panelCalculator.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCalculator_Paint);
            // 
            // cbxVars
            // 
            this.cbxVars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVars.FormattingEnabled = true;
            this.cbxVars.Items.AddRange(new object[] {
            "2",
            "3",
            "4"});
            this.cbxVars.Location = new System.Drawing.Point(32, 21);
            this.cbxVars.Name = "cbxVars";
            this.cbxVars.Size = new System.Drawing.Size(376, 21);
            this.cbxVars.TabIndex = 100;
            this.cbxVars.SelectedIndexChanged += new System.EventHandler(this.cbxVars_SelectedIndexChanged_1);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(12, 490);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(90, 24);
            this.lblOutput.TabIndex = 58;
            this.lblOutput.Text = "Output:";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4Variables
            // 
            this.panel4Variables.Controls.Add(this.button20);
            this.panel4Variables.Controls.Add(this.button21);
            this.panel4Variables.Controls.Add(this.button22);
            this.panel4Variables.Controls.Add(this.button23);
            this.panel4Variables.Controls.Add(this.button24);
            this.panel4Variables.Controls.Add(this.button25);
            this.panel4Variables.Controls.Add(this.button26);
            this.panel4Variables.Controls.Add(this.button27);
            this.panel4Variables.Controls.Add(this.button12);
            this.panel4Variables.Controls.Add(this.button13);
            this.panel4Variables.Controls.Add(this.button14);
            this.panel4Variables.Controls.Add(this.button15);
            this.panel4Variables.Controls.Add(this.button16);
            this.panel4Variables.Controls.Add(this.button17);
            this.panel4Variables.Controls.Add(this.button18);
            this.panel4Variables.Controls.Add(this.button19);
            this.panel4Variables.Location = new System.Drawing.Point(333, 71);
            this.panel4Variables.Name = "panel4Variables";
            this.panel4Variables.Size = new System.Drawing.Size(36, 394);
            this.panel4Variables.TabIndex = 85;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.DarkRed;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button20.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button20.Location = new System.Drawing.Point(5, 364);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(25, 25);
            this.button20.TabIndex = 99;
            this.button20.Tag = "C16";
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.DarkRed;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button21.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button21.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button21.Location = new System.Drawing.Point(5, 340);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(25, 25);
            this.button21.TabIndex = 98;
            this.button21.Tag = "C15";
            this.button21.Text = "0";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.DarkRed;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button22.Location = new System.Drawing.Point(5, 316);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(25, 25);
            this.button22.TabIndex = 97;
            this.button22.Tag = "C14";
            this.button22.Text = "0";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.DarkRed;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button23.Location = new System.Drawing.Point(5, 292);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(25, 25);
            this.button23.TabIndex = 96;
            this.button23.Tag = "C13";
            this.button23.Text = "0";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.DarkRed;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button24.Location = new System.Drawing.Point(5, 268);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(25, 25);
            this.button24.TabIndex = 95;
            this.button24.Tag = "C12";
            this.button24.Text = "0";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.DarkRed;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button25.Location = new System.Drawing.Point(5, 244);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(25, 25);
            this.button25.TabIndex = 94;
            this.button25.Tag = "C11";
            this.button25.Text = "0";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.DarkRed;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button26.Location = new System.Drawing.Point(5, 220);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(25, 25);
            this.button26.TabIndex = 93;
            this.button26.Tag = "C10";
            this.button26.Text = "0";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.DarkRed;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button27.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button27.Location = new System.Drawing.Point(5, 196);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(25, 25);
            this.button27.TabIndex = 92;
            this.button27.Tag = "C9";
            this.button27.Text = "0";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkRed;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button12.Location = new System.Drawing.Point(5, 172);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(25, 25);
            this.button12.TabIndex = 91;
            this.button12.Tag = "C8";
            this.button12.Text = "0";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.DarkRed;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button13.Location = new System.Drawing.Point(5, 148);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(25, 25);
            this.button13.TabIndex = 90;
            this.button13.Tag = "C7";
            this.button13.Text = "0";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.DarkRed;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button14.Location = new System.Drawing.Point(5, 124);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(25, 25);
            this.button14.TabIndex = 89;
            this.button14.Tag = "C6";
            this.button14.Text = "0";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DarkRed;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button15.Location = new System.Drawing.Point(5, 100);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(25, 25);
            this.button15.TabIndex = 88;
            this.button15.Tag = "C5";
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DarkRed;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button16.Location = new System.Drawing.Point(5, 76);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(25, 25);
            this.button16.TabIndex = 87;
            this.button16.Tag = "C4";
            this.button16.Text = "0";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DarkRed;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button17.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button17.Location = new System.Drawing.Point(5, 52);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(25, 25);
            this.button17.TabIndex = 86;
            this.button17.Tag = "C3";
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.DarkRed;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button18.Location = new System.Drawing.Point(5, 28);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(25, 25);
            this.button18.TabIndex = 85;
            this.button18.Tag = "C2";
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.DarkRed;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button19.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button19.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button19.Location = new System.Drawing.Point(5, 4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(25, 25);
            this.button19.TabIndex = 84;
            this.button19.Tag = "C1";
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // panel3variables
            // 
            this.panel3variables.Controls.Add(this.button28);
            this.panel3variables.Controls.Add(this.button29);
            this.panel3variables.Controls.Add(this.button30);
            this.panel3variables.Controls.Add(this.button31);
            this.panel3variables.Controls.Add(this.button32);
            this.panel3variables.Controls.Add(this.button33);
            this.panel3variables.Controls.Add(this.button34);
            this.panel3variables.Controls.Add(this.button35);
            this.panel3variables.Location = new System.Drawing.Point(195, 75);
            this.panel3variables.Name = "panel3variables";
            this.panel3variables.Size = new System.Drawing.Size(34, 201);
            this.panel3variables.TabIndex = 84;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.DarkRed;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button28.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button28.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button28.Location = new System.Drawing.Point(5, 171);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(25, 25);
            this.button28.TabIndex = 75;
            this.button28.Tag = "B8";
            this.button28.Text = "0";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.DarkRed;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button29.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button29.Location = new System.Drawing.Point(5, 147);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(25, 25);
            this.button29.TabIndex = 74;
            this.button29.Tag = "B7";
            this.button29.Text = "0";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.button29_Click);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.DarkRed;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button30.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button30.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button30.Location = new System.Drawing.Point(5, 123);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(25, 25);
            this.button30.TabIndex = 73;
            this.button30.Tag = "B6";
            this.button30.Text = "0";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.DarkRed;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button31.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button31.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button31.Location = new System.Drawing.Point(5, 99);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(25, 25);
            this.button31.TabIndex = 72;
            this.button31.Tag = "B5";
            this.button31.Text = "0";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.DarkRed;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button32.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button32.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button32.Location = new System.Drawing.Point(5, 75);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(25, 25);
            this.button32.TabIndex = 71;
            this.button32.Tag = "B4";
            this.button32.Text = "0";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.DarkRed;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button33.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button33.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button33.Location = new System.Drawing.Point(5, 51);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(25, 25);
            this.button33.TabIndex = 70;
            this.button33.Tag = "B3";
            this.button33.Text = "0";
            this.button33.UseVisualStyleBackColor = false;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.DarkRed;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button34.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button34.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button34.Location = new System.Drawing.Point(5, 27);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(25, 25);
            this.button34.TabIndex = 69;
            this.button34.Tag = "B2";
            this.button34.Text = "0";
            this.button34.UseVisualStyleBackColor = false;
            this.button34.Click += new System.EventHandler(this.button34_Click);
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.DarkRed;
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button35.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button35.Location = new System.Drawing.Point(5, 3);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(25, 25);
            this.button35.TabIndex = 68;
            this.button35.Tag = "B1";
            this.button35.Text = "0";
            this.button35.UseVisualStyleBackColor = false;
            this.button35.Click += new System.EventHandler(this.button35_Click);
            // 
            // panel2variables
            // 
            this.panel2variables.Controls.Add(this.btn0);
            this.panel2variables.Controls.Add(this.button1);
            this.panel2variables.Controls.Add(this.button2);
            this.panel2variables.Controls.Add(this.button3);
            this.panel2variables.Location = new System.Drawing.Point(67, 71);
            this.panel2variables.Name = "panel2variables";
            this.panel2variables.Size = new System.Drawing.Size(30, 107);
            this.panel2variables.TabIndex = 60;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkRed;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn0.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn0.Location = new System.Drawing.Point(2, 4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(25, 25);
            this.btn0.TabIndex = 56;
            this.btn0.Tag = "A1";
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(2, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 57;
            this.button1.Tag = "A2";
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(2, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 58;
            this.button2.Tag = "A3";
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(2, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 59;
            this.button3.Tag = "A4";
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(108, 487);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(300, 73);
            this.textBox1.TabIndex = 101;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(446, 613);
            this.Controls.Add(this.panelCalculator);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCalculator.ResumeLayout(false);
            this.panelCalculator.PerformLayout();
            this.panel4Variables.ResumeLayout(false);
            this.panel3variables.ResumeLayout(false);
            this.panel2variables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelCalculator;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel panel4Variables;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Panel panel3variables;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Panel panel2variables;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbxVars;
        private System.Windows.Forms.TextBox textBox1;
    }
}