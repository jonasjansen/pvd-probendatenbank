using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Entity;
using ProbenDatenbank.src.Forms.Verwaltung;

namespace ProbenDatenbank.Forms.Verwaltung
{
    public partial class Verwaltung : Form
    {
        public Verwaltung()
        {
            InitializeComponent();
        }

        // Group Allgemein
        private void buttonProjektAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new ProjektAnlegen();
            form.ShowDialog();
        }
        
        private void buttonTechnologieAnlegen_Click(object sender, EventArgs e)
        {
            Form form= new TechnologieAnlegen();
            form.ShowDialog();
        }
        
        private void buttonBereichAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new BereichAnlegen();
            form.ShowDialog();
        }
        
        // Group Substrat
        private void buttonSubstratwerkstoffAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new SubstratwerkstoffAnlegen();
            form.ShowDialog();
        }
        private void buttonVorbehandlungAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new VorbehandlungAnlegen();
            form.ShowDialog();
        }
        
        // Group Prozess
        private void buttonAnlageAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new AnlageAnlegen();
            form.ShowDialog();
        }
        
        private void buttonModusAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new ModusAnlegen();
            form.ShowDialog();
        }

        private void buttonRotationAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new RotationAnlegen();
            form.ShowDialog();
        }

        private void buttonTargetAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new TargetwerkstoffAnlegen();
            form.ShowDialog();
        }
        
        // Group Schichtsystem
        private void buttonSchichtsystemAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new SchichtarchitekturAnlegen();
            form.ShowDialog();
        }
        private void buttonWerkstoffAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new SchichtwerkstoffAnlegen();
            form.ShowDialog();
        }
        // Group Analyse
        private void buttonAnalysemethodeAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new AnalysemethodeAnlegen();
            form.ShowDialog();
        }

        private void buttonEigenschaftAnlegen_Click(object sender, EventArgs e)
        {
            Form form = new EigenschaftAnlegen();
            form.ShowDialog();
        }
        // Rest
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
