using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLift : MonoBehaviour 
{
	public enum Corpus
	{
		A,
		B,
		C,
	}
	public Corpus corpus;
	public bool Stay;
	private float Speed = 0.01f;
	public bool Level_1 = false;
	public bool Level_2 = false;
	public bool Level_3 = false;
	public bool Level_4 = false;
	public bool Level_5 = false;
	public bool Level_6 = false;
	public bool Level_7 = false;
	public bool Level_8 = false;
	public bool Level_9 = false;

	public float TimeCloseDoor = 5;
	private float val;

	GameObject player;

	GameObject DoorLevel1;
	GameObject DoorLevel2;
	GameObject DoorLevel3;
	GameObject DoorLevel4;
	GameObject DoorLevel5;
	GameObject DoorLevel6;
	GameObject DoorLevel7;
	GameObject DoorLevel8;
	GameObject DoorLevel9;

	private void Start()
	{		
		val = TimeCloseDoor;
		if (GameObject.Find (string.Format("Room 4-1-{0}",corpus))!=null) 
		{
			DoorLevel1 = GameObject.Find (string.Format("Room 4-1-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-1-{0} . Переименуйте Room 4 в Room 4-1-{0}",corpus));
		}

		if (GameObject.Find (string.Format("Room 4-2-{0}",corpus))!=null) 
		{
			DoorLevel2 = GameObject.Find (string.Format("Room 4-2-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-2-{0} . Переименуйте Room 4 в Room 4-2-{0}",corpus));
		}

		if (GameObject.Find (string.Format("Room 4-3-{0}",corpus))!=null) 
		{
			DoorLevel3 = GameObject.Find (string.Format("Room 4-3-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-3-{0} . Переименуйте Room 4 в Room 4-3-{0}",corpus));
		}

		if (GameObject.Find (string.Format("Room 4-4-{0}",corpus))!=null) 
		{
			DoorLevel4 = GameObject.Find (string.Format("Room 4-4-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-4-{0} . Переименуйте Room 4 в Room 4-4-{0}",corpus));
		}

		if (GameObject.Find (string.Format("Room 4-5-{0}",corpus))!=null) 
		{
			DoorLevel5 = GameObject.Find (string.Format("Room 4-5-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-5-{0} . Переименуйте Room 4 в Room 4-5-{0}",corpus));
		}

		if (GameObject.Find (string.Format("Room 4-6-{0}",corpus))!=null) 
		{
			DoorLevel6 = GameObject.Find (string.Format("Room 4-6-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-6-{0} . Переименуйте Room 4 в Room 4-6-{0}",corpus));
		}

		if (GameObject.Find (string.Format("Room 4-7-{0}",corpus))!=null) 
		{
			DoorLevel7 = GameObject.Find (string.Format("Room 4-7-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-7-{0} . Переименуйте Room 4 в Room 4-7-{0}",corpus));
		}

		if (GameObject.Find (string.Format("Room 4-8-{0}",corpus))!=null) 
		{
			DoorLevel8 = GameObject.Find (string.Format("Room 4-8-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-8-{0} . Переименуйте Room 4 в Room 4-8-{0}",corpus));
		}

		if (GameObject.Find (string.Format("Room 4-9-{0}",corpus))!=null) 
		{
			DoorLevel9 = GameObject.Find (string.Format("Room 4-9-{0}",corpus));
		}
		else
		{
			Debug.LogError (string.Format("Ненайден объект - Room 4-9-{0} . Переименуйте Room 4 в Room 4-9-{0}",corpus));
		}
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	private void Update()
	{
		Timer();
		if (Level_1) 
		{
			Stay = false;
			if (transform.localPosition.y > 0)
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel1.GetComponent<ForLiftDoors> ().Open = true;
				Level_1 = false;
			}
		} 
		else if (Level_2) 
		{
			Stay = false;
			if (transform.localPosition.y > 2.6f)
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed)
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else if (transform.localPosition.y < 2.59f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * Speed);
				}
			} 
			else 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel2.GetComponent<ForLiftDoors> ().Open = true;
				Level_2 = false;
			}
		} 
		else if (Level_3) 
		{
			Stay = false;
			if (transform.localPosition.y > 5.2f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed)
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else if (transform.localPosition.y < 5.19f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * Speed);
				}
			}
			else 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel3.GetComponent<ForLiftDoors> ().Open = true;
				Level_3 = false;
			}
		} 
		else if (Level_4) 
		{
			Stay = false;
			if (transform.localPosition.y > 7.8f)
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else if (transform.localPosition.y < 7.79f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * Speed);
				}
			}
			else 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel4.GetComponent<ForLiftDoors> ().Open = true;
				Level_4 = false;
			}
		} 
		else if (Level_5) 
		{
			Stay = false;
			if (transform.localPosition.y > 10.4f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else if (transform.localPosition.y < 10.39f)
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * Speed);
				}
			} 
			else 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel5.GetComponent<ForLiftDoors> ().Open = true;
				Level_5 = false;
			}
		} 
		else if (Level_6) 
		{
			Stay = false;
			if (transform.localPosition.y > 13f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else if (transform.localPosition.y < 12.9f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * Speed);
				}
			} 
			else
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel6.GetComponent<ForLiftDoors> ().Open = true;
				Level_6 = false;
			}
		} 
		else if (Level_7) 
		{
			Stay = false;
			if (transform.localPosition.y > 15.6f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else if (transform.localPosition.y < 15.59f)
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * Speed);
				}
			} 
			else 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel7.GetComponent<ForLiftDoors> ().Open = true;
				Level_7 = false;
			}
		} 
		else if (Level_8) 
		{
			Stay = false;
			if (transform.localPosition.y > 18.2f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else if (transform.localPosition.y < 18.19f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * Speed);
				}
			} 
			else 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel8.GetComponent<ForLiftDoors> ().Open = true;
				Level_8 = false;
			}
		} 
		else if (Level_9) 
		{
			Stay = false;
			if (transform.localPosition.y > 20.8f) 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * -Speed);
				}
			} 
			else if (transform.localPosition.y < 20.79f)
			{
				gameObject.GetComponent<ForLiftDoors>().Open = false;
				CloseDoors ();
				if (gameObject.GetComponent<ForLiftDoors>().closed) 
				{
					transform.Translate (Vector3.up * Speed);
				}
			}
			else 
			{
				gameObject.GetComponent<ForLiftDoors>().Open = true;
				DoorLevel9.GetComponent<ForLiftDoors> ().Open = true;
				Level_9 = false;
			}
		} 
		else 
		{
			Stay = true;
		}
	}
	private void CloseDoors()
	{
		
			DoorLevel1.GetComponent<ForLiftDoors> ().Open = false;

			DoorLevel2.GetComponent<ForLiftDoors> ().Open = false;

			DoorLevel3.GetComponent<ForLiftDoors> ().Open = false;

			DoorLevel4.GetComponent<ForLiftDoors> ().Open = false;

			DoorLevel5.GetComponent<ForLiftDoors> ().Open = false;

			DoorLevel6.GetComponent<ForLiftDoors> ().Open = false;

			DoorLevel7.GetComponent<ForLiftDoors> ().Open = false;

			DoorLevel8.GetComponent<ForLiftDoors> ().Open = false;

			DoorLevel9.GetComponent<ForLiftDoors> ().Open = false;

	}
	private void Timer()
	{
		if (gameObject.GetComponent<ForLiftDoors> ().opened) 
		{
			if (val > 0) 
			{
				val -= 0.02f;
			} 
			else 
			{
				gameObject.GetComponent<ForLiftDoors> ().Open = false;
				CloseDoors ();
			}
		} 
		else if (gameObject.GetComponent<ForLiftDoors> ().closed) 
		{
			val = TimeCloseDoor;
		}
	}
	private void ChooseLevel()
	{
		if (Vector3.Distance (player.transform.position, transform.position) < 0.5f && gameObject.GetComponent<ForLift> ().Stay == true) 
		{
			GUI.Label (new Rect (Screen.width/2, Screen.height/2, 100, 40),"press 1-9 key");

			if(Input.GetKey(KeyCode.Alpha1))
			{
				gameObject.GetComponent<ForLift> ().Level_1 = true;
			}
			if(Input.GetKey(KeyCode.Alpha2))
			{
				gameObject.GetComponent<ForLift> ().Level_2 = true;
			}
			if(Input.GetKey(KeyCode.Alpha3))
			{
				gameObject.GetComponent<ForLift> ().Level_3 = true;
			}
			if(Input.GetKey(KeyCode.Alpha4))
			{
				gameObject.GetComponent<ForLift> ().Level_4 = true;
			}
			if(Input.GetKey(KeyCode.Alpha5))
			{
				gameObject.GetComponent<ForLift> ().Level_5 = true;
			}
			if(Input.GetKey(KeyCode.Alpha6))
			{
				gameObject.GetComponent<ForLift> ().Level_6 = true;
			}
			if(Input.GetKey(KeyCode.Alpha7))
			{
				gameObject.GetComponent<ForLift> ().Level_7 = true;
			}
			if(Input.GetKey(KeyCode.Alpha8))
			{
				gameObject.GetComponent<ForLift> ().Level_8 = true;
			}
			if(Input.GetKey(KeyCode.Alpha9))
			{
				gameObject.GetComponent<ForLift> ().Level_9 = true;
			}
		}
	}
	void OnGUI()
	{
		ChooseLevel ();
	}
}
