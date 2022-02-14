using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Browser_Project
{
    public partial class Form1 : Form
    {
        string Url = string.Empty;  // deklariranje Url varijable za kasnije korištenje
        public Form1()
        {
            InitializeComponent();
            Url = "https://www.google.hr/"; // postavljanje Url-a na određenu stranicu
        }
    }
}
