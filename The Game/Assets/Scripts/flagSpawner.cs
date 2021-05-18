using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flagSpawner : MonoBehaviour
{

    public GameObject flagpole;
    // Start is called before the first frame update
    void Start()
    {
        GameObject flagstang = (GameObject)Instantiate(flagpole);

        int randomValue = Mathf.FloorToInt((Random.value) * 4);
        //first quadrant=x=500 z=-300
        //max=x=860 z=-715

        //second quadrant x=500 z = 300
        //max x=860 z=715

        //third quadrant x=-690 z = 300
        //max x=-1050 z=715

        //fourth quadrant x=-690 z = -300
        //max x=-1050 z=-715

        float randomNumberx=0;
        float randomNumberz=0;


        switch (randomValue)
		{
			case 0:
                 randomNumberx = Random.Range(500f, 860);
                 randomNumberz = Random.Range(-300f, -715f);
                break;

            case 1:
                 randomNumberx = Random.Range(500f, 860f);
                 randomNumberz = Random.Range(300f, 715f);
                break;

            case 2:
                 randomNumberx = Random.Range(-690f, -1050f);
                 randomNumberz = Random.Range(300f, 715f);
                break;

            case 3:
                 randomNumberx = Random.Range(-690f, -1050f);
                 randomNumberz = Random.Range(-300f, -715f);
                break;
        }
        

       

        flagstang.transform.position = new Vector3(randomNumberx, 17, randomNumberz);//også til punkter
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
