using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ZedGraph;

namespace Draw
{
    public partial class FormControlBuild : Form
    {
        public FormControlBuild()
        {
            InitializeComponent();
            CreateGraph(zedGraphControlNewForm);
        }
        
        public void CreateGraph(ZedGraphControl zgc)
        {
            GraphPane myPane = zgc.GraphPane;
            PointPairList listControl = new PointPairList();
            PointPairList list = new PointPairList();

            myPane.CurveList.Clear();
            myPane.Title = "Picture";

            for (int i = 0; i < Program.u.Count; i++)
            {
                listControl.Add(i, Program.u[i]);
            }
            LineItem myCurve = myPane.AddCurve("Control",
                  listControl, Color.Blue, SymbolType.None);

            zgc.AxisChange();
            zgc.Invalidate();
            zgc.Show();
        }

    }

}
