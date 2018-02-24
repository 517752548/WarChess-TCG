using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ECS {
	/// <summary>
	/// Required Components: MyComponent
	/// </summary>
	//use this tag to group systems for debugging purposes
	[DebugSystemGroup("Init")]
	public class InitGameBoardSystem : ComponentSystem {
		public EntityService entityService = EntityService.singleton;


		// Use this for standard unity start function
		public override void OnStart() {
			//创建GameBoard
			//var gameBoard = entityService.CreateGameBoard(_contexts.game).gameBoard;

			//创建RandomPiece
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 9; j++)
				{

				}
			}

		}
        
        // Use this for standard unity update function
        public override void OnUpdate() {
			
		}
    }

}
