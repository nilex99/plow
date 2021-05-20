using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject Player;
    public float RotationSpeed;
    private Quaternion targetRotation;
    public float rightTimer;
    private float leftTimer;

    void Start()
    {
        targetRotation = new Quaternion(0, transform.rotation.y, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Player)
        {
            transform.position = Player.transform.position;
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * RotationSpeed);
            rightTimer -= Time.deltaTime;
            leftTimer -= Time.deltaTime;
            if (rightTimer <= 0 )
            {
                rightTimer = 0;
            }    
            if (leftTimer <= 0)
            {    
                leftTimer = 0;
            }
        }
    }

    public void RotationRight()
    {
        if (rightTimer == 0)
        {
            targetRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y + 90, transform.eulerAngles.z);
            rightTimer += 1;
        }
      
    }
    public void RotationLeft()
    {
        if (leftTimer == 0)
        {
            targetRotation = Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y - 90, transform.eulerAngles.z);
            leftTimer += 1;
        }
    }
}
