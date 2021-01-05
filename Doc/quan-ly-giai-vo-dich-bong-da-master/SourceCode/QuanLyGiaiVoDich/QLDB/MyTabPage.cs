using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;


namespace QLDB
{
    public class MyTabPage : TabPage
    {
        private Form frm;
        public MyTabPage(MyFormPage frm_contenido)
        {
            this.frm = frm_contenido;
            this.Controls.Add(frm_contenido._Mypanel);
            this.Text = frm_contenido.Text;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                frm.Dispose();
            }
            base.Dispose(disposing);
        }
    }
    public class MyFormPage : Form
    {
        public Panel _Mypanel;
    }


    public class MyTagPage : MyFormPage
    {
        private Form frm;
        public MyTagPage(MyFormPage frm_contensido)
        {
            this.frm = frm_contensido;
            this.Controls.Add(frm_contensido._Mypanel);
            this.Text = frm_contensido.Text;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                frm.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
