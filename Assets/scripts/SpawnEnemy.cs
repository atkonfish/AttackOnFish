using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
   
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy;
	
	void Update () {
		if (_enemy == null) {
			_enemy = Instantiate(enemyPrefab) as GameObject;
			float spawnY = Random.Range(-4.2f, 4.2f);
			_enemy.transform.position = new Vector3(10, spawnY, 0);;
		}
	}
}
