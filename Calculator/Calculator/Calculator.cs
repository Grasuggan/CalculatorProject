using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    class Calculator : Form
    {
        public Calculator()
        {
            TableLayoutPanel window = new TableLayoutPanel
            {
                RowCount = 2
            };

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill
            };
            panel.Controls.Add(window);
            Controls.Add(panel);

            Button c = new Button
            {
                Text = "C",
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(c);

            Button divide = new Button
            {
                Text = "%",
                TextAlign = ContentAlignment.MiddleCenter
            };
            panel.Controls.Add(divide);

            Button multiply = new Button
            {
                Text = "X",
                TextAlign = ContentAlignment.MiddleCenter,
                
            };
            panel.Controls.Add(multiply);

            

            



        }

    
    }
}
