using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowByTag : MonoBehaviour
{
    public GameObject targetObj;
    public GameObject targetRotObj;
    public string Tag;
    public string RotTag;
    public float movingSpeed;
    void Start()
    {
        targetObj = GameObject.FindWithTag(Tag);
        targetRotObj = GameObject.FindWithTag(RotTag);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(targetObj.transform.position.x, transform.position.y, targetObj.transform.position.z), movingSpeed * Time.deltaTime);
        if (targetRotObj)
        {
            transform.rotation = targetRotObj.transform.rotation;
        }
    }
}
