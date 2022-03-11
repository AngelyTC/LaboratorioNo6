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
        int reco;
        public IngresoAlquiler()
        {
            InitializeComponent();
        }

        private void btnIngresarDato_Click(object sender, EventArgs e)
        {
            reco = Int16.Parse(txtKm.Text);
            Alquiler alqui1 = new Alquiler();
            alqui1.placa = txtPlaca1.Text;
            alqui1.NIT  = txtNit1.Text;
            alqui1.fechaAlquiler = txtFechaA.Value;
            alqui1.fechaDevolucion =txtFechaD.Value;
            alqui1.kmRecorrido = Convert.ToInt16(txtKm.Text);
            //int 32 guarda hasta 32 bits, int16 guarda hasta 16 bits
            //agregar a lista
            alqui.Add(alqui1);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Leer2(@"C:\ArchivoAlquiler.txt");
            Guardar1(@"C:\ArchivoAlquiler.txt");
           
        }

        private void Leer2(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1) //el -1 significa la ultima linea que no existe demostrando el final del archivo
            {
                Alquiler alqui1 = new Alquiler();
                alqui1.NIT  = reader.ReadLine();
                alqui1.placa  = reader.ReadLine();
                alqui1.fechaAlquiler = Convert.ToDateTime (reader.ReadLine());
                alqui1.fechaDevolucion = Convert.ToDateTime(reader.ReadLine());
                alqui1.kmRecorrido = Convert.ToInt32(reader.ReadLine());

                //agregar a lista
                alqui.Add(alqui1);
            }

            reader.Close();
        }
        private void Guardar1(string fileName)
        {
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);

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
                    }
                }
                mostrar.Add(mostrar2);
            }
          
            dgtAlquiler.Refresh();

            dgtAlquiler.DataSource = mostrar;
            dgtAlquiler.Refresh();


        }
    }
}
