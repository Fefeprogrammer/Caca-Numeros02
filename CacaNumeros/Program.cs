using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;
using CacaNumeros.Entidades;

namespace CacaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Game("Caça Numeros");

            var scene1 = new Scene();

            var jogador = new Jogador(100, 100);

            var score = new Score(400, 10).Pontos;



            var listaNumero = new List<Numero>();

            listaNumero.Add(new Numero(50, 150, 1));
            listaNumero.Add(new Numero(20, 160, 2));
            listaNumero.Add(new Numero(500, 260, 3));
            listaNumero.Add(new Numero(110, 150, 4));
            listaNumero.Add(new Numero(150, 100, 5));
            listaNumero.Add(new Numero(80, 170, 6));
            listaNumero.Add(new Numero(200, 500, 7));
            listaNumero.Add(new Numero(100, 200, 8));
            listaNumero.Add(new Numero(80, 300, 9));


            foreach (var numero in listaNumero)
            {
            scene1.Add(numero);

            }



            scene1.AddGraphic(score);
            scene1.Add(jogador);

            jogo.Start(scene1);

            /*var numero1 = new Numeros(50, 200).num1;
            var sprite1 = new Numeros(50, 200).Sprite1;
            var numero2 = new Numeros(150, 250).num2;
            var sprite2 = new Numeros(150, 250).Sprite2;
            var numero3 = new Numeros(40, 150).num3;
            var sprite3 = new Numeros(40, 150).Sprite3;
            var numero4 = new Numeros(30, 10).num4;
            var sprite4 = new Numeros(30, 10).Sprite4;
            var numero5 = new Numeros(130, 120).num5;
            var sprite5 = new Numeros(130, 120).Sprite5;
            var numero6 = new Numeros(170, 14).num6;
            var sprite6 = new Numeros(170, 14).Sprite6;
            var numero7 = new Numeros(190, 200).num7;
            var sprite7 = new Numeros(190, 200).Sprite7;
            var numero8 = new Numeros(50, 60).num8;
            var sprite8 = new Numeros(50, 60).Sprite8;
            var numero9 = new Numeros(90, 200).num9;
            var sprite9 = new Numeros(90, 200).Sprite9;

            
            

            scene1.AddGraphic(numero1);
            scene1.AddGraphic(sprite1);
            scene1.AddGraphic(numero2);
            scene1.AddGraphic(sprite2);
            scene1.AddGraphic(numero3);
            scene1.AddGraphic(sprite3);
            scene1.AddGraphic(numero4);
            scene1.AddGraphic(sprite4);
            scene1.AddGraphic(numero5);
            scene1.AddGraphic(sprite5);
            scene1.AddGraphic(numero6);
            scene1.AddGraphic(sprite6);
            scene1.AddGraphic(numero7);
            scene1.AddGraphic(sprite7);
            scene1.AddGraphic(numero8);
            scene1.AddGraphic(sprite8);
            scene1.AddGraphic(numero9);
            scene1.AddGraphic(sprite9);*/




        }
    }
}
