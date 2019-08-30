using CM.Essentials;
using CM.Orientation;
using CM.Spawner;
using UnityEngine;

public class Player : Entity, IMovement2D, IRotate, ISpawning
{
	private IMovement2D[] _movementModules;
	private IRotate[] _rotateModules;
	private ISpawning[] _spawningModules;

	protected override void OnAwake()
	{
		base.OnAwake();

		_movementModules = GetModules<IMovement2D>();
		_rotateModules = GetModules<IRotate>();
		_spawningModules = GetModules<ISpawning>();
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

	public void Spawn()
	{
		foreach (ISpawning module in _spawningModules)
		{
			module.Spawn();
		}
	}

	public void SetSpawn(Transform spawnPoint)
	{
		foreach (ISpawning module in _spawningModules)
		{
			module.SetSpawn(spawnPoint);
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
			Spawn();
	}
}