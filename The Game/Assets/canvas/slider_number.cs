using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider_number : MonoBehaviour
{
	// Start is called before the first frame update
	 Text textNumber;

	private void Start()
	{
		textNumber = GetComponent<Text>();
	}

	public void textUpdate(float value)
	{
		textNumber.text = "" + value;
	}
}
