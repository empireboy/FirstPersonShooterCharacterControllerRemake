using CM.Essentials;
using CM.Orientation;
using UnityEngine;

public class MovementInputManager : Manager<IMovement2D>
{
	private Vector2 _input;

	private void Update()
	{
		_input.Set(
			Input.GetAxis("Horizontal"),
			Input.GetAxis("Vertical")
		);
	}

	private void FixedUpdate()
	{
		for (int i = 0; i < interfaces.Count; i++)
		{
			interfaces[i].Move(_input);
		}
	}
}
