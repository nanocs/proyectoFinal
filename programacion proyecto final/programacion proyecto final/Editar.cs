/* Creado por L. Mora */

using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace programacion_proyecto_final
{
	/// <summary>
	/// Description of Editar.
	/// </summary>
	public partial class Editar : Form
	{
		public Editar()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			string producto = textBox2.Text;
			string codigo = textBox1.Text;
			string cantidad = textBox3.Text;
			
			
			con = new MySqlConnection("Server=localhost; Database=insumos; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("UPDATE productos SET producto='"+producto+"', codigo ='"+codigo+"',cantidad= '"+cantidad+"'where (codigo = "+codigo+")", con);
			read = comando.ExecuteReader();
			
			if(read.Read()){
			
				label1.Text = "done";
			}

			
		}
		
		void EditarLoad(object sender, EventArgs e)
		{

			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			
			con = new MySqlConnection("Server=localhost; Database=insumos; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM productos", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.editarCliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2));
			}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{

			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			editarCliente.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=insumos; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM productos", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.editarCliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2));
		}						
			
		}
	}
}
