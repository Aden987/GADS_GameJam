using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{

    public float loofRadius = 10f;
    public Transform target;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance <= loofRadius)
        {
            agent.SetDestination(target.position);
            if (distance <= agent.stoppingDistance)
            {
                FaceTarget();
            }
            /*if (gameObject.tag == "range")
            {
                range.Fire();
            }*/
        }
    }

    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized; //direction of target
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, loofRadius);
    }
}
