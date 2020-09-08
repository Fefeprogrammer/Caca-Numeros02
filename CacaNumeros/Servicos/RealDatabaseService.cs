using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using CacaNumeros.Modelo;

namespace CacaNumeros.Servicos
{
    class RealDatabaseService
    {
        FirebaseClient firebase;

        public RealDatabaseService()
        {
            firebase = new FirebaseClient("https://cacanumeros.firebaseio.com/");
        }

        public async Task<Placar> Get()
        {
            var registro = await firebase.Child("Placar").OrderByKey().StartAt("suabusca").OnceAsync<Placar>();
            return registro as Placar;
        }

        public async Task Post(Placar placar)
        {
            var registro = await firebase.Child("Placar").PostAsync(placar);
        }
    }
}
