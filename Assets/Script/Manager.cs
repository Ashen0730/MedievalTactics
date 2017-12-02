﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

	[SerializeField]
	Map map;
	[SerializeField]
	Unit KingPrefab;
	[SerializeField]
	Unit EnemyKingPrefab;
	[SerializeField]
	Unit SwordmanPrefab;
	[SerializeField]
	Unit EnemySwordmanPrefab;
	[SerializeField]
	Unit ArcherPrefab;
	[SerializeField]
	Unit EnemyArcherPrefab;
	[SerializeField]
	Obstacles RockPrefab;
	[SerializeField]
	Obstacles TreePrefab;

	private Button button; //button instance

	// Use this for initialization
	IEnumerator Start () {
		map.GenerateMap();
		yield return null;

		KingPrefab.gameObject.SetActive(false);
		EnemyKingPrefab.gameObject.SetActive(false);
		ArcherPrefab.gameObject.SetActive (false);
		EnemyArcherPrefab.gameObject.SetActive (false);
		SwordmanPrefab.gameObject.SetActive (false);
		EnemySwordmanPrefab.gameObject.SetActive (false);


		map.PutUnit (0, 4, KingPrefab, false);
		map.PutUnit (0, 6, ArcherPrefab, false);
		map.PutUnit (1, 5, SwordmanPrefab, false);
		map.PutUnit (1,7, SwordmanPrefab, false);

		map.PutUnit (1, 4, EnemyKingPrefab, true);
		map.PutUnit (19, 6, EnemyArcherPrefab, true);
		map.PutUnit (18, 5, EnemySwordmanPrefab, true);
		map.PutUnit (18, 6, EnemySwordmanPrefab, true);

		//Sets the enemy sides 
		for (int i = 0; i < map.unitsEnemy.Count; i++) {
			button = map.unitsEnemy[i].GetComponent<Button> ();
			button.enabled = !button.enabled;
		}
	}
		
}
