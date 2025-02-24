using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    public Vector3 positionOffset = new Vector3(0f,-2f,0f);
    public float speed = 5f;
    private Vector3 openPosition;

    void Start()
    {
        openPosition = transform.position + positionOffset;
    }

    public void OpenTheDoor()
    {
        transform.position = Vector3.MoveTowards(transform.position, openPosition, speed * Time.deltaTime);
    }

    void Update()
    {
       // OpenTheDoor();
    }
    

}
