using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upomínač
{
    public partial class Form_Osoba : Form
    {
        private SprávceOsob spravceOsob;

        public Form_Osoba(SprávceOsob spravceOsob)
        {
            InitializeComponent();
            this.spravceOsob = spravceOsob;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                spravceOsob.Pridej(textBox_jmeno.Text, dateTimePicker_narozeniny.Value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
