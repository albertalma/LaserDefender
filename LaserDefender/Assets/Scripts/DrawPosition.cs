﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPosition : MonoBehaviour {

	public float radius = 1.0f;

	void OnDrawGizmos() {
		Gizmos.DrawWireSphere (transform.position, radius);
	}
}
