using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace TicTacToeServer
{
    public class Game : Hub
    {

        List<Player> pleyers = new List<Player>();

        public void RegistersPlater(String Name)
        {
            var player = pleyers.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            if (player == null)
            {
                player = new Player { Name = Name, ConnectionId = Context.ConnectionId};
                pleyers.Add(player);
            }
            player.IsPlaying = false;

            Clients.Client(Context.ConnectionId).registerComplete();

        }
    }
}