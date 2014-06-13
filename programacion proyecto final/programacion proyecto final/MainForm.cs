/*
 * Creado por SharpDevelop.
 * Usuario: Nano
 * Fecha: 12/06/2014
 * Hora: 11:03 p.m.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace programacion_proyecto_final
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{

 
		
   Editar edit = new Editar();
    edit.Show();
		
    
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{

MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			
			con = new MySqlConnection("Server=localhost; Database=insumos; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM productos", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.tablaCliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2));
			}
			


			
		}
		
		void Button1Click(object sender, EventArgs e)
		{

			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			string producto = textBox1.Text;
			string codigo = textBox2.Text;
			string cantidad = textBox3.Text;
			
			con = new MySqlConnection("Server=localhost; Database=insumos; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("INSERT INTO productos (producto, codigo, cantidad ) VALUES ('"+producto+"','"+codigo+"','"+cantidad+"')", con);
			read = comando.ExecuteReader();
while (read.Read()){
			textBox1.Text = "";
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{

			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			tablaCliente.Rows.Clear();
			
			con = new MySqlConnection("Server=localhost; Database=insumos; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM productos", con);
			read = comando.ExecuteReader();
			
			while (read.Read()){
				this.tablaCliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2));
		}						

			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			
			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			string codigo = textBox2.Text;
			
			con = new MySqlConnection("Server=localhost; Database=insumos; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("delete FROM productos where codigo = '"+codigo+"' ", con);
			read = comando.ExecuteReader();
			
			
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{

			MySqlConnection con;
			MySqlCommand comando;
			MySqlDataReader read;
			
			string producto = textBox1.Text;
			string codigo = textBox2.Text;
			
			
			tablaCliente.Rows.Clear();
			con = new MySqlConnection("Server=localhost; Database=insumos; User ID=root; Password=123");
			con.Open();
			comando = new MySqlCommand("SELECT * FROM productos WHERE producto ='"+producto+"' OR codigo ='"+codigo+"' ", con);
			read = comando.ExecuteReader();
			while (read.Read()){
				this.tablaCliente.Rows.Add(read.GetValue(0),read.GetValue(1),read.GetValue(2));
		}			
		

			
		}
		
		void TablaClienteCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
	}

}