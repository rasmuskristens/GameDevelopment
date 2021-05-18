using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorScrip : MonoBehaviour
{

    private Animator animator;
    private float oldValue=0;
   
    // Start is called before the first frame update
    void Start()
    {
        oldValue = gameObject.transform.position.x;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.J))
		{
            animator.SetBool("isRunning",true);
		}
		else
		{
            animator.SetBool("isRunning", false);
        }
        
    }
}
