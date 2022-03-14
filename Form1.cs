using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LaboratorioNo6
{
    public partial class Form1 : Form
    {
        List<Vehiculo> carro = new List<Vehiculo>();
        List<Cliente> persona = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void GuardarVehiculo()
        {
            FileStream stream = new FileStream("Carros.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var carro1 in carro)
            {
                writer.WriteLine(carro1.placa );
                writer.WriteLine(carro1.modelo);
                writer.WriteLine(carro1.color);
                writer.WriteLine(carro1.precioKm);
                writer.WriteLine(carro1.marca);
            }
            writer.Close();
            
        }


        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Vehiculo carro1 = new Vehiculo();
            carro1.placa = txtPlaca.Text;
            carro1.modelo = txtModelo.Text;
            carro1.color = txtColor.Text;
            carro1.precioKm = Convert.ToInt16(txtPrecio.Text);
            carro1.marca = txtMarca.Text;

            int posicion = carro.FindIndex(x => x.placa == carro1.placa);
            if (posicion == -1)
            {
                carro.Add(carro1);
                GuardarVehiculo();
            }
            else
            {
                MessageBox.Show("Este vehiculo ya existe"); 
            }

               
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            LeerCliente();
        }
    

        private void LeerCliente()
        {
            FileStream stream = new FileStream("Archivo1Cliente.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1) //el -1 significa la ultima linea que no existe demostrando el final del archivo
            {
                Cliente persona2 = new Cliente();
                persona2.NIT = reader.ReadLine();
                persona2.Nombre = reader.ReadLine();
                persona2.direccion = reader.ReadLine();

                //agregar a lista
               persona.Add(persona2);
            }

            reader.Close();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dtgVehiculo.DataSource = null;
            dtgVehiculo.Refresh();

            dtgVehiculo.DataSource = carro;
            dtgVehiculo.Refresh();
      
        }

        private void btnIngresoAlquiler_Click(object sender, EventArgs e)
        {
            IngresoAlquiler F1 = new IngresoAlquiler();
            F1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void btnverCliente_Click(object sender, EventArgs e)
        {
           dtgClientes.DataSource = null;
            dtgClientes.Refresh();

            dtgClientes.DataSource = persona;
            dtgClientes.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
