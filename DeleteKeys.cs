using UnityEngine;
using System.Collections;

public class DeleteKeys : MonoBehaviour
{
	void Start ()
	{
		PlayerPrefs.DeleteAll ();
	}
}
