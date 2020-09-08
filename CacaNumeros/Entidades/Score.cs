using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace CacaNumeros.Entidades
{
    class Score : Entity
    {
        public Text Pontos { get; set; }

        

        public Score(float x, float y) : base(x,y)
        {
            Pontos = new Text("Pontos: "+ Jogador.Score, 40);
            Pontos.SetPosition(x, y);
            Pontos.OutlineColor = Color.White;
            
        }

        public override void Update()
        {
            base.Update();

            

        }

        public override void Render()
        {
            base.Render();
        }
    }
}
