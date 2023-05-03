using System.Data;
using System.Data.SqlClient;

namespace PruebaDesarrollo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("conexión exitosa");

            dataGridView1.DataSource = llenar_grid();
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT FACTURA.FECHA_FAC, CLIENTES.NOMBRE, FACTURA.VALOR_FAC, ESTADOS_FACTURA.DESCRIPCION FROM FACTURA JOIN CLIENTES ON FACTURA.NUME_DOC = CLIENTES.NUME_DOC JOIN ESTADOS_FACTURA ON FACTURA.CODI_ESTADO = ESTADOS_FACTURA.CODI_ESTADO";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();

            SqlTransaction transaction = Conexion.Conectar().BeginTransaction();
            try
            {
                string insertar_clientes = "INSERT INTO CLIENTES (NOMBRE, DIRECCION) VALUES (@NOMBRE, @DIRECCION)";
                SqlCommand cmd_clientes = new SqlCommand(insertar_clientes, Conexion.Conectar());
                cmd_clientes.Parameters.AddWithValue("@NOMBRE", textnombre.Text);
                cmd_clientes.Parameters.AddWithValue("@DIRECCION", textdireccion.Text);
                cmd_clientes.ExecuteNonQuery();
                


                string insertar_estado = "INSERT INTO ESTADOS_FACTURA (DESCRIPCION) VALUES (@DESCRIPCION)";
                SqlCommand cmd_estado = new SqlCommand(insertar_estado, Conexion.Conectar());
                cmd_estado.Parameters.AddWithValue("@DESCRIPCION", textdescripcion.Text);
                cmd_estado.ExecuteNonQuery();


                 int id_cliente = 1;
                object id_cliente_obj = new SqlCommand("SELECT IDENT_CURRENT('CLIENTES') as NUME_DOC", Conexion.Conectar()).ExecuteScalar();
                if (id_cliente_obj != DBNull.Value)
                {
                    id_cliente = Convert.ToInt32(id_cliente_obj);
                }
                

                int id_estado = 1;
                object id_estado_obj = new SqlCommand("SELECT IDENT_CURRENT('ESTADOS_FACTURA') as CODI_ESTADO", Conexion.Conectar()).ExecuteScalar();
                if (id_estado_obj != DBNull.Value)
                {
                    id_estado = Convert.ToInt32(id_estado_obj);
                }


                string insertar_factura = "INSERT INTO FACTURA (NUME_DOC, CODI_ESTADO, FECHA_FAC, VALOR_FAC) VALUES (@NUME_DOC, @CODI_ESTADO,@FECHA_FAC, @VALOR_FAC)";
                SqlCommand cmd_factura = new SqlCommand(insertar_factura, Conexion.Conectar());
                cmd_factura.Parameters.AddWithValue("@NUME_DOC", id_cliente);
                cmd_factura.Parameters.AddWithValue("@CODI_ESTADO", id_estado);
                cmd_factura.Parameters.AddWithValue("@FECHA_FAC", dateTimePicker1.Value);
                cmd_factura.Parameters.AddWithValue("@VALOR_FAC", textvalor.Text);
                cmd_factura.ExecuteNonQuery();

                
                transaction.Commit();

                MessageBox.Show("Los datos fueron agregados con éxito");
                dataGridView1.DataSource = llenar_grid();
            }
            catch (Exception ex)
            {
                // Revertir la transacción en caso de error
                transaction.Rollback();
                MessageBox.Show("Ocurrió un error al agregar los datos: " + ex.Message);
            }

        }
    }
}
