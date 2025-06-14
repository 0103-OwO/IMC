using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    internal class clsIMC
    {
        // Atributos
        private float peso;
        private float estatura;
        private int pasos;
        private float sancada;
        private int Meta;

        // Constructor
        public clsIMC()
        {
            peso = 0;
            estatura = 0;
            pasos = 0;
            sancada = 0;
            Meta = 0;
        }

        // Propiedades
        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        public float Estatura
        {
            get { return estatura; }
            set { estatura = value; }
        }
        public int Pasos
        {
            get { return pasos; }
            set { pasos = value; }
        }
        public float Sancada
        {
            get { return sancada; }
            set { sancada = value; }
        }
        public int meta
        {
            get { return Meta; }
            set { Meta = value; }
        }

        // Métodos
        // Calcular el IMC y valida que los valores sean mayores que cero.
        public float CalcularIMC()
        {
            float res = 0;

            if (estatura <= 0 || peso <= 0)
            {
                MessageBox.Show("Los valores deben ser mayores que cero.");
            }
            else
            {
                res = peso / (estatura * estatura);
            }

            return res;
            
        }

        // Clasifica el IMC y asigna una meta de pasos diaria según la clasificación.
        public string Clasificacion()
        {
            float imc = CalcularIMC();
            string clasificacion = "";

            if (imc < 18.5)
            {
                clasificacion = "Bajo peso";
                meta = 4000;

            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                clasificacion = "Peso normal";
                meta = 6000;
            }
            else if (imc >= 25 && imc < 29.9)
            {
                clasificacion = "Sobrepeso";
                meta = 8000;
            }
            else
            {
                clasificacion = "Obesidad";
                meta = 10000;
            }
            return clasificacion;
        }

        //Calcula los pasos restantes para alcanzar la meta diaria, valida que los pasos sean mayores que cero.
        public string CalcularPasos()
        {
            float imc = CalcularIMC();
            float res = 0;
            string PasosFaltantes = "";
            if (pasos <= 0)
            {
                MessageBox.Show("Los valores deben ser mayores que cero.");
            }
            else
            {
                res = pasos * sancada;
            }

            if (res > meta)
            {
                PasosFaltantes = "No necesita caminar más, ya ha alcanzado su meta diaria.";
            }
            else
            {
                PasosFaltantes = "Le faltan " + (meta - res) + "m para alcanzar su meta diaria.";
            }
            return PasosFaltantes;
        }
    }
}
