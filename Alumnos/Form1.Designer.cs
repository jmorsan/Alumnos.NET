
namespace Alumnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.evaluacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluaDataSet2 = new Alumnos.evaluaDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.evaluaDataSet = new Alumnos.evaluaDataSet();
            this.evaluaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.alumnosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluaAlumnosDataSet = new Alumnos.evaluaAlumnosDataSet();
            this.alumnosTableAdapter = new Alumnos.evaluaAlumnosDataSetTableAdapters.AlumnosTableAdapter();
            this.evaluaAlumnosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluacionesTableAdapter = new Alumnos.evaluaDataSet2TableAdapters.EvaluacionesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nifAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.folDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fprDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ralDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evaluaDataSet3 = new Alumnos.evaluaDataSet3();
            this.notasTableAdapter = new Alumnos.evaluaDataSet3TableAdapters.NotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaAlumnosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaAlumnosDataSetBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumnos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.evaluacionesBindingSource;
            this.comboBox1.DisplayMember = "Evaluacion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(492, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // evaluacionesBindingSource
            // 
            this.evaluacionesBindingSource.DataMember = "Evaluaciones";
            this.evaluacionesBindingSource.DataSource = this.evaluaDataSet2;
            // 
            // evaluaDataSet2
            // 
            this.evaluaDataSet2.DataSetName = "evaluaDataSet2";
            this.evaluaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evaluación:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 79);
            this.button1.TabIndex = 4;
            this.button1.Text = "Validar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(41, 365);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // evaluaDataSet
            // 
            this.evaluaDataSet.DataSetName = "evaluaDataSet";
            this.evaluaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // evaluaDataSetBindingSource
            // 
            this.evaluaDataSetBindingSource.DataSource = this.evaluaDataSet;
            this.evaluaDataSetBindingSource.Position = 0;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.alumnosBindingSource;
            this.listBox1.DisplayMember = "nombre";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(41, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 199);
            this.listBox1.TabIndex = 6;
            this.listBox1.ValueMember = "nif";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // alumnosBindingSource
            // 
            this.alumnosBindingSource.DataMember = "Alumnos";
            this.alumnosBindingSource.DataSource = this.evaluaAlumnosDataSet;
            // 
            // evaluaAlumnosDataSet
            // 
            this.evaluaAlumnosDataSet.DataSetName = "evaluaAlumnosDataSet";
            this.evaluaAlumnosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // evaluaAlumnosDataSetBindingSource
            // 
            this.evaluaAlumnosDataSetBindingSource.DataSource = this.evaluaAlumnosDataSet;
            this.evaluaAlumnosDataSetBindingSource.Position = 0;
            // 
            // evaluacionesTableAdapter
            // 
            this.evaluacionesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nifAlumnoDataGridViewTextBoxColumn,
            this.periodoDataGridViewTextBoxColumn,
            this.folDataGridViewTextBoxColumn,
            this.retDataGridViewTextBoxColumn,
            this.inaDataGridViewTextBoxColumn,
            this.fprDataGridViewTextBoxColumn,
            this.ralDataGridViewTextBoxColumn,
            this.simDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notasBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nifAlumnoDataGridViewTextBoxColumn
            // 
            this.nifAlumnoDataGridViewTextBoxColumn.DataPropertyName = "nifAlumno";
            this.nifAlumnoDataGridViewTextBoxColumn.HeaderText = "nifAlumno";
            this.nifAlumnoDataGridViewTextBoxColumn.Name = "nifAlumnoDataGridViewTextBoxColumn";
            // 
            // periodoDataGridViewTextBoxColumn
            // 
            this.periodoDataGridViewTextBoxColumn.DataPropertyName = "periodo";
            this.periodoDataGridViewTextBoxColumn.HeaderText = "periodo";
            this.periodoDataGridViewTextBoxColumn.Name = "periodoDataGridViewTextBoxColumn";
            // 
            // folDataGridViewTextBoxColumn
            // 
            this.folDataGridViewTextBoxColumn.DataPropertyName = "fol";
            this.folDataGridViewTextBoxColumn.HeaderText = "fol";
            this.folDataGridViewTextBoxColumn.Name = "folDataGridViewTextBoxColumn";
            // 
            // retDataGridViewTextBoxColumn
            // 
            this.retDataGridViewTextBoxColumn.DataPropertyName = "ret";
            this.retDataGridViewTextBoxColumn.HeaderText = "ret";
            this.retDataGridViewTextBoxColumn.Name = "retDataGridViewTextBoxColumn";
            // 
            // inaDataGridViewTextBoxColumn
            // 
            this.inaDataGridViewTextBoxColumn.DataPropertyName = "ina";
            this.inaDataGridViewTextBoxColumn.HeaderText = "ina";
            this.inaDataGridViewTextBoxColumn.Name = "inaDataGridViewTextBoxColumn";
            // 
            // fprDataGridViewTextBoxColumn
            // 
            this.fprDataGridViewTextBoxColumn.DataPropertyName = "fpr";
            this.fprDataGridViewTextBoxColumn.HeaderText = "fpr";
            this.fprDataGridViewTextBoxColumn.Name = "fprDataGridViewTextBoxColumn";
            // 
            // ralDataGridViewTextBoxColumn
            // 
            this.ralDataGridViewTextBoxColumn.DataPropertyName = "ral";
            this.ralDataGridViewTextBoxColumn.HeaderText = "ral";
            this.ralDataGridViewTextBoxColumn.Name = "ralDataGridViewTextBoxColumn";
            // 
            // simDataGridViewTextBoxColumn
            // 
            this.simDataGridViewTextBoxColumn.DataPropertyName = "sim";
            this.simDataGridViewTextBoxColumn.HeaderText = "sim";
            this.simDataGridViewTextBoxColumn.Name = "simDataGridViewTextBoxColumn";
            // 
            // notasBindingSource
            // 
            this.notasBindingSource.DataMember = "Notas";
            this.notasBindingSource.DataSource = this.evaluaDataSet3;
            // 
            // evaluaDataSet3
            // 
            this.evaluaDataSet3.DataSetName = "evaluaDataSet3";
            this.evaluaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaAlumnosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaAlumnosDataSetBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evaluaDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private evaluaDataSet evaluaDataSet;
        private System.Windows.Forms.BindingSource evaluaDataSetBindingSource;
        private System.Windows.Forms.ListBox listBox1;
        private evaluaAlumnosDataSet evaluaAlumnosDataSet;
        private System.Windows.Forms.BindingSource alumnosBindingSource;
        private evaluaAlumnosDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.BindingSource evaluaAlumnosDataSetBindingSource;
        private evaluaDataSet2 evaluaDataSet2;
        private System.Windows.Forms.BindingSource evaluacionesBindingSource;
        private evaluaDataSet2TableAdapters.EvaluacionesTableAdapter evaluacionesTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private evaluaDataSet3 evaluaDataSet3;
        private System.Windows.Forms.BindingSource notasBindingSource;
        private evaluaDataSet3TableAdapters.NotasTableAdapter notasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn folDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fprDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simDataGridViewTextBoxColumn;
    }
}

