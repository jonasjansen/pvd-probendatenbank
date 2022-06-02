using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;
using ProbenDatenbank.Forms;
using ProbenDatenbank.Forms.IDAnlegen;

namespace ProbenDatenbank
{
    public partial class Bearbeiten : Form
    {
        private BeschichtungCollection beschichtungCollection;
        const String ButtonEditName = "edit";
        const String ButtonAddAnalyticDataName = "addAnalyticData";
        
        public Bearbeiten()
        {
            beschichtungCollection = new BeschichtungCollection();
            InitializeComponent();
            InitializeDgvButtons();
            InitizalizeData();
        }
        
        private void InitizalizeData()
        {
            ProjektCollection projektCollection = new ProjektCollection();
            foreach (Projekt item in projektCollection.GetItems())
            {
                comboBoxProjekt.Items.Add(item);
            }

            AnlageCollection anlageCollection = new AnlageCollection();
            foreach (Anlage item in anlageCollection.GetItems())
            {
                comboBoxAnlage.Items.Add(item);
            }

            SubstratwerkstoffCollection substratwerkstoffCollection = new SubstratwerkstoffCollection();
            foreach (Substratwerkstoff item in substratwerkstoffCollection.GetItems())
            {
                comboBoxSubstratwerkstoff.Items.Add(item);
            }

            SchichtwerkstoffCollection schichtwerkstoffCollection = new SchichtwerkstoffCollection();
            foreach (Schichtwerkstoff item in schichtwerkstoffCollection.GetItems())
            {
                comboBoxSchichtwerkstoff.Items.Add(item);
            }
        }
        
        private void InitializeDgvButtons()
        {
            dataGridViewBeschichtung.Columns.Add(GetDgvButtonColumn(ButtonAddAnalyticDataName, "Analysedaten hinzufügen"));
            dataGridViewBeschichtung.Columns.Add(GetDgvButtonColumn(ButtonEditName, "Bearbeiten"));
        }

        private DataGridViewButtonColumn GetDgvButtonColumn(string name, string text)
        {
            return new DataGridViewButtonColumn
            {
                Name = name,
                Text = text,
                HeaderText = "",
                Width = 250,
                UseColumnTextForButtonValue = true
            };
        }
        
        /* UI components and functions */
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            InitializeTargetBelegungDataGridView();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxAnlage.SelectedItem = null;
            comboBoxProjekt.SelectedItem = null;
            comboBoxSubstratwerkstoff.SelectedItem = null;
            comboBoxSchichtwerkstoff.SelectedItem = null;
            textBoxId.Text = "";
        }

        private void buttonIdDecrease_Click(object sender, EventArgs e)
        {
            int number = 0;
            try
            {
                number = (int.Parse(textBoxId.Text) - 1);
            }
            catch (FormatException)
            {
                number = 0;
            }

            if (number < 0)
            {
                number = 0;
            }

            textBoxId.Text = number.ToString();
        }

        private void buttonIdIncrease_Click(object sender, EventArgs e)
        {
            int number = 0;
            try
            {
                number = (int.Parse(textBoxId.Text) + 1);
            }
            catch (FormatException)
            {
                number = 0;
            }

            if (number < 0)
            {
                number = 0;
            }

            textBoxId.Text = number.ToString();
        }
        
        private void InitializeTargetBelegungDataGridView()
        {
            dataGridViewBeschichtung.Rows.Clear();
            OverviewItemCollection collection = new OverviewItemCollection
            {
                ID = textBoxId.Text,
                Projekt = (Projekt)comboBoxProjekt.SelectedItem,
                Anlage = (Anlage)comboBoxAnlage.SelectedItem, 
                Substratwerkstoff = (Substratwerkstoff)comboBoxSubstratwerkstoff.SelectedItem,
                Schichtwerkstoff = (Schichtwerkstoff)comboBoxSchichtwerkstoff.SelectedItem
            };

            foreach (var baseEntity in collection.GetItems())
            {
                var item = (OverviewItem)baseEntity;
                
                dataGridViewBeschichtung.Rows.Add(
                    item.Beschichtung.Id.ToString()
                    );
            }
        }

        private void dataGridViewBeschichtung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == ButtonEditName)
                {
                    int beschichtungId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Beschichtung beschichtung = new Beschichtung();
                    beschichtung.Load(beschichtungId);
                
                    IDAnlegen formIdAnlegen = new IDAnlegen();
                    formIdAnlegen.AddBeschichtung(beschichtung);
                    formIdAnlegen.ShowDialog(this);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == ButtonAddAnalyticDataName)
                {
                    int beschichtungId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Beschichtung beschichtung = new Beschichtung();
                    beschichtung.Load(beschichtungId);
                    
                    Analysedaten formAnalysedaten = new Analysedaten();
                    formAnalysedaten.AddBeschichtung(beschichtung);
                    formAnalysedaten.ShowDialog(this);
                }
            }
        }
    }
}
