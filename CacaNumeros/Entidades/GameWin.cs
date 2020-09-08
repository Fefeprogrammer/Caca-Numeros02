using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace CacaNumeros.Entidades
{
    class GameWin : Entity
    {
        public Text msg { get; set; }

        public GameWin(float x, float y) : base(x, y)
        {
            msg = new Text("VOCE VENCEU!", 80);
            msg.CenterOrigin();
        }
    }
}
