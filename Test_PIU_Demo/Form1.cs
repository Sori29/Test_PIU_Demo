using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librarie;
namespace Test_PIU_Demo
{
    public partial class Form1 : Form
    {
        private List<Student> studententi;
        public Form1()
        {
            InitializeComponent();
            studententi = new List<Student>();

        }
        private void ClearCasete()
        {
            txtNume.Text = String.Empty;
            cmbOras.Text = "Selecteaza orasul...";
            radioAutomatica.Checked = false;
            radioCalculatoare.Checked = false;
            radioElectronica.Checked = false;
            dateInscriere.Value = DateTime.Today;

        }
        private int verificareStudentOras(string Nume, string oras)
        {
            foreach(Student student in studententi)
            {
                if(student.Nume == Nume && student.Oras==oras)
                    return 0;
            }
            return 1;
        }
        private void btnAdauga_Click(object sender, EventArgs e)
        {
            string program = VerificaProgramStudiuSelectat();
            if(txtNume.Text==String.Empty || cmbOras.SelectedIndex==-1 || program== "NECUNOSCUT")
                MessageBox.Show("O casuta obligatorie nu a fost completate","Adaugare invalida",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else if(DateTime.Compare(dateInscriere.Value, DateTime.Today) >= 0)
            {
                MessageBox.Show("Data inscrieri nu poate fi mai mare decat curenta", "Adaugare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verificareStudentOras(txtNume.Text, cmbOras.Text) == 0)
            {
                MessageBox.Show($"Exista deja studentul {txtNume.Text} in orasul {cmbOras.Text}", "Adaugare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                studententi.Add(new Student(txtNume.Text,cmbOras.Text,dateInscriere.Value,program));
                ClearCasete();
            }

        }
        private string VerificaProgramStudiuSelectat()
        {
            if (radioCalculatoare.Checked)
                return radioCalculatoare.Text;
            else if (radioAutomatica.Checked)
                return radioAutomatica.Text;
            else if (radioElectronica.Checked)
                return radioElectronica.Text;
            else return "NECUNOSCUT";
                
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            dateStudenti.Rows.Clear();
            foreach (Student student in studententi)
                dateStudenti.Rows.Add(student.Nume,student.Oras,student.DataInscriere.ToShortDateString(),student.ProgramStudiu);
            dateStudenti.Visible = true;
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {
            int ok = 0;
            if(cmbOras.SelectedIndex==-1)
            {
                MessageBox.Show("Orasul nu a fost selectat", "Filtrare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dateStudenti.Rows.Clear();
                foreach(Student student in studententi)
                {
                    if (student.Oras == cmbOras.Text)
                    {
                        dateStudenti.Rows.Add(student.Nume, student.Oras, student.DataInscriere.ToShortDateString(), student.ProgramStudiu);
                        ok = 1;
                    }
                    else continue;
                }
                if (ok == 0)
                    MessageBox.Show("Nu s-au gasit niciun student cu orasul cautat", "Filtrare invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
