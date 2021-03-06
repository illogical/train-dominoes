using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Models
{
    public class Track
    {
        public int? PlayerId { get; set; }  // each player gets only 1 track. When null then anyone can use this track
        public bool HasTrain { get; set; }  // TODO: needs set to true when a player is unable to play a domino
        public List<int> DominoIds { get; set; }

        public Track(int dominoId)
        {
            DominoIds = new List<int>();
            DominoIds.Add(dominoId);
        }

        public void AddDominoToTrack(int dominoId)
        {
            DominoIds.Add(dominoId);
        }
    }
}
