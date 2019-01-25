using MyClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamVanya
{
    public partial class NewAnimal : Form
    {
        public bool Handled { get; private set; } = false;
        public Animal Animal { get; private set; }

        public NewAnimal()
        {
            InitializeComponent();

            UpdateAnimalTypesList();
            UpdateFeedTypesList();
        }

        private void UpdateAnimalTypesList()
        {
            AnimalTypesList.Items.Add(Animals.Bird);
            AnimalTypesList.Items.Add(Animals.Fish);
            AnimalTypesList.Items.Add(Animals.Mammal);
            AnimalTypesList.SelectedIndex = 0;
        }

        private void UpdateFeedTypesList()
        {
            FeedTypesList.Items.Add(FeedTypes.Herbivorous);
            FeedTypesList.Items.Add(FeedTypes.Omnivorous);
            FeedTypesList.Items.Add(FeedTypes.Carnivorous);
            FeedTypesList.SelectedIndex = 0;
        }

        private void NameIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddAnimal_Click(object sender, EventArgs e)
        {
            if (NameIn.Text.Trim() != String.Empty)
            {
                FeedType feedType = null;
                switch (FeedTypesList.SelectedItem)
                {
                    case FeedTypes.Herbivorous:
                        feedType = new Herbivorous();
                        break;
                    case FeedTypes.Omnivorous:
                        feedType = new Omnivorous();
                        break;
                    case FeedTypes.Carnivorous:
                        feedType = new Carnivorous();
                        break;
                }
                switch (AnimalTypesList.SelectedItem)
                {
                    case Animals.Bird:
                        Animal = new Bird(NameIn.Text.Trim(), DateOfBirthIn.Value, feedType);
                        break;
                    case Animals.Fish:
                        Animal = new Fish(NameIn.Text.Trim(), DateOfBirthIn.Value, feedType);
                        break;
                    case Animals.Mammal:
                        Animal = new Mammal(NameIn.Text.Trim(), DateOfBirthIn.Value, feedType);
                        break;
                }
                Handled = true;
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Handled = false;
            Close();
        }
    }
}
