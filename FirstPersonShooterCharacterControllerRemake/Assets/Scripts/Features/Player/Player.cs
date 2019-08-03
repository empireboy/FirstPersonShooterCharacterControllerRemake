using CM.Essentials;
using CM.Orientation;
using UnityEngine;

public class Player : Entity, IMovement2D, IRotate
{
	private IMovement2D[] _movementModules;
	private IRotate[] _rotateModules;

	protected override void OnAwake()
	{
		base.OnAwake();

		_movementModules = GetModules<IMovement2D>();
		_rotateModules = GetModules<IRotate>();
	}

	public void Move(Vector2 input)
	{
		foreach (IMovement2D module in _movementModules)
		{
			module.Move(input);
		}
	}

	public void Rotate(Vector3 input)
	{
		foreach (IRotate module in _rotateModules)
		{
			module.Rotate(input);
		}
	}
}