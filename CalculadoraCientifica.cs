namespace Aula09Calculadora
{
    public class CalculadoraCientifica : Calculadora
    {
        
        private string[] valores {get; set;}
        private float val {get; set;}
        private float soma;

        public void CalcularMedia(string txtConsole){

            //  separa os números pela as vírgulas
            valores = txtConsole.Split(",");

            //  array de acordo com seu tamanho 
            for (int i = 0; i < valores.Length; i++)
            {

                val   = float.Parse(valores[i]);
                soma += val;
            }

            
            resultado = soma / valores.Length;
        }


        public void ManipularCalculos(string entradaUsuario){

            // Dividimos as entradas do usuário em um array
            string[] entrada = entradaUsuario.Split(' ');

            // Pegamos as entradas separada e atribuímos às nossas vairáveis 
            // entrada[0] = 12
            // entrada[1] = +
            // entrada[2] = 12
            n1 = float.Parse(entrada[0]);

            operador = entrada[1];
            
            n2 = float.Parse(entrada[2]);

            if(entrada[1] == null){

                entrada = entradaUsuario.Split('+');
                if(entrada[1] != null){
                    operador = "+";
                
                }
            }

            switch (operador)
            {    
                case "+":
                Somar( );
                break;

                
                case "-":
                Subtrair();
                break;

                case "x":
                Multiplicar();
                break;

                case "/":
                Dividir();
                break;

                
                default:
                Somar();
                break;


            }

        }

    }
}
