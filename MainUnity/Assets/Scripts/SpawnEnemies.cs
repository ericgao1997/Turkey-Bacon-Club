using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

	public GameObject enemy;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	//public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.


	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn ()
	{
		// If the player has no health left...
		if(hpManager.health <= 0)
		{
			// ... exit the function.
			return;
		}

		// Find a random index between zero and one less than the number of spawn points.
		int spawnangle = Random.Range (0, 360); //ALWAYS SPAWN furthest away from circle

		//here manipulate setEnemyType.cs static vars to spawn diff enemies

		Vector3 difference = new Vector3 (Mathf.Cos (spawnangle) * 50, Mathf.Sin (spawnangle) * 50, 0);
		//difference.Normalize();
		//Vector3 spawnPoint = difference * 100;
		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		setEnemyType.nextEnSize = Random.Range(1,4);
		setEnemyType.nextEnType = Random.Range (0, 4);
		Instantiate (enemy, difference, new Quaternion(0,0,0,0));
	}
}
