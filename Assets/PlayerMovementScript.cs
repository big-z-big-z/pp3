using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public Vector3 upDirection;
    public Vector3 downDirection;
    public Vector3 leftDirection;
    public Vector3 rightDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().position += upDirection;
        }
    }
}
