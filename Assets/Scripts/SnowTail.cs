
using UnityEngine;

public class SnowTail : MonoBehaviour
{
    private GameObject target;
    public GameObject snowPeaces;
    public GameObject snowPeaces2;

    private void Start()
    {
        target = GameObject.FindWithTag("TargetPoint");
       
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {

            Vector3.MoveTowards(transform.position, new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z), 4 * Time.deltaTime);
            Instantiate(snowPeaces, new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z), Quaternion.identity);
            //Instantiate(snowPeaces2, new Vector3(target.transform.position.x, 0, target.transform.position.z), Quaternion.identity);
           Instantiate(snowPeaces2, new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z), Quaternion.Euler(Random.Range(1, 90), Random.Range(1, 90), Random.Range(1, 90)));
            Destroy(gameObject,0.1f);
        }
    }
}
