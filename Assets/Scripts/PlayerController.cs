using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public Camera cam;
    public Transform TargetPoint;
    public NavMeshAgent agent;

    // Update is called once per frame
    void Update()
    {
        
            

                agent.SetDestination(new Vector3(TargetPoint.position.x, TargetPoint.position.y,TargetPoint.position.z));
            
        
    }
}
