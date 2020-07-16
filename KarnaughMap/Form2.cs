using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace KarnaughMap
{
    public partial class Form2 : Form
    {
        public int cantVars;
        public int comb;
        
        HashSet<long> oNSet = new HashSet<long>();
        Tuple<string, string> result;

        public Form2()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        #region Interfaz
        private void Form2_Load(object sender, EventArgs e)
        {
            if (cbxVars.SelectedIndex == -1)
            {
                panel3variables.Enabled = false;
                panel4Variables.Enabled = false;
                panel2variables.Enabled = false;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 2Variables
        private void btn0_Click(object sender, EventArgs e)
        {
            btn0.Text = btn0.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = button1.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = button2.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = button3.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        #endregion

        #region 3Variables
        private void button35_Click(object sender, EventArgs e)
        {
            button35.Text = button35.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.Text = button34.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.Text = button33.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.Text = button32.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Text = button31.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Text = button30.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Text = button29.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Text = button28.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        #endregion

        #region 4Variables
        private void button19_Click(object sender, EventArgs e)
        {
            button19.Text = button19.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Text = button18.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.Text = button17.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Text = button16.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Text = button14.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Text = button13.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Text = button12.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Text = button27.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Text = button26.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Text = button25.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Text = button24.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Text = button23.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Text = button22.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Text = button21.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Text = button20.Text == "0" ? "1" : "0";
            Resultado(sender, e);
        }

        #endregion

        void Resultado(object sender, EventArgs e)
        {
            List<Button> boton2vars = new List<Button>();
            List<Button> boton3vars = new List<Button>();
            List<Button> boton4vars = new List<Button>();

            foreach (var a in panel2variables.Controls)
            {
                Button n = (Button)a;
                boton2vars.Add(n);
            }
            foreach (var a in panel3variables.Controls)
            {
                Button n = (Button)a;
                boton3vars.Add(n);
            }
            foreach (var a in panel4Variables.Controls)
            {
                Button n = (Button)a;
                boton4vars.Add(n);
            }

            // 2 vars se queda igual
            boton3vars.Reverse();
            boton4vars.Reverse();

            comb = Convert.ToInt32(Math.Pow(2, cantVars));

            oNSet.Clear();
            for (int i = 0; i < comb; i++)
            {
                if (cantVars == 2)
                    if (Convert.ToInt32(boton2vars.ElementAt(i).Text) == 1)
                        oNSet.Add(long.Parse(i.ToString()));
                if (cantVars == 3)
                    if (Convert.ToInt32(boton3vars.ElementAt(i).Text) == 1)
                        oNSet.Add(long.Parse(i.ToString()));
                if (cantVars == 4)
                    if (Convert.ToInt32(boton4vars.ElementAt(i).Text) == 1)
                        oNSet.Add(long.Parse(i.ToString()));
            }



            if (oNSet.Count == 0)
            {
                textBox1.Visible = false;
            }
            else
            {
                textBox1.Visible = true;

                var kMap = new KMap(cantVars, oNSet, new HashSet<long>() { });
                result = kMap.PrintCoverages(true);
                if (cantVars == 2 && oNSet.Count() == 4)
                    textBox1.Text = "1";
                else if (cantVars == 3 && oNSet.Count() == 8)
                    textBox1.Text = "1";
                else if (cantVars == 4 && oNSet.Count() == 16)
                    textBox1.Text = "1";
                else
                {
                    textBox1.Text = result.Item2;
                    if (textBox1.Width >= 261)
                        textBox1.Text += "\n";
                }

            }




        }
        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void cbxVars_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxVars_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cantVars = Convert.ToInt32(cbxVars.Items[cbxVars.SelectedIndex]);

            if (cbxVars.SelectedIndex == 0)
            {
                panel3variables.Enabled = false;
                panel4Variables.Enabled = false;
                panel2variables.Enabled = true;
                cantVars = 2;
            }
            if (cbxVars.SelectedIndex == 1)
            {
                panel2variables.Enabled = false;
                panel4Variables.Enabled = false;
                panel3variables.Enabled = true;
                cantVars = 3;
            }
            if (cbxVars.SelectedIndex == 2)
            {
                panel2variables.Enabled = false;
                panel3variables.Enabled = false;
                panel4Variables.Enabled = true;
                cantVars = 4;
            }
            if (cbxVars.SelectedIndex == -1)
            {
                panel3variables.Enabled = false;
                panel4Variables.Enabled = false;
                panel2variables.Enabled = false;
            }

            Resultado(sender, e);
        }

        private void panelCalculator_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblResult_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
