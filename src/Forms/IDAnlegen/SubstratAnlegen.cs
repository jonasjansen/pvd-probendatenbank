using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Forms.IDAnlegen
{
    public partial class SubstratAnlegen : Form
    {
        private IDAnlegen parentForm;
        private Substrat substrat;
        private int collectionId;
        
        public SubstratAnlegen(IDAnlegen parentForm)
        {
            this.parentForm = parentForm;
            substrat = new Substrat();
            collectionId = 0;
            InitializeComponent();
            
            VorbehandlungCollection vorbehandlungCollection = new VorbehandlungCollection();
            foreach (Vorbehandlung item in vorbehandlungCollection.GetItems())
            {
                comboBoxVorbehandlungsschritt1.Items.Add(item);
                comboBoxVorbehandlungsschritt2.Items.Add(item);
                comboBoxVorbehandlungsschritt3.Items.Add(item);
            }

            SubstratwerkstoffCollection substratwerkstoffCollection = new SubstratwerkstoffCollection();
            foreach (Substratwerkstoff item in substratwerkstoffCollection.GetItems())
            {
                comboBoxSubstratwerkstoff.Items.Add(item);
            }
        }

        /// <summary>
        /// Add Substrat entity which allows to edit the entity by this form.
        /// </summary>
        /// <param name="item"></param>
        public void AddSubstrat(Substrat substrat, int collectionId)
        {
            this.substrat = substrat;
            this.collectionId = collectionId;
            
            // Preselect ComboBox items 
            comboBoxSubstratwerkstoff.SelectedIndex = GetPositioOfEntity(comboBoxSubstratwerkstoff, substrat.GetSubstratwerkstoffBezeichnung());
            comboBoxVorbehandlungsschritt1.SelectedIndex = GetPositioOfEntity(comboBoxVorbehandlungsschritt1, substrat.GetVorbehandlungBezeichnung(1));
            comboBoxVorbehandlungsschritt2.SelectedIndex = GetPositioOfEntity(comboBoxVorbehandlungsschritt2, substrat.GetVorbehandlungBezeichnung(2));
            comboBoxVorbehandlungsschritt3.SelectedIndex = GetPositioOfEntity(comboBoxVorbehandlungsschritt3, substrat.GetVorbehandlungBezeichnung(3));
        }

        /// <summary>
        /// Check if label of Object is part of a ComboBox and return it's position.
        /// Returns -1 if label could not be found.
        /// </summary>
        /// <param name="comboBox">Search ComboBox</param>
        /// <param name="label">Label of object, which should be selected</param>
        /// <returns></returns>
        private int GetPositioOfEntity(ComboBox comboBox, string label)
        {
            // -1 => No entity selected in ComboBox.
            int position =-1;
            foreach (BaseEntity item in comboBox.Items)
            {
                position++;
                if (item.ToString() == label)
                {
                    return position;
                }
            }
            return position;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxSubstratwerkstoff.SelectedIndex < 0)
            {
                MessageBox.Show(@"Substrat mit Vorbehandlungsschritten konnte nicht angelegt werden, da kein Substratwerkstoff ausgewählt wurde. Bitte wählen Sie einen Wert aus.");
                return;
            }
            
            if (comboBoxVorbehandlungsschritt1.SelectedIndex >= 0)
            {
                substrat.AddVorbehandungsSchritt( 
                    BuildVorbehandlungsSchritt(
                        (Substratwerkstoff) comboBoxSubstratwerkstoff.SelectedItem,
                        (Vorbehandlung) comboBoxVorbehandlungsschritt1.SelectedItem,
                        1
                        )
                    );
            }
          
            if (comboBoxVorbehandlungsschritt2.SelectedIndex >= 0)
            {
                substrat.AddVorbehandungsSchritt( 
                    BuildVorbehandlungsSchritt(
                        (Substratwerkstoff) comboBoxSubstratwerkstoff.SelectedItem,
                        (Vorbehandlung) comboBoxVorbehandlungsschritt2.SelectedItem,
                        2
                    )
                );
            }
            
            if (comboBoxVorbehandlungsschritt3.SelectedIndex >= 0)
            {
                substrat.AddVorbehandungsSchritt( 
                    BuildVorbehandlungsSchritt(
                        (Substratwerkstoff) comboBoxSubstratwerkstoff.SelectedItem,
                        (Vorbehandlung) comboBoxVorbehandlungsschritt3.SelectedItem,
                        3
                    )
                );
            }
            
            parentForm.AddSubstrat(substrat, collectionId);
            Close();
        }

        private VorbehandlungsSchritt BuildVorbehandlungsSchritt (
            Substratwerkstoff substratwerkstoff,
            Vorbehandlung vorbehandlung,
            int position)
        {
            return new VorbehandlungsSchritt {
                Substratwerkstoff_ID = substratwerkstoff.Id,
                Substratwerkstoff_Bezeichnung = substratwerkstoff.Bezeichnung,
                Vorbehandlung_ID = vorbehandlung.Id,
                Vorbehandlung_Bezeichnung = vorbehandlung.Bezeichnung,
                Position = position.ToString()
            };
        }
    }
}