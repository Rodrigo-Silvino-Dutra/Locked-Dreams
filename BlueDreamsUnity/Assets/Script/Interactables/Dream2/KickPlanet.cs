using UnityEngine;

public class KickPlanet : MonoBehaviour
{
    [SerializeField] private Transform player;
    private float kickForce = 5f;
    private Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            rigidbody.AddForce((gameObject.transform.position - player.position) * kickForce, ForceMode.Force);
        }
    }
}
