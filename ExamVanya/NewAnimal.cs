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
        }
    }
}
