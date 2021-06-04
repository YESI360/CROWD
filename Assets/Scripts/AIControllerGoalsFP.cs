using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace FSG.MeshAnimator
{
    public class AIControllerGoalsFP : MonoBehaviour
    {
        GameObject[] goalLocations;
        NavMeshAgent agent;
        //Animator anim;
        public MeshAnimatorBase anim = null;
        public float speed;

        void Start()
        {
            goalLocations = GameObject.FindGameObjectsWithTag("GoalsP");
            agent = this.GetComponent<NavMeshAgent>();
            agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);

            //anim = this.GetComponent<Animator>();
            // anim.Play("Walk");
            anim.Play("RunningInPlace");
            //anim.Play("Walk");
            //anim.SetTrigger("Moving");

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
                //anim.Play("Run");
                //anim.SetBool("Run", true);
            }
            if (Input.GetKeyDown("z"))
            {
                anim.Play("Breathing Idle 1");
                //anim.Play("Walk");
                //anim.SetBool("Run", false);
            }




        }


    }
}

