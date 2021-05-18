using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadToOtherSceneRange : MonoBehaviour
{

    public int range;
    // Start is called before the first frame update


    public void setRange(float afstand)
	{
        range = (int)afstand;
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
