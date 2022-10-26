using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Canoppus.UI.Utilitarios
{
    public static class Limpar
    {
        public static void ClearControl(Control ctrl)
        {

            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = "";
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).MinDate = new DateTime(1900, 1, 1);
                    ((DateTimePicker)c).MaxDate = new DateTime(2100, 1, 1);
                    ((DateTimePicker)c).Value = DateTime.Now.Date < ((DateTimePicker)c).MinDate ? ((DateTimePicker)c).MinDate : DateTime.Now.Date > ((DateTimePicker)c).MaxDate ? ((DateTimePicker)c).MaxDate : DateTime.Now.Date;
                    if (((DateTimePicker)c).ShowCheckBox)
                        ((DateTimePicker)c).Checked = false;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0 < ((NumericUpDown)c).Minimum ? ((NumericUpDown)c).Minimum : 0 > ((NumericUpDown)c).Maximum ? ((NumericUpDown)c).Maximum : 0;// ((NumericUpDown)c).Minimum;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Text = "";
                }
                else if (c is Label)
                {
                    //((Label)c).Text = "";
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).DataSource = null;
                }/*
                else if (c is TrackBar)
                    ((TrackBar)c).Value = ((TrackBar)c).Minimum;
                else if (c is RichTextBoxExtended)
                    ((RichTextBoxExtended)c).ResetText();
                */
                else if (c.HasChildren)
                {
                    if (c is TabControl)
                        ((TabControl)c).SelectedIndex = 0;

                    ClearControl(c);
                }

            }
        }
    }
}
