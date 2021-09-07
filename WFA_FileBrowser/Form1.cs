using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_FileBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadComboBoxDefault(); // +
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadComboBoxDefault()
        {
            //Obtener la lista de unidades de la pc
            cboDirPath.DataSource = DriveInfo.GetDrives();
        }

        private void cboDirPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstCarpetas.DataSource = Directory.GetDirectories(cboDirPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(lstArchivos.Text);
            if (info.Extension == ".jpg" || info.Extension == ".gif" || info.Extension == ".png")
            {
                pctImagen.Image = Image.FromFile(lstArchivos.Text);
            }
        }

        private void lstArchivos_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lstArchivos.Text);

        }

        private void lstCarpetas_DoubleClick(object sender, EventArgs e)
        {
            
            cboDirPath.Text = lstCarpetas.Text;

            try
            {
                lstCarpetas.DataSource = Directory.GetDirectories(cboDirPath.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void lstCarpetas_Click(object sender, EventArgs e)
        {

        }

        private void lstCarpetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstArchivos.DataSource = Directory.GetFiles(lstCarpetas.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboDirPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    lstCarpetas.DataSource = Directory.GetDirectories(cboDirPath.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
