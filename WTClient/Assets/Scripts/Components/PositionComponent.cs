using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ECS {
    // structs are way faster than class 
    // use this when ever you can it has an important impact on the computation speedup
    [Serializable]
    public struct Position : IComponent {
		
		public IntVector2 value;
	}

	public class PositionComponent : ComponentDataWrapper<Position> { }
}
