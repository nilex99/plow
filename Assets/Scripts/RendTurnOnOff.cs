using UnityEngine;

public class RendTurnOnOff : MonoBehaviour
{
    public float timer;
    private MeshRenderer Rend;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        timer = 1;
        Rend = GetComponent<MeshRenderer>();
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (Vector3.Distance(transform.position, Player.transform.position) > 25)
            {
                Rend.enabled = false;
            }
            else
            {
                Rend.enabled = true;
            }
        }
    }
}
