using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	public Rigidbody rb;

	public Transform target;
	public float speed;
	public float amplitude;
	public float frequency;

	private float startTime;
	private Vector3 direction;
	private Vector3 orthogonal;

	void Start() {
		startTime = Time.time;
		direction = (target.position - transform.position).normalized;
		orthogonal = new Vector3 (-direction.z, 0, direction.x);
	}

	void FixedUpdate () {
		float t = Time.time - startTime;
		rb.velocity = direction * speed + orthogonal * amplitude * Mathf.Sin (frequency * t);
	}
}
