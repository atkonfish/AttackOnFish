using UnityEngine;
using System.Collections;

public class bad1hit : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D coll) {
		if (coll.gameObject.tag == "bullet") {
			Destroy(gameObject);
			scoreCounter.score += 50;
		}
		if (coll.gameObject.tag == "player") {
			Destroy(gameObject);
			scoreCounter.score -= 1000;
		}
	}
}
