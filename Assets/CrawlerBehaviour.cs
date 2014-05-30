using UnityEngine;
using System.Collections;

public class CrawlerBehaviour : MonoBehaviour {

	public float moveSpeed = .2f;

	void Start () {
	}
	
	void Update () {
	}

	void FixedUpdate () {
		rigidbody2D.velocity = new Vector2(transform.localScale.x * moveSpeed, rigidbody2D.velocity.y);
	}

}
