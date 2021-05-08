using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace FSG.MeshAnimator
{
    public class AIControllerGoalsMB : MonoBehaviour
    {
        GameObject[] goalLocations;
        NavMeshAgent agent;
        //Animator anim;
        public MeshAnimatorBase anim = null;
        public float speed;

        void Start()
        {
            goalLocations = GameObject.FindGameObjectsWithTag("GoalsB");
            agent = this.GetComponent<NavMeshAgent>();
            agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);

            //anim = this.GetComponent<Animator>();

            /////anim.SetFloat("Offset", Random.Range (0,1));

            //anim.SetTrigger("Moving");
            anim.Play("Walk");
            ///////float sm = Random.Range(1f, 2f); 
            //////anim.SetFloat("Speed", sm);
            /////agent.speed *= sm;

        }

        private void Update()
        {
            transform.Translate(0, 0, speed);

            if (agent.remainingDistance < 3)
            {
                agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
            }

            //if (Input.GetButtonDown("Jump"))
            //{
            //    anim.SetBool("Run", true);
            //}
            //if (Input.GetButtonDown("Fire1"))
            //{
            //    anim.SetBool("Run", false);
            //}
        }



    }
}
