using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace interfazCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServicioMetodos.Service1Client cliente = new ServicioMetodos.Service1Client();

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(textBox1.Text);
            var primerServicio = cliente.elevarCuadrado(numero);
            label2.Text= Convert.ToString(primerServicio.num1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pelicula;
            pelicula = Convert.ToString(textBox2.Text);
            var segundoServicio = cliente.BuscaPeliculas(pelicula);
            listBox1.Items.Add("Nombre: "+segundoServicio.Nombre);
            listBox1.Items.Add("Duracion: "+segundoServicio.Duracion);
            listBox1.Items.Add("Director: "+segundoServicio.Director);
            listBox1.Items.Add("Calificacion: "+segundoServicio.Calificacion);
            listBox1.Items.Add("Estado: "+segundoServicio.Error);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt32(textBox3.Text);
            var tercerServicio = cliente.ComparaNum(num);
            label7.Text = Convert.ToString(tercerServicio);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int numCont;
            numCont = Convert.ToInt32(textBox4.Text);
            var cuartoServicio = cliente.BuscarAlumno(numCont);
            textBox5.Text = Convert.ToString(cuartoServicio.nombre);
            textBox6.Text = Convert.ToString(cuartoServicio.apellido);
            textBox7.Text = Convert.ToString(cuartoServicio.carrera);
            textBox8.Text = Convert.ToString(cuartoServicio.semestre);
            textBox9.Text = Convert.ToString(cuartoServicio.grupo);
        }
    }
}
