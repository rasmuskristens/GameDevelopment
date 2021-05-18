using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class main_menu : MonoBehaviour
{

	public GameObject enemy;
	public loadToOtherScene scene;
	
	public Text textValue;



	public void PlayLevel1()
	{
		
        SceneManager.LoadScene("gameplay");
		
			}


	public void QuitGame()
	{
        Application.Quit();
	}

	public void setValue()
	{
		
	}



    
  

}
