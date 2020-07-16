using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Windows.Forms;
using Z.Expressions;
using System.Drawing;

namespace KarnaughMap
{
    public class Value
    {
        public bool x { get; set; }
        public bool y { get; set; }
        public bool z { get; set; }
        public bool w { get; set; }
        public bool F { get; set; }
    }

    public class Map
    {
        public int columnas { get; set; }
        public int renglones { get; set; }
        public TruthTable truthT;
        public Array matriz;
        public DataGridView DataMap { get; set; }
        public Color c { get; set; }

        public Map(TruthTable truthT)
        {
            this.truthT = truthT;
            if (this.truthT.cantVars % 2 == 0)
                renglones = columnas = Convert.ToInt32(Math.Sqrt(Math.Pow(2, this.truthT.cantVars)));
            else
            {
                columnas = Convert.ToInt32(Math.Sqrt(Math.Pow(2, this.truthT.cantVars + 1)));
                renglones = columnas / 2;
            }

            matriz = Array.CreateInstance(typeof(bool), renglones, columnas);
        }

        public Array ChangeValues(Array f, int im, int iM)
        {
            Array m = f;
            Object[] temp = new Object[truthT.cantVars + 1];

            for (int j = 0; j < truthT.cantVars + 1; j++)
            {
                temp[j] = m.GetValue(im, j);
                m.SetValue(m.GetValue(iM, j), im, j);
                m.SetValue(temp[j], iM, j);
            }

            return m;
        }

        public void FillMap()
        {
            

            if (truthT.cantVars == 3 || truthT.cantVars == 4)
            {
                for (int i = 0, j = 0; i < truthT.comb && j < truthT.comb; i++, j++)
                    if (i == 2 || i == 6 || i == 10 || i == 14)
                        truthT.Vars = ChangeValues(truthT.Vars, i, i + 1);

                if (truthT.cantVars == 4)
                    for (int j = 0; j < truthT.comb; j++)
                        if (j == 8 || j == 9 || j == 10 || j == 11)
                            truthT.Vars = ChangeValues(truthT.Vars, j, j + 4);
            }

            
            int index = 0;
            for (int i = 0; i < renglones; i++)
                for (int j = 0; j < columnas; j++, index++)
                    matriz.SetValue(truthT.Vars.GetValue(index, truthT.cantVars), i, j);
        }

        public void CreateMap()
        {
            for (int i = 0; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                    DataMap[j, i].Value = ((Convert.ToBoolean(matriz.GetValue(i, j)) == true) ? 1 : 0);
            }
        }

        public void MapColor()
        {
            for (int i = 0; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                    if (Convert.ToBoolean(DataMap[j, i].Value) == true)
                        DataMap[j, i].Style.BackColor = c;
            }
        }

        public void ClearMap()
        {
            for (int i = 0; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                        DataMap[j, i].Style.BackColor = Color.FromArgb(61,61,61);
            }
        }

    }
}
