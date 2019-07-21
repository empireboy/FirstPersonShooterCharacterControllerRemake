using System.Collections.Generic;
using UnityEngine;

public class MovementInputManager : MonoBehaviour
{
	private List<IMovement2D> _movementInterfaces = new List<IMovement2D>();

	private Vector2 _input;

	private void Awake()
	{
		_movementInterfaces.Add(GameObject.Find("Player").GetComponent<IMovement2D>());
	}

	private void Update()
	{
		_input.Set(
			Input.GetAxis("Horizontal"),
			Input.GetAxis("Vertical")
		);
	}

	private void FixedUpdate()
	{
		for (int i = 0; i < _movementInterfaces.Count; i++)
		{
			_movementInterfaces[i].Move(_input);
		}
	}
}
