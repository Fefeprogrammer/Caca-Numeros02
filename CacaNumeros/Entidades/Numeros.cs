/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace CacaNumeros.Entidades
{
    class Numeros : Entity
    {
        public Text num1 { get; set; }
        public Text num2 { get; set; }
        public Text num3 { get; set; }
        public Text num4 { get; set; }
        public Text num5 { get; set; }
        public Text num6 { get; set; }
        public Text num7 { get; set; }
        public Text num8 { get; set; }
        public Text num9 { get; set; }

        public Image Sprite1 { get; set; }
        public Image Sprite2 { get; set; }
        public Image Sprite3 { get; set; }
        public Image Sprite4 { get; set; }
        public Image Sprite5 { get; set; }
        public Image Sprite6 { get; set; }
        public Image Sprite7 { get; set; }
        public Image Sprite8 { get; set; }
        public Image Sprite9 { get; set; }

        //CircleCollider collider = new CircleCollider(20, Tags.Numeros);

        CircleCollider collider1 = new CircleCollider(15, Tags.Num1);
        CircleCollider collider2 = new CircleCollider(15, Tags.Num2);
        CircleCollider collider3 = new CircleCollider(15, Tags.Num3);
        CircleCollider collider4 = new CircleCollider(15, Tags.Num4);
        CircleCollider collider5 = new CircleCollider(15, Tags.Num5);
        CircleCollider collider6 = new CircleCollider(15, Tags.Num6);
        CircleCollider collider7 = new CircleCollider(15, Tags.Num7);
        CircleCollider collider8 = new CircleCollider(15, Tags.Num8);
        CircleCollider collider9 = new CircleCollider(15, Tags.Num9);

        public Numeros(float x, float y) : base(x, y)
        {
            
            num1 = new Text("1", 40);
            //num1.OutlineColor = cor;
            num1.SetPosition(x, y);
            Sprite1 = Image.CreateCircle(20, Color.Red);
            collider1.SetPosition(x, y);
            AddCollider(collider1);
            

            num2 = new Text("2", 40);
            //num2.OutlineColor = cor;
            num2.SetPosition(x, y);
            Sprite2 = Image.CreateCircle(20, Color.Red);
            AddCollider(collider2);
            collider2.SetPosition(x, y);

            num3 = new Text("3", 40);
            //num3.OutlineColor = cor;
            num3.SetPosition(x, y);
            Sprite3 = Image.CreateCircle(20, Color.Red);
            AddCollider(collider3);
            collider3.SetPosition(x, y);

            num4 = new Text("4", 40);
            //num4.OutlineColor = cor;
            num4.SetPosition(x, y);
            Sprite4 = Image.CreateCircle(20, Color.Red);
            AddCollider(collider4);
            collider4.SetPosition(x, y);

            num5 = new Text("5", 40);
            //num5.OutlineColor = cor;
            num5.SetPosition(x, y);
            Sprite5 = Image.CreateCircle(20, Color.Red);
            AddCollider(collider5);
            collider5.SetPosition(x, y);

            num6 = new Text("6", 40);
            //num6.OutlineColor = cor;
            num6.SetPosition(x, y);
            Sprite6 = Image.CreateCircle(20, Color.Red);
            AddCollider(collider6);
            collider6.SetPosition(x, y);

            num7 = new Text("7", 40);
            //num7.OutlineColor = cor;
            num7.SetPosition(x, y);
            Sprite7 = Image.CreateCircle(20, Color.Red);
            AddCollider(collider7);
            collider7.SetPosition(x, y);

            num8 = new Text("8", 40);
            //num8.OutlineColor = cor;
            num8.SetPosition(x, y);
            Sprite8 = Image.CreateCircle(20, Color.Red);
            AddCollider(collider8);
            collider8.SetPosition(x, y);

            num9 = new Text("9", 40);
            //num9.OutlineColor = cor;
            num9.SetPosition(x, y);
            Sprite9 = Image.CreateCircle(20, Color.Red);
            AddCollider(collider9);
            collider9.SetPosition(x, y);
        }

        public override void Update()
        {
            base.Update();

            Colid();
        }

        public void Colid()
        {
            var collisions1 = collider1.CollideEntities(X, Y, Tags.Jogador);
            if (collisions1.Count > 0)
            {
                RemoveSelf();
                Jogador.Score++;
            }
            else
            {
                GameOver GameOver = new GameOver(500,500);
            }

            /*if (collider1.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }

            if (collider2.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }

            if (collider3.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }

            if (collider4.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }

            if (collider5.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }

            if (collider6.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }

            if (collider7.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }

            if (collider8.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }

            if (collider9.Overlap(X, Y, Tags.Jogador))
            {
                RemoveSelf();
                Jogador.Score++;
            }
        }

        public override void Render()
        {
            base.Render();
        }

    }
}*/
