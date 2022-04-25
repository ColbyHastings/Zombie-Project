using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pursuit : MonoBehaviour
{
    public NavMeshAgent zombie;
    public Transform player;

    public GameObject m_RightFist;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void activateFist()
    {
        m_RightFist.GetComponent<Collider>().enabled = true;
    }

    public void deactivateFist()
    {
        m_RightFist.GetComponent<Collider>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            zombie.SetDestination(player.position);

            if (zombie.remainingDistance < 0.001f)
            {
                GetComponent<Animator>().SetTrigger("Attack");
            }
        }
        
    }
}
