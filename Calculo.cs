namespace Atividade_Aula_11
{
    public class Calculo
    {
        //Objetivo -> tentar diferentes formas de uso do overload polimorfismo

        //Compra
        public string Calcular(){
            return "Não há compra";
        }
        public string Calcular(int v1){
            return "O valor da compra é "+v1;
        }
        public string Calcular(double v1, double j1){
            v1 = v1 + j1;
            return "O valor da compra com juros é "+v1;
        }
        public string Calcular(string nome){
            return "O nome do produto é "+nome;
        }
        public string Calcular(string nome, string marca){
            return $"O produto é {nome} da marca {marca}";
        }
    


    }
}