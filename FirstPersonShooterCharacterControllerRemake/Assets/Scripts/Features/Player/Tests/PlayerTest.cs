using System.Collections;
using CM.Orientation;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerTest
    {
        [UnityTest]
        public IEnumerator PlayerMovement_CanPlayerMove()
        {
			// Arrange
			Player player = GameObject.Instantiate(new GameObject("Player")).AddComponent<Player>();
			player.gameObject.AddComponent<Rigidbody>();
			player.CreateModules();
			player.GetModuleObject<IMovement2D>().AddComponent<RigidbodyMovement>().Initialize(player.GetComponent<Rigidbody>());
			Vector3 playerPosition = player.transform.position;

			// Act
			player.Move(Vector2.right);

            yield return null;

			// Assert
			Assert.AreNotEqual(player.transform.position.x, playerPosition.x);
        }
    }
}
