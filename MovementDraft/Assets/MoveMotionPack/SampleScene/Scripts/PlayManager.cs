using UnityEngine;
using System.Collections;

public class PlayManager : MonoBehaviour 
{
	private Animator player; 
	private string[] animClipNameGroup;
	private int currentNumber;

	// Use this for initialization
	void Start () 
    {
		animClipNameGroup = new string[] 
        {
			"Basic_Run_02",
		};

		currentNumber = 0;

        player = GameObject.Find("Player").transform.GetComponentInChildren<Animator>();

        player.speed = 1f;
        player.Play(animClipNameGroup[currentNumber]);
	}
}
