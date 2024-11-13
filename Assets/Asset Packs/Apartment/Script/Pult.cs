using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pult : MonoBehaviour 
{
	public enum Corpus
	{
		A,
		B,
		C,
	}
	public Corpus corpus;
	public int Level;
	public KeyCode Key;
	GameObject player;
	GameObject lift;

	private void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		lift = GameObject.Find (string.Format("Lift 1-{0}",corpus));
	}

	private void Update()
	{
		
	}
	void OnGUI()
	{
		if (Vector3.Distance (player.transform.position, transform.position) < 1.3f && lift.GetComponent<ForLift> ().Stay == true) 
		{
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 200, 40), string.Format("press {0} Key for call Lift",Key));
			if (Input.GetKey (Key)) 
			{
				switch(Level)
				{
				case 1:if(lift.GetComponent<ForLift> ().Stay == true)lift.GetComponent<ForLift> ().Level_1 = true;break;
				case 2:if(lift.GetComponent<ForLift> ().Stay== true)lift.GetComponent<ForLift> ().Level_2 = true;break;
				case 3:if(lift.GetComponent<ForLift> ().Stay== true)lift.GetComponent<ForLift> ().Level_3 = true;break;
				case 4:if(lift.GetComponent<ForLift> ().Stay== true)lift.GetComponent<ForLift> ().Level_4 = true;break;
				case 5:if(lift.GetComponent<ForLift> ().Stay== true)lift.GetComponent<ForLift> ().Level_5 = true;break;
				case 6:if(lift.GetComponent<ForLift> ().Stay== true)lift.GetComponent<ForLift> ().Level_6 = true;break;
				case 7:if(lift.GetComponent<ForLift> ().Stay== true)lift.GetComponent<ForLift> ().Level_7 = true;break;
				case 8:if(lift.GetComponent<ForLift> ().Stay== true)lift.GetComponent<ForLift> ().Level_8 = true;break;
				case 9:if(lift.GetComponent<ForLift> ().Stay== true)lift.GetComponent<ForLift> ().Level_9 = true;break;
				}
			}
		}
	}
}
