using UnityEngine;
using System.Collections;

public class ScrollBackground : MonoBehaviour {

    public float speed;

	void Start () {
        speed = 0.5f;
	}
	
	void Update () {
        Vector2 offset = new Vector2 (Time.time * speed, 0f);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
