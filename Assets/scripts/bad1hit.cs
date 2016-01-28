using UnityEngine;
using System.Collections;

public class bad1hit : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other) {
		Destroy(gameObject);
	}
}
