using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFoda
    {
        private readonly IJogador _jogadorA;
        private readonly IJogador _jogadorB;

        public JogoFoda(IJogador jogadorA, IJogador jogadorB)
        {
            this._jogadorA = jogadorA;
            this._jogadorB = jogadorB;
        }
        
        public void IniciarJogo(){
            System.Console.Write(_jogadorA.Correr());
            System.Console.Write(_jogadorA.Chutar());
            System.Console.Write(_jogadorA.Passar());
            System.Console.Write("PRÓXIMO JOGADOR \n");
            System.Console.Write(_jogadorB.Correr());
            System.Console.Write(_jogadorB.Chutar());
            System.Console.Write(_jogadorB.Passar());
       
        }
    }
}