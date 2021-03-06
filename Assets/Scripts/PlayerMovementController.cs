﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour {

	[SerializeField] private CharacterMovement movement;
	[SerializeField] private string horizontalInputAxis = "Horizontal";
	[SerializeField] private string verticalInputAxis = "Vertical";
	[SerializeField] private string jumpButton = "Jump";

	// Update is called once per frame
	void Update () {
		float xInput = Input.GetAxisRaw (horizontalInputAxis);
		float yInput = Input.GetAxisRaw (verticalInputAxis);
		Vector2 input = new Vector2 (xInput, yInput);

		movement.DirectionalInput = input;

		if (Input.GetButtonDown (jumpButton)) {
			movement.Jump();
		}
	}
}