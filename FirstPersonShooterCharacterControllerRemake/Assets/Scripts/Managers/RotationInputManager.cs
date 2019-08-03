using CM.Orientation;
using System.Collections.Generic;
using UnityEngine;

public class RotationInputManager : MonoBehaviour
{
	private List<IRotate> _rotateInterfaces = new List<IRotate>();

	private Vector3 _input;

	[SerializeField]
	private Vector2 _sensitivity;

	private void Awake()
	{
		_rotateInterfaces.Add(GameObject.Find("Player").GetComponent<IRotate>());
	}

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
		for (int i = 0; i < _rotateInterfaces.Count; i++)
		{
			_rotateInterfaces[i].Rotate(_input);
		}
	}
}
