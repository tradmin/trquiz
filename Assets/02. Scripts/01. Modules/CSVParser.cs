using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVParser : MonoBehaviour {

	StreamReader _reader;

	// Use this for initialization
	void Start () {
		LoadFile ("contents");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadFile(string strFileName)
	{
		TextAsset _txtFile = (TextAsset)Resources.Load(strFileName) as TextAsset;
		string fileFullPath = _txtFile.text;

		string[] strLineList = fileFullPath.Split('\n');

		for (int i = 0; i < strLineList.Length; i++) {
			string[] strContentsList = strLineList[i].Split ('\t');

			Debug.Log (strContentsList [0] + ", " + strContentsList [1] + ", " + strContentsList [2]);
		}
	}
}
