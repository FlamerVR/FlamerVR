using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour 
{
	public KeyCode Key;
	public bool Open;
	public bool Revers;
	public float Speed = 1f;
	public float Distance = 1.2f;

	GameObject player;
	Quaternion CurrQuat;
	float currVelosity;
	float currValue;

	private void Start()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		CurrQuat = transform.rotation;
	}
	void Update()
	{
		if (Vector3.Distance (player.transform.position, transform.position) < Distance) 
		{
			if (Input.GetKeyDown (Key)) 
			{
				if (Open == false) 
				{
					Open = true;
				} 
				else if (Open == true) 
				{
					Open = false;
				}
			}
		}

		if (Open) 
		{
			if (Revers) 
			{
				currValue = Mathf.SmoothDamp (currValue, 90, ref currVelosity, Speed);
				Quaternion x = Quaternion.AngleAxis (currValue, Vector3.up);
				transform.rotation = x * CurrQuat;
			} 
			else 
			{
				currValue = Mathf.SmoothDamp (currValue, -90, ref currVelosity, Speed);
				Quaternion x = Quaternion.AngleAxis (currValue, Vector3.up);
				transform.rotation = x * CurrQuat;
			}
		} 
		else 
		{
			currValue = Mathf.SmoothDamp (currValue, 0, ref currVelosity, Speed);
			Quaternion x = Quaternion.AngleAxis (currValue, Vector3.up);
			transform.rotation = x * CurrQuat;
		}
	}
	void OnGUI()
	{
		if (Vector3.Distance (player.transform.position, transform.position) < Distance ) 
		{
			GUI.Label (new Rect (Screen.width / 2, Screen.height / 2, 200, 40), string.Format ("press {0} Key", Key));
		}
	}
}
