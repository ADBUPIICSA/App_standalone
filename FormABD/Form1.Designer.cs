namespace FormABD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Nuevo_item = new System.Windows.Forms.ToolStripMenuItem();
            this.New_date = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.label_date = new System.Windows.Forms.Label();
            this.textBox_hrs = new System.Windows.Forms.TextBox();
            this.textBox_Min = new System.Windows.Forms.TextBox();
            this.comboBox_date_tipe = new System.Windows.Forms.ComboBox();
            this.comboBox_res_id = new System.Windows.Forms.ComboBox();
            this.text_res_name = new System.Windows.Forms.TextBox();
            this.textBox_area = new System.Windows.Forms.TextBox();
            this.label_res = new System.Windows.Forms.Label();
            this.groupBox_datosSolicitante = new System.Windows.Forms.GroupBox();
            this.textBox_datosSolictante = new System.Windows.Forms.TextBox();
            this.button_acept = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_area = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox_datosSolicitante.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nuevo_item});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Nuevo_item
            // 
            this.Nuevo_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.New_date});
            this.Nuevo_item.Name = "Nuevo_item";
            this.Nuevo_item.Size = new System.Drawing.Size(54, 20);
            this.Nuevo_item.Text = "Nuevo";
            // 
            // New_date
            // 
            this.New_date.Name = "New_date";
            this.New_date.Size = new System.Drawing.Size(95, 22);
            this.New_date.Text = "Cita";
            this.New_date.Click += new System.EventHandler(this.New_date_Click);
            // 
            // comboBox_date
            // 
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.Location = new System.Drawing.Point(26, 49);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.Size = new System.Drawing.Size(301, 21);
            this.comboBox_date.TabIndex = 1;
            this.comboBox_date.Visible = false;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(26, 101);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker_date.TabIndex = 2;
            this.dateTimePicker_date.Visible = false;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(23, 85);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(114, 13);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "Seleccione una fecha:";
            this.label_date.Visible = false;
            // 
            // textBox_hrs
            // 
            this.textBox_hrs.Location = new System.Drawing.Point(240, 101);
            this.textBox_hrs.Name = "textBox_hrs";
            this.textBox_hrs.Size = new System.Drawing.Size(35, 20);
            this.textBox_hrs.TabIndex = 4;
            this.textBox_hrs.Text = "Hrs.";
            this.textBox_hrs.Visible = false;
            // 
            // textBox_Min
            // 
            this.textBox_Min.Location = new System.Drawing.Point(292, 101);
            this.textBox_Min.Name = "textBox_Min";
            this.textBox_Min.Size = new System.Drawing.Size(35, 20);
            this.textBox_Min.TabIndex = 5;
            this.textBox_Min.Text = "Min.";
            this.textBox_Min.Visible = false;
            // 
            // comboBox_date_tipe
            // 
            this.comboBox_date_tipe.FormattingEnabled = true;
            this.comboBox_date_tipe.Location = new System.Drawing.Point(26, 145);
            this.comboBox_date_tipe.Name = "comboBox_date_tipe";
            this.comboBox_date_tipe.Size = new System.Drawing.Size(301, 21);
            this.comboBox_date_tipe.TabIndex = 6;
            this.comboBox_date_tipe.Visible = false;
            // 
            // comboBox_res_id
            // 
            this.comboBox_res_id.FormattingEnabled = true;
            this.comboBox_res_id.Location = new System.Drawing.Point(26, 197);
            this.comboBox_res_id.Name = "comboBox_res_id";
            this.comboBox_res_id.Size = new System.Drawing.Size(56, 21);
            this.comboBox_res_id.TabIndex = 7;
            this.comboBox_res_id.Visible = false;
            // 
            // text_res_name
            // 
            this.text_res_name.Location = new System.Drawing.Point(103, 197);
            this.text_res_name.Name = "text_res_name";
            this.text_res_name.Size = new System.Drawing.Size(224, 20);
            this.text_res_name.TabIndex = 8;
            this.text_res_name.Visible = false;
            // 
            // textBox_area
            // 
            this.textBox_area.Location = new System.Drawing.Point(103, 237);
            this.textBox_area.Name = "textBox_area";
            this.textBox_area.Size = new System.Drawing.Size(224, 20);
            this.textBox_area.TabIndex = 9;
            this.textBox_area.Visible = false;
            // 
            // label_res
            // 
            this.label_res.AutoSize = true;
            this.label_res.Location = new System.Drawing.Point(26, 178);
            this.label_res.Name = "label_res";
            this.label_res.Size = new System.Drawing.Size(137, 13);
            this.label_res.TabIndex = 10;
            this.label_res.Text = "Selccione un Responsable:";
            this.label_res.Visible = false;
            // 
            // groupBox_datosSolicitante
            // 
            this.groupBox_datosSolicitante.Controls.Add(this.textBox_datosSolictante);
            this.groupBox_datosSolicitante.Location = new System.Drawing.Point(361, 49);
            this.groupBox_datosSolicitante.Name = "groupBox_datosSolicitante";
            this.groupBox_datosSolicitante.Size = new System.Drawing.Size(200, 229);
            this.groupBox_datosSolicitante.TabIndex = 11;
            this.groupBox_datosSolicitante.TabStop = false;
            this.groupBox_datosSolicitante.Text = "Datos del solicitante";
            this.groupBox_datosSolicitante.Visible = false;
            // 
            // textBox_datosSolictante
            // 
            this.textBox_datosSolictante.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_datosSolictante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_datosSolictante.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox_datosSolictante.Location = new System.Drawing.Point(6, 19);
            this.textBox_datosSolictante.Multiline = true;
            this.textBox_datosSolictante.Name = "textBox_datosSolictante";
            this.textBox_datosSolictante.Size = new System.Drawing.Size(188, 204);
            this.textBox_datosSolictante.TabIndex = 0;
            // 
            // button_acept
            // 
            this.button_acept.Location = new System.Drawing.Point(486, 284);
            this.button_acept.Name = "button_acept";
            this.button_acept.Size = new System.Drawing.Size(75, 23);
            this.button_acept.TabIndex = 12;
            this.button_acept.Text = "Aceptar";
            this.button_acept.UseVisualStyleBackColor = true;
            this.button_acept.Visible = false;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(405, 284);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 13;
            this.button_cancel.Text = "Cancelar";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Visible = false;
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Location = new System.Drawing.Point(50, 244);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(32, 13);
            this.label_area.TabIndex = 14;
            this.label_area.Text = "Area:";
            this.label_area.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 315);
            this.Controls.Add(this.label_area);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_acept);
            this.Controls.Add(this.groupBox_datosSolicitante);
            this.Controls.Add(this.label_res);
            this.Controls.Add(this.textBox_area);
            this.Controls.Add(this.text_res_name);
            this.Controls.Add(this.comboBox_res_id);
            this.Controls.Add(this.comboBox_date_tipe);
            this.Controls.Add(this.textBox_Min);
            this.Controls.Add(this.textBox_hrs);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.comboBox_date);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Agendar evento";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_datosSolicitante.ResumeLayout(false);
            this.groupBox_datosSolicitante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Nuevo_item;
        private System.Windows.Forms.ToolStripMenuItem New_date;
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TextBox textBox_hrs;
        private System.Windows.Forms.TextBox textBox_Min;
        private System.Windows.Forms.ComboBox comboBox_date_tipe;
        private System.Windows.Forms.ComboBox comboBox_res_id;
        private System.Windows.Forms.TextBox text_res_name;
        private System.Windows.Forms.TextBox textBox_area;
        private System.Windows.Forms.Label label_res;
        private System.Windows.Forms.GroupBox groupBox_datosSolicitante;
        private System.Windows.Forms.TextBox textBox_datosSolictante;
        private System.Windows.Forms.Button button_acept;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_area;
    }
}

