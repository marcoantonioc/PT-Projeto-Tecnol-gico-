using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesingPT
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            
        }


        private void panel()        
        {            
            panelrhsubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelrhsubMenu.Visible == true)
                panelrhsubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

            

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelrhsubMenu);           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMarksubMenu);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showSubMenu(panelFinansubMenu);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            showSubMenu(panelComersubMenu);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOpsubMenu);
        }
        
        private void button10_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelComersubMenu);
        }

       

        private void button19_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormAdm form = new FormAdm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};            
            this.panel4.Controls.Add(form);
            form.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormRHFun form = new FormRHFun() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panel4.Controls.Add(form);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormRHPres form = new FormRHPres() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panel4.Controls.Add(form);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormRHAva form = new FormRHAva() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panel4.Controls.Add(form);
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormEmail form = new FormEmail() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panel4.Controls.Add(form);
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormFinDesp form = new FormFinDesp() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panel4.Controls.Add(form);
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormFinFat form = new FormFinFat() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panel4.Controls.Add(form);
            form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormGesVen form = new FormGesVen() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            this.panel4.Controls.Add(form);
            form.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            FormStock form = new FormStock() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel4.Controls.Add(form);
            form.Show();
        }
    }
}

