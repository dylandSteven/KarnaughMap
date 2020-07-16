using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Linq;
using System.Security.Policy;
using System.Collections.Generic;
using Z.Expressions;

namespace KarnaughMap
{
    public partial class Form1 : Form
    {

        public int cantVars;
        public int comb;
        public TruthTable table { get; set; }
        public Map map { get; set; }

        HashSet<long> oNSet = new HashSet<long>();
        Tuple<string, string> result;


        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BTNx_Click(object sender, EventArgs e)
        {
            TBXFunction.Text += "A";
        }
        private void BTNy_Click(object sender, EventArgs e)
        {
            TBXFunction.Text += "B";
        }
        private void BTNz_Click(object sender, EventArgs e)
        {
            TBXFunction.Text += "C";
        }
        private void BTNw_Click(object sender, EventArgs e)
        {
            TBXFunction.Text += "D";
        }
        private void BTNand_Click(object sender, EventArgs e)
        {
            if (cbxVars.Enabled == false)
                TBXFunction.Text += "^";
            else
                TBXFunction.Text += "";
        }
        private void BTNor_Click(object sender, EventArgs e)
        {
            if (cbxVars.Enabled == false)
                TBXFunction.Text += "v";
            else
                TBXFunction.Text += "";
        }
        private void BTNParentesis1_Click(object sender, EventArgs e)
        {
            if (cbxVars.Enabled == false)
                TBXFunction.Text += "(";
            else
                TBXFunction.Text += "";
        }
        private void BTNParentesis2_Click(object sender, EventArgs e)
        {
            if (cbxVars.Enabled == false)
                TBXFunction.Text += ")";
            else
                TBXFunction.Text += "";
        }
        private void BTNNnegacion_Click(object sender, EventArgs e)
        {
            if (cbxVars.Enabled == false)
                TBXFunction.Text += "~";
            else
                TBXFunction.Text += "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(TBXFunction.Text.Length > 0)
            {
                TBXFunction.Text = TBXFunction.Text.Remove(TBXFunction.Text.Length-1);
            }
        }

        /************************************************ HoverLeave ************************************************/

        private void BTNand_MouseEnter(object sender, EventArgs e)
        {
            BTNand.BackColor = Color.FromArgb(192, 57, 43);
        }
        private void BTNand_MouseLeave(object sender, EventArgs e)
        {
            BTNand.BackColor = Color.FromArgb(150, 40, 27);
        }

        private void BTNor_MouseEnter(object sender, EventArgs e)
        {
            BTNor.BackColor = Color.FromArgb(192, 57, 43);
        }
        private void BTNor_MouseLeave(object sender, EventArgs e)
        {
            BTNor.BackColor = Color.FromArgb(150, 40, 27);
        }

        private void BTNParentesis1_MouseEnter(object sender, EventArgs e)
        {
            BTNParentesis1.BackColor = Color.FromArgb(192, 57, 43);
        }
        private void BTNParentesis1_MouseLeave(object sender, EventArgs e)
        {
            BTNParentesis1.BackColor = Color.FromArgb(150, 40, 27);
        }

        private void BTNParentesis2_MouseEnter(object sender, EventArgs e)
        {
            BTNParentesis2.BackColor = Color.FromArgb(192, 57, 43);
        }
        private void BTNParentesis2_MouseLeave(object sender, EventArgs e)
        {
            BTNParentesis2.BackColor = Color.FromArgb(150, 40, 27);
        }

        private void BTNNnegacion_MouseEnter(object sender, EventArgs e)
        {
            BTNNnegacion.BackColor = Color.FromArgb(192, 57, 43);
        }
        private void BTNNnegacion_MouseLeave(object sender, EventArgs e)
        {
            BTNNnegacion.BackColor = Color.FromArgb(150, 40, 27);
        }

        private void BTNresultado_MouseEnter(object sender, EventArgs e)
        {
            BTNresultado.BackColor = Color.FromArgb(192, 57, 43);
        }
        private void BTNresultado_MouseLeave(object sender, EventArgs e)
        {
            BTNresultado.BackColor = Color.FromArgb(150, 40, 27);
        }

        private void BTNnew_MouseEnter(object sender, EventArgs e)
        {
            BTNnew.BackColor = Color.FromArgb(192, 57, 43);
        }
        private void BTNnew_MouseLeave(object sender, EventArgs e)
        {
            BTNnew.BackColor = Color.FromArgb(150, 40, 27);
        }


        /************************************************ VARIABLES ************************************************/


        string[] letras = { "A", "B", "C", "D"};
        void PrepararDGVParaTabla(int n)
        {
            for(int i = 0; i <= n; i++)
            {
                if (i == n)
                    DGVTable.Columns.Add("", "F");
                else
                    DGVTable.Columns.Add("", letras[i]);
            }

            for (int j = 0; j < Convert.ToInt32(Math.Pow(2, n)); j++)
                DGVTable.Rows.Add();

            for (int i = 0; i < n + 1; i++)
            {
                DGVTable.Columns[i].Width = 25;
                DGVTable.Width += DGVTable.Columns[i].Width;
            }   
        }
        void PrepararDGVParaMapa(int n)
        {
            if (n == 2)
            {
                DGVMap.Columns.Add("", "B'");
                DGVMap.Columns.Add("", "B");
                DGVMap.Rows.Add(); DGVMap.Rows.Add();
                DGVMap.Rows[0].HeaderCell.Value = "A'";
                DGVMap.Rows[1].HeaderCell.Value = "A";

                for (int i = 0; i < 2; i++)
                {
                    DGVMap.Columns[i].Width = 132;
                    DGVMap.Rows[i].Height = 132;
                    DGVMap.Width += DGVMap.Columns[i].Width;
                    DGVMap.Height += DGVMap.Rows[i].Height;
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        DGVMap[j, i].Style.Font = new Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
            else if(n == 3)
            {
                DGVMap.Columns.Add("", "B'C'");
                DGVMap.Columns.Add("", "B'C");
                DGVMap.Columns.Add("", "BC");
                DGVMap.Columns.Add("", "BC'");
                DGVMap.Rows.Add(); DGVMap.Rows.Add();
                DGVMap.Rows[0].HeaderCell.Value = "A'";
                DGVMap.Rows[1].HeaderCell.Value = "A";


                for (int i = 0; i < 2; i++)
                {
                    DGVMap.Rows[i].Height = 132;
                    DGVMap.Height += DGVMap.Rows[i].Height;
                }

                for (int i = 0; i < 4; i++)
                {
                    DGVMap.Columns[i].Width = 66;
                    DGVMap.Width += DGVMap.Columns[i].Width;
                }
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        DGVMap[j, i].Style.Font = new Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
            else if(n == 4)
            {
                DGVMap.RowHeadersWidth = 50;
                DGVMap.Columns.Add("", "C'D'");
                DGVMap.Columns.Add("", "C'D");
                DGVMap.Columns.Add("", "CD");
                DGVMap.Columns.Add("", "CD'");
                DGVMap.Rows.Add();
                DGVMap.Rows.Add();
                DGVMap.Rows.Add();
                DGVMap.Rows.Add();
                DGVMap.Rows[0].HeaderCell.Value = "A'B'";
                DGVMap.Rows[1].HeaderCell.Value = "A'B";
                DGVMap.Rows[2].HeaderCell.Value = "AB";
                DGVMap.Rows[3].HeaderCell.Value = "AB'";


                for (int i = 0; i < 4; i++)
                {
                    DGVMap.Rows[i].Height = 66;
                    DGVMap.Height += DGVMap.Rows[i].Height;
                }

                for (int i = 0; i < 4; i++)
                {
                    DGVMap.Columns[i].Width = 66;
                    DGVMap.Width += DGVMap.Columns[i].Width;
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        DGVMap[j, i].Style.Font = new Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
            }
        }
        
        public void InitForm(int w)
        {
            if(w == 0)
            {
                this.Width = 252;

                //AJUSTA LAS POSICIONES DE LOS BOTONES CERRAR Y MINIMIZAR
                label2.Location = new System.Drawing.Point(82, 8);
                label1.Location = new System.Drawing.Point(140, 8);
                pictureBox1.Location = new System.Drawing.Point(232, 7);
                pictureBox2.Location = new System.Drawing.Point(214, 7);

                TBXFunction.Text = "";
                TBXFunction.Enabled = false;
                BTNx.Enabled = false;
                BTNy.Enabled = false;
                BTNz.Enabled = false;
                BTNw.Enabled = false;
                BTNresultado.Enabled = false;
                cbxVars.Enabled = true;
                cbxVars.Text = "";

                DGVTable.DataSource = null;
                DGVTable.Columns.Clear();
                DGVMap.DataSource = null;
                DGVMap.Columns.Clear();
            }
            else
            {
                this.Width = 800;
                //800
                //780
                //762
                DGVTable.Enabled = false;
                DGVTable.ClearSelection();
                DGVMap.Enabled = false;
                DGVMap.ClearSelection();

                label2.Location = new System.Drawing.Point(380, 8);
                label1.Location = new System.Drawing.Point(438, 8);
                pictureBox1.Location = new System.Drawing.Point(780, 7);
                pictureBox2.Location = new System.Drawing.Point(762, 7);
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitForm(0);
        }
        
        private void cbxVars_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBXFunction.Enabled = true;
            BTNresultado.Enabled = true;
            cbxVars.Enabled = false;
            
            cantVars = Convert.ToInt32(cbxVars.Items[cbxVars.SelectedIndex]);
            //Creacion de Tabla de Verdad
            PrepararDGVParaTabla(cantVars);
            //Creacion Mapa de Karnaugh
            PrepararDGVParaMapa(cantVars);

            int y = 14;
            int x = 23;

            if (cbxVars.SelectedIndex == 0)
            {
                BTNx.Enabled = true;
                BTNy.Enabled = true;
                BTNx.ForeColor = Color.White;
                BTNy.ForeColor = Color.White;
                BTNz.Enabled = false;
                BTNw.Enabled = false;
                y = 143;
                x = 40;
            }
            if (cbxVars.SelectedIndex == 1)
            {
                BTNx.Enabled = true;
                BTNy.Enabled = true;
                BTNz.Enabled = true;
                BTNx.ForeColor = Color.White;
                BTNy.ForeColor = Color.White;
                BTNz.ForeColor = Color.White;
                BTNw.Enabled = false;
                x = 23;
                y = 98;
            }
            if (cbxVars.SelectedIndex == 2)
            {
                BTNx.Enabled = true;
                BTNy.Enabled = true;
                BTNz.Enabled = true;
                BTNw.Enabled = true;
                BTNx.ForeColor = Color.White;
                BTNy.ForeColor = Color.White;
                BTNz.ForeColor = Color.White;
                BTNw.ForeColor = Color.White;
                x = 23;
                y = 14;
            }

            DGVTable.Location = new Point(x, y);
        }

        private void TBXFunction_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Nota:
            /*
             
                ----------------------------------------------- Hex: 0x0NUM -----------------------------------------------

                Space: 20
                
                A: 41
                B: 42
                C: 43
                D: 44
                
                a: 61
                b: 62
                c: 63
                d: 64

                ~: 7E
                (: 28
                ): 29

                v: 76
                ^: 5E
                BackSpace: 8

            */

            if (cbxVars.SelectedIndex == 0)
                if (e.KeyChar != 0x041 && e.KeyChar != 0x042 &&
                    e.KeyChar != 0x061 && e.KeyChar != 0x062 &&
                    e.KeyChar != 0x07E && e.KeyChar != 0x028 && e.KeyChar != 0x029 &&
                    e.KeyChar != 0x08 && e.KeyChar != 0x076 && e.KeyChar != 0x05E)
                    e.Handled = true;

            if (cbxVars.SelectedIndex == 1)
                if (e.KeyChar != 0x041 && e.KeyChar != 0x042 && e.KeyChar != 0x043 &&
                    e.KeyChar != 0x061 && e.KeyChar != 0x062 && e.KeyChar != 0x063 &&
                    e.KeyChar != 0x07E && e.KeyChar != 0x028 && e.KeyChar != 0x029 &&
                    e.KeyChar != 0x08 && e.KeyChar != 0x076 && e.KeyChar != 0x05E)
                    e.Handled = true;

            if (cbxVars.SelectedIndex == 2)
                if (e.KeyChar != 0x041 && e.KeyChar != 0x042 && e.KeyChar != 0x043 && e.KeyChar != 0x044 &&
                    e.KeyChar != 0x061 && e.KeyChar != 0x062 && e.KeyChar != 0x063 && e.KeyChar != 0x064 &&
                    e.KeyChar != 0x07E && e.KeyChar != 0x028 && e.KeyChar != 0x029 &&
                    e.KeyChar != 0x08 && e.KeyChar != 0x076 && e.KeyChar != 0x05E)
                    e.Handled = true;
        }

        private void BTNnew_Click(object sender, EventArgs e)
        {
            InitForm(0);
            comb = 0;
            Console.Clear();
        }

        void StyleMap()
        {
            DGVMap.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(61, 61, 61);
            DGVMap.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(61, 61, 61);
        }

        private void BTNresultado_Click(object sender, EventArgs e)
        {
            StyleMap();
            // Map map = new Map(cantVars, TBXFunction.Text, GridValues, mapValues);
            comb = 0;
            table = new TruthTable(cantVars, TBXFunction.Text);
            table.Table = DGVTable;
            table.InsertValues();

            map = new Map(table);
            map.DataMap = DGVMap;

            

            if (table.verif == true)
            {
                MessageBox.Show("Introduzca una funcion valida", "ERROR");
            }
            else
            {
                Random Aleatorios = new Random();
                Aleatorios = new Random();
                int Red = Aleatorios.Next(250);
                int Blue = Aleatorios.Next(250);
                int Green = Aleatorios.Next(250);
                Color c = Color.FromArgb(Red, Green, Blue);

                table.c = c;
                map.c = c;

                table.CreateTable();
                table.ClearMinTerms();
                table.SelectMinTerms();

                comb = Convert.ToInt32(Math.Pow(2, cantVars));

                oNSet.Clear();
                for (int i = 0; i < comb; i++)
                {
                    if (Convert.ToInt32(table.Vars.GetValue(i, cantVars)) == 1)
                        oNSet.Add(long.Parse(i.ToString()));
                }

                if (oNSet.Count == 0)
                {
                    lblResult.Visible = false;
                    map.FillMap();
                    map.CreateMap();
                    map.ClearMap();
                    map.MapColor();
                    InitForm(1);
                }
                else
                {
                    lblResult.Visible = true;

                    var kMap = new KMap(cantVars, oNSet, new HashSet<long>() { });
                    result = kMap.PrintCoverages(true);
                    if (cantVars == 2 && oNSet.Count() == 4)
                        lblResult.Text = "1";
                    else if (cantVars == 3 && oNSet.Count() == 8)
                        lblResult.Text = "1";
                    else if (cantVars == 4 && oNSet.Count() == 16)
                        lblResult.Text = "1";
                    else
                        lblResult.Text = result.Item2;

                    map.FillMap();
                    map.CreateMap();
                    map.ClearMap();
                    map.MapColor();
                    InitForm(1);
                }
            }
        }

    }
}
