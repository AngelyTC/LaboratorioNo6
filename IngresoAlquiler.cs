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
    public partial class IngresoAlquiler : Form
    {
        List<Alquiler> alqui = new List<Alquiler>();
        List<Cliente> persona = new List<Cliente>();
        List<Vehiculo> carro = new List<Vehiculo>();
        List<Mostrar> mostrar = new List<Mostrar>();
        public IngresoAlquiler()
        {
            InitializeComponent();
        }

        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            Alquiler alqui1 = new Alquiler();
            alqui1.NIT = txtNit1.Text;
            alqui1.placa = txtPlaca1.Text;
            alqui1.fechaAlquiler = txtFechaA.Value;
            alqui1.fechaDevolucion =txtFechaD.Value;
            alqui1.kmRecorrido = Convert.ToInt16(txtKm.Text);
            //int 32 guarda hasta 32 bits, int16 guarda hasta 16 bits
            //agregar a lista
           int pos = alqui.FindIndex(x => x.NIT == alqui1.NIT);
            if (pos == -1)
            {
                //agregar a lista
                alqui.Add(alqui1);
                Guardar1();
            }
            else
            {
                MessageBox.Show("La placa ingresada ya existe");
            }

            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            LeerCliente();
            Leer1();
        }

       

        private void LeerCliente()
        {
            FileStream stream = new FileStream("Archivo1Cliente.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1) //el -1 significa la ultima linea que no existe demostrando el final del archivo
            {
                Cliente persona1 = new Cliente();
                persona1.NIT= reader.ReadLine();
                persona1.Nombre = reader.ReadLine();
                persona1.direccion = reader.ReadLine();

                //agregar a lista
                persona.Add(persona1);
            }

            reader.Close();
        }

        private void Leer1()
        {
            FileStream stream = new FileStream("Carros.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1) //el -1 significa la ultima linea que no existe demostrando el final del archivo
            {
                Vehiculo carro1 = new Vehiculo();
                carro1.placa = reader.ReadLine();
                carro1.marca = reader.ReadLine();
                carro1.modelo = reader.ReadLine();
                carro1.precioKm = Convert.ToInt16(reader.ReadLine());
                carro1.color = reader.ReadLine();
              
                //agregar a lista
                carro.Add(carro1);
            }

            reader.Close();
        }

        private void Guardar1()
        {
            FileStream stream = new FileStream("ArchivoAlquiler.txt", FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(stream);

            //las variables var utilizan cualquier tipo de variable ya sea string u otros
            foreach (var alqui1 in alqui )
            {
                writer.WriteLine(alqui1.NIT);
                writer.WriteLine(alqui1.placa );
                writer.WriteLine(alqui1.fechaAlquiler);
                writer.WriteLine(alqui1.fechaDevolucion);
                writer.WriteLine(alqui1.kmRecorrido);
            }
            //este writer.Close() ira fuera del ciclo
            writer.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < alqui.Count; ++i)
            {
                Mostrar mostrar2 = new Mostrar();
                for (int j = 0; j < persona.Count; j++)
                {
                    if (alqui[i].NIT == persona[j].NIT)
                    {
                        mostrar2.nombre = persona[j].Nombre;
                    }
                }
                for (int k = 0; k < carro.Count; k++)
                {
                    if (alqui[i].placa == carro[k].placa)
                    {
                        mostrar2.placa = carro[k].placa;
                        mostrar2.color = carro[k].color;
                        mostrar2.total = carro[k].precioKm * alqui[i].kmRecorrido;
                        mostrar2.devolucion = alqui[i].fechaDevolucion;
                    }
                }
                mostrar.Add(mostrar2);
                dgtdDatos.DataSource = null;
                dgtdDatos.Refresh();

                dgtdDatos.DataSource = mostrar;
                dgtdDatos.Refresh();
            }
 dgtAlquiler.DataSource = null;
            dgtAlquiler.Refresh();

            dgtAlquiler.DataSource = alqui;
            dgtAlquiler.Refresh();
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mayalqui = alqui.Max(u => u.kmRecorrido);
            label8.Text = "El alquiler con mayor recorrido es de  " + mayalqui.ToString();
        }
    }
}
