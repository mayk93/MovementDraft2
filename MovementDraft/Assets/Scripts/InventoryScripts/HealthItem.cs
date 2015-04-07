using UnityEngine;
using System.Collections;

public class HealthItem : Item
{
    public override void Use()
    {
        //base.Use();
        Debug.Log("Used health item.");
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().applyHealing(100.0f);
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
