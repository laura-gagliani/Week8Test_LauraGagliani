using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorraCinese.WinForm
{
    public partial class MorraCinese : Form
    {
        string sceltaUtente;

        public MorraCinese()
        {
            InitializeComponent();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            sceltaUtente = "carta";
            imgSceltaUtente.ImageLocation = @"F:\Laura\Documenti\Avanade\Pre-Academy\Week8Test\carta.png";

        }

        private void btnSasso_Click(object sender, EventArgs e)
        {
            sceltaUtente = "sasso";
            imgSceltaUtente.ImageLocation = @"F:\Laura\Documenti\Avanade\Pre-Academy\Week8Test\sasso.png";
        }

        private void btnForbici_Click(object sender, EventArgs e)
        {
            sceltaUtente = "forbici";
        }
    }
}
