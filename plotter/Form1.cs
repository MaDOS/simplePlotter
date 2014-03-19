using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace plotter
{
    public partial class Form1 : Form
    {
        static int size = 733;
        static int sizeHalf = (int)(size / 2);
        Graphics g;
        coordSystem csys = new coordSystem();
        Matrix translation;
        function selectedFunction;

        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(size + 24, size + 64);
            

        }

        private void btnAddNewFunction_Click(object sender, EventArgs e)
        {
            try
            {
                function newFunc;
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    newFunc = new function(this.txtNewFunction.Text, cd.Color);
                }
                else
                {
                    newFunc = new function(this.txtNewFunction.Text);
                }

                csys.addFunction(newFunc);
                this.lstFunctions.Items.Add(newFunc);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstFunctions.SelectedIndex == -1)
            {
                return;
            }
            this.selectedFunction = (function)lstFunctions.SelectedItem;
            this.lblEquation.Text = "f(x)=" + this.selectedFunction.equation;
            this.btnColor.BackColor = this.selectedFunction.color;
            if (this.selectedFunction.showAreaBelow)
            {
                this.chkBxArea.Checked = true;
            }
            else
            {
                this.chkBxArea.Checked = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.lstFunctions.SelectedIndex == -1)
            {
                return;
            }
            csys.removeFunction((function)this.lstFunctions.SelectedItem);
            this.lstFunctions.Items.RemoveAt(this.lstFunctions.SelectedIndex);
        }

        private void chkBxArea_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lstFunctions.SelectedIndex == -1)
            {
                return;
            }
            if (this.chkBxArea.Checked)
            {
                this.selectedFunction.showAreaBelow = true;
            }
            else
            {
                this.selectedFunction.showAreaBelow = false;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                this.selectedFunction.color = cd.Color;
                this.btnColor.BackColor = cd.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            g = this.tbPgDrawArea.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.GammaCorrected;
            translation = new Matrix();
            translation.Translate(sizeHalf, sizeHalf);
            translation.Scale(22, 22);
            g.Transform = translation;
            this.trckBrScale.Value = 22;
        }

        private void btnSetScale_Click(object sender, EventArgs e)
        {
            
        }

        private void reDraw()
        {
            g.Clear(Color.White);
            csys.Draw(g, sizeHalf);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reDraw();
        }

        private void tbPgDrawArea_Click(object sender, EventArgs e)
        {
            reDraw();
        }

        private void trckBrScale_Scroll(object sender, EventArgs e)
        {
            int newScale = this.trckBrScale.Value;
            translation = new Matrix();
            translation.Translate(sizeHalf, sizeHalf);
            translation.Scale(newScale, newScale);

            g.Transform = translation;

            reDraw();
        }

        private void tbCtrlPlotter_SelectedIndexChanged(object sender, EventArgs e)
        {
            reDraw();
        }
    }
}
