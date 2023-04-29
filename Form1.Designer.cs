namespace PruebaDesarrollo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textvalor = new TextBox();
            textdescripcion = new TextBox();
            textdireccion = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textnombre = new TextBox();
            label5 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 358);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(774, 171);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textvalor);
            groupBox1.Controls.Add(textdescripcion);
            groupBox1.Controls.Add(textdireccion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textnombre);
            groupBox1.Location = new Point(17, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 253);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textvalor
            // 
            textvalor.Location = new Point(132, 136);
            textvalor.Name = "textvalor";
            textvalor.Size = new Size(612, 27);
            textvalor.TabIndex = 12;
            // 
            // textdescripcion
            // 
            textdescripcion.Location = new Point(132, 191);
            textdescripcion.Name = "textdescripcion";
            textdescripcion.Size = new Size(612, 27);
            textdescripcion.TabIndex = 11;
            // 
            // textdireccion
            // 
            textdireccion.Location = new Point(132, 78);
            textdireccion.Name = "textdireccion";
            textdireccion.Size = new Size(243, 27);
            textdireccion.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 85);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 8;
            label6.Text = "DIRECCION:";
            label6.Click += label6_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 191);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "DESCRIPCION:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 136);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 6;
            label3.Text = "VALOR:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 33);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 5;
            label2.Text = "NOMBRE:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 85);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 4;
            label1.Text = "FECHA FACTURA:";
            label1.Click += label1_Click;
            // 
            // textnombre
            // 
            textnombre.Location = new Point(132, 30);
            textnombre.Name = "textnombre";
            textnombre.Size = new Size(612, 27);
            textnombre.TabIndex = 0;
            textnombre.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(268, 9);
            label5.Name = "label5";
            label5.Size = new Size(288, 35);
            label5.TabIndex = 8;
            label5.Text = "REGISTRO DE FACTURAS";
            // 
            // button1
            // 
            button1.Location = new Point(323, 306);
            button1.Name = "button1";
            button1.Size = new Size(130, 31);
            button1.TabIndex = 9;
            button1.Text = "AGREGAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(506, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 551);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textnombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox textvalor;
        private TextBox textdescripcion;
        private TextBox textdireccion;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}