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
            this.Size = new System.Drawing.Size(599, 354);
            this.Text = "Agendar Evento";

            //comboBox
            comboBox_date.Visible = true;
            comboBox_date.Text = "Seleccione Solicitud";
            comboBox_date_tipe.Visible = true;
            label_date.Location = new System.Drawing.Point(23, 85);
            comboBox_date_tipe.Text = "Seleccione tipo de Cita";
            comboBox_res_id.Visible = true;
            comboBox_res_id.Text = "Clave";

            //dataTime
            dateTimePicker_date.Visible = true;

            //label
            label_date.Visible = true;
            label_area.Visible = true;
            label_res.Visible = true;

            //textBox
            textBox_hrs.Visible = true;
            textBox_Min.Visible = true;
            text_res_name.Visible = true;
            textBox_area.Visible = true;

            //button
            button_acept.Visible = true;
            button_acept.Location = new System.Drawing.Point(486, 284);
            button_cancel.Visible = true;
            button_cancel.Location = new System.Drawing.Point(405, 284);

            //checkedListBox
            checkedListBox1.Visible = false;

        }

        private void new_proof_res_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(369, 354);
            this.Text = "Agregar Resultados de Pruebas";

            //comboBox
            comboBox_date.Visible = true;
            comboBox_date.Text = "Seleccione una Cita";
            comboBox_date_tipe.Visible = false;
            comboBox_res_id.Visible = false;

            //dateTime
            dateTimePicker_date.Visible = false;

            //label
            label_area.Visible = false;
            label_date.Visible = true;
            label_date.Text = "Resultados de las Pruebas";
            label_date.Location = new System.Drawing.Point(80, 85);
            label_res.Visible = false;

            //textBox
            textBox_hrs.Visible = false;
            textBox_Min.Visible = false;
            textBox_area.Visible = false;
            text_res_name.Visible = false;

            //button
            button_acept.Visible = true;
            button_acept.Location = new System.Drawing.Point(159, 284);
            button_cancel.Visible = true;
            button_cancel.Location = new System.Drawing.Point(240, 284);

            //checkedListBox
            checkedListBox1.Location = new System.Drawing.Point(78, 105);
            checkedListBox1.Visible = true;
           
        }
    

    }
}
