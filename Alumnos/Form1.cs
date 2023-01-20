using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'evaluaDataSet3.Notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.evaluaDataSet3.Notas);
            // TODO: esta línea de código carga datos en la tabla 'evaluaDataSet2.Evaluaciones' Puede moverla o quitarla según sea necesario.
            this.evaluacionesTableAdapter.Fill(this.evaluaDataSet2.Evaluaciones);
            // TODO: esta línea de código carga datos en la tabla 'evaluaAlumnosDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.FillByBaja(this.evaluaAlumnosDataSet.Alumnos);

            panel2.Visible = false;
            //cargarCombo();
            //cargarCombo1();

        }
       
        private void cargarCombo1()
        {

            string conexion = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\evalua.mdb";
            string sentencia = "select Id, Evaluacion from evaluaciones";
            OleDbConnection miCnx = new OleDbConnection(conexion);
            OleDbCommand miCmd = new OleDbCommand(sentencia, miCnx);
            OleDbDataReader miLector;
            miCnx.Open();
            miLector = miCmd.ExecuteReader();
            while (miLector.Read())
            {
                ComboboxItem item = new ComboboxItem();
                item.texto = miLector.GetString(1) + " " + miLector.GetString(2);
                item.id = miLector.GetInt32(0);
                comboBox1.Items.Add(item);
            }
            miLector.Close();
            miCnx.Close();

        }

        private void cargarCombo()
        {

            string connetionString = null;
            OleDbConnection connection;
            OleDbCommand command;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql = null;
            connetionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|\\evalua.mdb";
            sql = "select Id, Evaluacion from evaluaciones";
            connection = new OleDbConnection(connetionString);
            try
            {
                connection.Open();
                command = new OleDbCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();
                comboBox1.DataSource = ds.Tables[0];
                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Evaluacion";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void fillByBajaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.alumnosTableAdapter.FillByBaja(this.evaluaAlumnosDataSet.Alumnos);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) listBox1.Enabled = false;
            else listBox1.Enabled = true;
        }

        private void checkBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(comboBox1.SelectedValue)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

   
    }

    internal class ComboboxItem
    {
        public string texto { get; set; }
        public int id { get; set; }


        public override string ToString()
        {
            return texto;
        }

    }
}

