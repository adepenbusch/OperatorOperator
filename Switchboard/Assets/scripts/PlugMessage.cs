using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.scripts
{
    /*
     * PlugMessage - Extends the message base for communications between clients.
     * plugCoordinates - the coordinates of the plug that need tobe plugged, or was plugged.
     * playerId - PlayerId doing the request or response
     * isNewCoordinate - If true, everyone needs to try these plugs. If false, it was already done.
     */
    class PlugMessage : MessageBase
    {
        public PlugCoordinates plugCoordinates;
        public int playerId;
        public bool isNewCoordinate;
    }
}
