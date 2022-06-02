using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;
using ProbenDatenbank.Forms;

namespace ProbenDatenbank
{
    public partial class Analysedaten : Form
    {
        private Beschichtung beschichtung;
        const String ButtonEditName = "edit";
        const String ButtonDeleteName = "delete";
        
        public Analysedaten()
        {
            beschichtung = new Beschichtung();
            InitializeComponent();
            InitializeDgvButtons();
            InitizalizeData();
        }
        
        private void InitizalizeData()
        {
            AnalysemethodeCollection analysemethodeCollection = new AnalysemethodeCollection();
            foreach (Analysemethode item in analysemethodeCollection.GetItems())
            {
                comboBoxAnalysemethode.Items.Add(item);
            }
            
            EigenschaftCollection eigenschaftCollection = new EigenschaftCollection();
            foreach (Eigenschaft item in eigenschaftCollection.GetItems())
            {
                comboBoxEigenschaft.Items.Add(item);
            }
        }
        
        private void InitializeDgvButtons()
        {
            dataGridViewAnalysedaten.Columns.Add(GetDgvButtonColumn(ButtonEditName, "Bearbeiten"));
            dataGridViewAnalysedaten.Columns.Add(GetDgvButtonColumn(ButtonDeleteName, "Löschen"));
        }

        private DataGridViewButtonColumn GetDgvButtonColumn(string name, string text)
        {
            return new DataGridViewButtonColumn
            {
                Name = name,
                Text = text,
                HeaderText = "",
                Width = 150,
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
            comboBoxEigenschaft.SelectedItem = null;
            comboBoxAnalysemethode.SelectedItem = null;
        }

        private void InitializeTargetBelegungDataGridView()
        {
            dataGridViewAnalysedaten.Rows.Clear();
            AnalyseergebnisCollection collection = new AnalyseergebnisCollection()
            {
                Beschichtung = beschichtung,
                Analysemethode = (Analysemethode) comboBoxAnalysemethode.SelectedItem,
                Eigenschaft = (Eigenschaft) comboBoxEigenschaft.SelectedItem
            };
            
            foreach (var baseEntity in collection.GetItems())
            {
                var item = (Analyseergebnis)baseEntity;
                
                dataGridViewAnalysedaten.Rows.Add(
                    item.Id.ToString(), 
                    item.Eigenschaft_Bezeichnung,
                    item.Analysemethode_Bezeichnung,
                    item.Wert,
                    item.Einheit,
                    item.AnalysedatenLink == "[]" ? "Fehlen": "Vorhanden"
                    );
            }
        }

        private void dataGridViewAnalysedaten_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (senderGrid.Columns[e.ColumnIndex].Name == ButtonEditName)
                {
                    int selectedId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Analyseergebnis analyseergebnis = new Analyseergebnis();
                    analyseergebnis.Load(selectedId);
                    
                    Ergebnisablage formErgebnisablage = new Ergebnisablage(this);
                    formErgebnisablage.AddBeschichtung(beschichtung);
                    formErgebnisablage.AddAnalyseergebnis(analyseergebnis);
                    formErgebnisablage.ShowDialog(this);
                }
                else if (senderGrid.Columns[e.ColumnIndex].Name == ButtonDeleteName)
                {
                    // TODO: Ask, if really wants to delete.
                    int selectedId = Int32.Parse(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Analyseergebnis analyseergebnis = new Analyseergebnis();
                    analyseergebnis.Delete(selectedId);
                    InitializeTargetBelegungDataGridView();
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Ergebnisablage formErgebnisablage = new Ergebnisablage(this);
            formErgebnisablage.AddBeschichtung(beschichtung);
            formErgebnisablage.ShowDialog(this);
        }

        public void AddBeschichtung(Beschichtung beschichtung)
        {
            this.beschichtung = beschichtung;
            InitializeTargetBelegungDataGridView();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            //TODO: Save Analysdaten.
        }

        /// <summary>
        /// This function is called from child form, when the displayed data was potentially changed.
        /// </summary>
        public void UpdateForm()
        {
            InitializeTargetBelegungDataGridView();
        }
    }
}
