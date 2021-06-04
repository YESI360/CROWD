using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace FSG.MeshAnimator
{
    public class AIControllerGoalsFR : MonoBehaviour
{
    GameObject[] goalLocations;
    NavMeshAgent agent;
        //Animator anim;
    public MeshAnimatorBase anim = null;
    public float speed;

      

    void Start()
    {
        goalLocations = GameObject.FindGameObjectsWithTag("GoalsR");
        agent = this.GetComponent<NavMeshAgent>();       
        agent.SetDestination(goalLocations[Random.Range (0, goalLocations.Length)].transform.position);

            //anim = this.GetComponent<Animator>();
            //anim.SetTrigger("Moving");
        //anim.Play("Walk");
            anim.Play("RunningInPlace");
        }

    private void Update()
    {
        transform.Translate(0, 0, speed);

        if (agent.remainingDistance < 3)
        {
            agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
        }

            if (Input.GetKeyDown("space"))
            {
                anim.Play("RunningInPlace");
                //Debug.Log("SPACE");
                //anim.SetBool("Run", true);
            }
            if (Input.GetKeyDown("z"))
            {
                anim.Play("Breathing Idle 1");
                //Debug.Log("CTRL");
            }




        }


}

}
