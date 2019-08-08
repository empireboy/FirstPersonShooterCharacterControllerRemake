using CM.Essentials;
using CM.Orientation;
using UnityEngine;

public class RotationInputManager : Manager<IRotate>
{
	private Vector3 _input;

	[SerializeField]
	private Vector2 _sensitivity;

	private void Start()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void Update()
	{
		// Get input
		_input.Set(
			Input.GetAxis("Mouse X") * _sensitivity.x * Time.deltaTime,
			Input.GetAxis("Mouse Y") * _sensitivity.y * Time.deltaTime,
			0
		);

		// Set rotation
		for (int i = 0; i < interfaces.Count; i++)
		{
			interfaces[i].Rotate(_input);
		}
	}
}
