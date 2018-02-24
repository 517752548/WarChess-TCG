using ECS;

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


}
