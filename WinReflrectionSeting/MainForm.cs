using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinReflrectionSeting
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 폼1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCreateForm("Form1");
        }

        private void 폼2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenCreateForm("Form2");
            OpenCreateForm<Form2>();
        }

        private void OpenCreateForm<T>() where T : Form, new()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(T))
                {
                    form.Activate();
                    return;
                }
            }

            T frm = new T();
            frm.MdiParent = this;
            frm.Show();
        }

        private void OpenCreateForm(string prgName)
        {
            string AppName = Assembly.GetEntryAssembly().GetName().Name;
            string programName = prgName;
            Type frmType = Type.GetType($"{AppName}.{programName}");

            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == frmType)
                {
                    form.Activate();
                    return;
                }
            }

            Form frm = (Form)Activator.CreateInstance(frmType);
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
