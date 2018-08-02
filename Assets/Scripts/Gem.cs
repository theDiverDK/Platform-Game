using UnityEngine;

public class Gem : MonoBehaviour
{
    public AudioSource hitGem;

    float maxUpAndDown = 0.4f;
    float speed = 200;
    float angle = 0;
    float toDegrees = Mathf.PI / 180;
    float startY;

    // Use this for initialization
    void Start()
    {
        startY = transform.position.y;
        angle = Random.Range(0, 360);
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime;

        if (angle > 360)
        {
            angle -= 360;
        }

        transform.position = new Vector3(transform.position.x,
                                     startY + maxUpAndDown * Mathf.Sin(angle * toDegrees),
                                     transform.position.z);
    }

    public void OnTriggerEnter(Collider other)
    {
        print("collide");
        if (other.gameObject.tag == "Player")
        {
            hitGem.Play();
            Destroy(gameObject);
        }
    }
}
