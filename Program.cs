using System;
using framework.App.Adapters;
using framework.App.Adapters.Services;

namespace framework
{
    class Program
    {
        static void Main(string[] args){
            var clientId = Environment.GetEnvironmentVariable("BLUEG_CLIENT_ID") ?? String.Empty;
            var clientSecret = Environment.GetEnvironmentVariable("BLUEG_CLIENT_SECRET") ?? String.Empty;

            var service = new BlueGServices();
            service.Achievement = new Achievements();
            service.Leaderboard = new Leaderboard();
            service.Chats = new Chats();
            service.Friendship = new Friendship();
            service.Party = new Party();
            service.Users = new Users();

            BlueG.Auth = new Auth();
            BlueG.Table = new Table(service);
            BlueG.Storage = new Storage();
            BlueG.Start(clientId, clientSecret);
            
        }
    }
}
