using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCharacterManager : MonoBehaviour {
    public Animator anim;
	// Use this for initialization
	void Start () {
        /*
        //Animator anim = this.GetComponent<Animator>();
        int test = Animator.StringToHash("Idle");
        Debug.Log(test);
        //this.GetComponent<Animator>().SetTrigger()

        this.GetComponent<Animator>().Play(test);

        Debug.Log(anim.GetLayerName(0));

        anim.Play(test);
        */
        anim.SetFloat("Speed_f", 0.1f);
        anim.SetInteger("Animation_int", 0);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
