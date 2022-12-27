using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class linq1_where : Form
    {
        public linq1_where()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 3, 2, 4, 7, 6, 5 };
            foreach (var row in nums)
            { }
            var result1 = from num in nums
                          where num >= 5
                          select num;
            Console.WriteLine(string.Join(",", result1));
        }
    }
}
