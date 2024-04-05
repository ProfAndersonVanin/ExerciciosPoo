using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaQuadradoRetangulo
{
    public class Area
    {
        public int Altura {  get; set; }
        public int Baseret {  get; set; }
        

        public int CalculaArea()
        {
            int altura = this.Altura;
            int baseret = this.Baseret;
            int area;
            if (altura == baseret)
            {
                area = altura * altura;
            }
            else
            {
                area = altura * baseret;
            }
            return area;
        }
        public string CalculaArea2()
        {
            int altura = this.Altura;
            int baseret = this.Baseret;
            int area = 0;
            string resultado = "";
            if (altura == baseret)
            {
                area = altura * altura;
                resultado = "Como a base e altura são iguais, ";
                resultado += "será calculada a área de um QUADRADO.";
                resultado += " A área é: " + area;
            }
            else
            {
                area = altura * baseret;
                resultado = "Como a base e altura são diferentes, ";
                resultado += "será calculada a área de um RETÂNGULO.";
                resultado += " A área é: " + area;
            }
            return resultado;
        }
    }
}
