namespace upomínač
{
    public partial class Form_Prehled : Form
    {
        private SprávceOsob spravceOsob = new SprávceOsob();

        public Form_Prehled()
        {
            InitializeComponent();
            label_dnes.Text = DateTime.Now.ToLongDateString();
            listBox_osoby.DataSource = spravceOsob.Osoby;
        }

        private void button_pridat_Click(object sender, EventArgs e)
        {
            Form_Osoba osobaForm = new Form_Osoba(spravceOsob);
            osobaForm.ShowDialog();
        }

        private void listBox_osoby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_osoby.SelectedItem != null)
            {
                Osoba vybrana = (Osoba)listBox_osoby.SelectedItem;
                label_narozeniny.Text = vybrana.Narozeniny.ToLongDateString();
                label_vek.Text = vybrana.SpoctiVek().ToString();
                monthCalendar_narozeniny.SelectionStart = vybrana.Narozeniny;
            }
        }

        private void button_odebrat_Click(object sender, EventArgs e)
        {
            if (listBox_osoby.SelectedItem != null)
            {
                spravceOsob.Odeber((Osoba)listBox_osoby.SelectedItem);

            }

            label_narozeniny.Text = "";
            label_vek.Text = "";

        }
    }
}