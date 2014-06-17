using UnityEngine;
using System.Collections;

public class Reset : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.name == "player") 
			Application.LoadLevel(Application.loadedLevel);
	}
}
