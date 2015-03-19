using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour 
{
    private Animator player;
    private string[] animClipNameGroup;
    private int currentNumber;

	// Use this for initialization
	void Start () 
    {
        animClipNameGroup = new string[] 
        {
			//"Basic_Walk_02",
            "Etc_Walk_Zombi_01"
		};

        currentNumber = 0;

        player = GameObject.Find("Zombie").transform.GetComponentInChildren<Animator>(); /* Refactor: Find via tag */

        player.speed = 1f;
        player.Play(animClipNameGroup[currentNumber]);
	}
	
	// Update is called once per frame
	void Update () {}
}
