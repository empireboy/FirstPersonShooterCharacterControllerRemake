using CM.Essentials;
using CM.Orientation;
using UnityEngine;

public class PlayerSpawnTestManager : MonoBehaviour
{
	[SerializeField]
	private Transform _spawnPoint;

	[SerializeField]
	private Player _playerPrefab;

	[Header("Managers")]

	[SerializeField]
	private GameObject _movementManager;

	[SerializeField]
	private GameObject _rotationManager;

	private void Start()
	{
		Player player = Instantiate(_playerPrefab);
		player.SetSpawn(_spawnPoint);
		player.Spawn();

		_movementManager.GetComponent<Manager<IMovement2D>>().AddInterface(player);
		_rotationManager.GetComponent<Manager<IRotate>>().AddInterface(player);
	}
}