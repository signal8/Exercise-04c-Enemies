using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitZone : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D col)
	{
		gameObject.transform.parent.gameObject.SendMessage("hit");
	}
}
