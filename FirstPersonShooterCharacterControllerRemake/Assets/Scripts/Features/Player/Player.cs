using CM.Essentials;
using UnityEngine;

public class Player : Entity, IMovement2D
{
	public void Move(Vector2 input)
	{
		IMovement2D[] modules = GetModules<IMovement2D>();

		foreach (IMovement2D module in modules)
		{
			module.Move(input);
		}
	}
}