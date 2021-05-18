using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int numOfEnemies;
	// Start is called before the first frame update

	private void Awake()
	{
        if (GameObject.Find("ValueFromCanvas"))
        {
            numOfEnemies = GameObject.Find("ValueFromCanvas").GetComponent<loadToOtherScene>().amountOfEnemies;
        }
	}

	void Start()
    {
        for (int i = 0; i < numOfEnemies; i++)
        {
            GameObject fjende = (GameObject)Instantiate(enemy);

            float randomNumberx = Random.Range(-1050f, 860f);
            float randomNumberz = Random.Range(-715f, 715f);
            fjende.transform.position = new Vector3(randomNumberx, 17, randomNumberz);//også til punkter

            

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
