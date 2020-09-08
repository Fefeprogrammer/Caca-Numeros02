using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace CacaNumeros.Entidades
{
    class Jogador : Entity
    {
        public float Velocidade { get; set; }
        public static int Score { get; internal set; }

        public const float Movimentacao = 5;

        public Jogador(float x, float y) : base(x, y)
        {
            Graphic = Image.CreateCircle(15, Color.Blue);
            Collider = new CircleCollider(15, Tags.Jogador);
            Collider.SetPosition(x, y);
            
            Velocidade = Movimentacao;
        }

        

        public override void Update()
        {
            base.Update();

            MovimentarJogador();

           

            var collisions = Collider.CollideEntities(X, Y, Tags.Numero);
            if( collisions.Count > 0)
            {
                RemoveSelf();
                Jogador.Score++;
            }

           /* if (this.Overlap(X, Y, Tags.Numero))
            {
                RemoveSelf();
                Jogador.Score++;
            }*/


        }

        public override void Render()
        {
            base.Render();
        }

        private void MovimentarJogador()
        {
            if (Input.KeyDown(Key.W))
            {
                Y -= Velocidade;
            }

            if (Input.KeyDown(Key.S))
            {
                Y += Velocidade;
            }

            if (Input.KeyDown(Key.A))
            {
                X -= Velocidade;
            }

            if (Input.KeyDown(Key.D))
            {
                X += Velocidade;
            }
        }
    }
}
