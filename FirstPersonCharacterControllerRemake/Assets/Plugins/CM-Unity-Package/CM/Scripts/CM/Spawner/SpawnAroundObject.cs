﻿using UnityEngine;

namespace CM.Spawner
{
	public static class SpawnAroundObject
	{
		public static Transform Spawn(Transform from, GameObject objectToSpawn, float angle, float radius)
		{
			return Spawning(from, objectToSpawn, angle, radius);
		}

		public static Transform Spawn(GameObject objectToSpawn, float angle, float radius)
		{
			return Spawning(objectToSpawn, angle, radius);
		}

		/*
		public static void Spawn(Transform from, GameObject objectToSpawn, float angle, float radius, float seconds)
		{
			StartCoroutine(SpawnRoutine(from, objectToSpawn, angle, radius, seconds));
		}

		private IEnumerator SpawnRoutine(Transform from, GameObject objectToSpawn, float angle, float radius, float seconds)
		{
			yield return new WaitForSeconds(seconds);
			Spawning(from, objectToSpawn, angle, radius);
		}
		*/

		private static Transform Spawning(Transform from, GameObject objectToSpawn, float angle, float radius)
		{
			Vector2 offset = (Vector2)(Quaternion.Euler(0, 0, angle) * Vector2.right) * radius;

			GameObject spawningObject = Object.Instantiate(objectToSpawn);
			spawningObject.transform.position = new Vector2(from.position.x, from.position.y) + offset;
			spawningObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 90));

			return spawningObject.transform;
		}

		private static Transform Spawning(GameObject objectToSpawn, float angle, float radius)
		{
			Vector2 offset = (Vector2)(Quaternion.Euler(0, 0, angle) * Vector2.right) * radius;

			GameObject spawningObject = Object.Instantiate(objectToSpawn);
			spawningObject.transform.position = offset;
			spawningObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle + 90));

			return spawningObject.transform;
		}
	}
}