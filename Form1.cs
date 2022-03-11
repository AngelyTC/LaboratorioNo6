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
        List<Alquiler> alqui = new List<Alquiler>();
        int precio;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            precio = Int16.Parse(txtPrecio.Text);
            Vehiculo carro1 = new Vehiculo();
            carro1.placa  = txtPlaca.Text;
            carro1.marca  = txtMarca.Text;
            carro1.modelo  = Convert.ToInt16(txtModelo.Text);
            carro1.precioKm  = Convert.ToDecimal(txtPrecio.Text);
            carro1.color  = txtColor.Text;

            int pos = carro.FindIndex(x => x.placa == carro1.placa);
            if (pos == -1)
            {
                //agregar a lista
                carro.Add(carro1);
            }
            else
            {
                MessageBox.Show("La placa ingresada ya existe");
            }

         
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Leer1(@"C:\Archivo2Vehiculos.txt");
            Guardar(@"C:\Archivo2Vehiculos.txt");

        }

        private void Leer1(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1) //el -1 significa la ultima linea que no existe demostrando el final del archivo
            {
                Vehiculo carro1 = new Vehiculo();
                carro1.placa = reader.ReadLine();
                carro1.marca = reader.ReadLine();
                carro1.modelo = Convert.ToInt16(reader.ReadLine());
                carro1.precioKm  = Convert.ToInt16(reader.ReadLine());
                carro1.color = reader.ReadLine();

                //agregar a lista
                carro.Add(carro1);
            }

            reader.Close();
        }
        private void Guardar(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            //las variables var utilizan cualquier tipo de variable ya sea string u otros
            foreach (var carro1 in carro)
            {
                writer.WriteLine(carro1.placa);
                writer.WriteLine(carro1.marca);
                writer.WriteLine(carro1.modelo);
                writer.WriteLine(carro1.color);
                writer.WriteLine(carro1.precioKm);                   
            }
            //este writer.Close() ira fuera del ciclo
            writer.Close();

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
    }
}
