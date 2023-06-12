using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public Transform Football;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Enemy.SetDestination(Football.position);  
    }
}
