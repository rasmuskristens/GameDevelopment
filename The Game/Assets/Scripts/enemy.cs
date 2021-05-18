using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class enemy : MonoBehaviour
{

	float timeValue;
	


	public NavMeshAgent agent;
	private bool istrue;

	

    public bool playerInSightRange;

    public float sightRange;
    public Transform player;
	public Vector3 walkPoint;
	bool walkPointSet;
	public float walkPointRange;
	public LayerMask whatIsPlayer;
	
	public AudioSource run;
	//public AudioSource chase;
	GameObject canvas;

	public Animator animator;

	private bool runningOrStanding;
	

	


	private void Awake()
	{

		if (GameObject.Find("ValueFromCanvas"))
		{
			sightRange = GameObject.Find("ValueFromCanvas").GetComponent<loadToOtherSceneRange>().range;
		}
		player = GameObject.Find("Player").transform;
		agent = GetComponent<NavMeshAgent>();
		canvas = GameObject.Find("lostCanvas");
		

	}
	// Start is called before the first frame update
	void Start()
	{

		animator = GetComponent<Animator>();
		StartCoroutine("waitASec");

		if (canvas)
		{
			
			canvas.SetActive(false);

		}
		run = gameObject.GetComponent<AudioSource>();
		
		//chase = GameObject.FindGameObjectWithTag("audioChase").GetComponents<AudioSource>()[1];


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
			if (istrue)
			{
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
				SceneManager.LoadScene("canvas");
			}



		}

		/*Vector3 toPlayer = player.transform.position - transform.position;
		if (Vector3.Distance(player.transform.position, transform.position) < 3)
		{
			Vector3 targetPosition = toPlayer.normalized * -3f;
			agent.destination = targetPosition;

		}*/



	}

	IEnumerator waitASec()
	{

		while (true)
		{
			yield return new WaitForSeconds(0.01f);
			if (!playerInSightRange)
			{
				animator.SetBool("isRunning", false);
				yield return new WaitForSeconds(2);
			}
			
			float distance = Vector3.Distance(player.position, transform.position);



			if (distance < sightRange)
			{
				playerInSightRange = true;
			}
			else
			{
				playerInSightRange = false;
			}
			




			if (!playerInSightRange)
			{
				Patroling();
				run.Play();
			}
			if (playerInSightRange)
			{
				ChasePlayer();
				//chase.Play();
			}
		}
		
	}

	private void Patroling()
	{
		
		if (!walkPointSet)
		{
			createnewWalktpoint();
		
		}
		if (walkPointSet)
		{
			animator.SetBool("isRunning", true);
			agent.SetDestination(walkPoint);
		}

		Vector3 distanceToWalkPoint = transform.position - walkPoint;

		if (distanceToWalkPoint.magnitude < 1f)
		{
			walkPointSet = false;
			animator.SetBool("isRunning", false);
		}
	}

	private void createnewWalktpoint()
	{
		float randomZ = Random.Range(-walkPointRange, walkPointRange);
		float randomX = Random.Range(-walkPointRange, walkPointRange);

		walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

		

		walkPointSet = true;
	}

	private void ChasePlayer()
	{
		animator.SetBool("isRunning", true);
		agent.SetDestination(player.position);


	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "Player")
		{
			
			canvas.SetActive(true);
			istrue = true;

		}
	}




}
