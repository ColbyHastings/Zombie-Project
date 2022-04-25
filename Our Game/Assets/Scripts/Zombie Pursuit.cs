using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombiePursuit : MonoBehaviour
{
    public NavMeshAgent zombie;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zombie.SetDestination(player.position);
    }
}
