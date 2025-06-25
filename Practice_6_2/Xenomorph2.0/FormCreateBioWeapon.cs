using KsenomorphGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xenomorph2._0
{
    public partial class FormCreateBioWeapon: Form
    {
        public FormCreateBioWeapon()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetGeneList().Count; i++)
            {
                comboBox1.Items.Add(Game.getInstance().GetGeneList()[i]);
            }
            comboBox2.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetGeneList().Count; i++)
            {
                comboBox2.Items.Add(Game.getInstance().GetGeneList()[i]);
            }
            comboBox3.Items.Clear();
            for (int i = 0; i < Game.getInstance().GetGeneList().Count; i++)
            {
                comboBox3.Items.Add(Game.getInstance().GetGeneList()[i]);
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBox1 == null || textBox1.Text.Length == 0)
            {
                MessageBox.Show("Вы не ввели название!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    if (comboBox2.SelectedIndex != -1)
                    {
                        if (comboBox3.SelectedIndex != -1)
                        {
                            Game.getInstance().PlayerCreateBioWeapon(textBox1.Text, comboBox1.SelectedIndex, comboBox2.SelectedIndex, comboBox3.SelectedIndex);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Вы не выбрали третий ген!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не выбрали второй ген!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Вы не выбрали первый ген!", "Забыли?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
