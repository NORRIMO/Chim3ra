using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoxManager : MonoBehaviour {

	public GameObject textBox;

	public Texture theText;


	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

  	//public PlayerController player;

	// Use this for initialization
	void Start () {

		if (textFile != null) {
			//vom Textfile den Text nehmen und aufteilen wenn ein neuer Absatz beginnt
			textLines = (textFile.text.Split ('\n')); 
		}

	}
}
