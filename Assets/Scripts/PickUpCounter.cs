using UnityEngine;
using System.Collections;

public class PickUpCounter : MonoBehaviour {
	
	public GUIText CountText;
	public GUIText winText;
	private int count;
	private int maxCollectables;
	
	void Start()
	{
		SetCountText(); 
		count = 0;	
		winText.text = "";
		
		GameObject[] collectables = GameObject.FindGameObjectsWithTag(Tags.collectable);
		maxCollectables = collectables.Length;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.tag == Tags.collectable)
		{
			other.gameObject.SetActive(false);	
			count++;
			Debug.Log(count);
			SetCountText();
		}
	}
	
	void SetCountText()
	{
		CountText.text= "Count: " + count;
		if(count >= maxCollectables)
		{
			winText.text = "You Win !";
		}
	}
}
