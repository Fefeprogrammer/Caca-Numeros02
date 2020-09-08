using Otter;

namespace CacaNumeros.Entidades
{
    class Numero : Entity
    {
        public Text NumText { get; set; }
        public Numeros Num { get; set; }


        public Numero(int x, int y, int numero)
            : base(x, y)
        {
            Num = (Numeros)numero;
            NumText = new Text(numero.ToString(), 40);
            Graphic = Image.CreateCircle(20, Color.Red);
            Graphic = NumText;
            Collider = new CircleCollider(10, Tags.Numero);
        }

        public override void Update()
        {
            base.Update();

            var collisions = Collider.CollideEntities(X, Y, Tags.Jogador);
            if (collisions.Count > 0)
            {
              
                Jogador.Score++;
                RemoveSelf();
            }
            Num = (Numeros)num;
            if(collisions = Numer)
        }
    }

}
