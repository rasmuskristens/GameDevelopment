using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FlagPoleScript : MonoBehaviour
{

    Transform startPosition;
    AudioSource pickUpSound;
    float timeValue=0;
    GameObject victoryCanvas;
    bool istrue;



	private void Awake()
	{
        victoryCanvas = GameObject.Find("victoryCanvas");
    }
	// Start is called before the first frame update
	void Start()
    {
		if (victoryCanvas)
		{
            victoryCanvas.SetActive(false);
            
        }
        pickUpSound = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {


		if (timeValue > 0)
		{
            timeValue -= Time.deltaTime;
		}
		else
		{
                        if(istrue)
					{
                        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                        SceneManager.LoadScene("canvas");
                    }
                    
               
            
		}
        
    }


	private void OnTriggerEnter(Collider other)
	{
        
        
        if (other.gameObject.CompareTag("snakeTower"))
        {
            victoryCanvas.SetActive(true);


            timeValue = 2;
            istrue = true;


        }
    }
	private void OnCollisionEnter(Collision collision)
	{
        
		if (collision.gameObject.tag == "Player")
		{

            Transform positionOfCollider = collision.gameObject.transform;

            gameObject.transform.position = new Vector3(positionOfCollider.position.x, positionOfCollider.position.y +6, positionOfCollider.position.z);

            gameObject.transform.SetParent(collision.gameObject.transform);

            pickUpSound.Play();
                
        }

		
        
    }
}
