using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TextImporter : MonoBehaviour {



	public TextAsset textFile;
	public string[] textLines;

	// Use this for initialization
	void Start () {

		if (textFile != null) {
			//vom Textfile den Text nehmen und aufteilen wenn ein neuer Absatz beginnt
			textLines = (textFile.text.Split ('\n')); 
		}
		
	}
}