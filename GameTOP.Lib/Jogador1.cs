using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string _nome;

        public Jogador1(string nome)
        {
            this._nome = nome;
        }

        public string Chutar()
        {
            return $"{_nome} está Chutando \n";
        }

        public string Correr()
        {
            return $"{_nome} está Correndo \n";
        }

        public string Passar()
        {
            return $"{_nome} está Passando \n";
        }
    }
}