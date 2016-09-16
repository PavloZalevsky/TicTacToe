using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTacToeServer
{
    public class Player
    {
        public String ConnectionId  { get; set; }
        public String Name { get; set; }
        public bool IsPlaying { get; set; }
        public Player Opponent { get; set; }
    }
}