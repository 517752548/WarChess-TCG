using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ECS {
    // structs are way faster than class 
    // use this when ever you can it has an important impact on the computation speedup
    [Serializable]
    public struct GameBoard : IComponent {
		public int columns;
		public int rows;
    }

	public class GameBoardComponent : ComponentDataWrapper<GameBoard> { }
}
