namespace Aula09Calculadora
{
    public class Calculadora
    {
        public float n1 { get; set; }
        public float n2 { get; set; }
        public float resultado { get; set; }
        public string operador { get; set; }

        public void Somar(){
            resultado = n1 + n2;
        }

        public void Subtrair(){
            resultado = n1 - n2;
        }

        public void Multiplicar(){
            resultado = n1 * n2;
        }

        public void Dividir(){
            resultado = n1 / n2;
        }



    }
}
