using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestGame
{
    public partial class Form1 : Form
    {
        //gMap map = new Map();

        int x = 0, y = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        // Cell paint
        private void TableLayoutPanel1_CellPaint(object sender, System.Windows.Forms.TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0 && e.Column == 1)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.CellBounds);
            }


            if (e.Row == 3 && e.Column == 3)
            {
                e.Graphics.FillEllipse(new SolidBrush(Color.Red), e.CellBounds);
            }

            e.Graphics.FillEllipse(new SolidBrush(Color.Green), 58, 78, 20, 20);
        }


        // panel mouse click
        private void TableLayoutPanel1_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int row = 0;
            int verticalOffset = 0;
            foreach (int h in tableLayoutPanel1.GetRowHeights())
            {
                int column = 0;
                int horizontalOffset = 0;
                foreach (int w in tableLayoutPanel1.GetColumnWidths())
                {
                    Rectangle rectangle = new Rectangle(horizontalOffset, verticalOffset, w, h);
                    if (rectangle.Contains(e.Location))
                    {
                        x = e.X; y = e.Y;
                        
                        MessageBox.Show(String.Format("row {0}, column {1} was clicked, x = {2}, y = {3}", row, column, e.X, e.Y));
                        return;
                    }
                    horizontalOffset += w;
                    column++;
                }
                verticalOffset += h;
                row++;
            }
        }
    }
}
