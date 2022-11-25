using System;
using framework.App.Adapters;
using framework.App.Adapters.Services;

namespace framework_test
{
    class Program
    {
        static void Main(string[] args){
            BlueG.ClientId = Environment.GetEnvironmentVariable("client_id") ?? String.Empty;
            BlueG.ClientSecret = Environment.GetEnvironmentVariable("client_secret") ?? String.Empty;

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
            BlueG.Start();
            
        }
    }
}