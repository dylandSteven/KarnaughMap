using System;
using System.Drawing;
using System.Windows.Forms;
using Z.Expressions;

namespace KarnaughMap
{
    public class TruthTable
    {
        public int cantVars { get; set; }
        public int comb { get; set; }
        public Array Vars { get; set; }
        public bool verif { get; set; }
        public string op { get; set; }
        public DataGridView Table { get; set; }
        public Color c { get; set; }

        public TruthTable(int cantVars, string op)
        {
            this.cantVars = cantVars;
            comb = Convert.ToInt32(Math.Pow(2, cantVars));

            // Se hacen cambios en la cadena de operacion, para que la Funcion Operations determine el valor F por fila de tabla
            op = op.ToLower();
            op = op.Replace(" ", ""); op = op.Replace("^", "&&"); op = op.Replace("v", "||"); op = op.Replace("~", "!");

            this.op = op;
            
            Vars = Array.CreateInstance(typeof(bool), comb, 5);
        }

        public bool Operations(bool a, bool b, bool c, bool d)
        {
            bool temp = false;
            try
            {
                if (cantVars == 2) temp = Eval.Execute<bool>(op, new { a, b });
                if (cantVars == 3) temp = Eval.Execute<bool>(op, new { a, b, c });
                if (cantVars == 4) temp = Eval.Execute<bool>(op, new { a, b, c, d });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                verif = true;
            }
            return temp;
        }

        public void InsertValues()
        {
            int temp;
            int div = 1;
            bool value = true, a, b, c, d, F;

            for (int indexV = 0; indexV < cantVars; indexV++)
            {
                temp = comb / (2 * div);
                for (int indexXYZW = 0; indexXYZW < comb; indexXYZW++)
                {
                    if (indexXYZW % temp == 0)
                        value = !value;
                    Vars.SetValue(value, indexXYZW, indexV);
                    a = Convert.ToBoolean(Vars.GetValue(indexXYZW, 0));
                    b = Convert.ToBoolean(Vars.GetValue(indexXYZW, 1));
                    c = Convert.ToBoolean(Vars.GetValue(indexXYZW, 2));
                    d = Convert.ToBoolean(Vars.GetValue(indexXYZW, 3));
                    F = Operations(a, b, c, d);
                    Vars.SetValue(F, indexXYZW, cantVars);
                }
                div *= 2;
            }
        }

        public void CreateTable()
        {
            for (int i = 0; i < comb; i++)
            {
                for (int j = 0; j < cantVars + 1; j++)
                    Table[j, i].Value = ((Convert.ToBoolean(Vars.GetValue(i, j)) == true) ? 1 : 0);
            }
        }

        public void SelectMinTerms()
        {


            for (int i = 0; i < comb; i++)
            {
                if((Convert.ToBoolean(Vars.GetValue(i, cantVars)) == true))
                {
                    Table[cantVars, i].Style.BackColor = c;
                }
            }
        }

        public void ClearMinTerms()
        {
            for (int i = 0; i < comb; i++)
            {
                Table[cantVars, i].Style.BackColor = Color.FromArgb(61, 61, 61);
            }
        }

    }
}
