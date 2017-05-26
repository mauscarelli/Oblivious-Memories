using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	//pegando as variaveis
	public float speed;
	private bool isWalking;
	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		speed = 100;
	}

	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement() {
		isWalking = false;
		float horizontal = Input.GetAxisRaw("Horizontal");
		float vertical = Input.GetAxisRaw("Vertical");

		if (horizontal == 0 && vertical == 0) {
			anim.SetBool ("Walk", isWalking);
			return;
		}

		if (vertical != 0) {
			transform.Translate(0, vertical * Time.deltaTime * speed, 0);
			isWalking = true;
		}

		if (horizontal != 0) {
			transform.Translate(horizontal * Time.deltaTime * speed, 0, 0);
			isWalking = true;
		}

		anim.SetBool  ("Walk", isWalking);
		anim.SetFloat ("PositionY", vertical);
		anim.SetFloat ("PositionX", horizontal);
		anim.SetFloat ("StopX", horizontal);
		anim.SetFloat ("StopY", vertical);
	}
}
