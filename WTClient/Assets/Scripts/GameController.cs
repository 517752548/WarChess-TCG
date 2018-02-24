using ECS;
using UnityEngine;

public class GameController : ECSController<UnityStandardSystemRoot, UnityEntityManager>
{
	protected override void Initialize()
	{
		AddSystem<RotateObjectSystem>();
	}
}

