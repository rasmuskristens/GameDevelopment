using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadToOtherScene : MonoBehaviour


{
    // Start is called before the first frame update

    public int amountOfEnemies;
    public void setamountOfEnemies(float enemies)
	{
        amountOfEnemies = (int)enemies;
	}
    void Start()
    {
        DontDestroyOnLoad(this);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
