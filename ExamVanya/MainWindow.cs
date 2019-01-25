using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyClassLibrary;

namespace ExamVanya
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            UpdateAviaries();
        }

        private void UpdateAviaries()
        {
            AviariesList.Items.Clear();

            foreach(Aviary aviary in Aviary.Aviaries)
            {
                AviariesList.Items.Add(aviary);
            }

            if (AviariesList.Items.Count > 0)
            {
                AviariesList.SelectedIndex = 0;
            }
        }

        private void AviariesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AviariesList.SelectedIndex > -1)
            {
                AnimalsList.Items.Clear();

                foreach(Animal animal in ((Aviary)AviariesList.SelectedItem).Animals)
                {
                    AnimalsList.Items.Add(animal);
                }
            }
        }

        private void IDIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void AddAviary_Click(object sender, EventArgs e)
        {
            if (IDIn.Text.Trim() != String.Empty)
            {
                Aviary.Aviaries.Add(new Aviary(new ID(IDIn.Text)));
                UpdateAviaries();
            }
        }

        private void AddAnimal_Click(object sender, EventArgs e)
        {
            if (AviariesList.SelectedIndex > -1)
            {
                NewAnimal newAnimalForm = new NewAnimal();
                newAnimalForm.ShowDialog();
                if (newAnimalForm.Handled)
                {
                    ((Aviary)AviariesList.SelectedItem).AddAnimal(newAnimalForm.Animal);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
