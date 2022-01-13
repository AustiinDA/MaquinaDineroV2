using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDinero
{
    public class Cliente
    {
        String nombre;
        int codigoCliente;
        double saldoCliente, interes;

        public Cliente(string nombre, int codigoCliente, double saldoCliente, double interes)
        {
            this.Nombre = nombre;
            this.CodigoCliente = codigoCliente;
            this.SaldoCliente = saldoCliente;
            this.Interes = interes;
        }

        public Cliente(string nombre, int codigoCliente)
        {
            this.nombre = nombre;
            this.codigoCliente = codigoCliente;
        }

        public Cliente(string nombre)
        {
            this.Nombre= nombre;
        }
        public Cliente(double saldoCliente)
        {
            this.saldoCliente = saldoCliente;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int CodigoCliente { get => codigoCliente; set => codigoCliente = value; }
        public double SaldoCliente { get => saldoCliente; set => saldoCliente = value; }
        public double Interes { get => interes; set => interes = value; }


        public override string ToString()
        {
            return "Nombre: " + nombre + ", Código: " + codigoCliente + ", Saldo: " + saldoCliente + "€, Interés: " + interes + "%";
        }
    }
}
