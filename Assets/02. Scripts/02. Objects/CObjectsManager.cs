using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CObjectsManager : MonoBehaviour {
    Object[] m_objCharacter = new Object[12];

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InitObjectsManager()
    {
        string strKey;
        for(int i = 0; i < m_objCharacter.Length; i++)
        {
            strKey = "Characters/character" + i.ToString("000");
            m_objCharacter[i] = (Object)Resources.Load(strKey);
        }
    }

    public Object GetCharacterObject(int nIndex)
    {
        if (nIndex >= m_objCharacter.Length)
            return m_objCharacter[0];

        return m_objCharacter[nIndex];
    }
}
