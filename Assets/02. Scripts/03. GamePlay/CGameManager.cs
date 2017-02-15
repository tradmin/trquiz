using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        InitGameManager();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InitGameManager()
    {
        GameObject.Find("ObjectsManager").GetComponent<CObjectsManager>().InitObjectsManager();

        for(int i = 0; i < 6; i++)
        {
            int nRandomValue = Random.Range(0, 12);
            Object objCharacter = GameObject.Find("ObjectsManager").GetComponent<CObjectsManager>().GetCharacterObject(nRandomValue);

            GameObject goPlayer = (GameObject)Instantiate(objCharacter, new Vector3(-7.5f + (3.0f * i), 0f, 1.3f), Quaternion.Euler(new Vector3(0, 180f, 0)));
        }
    }
}
