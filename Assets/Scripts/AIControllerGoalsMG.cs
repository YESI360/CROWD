using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace FSG.MeshAnimator
{
    public class AIControllerGoalsMG : MonoBehaviour
    {
        GameObject[] goalLocations;
        NavMeshAgent agent;
        //Animator anim;
        public MeshAnimatorBase anim = null;
        public float speed;

        void Start()
        {
            goalLocations = GameObject.FindGameObjectsWithTag("GoalsG");
            agent = this.GetComponent<NavMeshAgent>();
            agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);

            //anim = this.GetComponent<Animator>();
            //anim.SetTrigger("Moving");//empiezan en moving ON
            anim.Play("RunningInPlace");
        }

        private void Update()
        {
            transform.Translate(0, 0, speed);

            if (agent.remainingDistance < 3)
            {
                agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
            }

            if (Input.GetButtonDown("Jump"))
            {
                anim.Play("RunningInPlace");
                Debug.Log("jump");
                //anim.SetBool("Run", true);
            }
            ////////////////////
            if (Input.GetButtonDown("Fire1"))
            {
                anim.Play("Breathing Idle 1");
                Debug.Log("fire1");
                //anim.SetBool("Run", false);

            }




        }


    }
}