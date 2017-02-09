using UnityEngine;
using System.Collections;
using System;
public class NewBehaviourScript : MonoBehaviour 
{
		public GameObject hourhand;
		public GameObject minutehand;
		public GameObject secondhand;

	void Update()
		{

		DateTime time = DateTime.Now;

		// set the second hand root.
		int secondss = time.Second;

		// map seonds (0, 60) to a rotation (0. 360)
		float seconds_normalized = secondss / 60f;
		float seconds_degrees = seconds_normalized * 360f;
		float clockwise_seconds = 360f - seconds_degrees;

		// {x, y, z }
		Vector3 secondsrotation = new Vector3 (0f, 0f, clockwise_seconds);
		Quaternion secondsrotationquat = Quaternion.Euler (secondsrotation);
		secondhand.transform.rotation = secondsrotationquat;	

		// temporary variable for minutes
		int minutes = time.Minute;
		Vector3 minuteseuler = new Vector3 (0f, 0f, (1f - (minutes / 60f)) * 360f);
		minutehand.transform.rotation = Quaternion.Euler (minuteseuler);

		//vector3. forward = new vector3(0, 0, 1)

		//set hour hand
		hourhand.	}
}
