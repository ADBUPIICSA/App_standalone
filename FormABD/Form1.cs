using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormABD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void New_date_Click(object sender, EventArgs e)
        {
            comboBox_date.Visible = true;
            comboBox_date.Text = "Seleccione Solicitud";
            comboBox_date_tipe.Visible = true;
            comboBox_date_tipe.Text = "Seleccione tipo de Cita";
            comboBox_res_id.Visible = true;
            comboBox_res_id.Text = "Clave";

            dateTimePicker_date.Visible = true;

            label_date.Visible = true;

            textBox_hrs.Visible = true;
            textBox_Min.Visible = true;
            text_res_name.Visible = true;
            textBox_area.Visible = true;


        }
    }
}
