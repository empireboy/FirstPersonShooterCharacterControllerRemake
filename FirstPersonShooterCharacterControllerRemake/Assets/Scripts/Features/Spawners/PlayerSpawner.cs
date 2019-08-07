using CM.Essentials;
using CM.Orientation;
using CM.Spawner;
using UnityEngine;

public class PlayerSpawner : Spawner
{
	[SerializeField]
	private GameObject _movementManager;

	[SerializeField]
	private GameObject _rotationManager;

	private void Start()
	{
		Spawn();
	}

	protected override void OnSpawn(GameObject instantiatedObject)
	{
		base.OnSpawn(instantiatedObject);

		Player player = instantiatedObject.GetComponent<Player>();

		_movementManager.GetComponent<Manager<IMovement2D>>().interfaces.Add(player);
		_rotationManager.GetComponent<Manager<IRotate>>().interfaces.Add(player);
	}
}