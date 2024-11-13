using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLiftDoors : MonoBehaviour 
{
	public Transform LeftDoor;
	public Transform RigthDoor;
	public bool Open;
	public bool opened;
	public bool closed;
	private Transform CurrLeftD;
	private Transform CurrRigthD;
	public float OpenValue = 0.036f;
	public float CloseValue = 0.030f;
	public float SpeedOpen = 0.01f;
	private void Update()
	{
		if (Open) 
		{
			if (LeftDoor.localPosition.z < OpenValue) 
			{
				closed = false;
				LeftDoor.Translate (Vector3.forward * SpeedOpen);
				RigthDoor.Translate (Vector3.back * SpeedOpen);
			} 
			else 
			{
				opened = true;
			}
		} 
		else 
		{
			if (LeftDoor.localPosition.z > CloseValue) 
			{
				opened = false;
				LeftDoor.Translate (Vector3.forward * -SpeedOpen);
				RigthDoor.Translate (Vector3.back * -SpeedOpen);
			}
			else 
			{
				closed = true;
			}
		}
	}
}
