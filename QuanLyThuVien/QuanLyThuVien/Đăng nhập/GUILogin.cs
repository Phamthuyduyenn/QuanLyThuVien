using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace LapTrinhCoSoDuLieu
{
    public partial class GUILogin : Form
    {
        DAOvsBUSLogin dn = new DAOvsBUSLogin();

        public GUILogin()
        {
            InitializeComponent();
        }
    }
}



