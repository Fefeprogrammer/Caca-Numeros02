using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace CacaNumeros.Entidades
{
    class GameOver : Entity
    {
        public Text msg { get; set; }

        public GameOver(float x, float y) : base(x, y)
        {
            msg = new Text("GAME OVER!", 80);
            msg.CenterOrigin();
        }
    }
}
