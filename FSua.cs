using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace QLDanhBa
{
    public partial class fSua : Form
    {
       
        private CXulyDanhBa xuly;
        public fSua()
        {
            InitializeComponent();
            xuly = new CXulyDanhBa();
        }
        
        private void FSua_Load(object sender, EventArgs e)
        {

        }
        private void btnSuaXacnhan_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSuaHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSua_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
