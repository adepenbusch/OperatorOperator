using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.scripts
{
    /*
     * Player GameObject - created upon client connection.
    */
    class Player : NetworkBehaviour
    {
        [SyncVar]
        public PlugEnds plugCoordinates;
        [SyncVar]
        public int playerId;

    }
}
