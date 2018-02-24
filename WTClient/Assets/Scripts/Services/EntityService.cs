using ECS;
using UnityEngine;

public class EntityService
{

	//public RandomService randomService = RandomService.game;

	public static EntityService singleton = new EntityService();

	static readonly string[] _pieces = {
		//Res.Piece0,
		//Res.Piece1,
		//Res.Piece2,
		//Res.Piece3,
		//Res.Piece4,
		//Res.Piece5
	};

	public void CreateGameBoard()
	{
		//var entity = context.CreateEntity();
		//entity.AddGameBoard(8, 9);
		//return entity;
		//return null;
	}

	public GameObjectEntity CreateRandomPiece(UnityEntityManager entityManager,int x,int y,GameObject _gameObject)
	{
		Entity entity = entityManager.CreateEntity();

		GameObject gameObject = new GameObject("Entity-" + x + y);
		gameObject.transform.SetParent(_gameObject.transform);

		GameObjectEntity goEntity = gameObject.AddComponent<GameObjectEntity>();
		goEntity.SetEntity(entity, entityManager);
		entityManager.AddComponent(entity, new Position(new IntVector2(x, y)));

		return goEntity;
	}


}
