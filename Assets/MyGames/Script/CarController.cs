
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float maxHealth = 100;
    // public float moveSpeed = 15;
    public float currentFuel = 20;
    // public float rotateSpeed = 100;
    public float damageValue = 105;
    public GameObject explotionPrefab;


    private float currentHealth = 0;
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // float horizontal = Input.GetAxis("Horizontal");
        // float vertical = Input.GetAxis("Vertical");

        // transform.Translate(new Vector3(0, 0, vertical * moveSpeed * Time.deltaTime));
        // transform.Rotate(new Vector3(0, horizontal * rotateSpeed * Time.deltaTime, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fuel")
        {
            Destroy(other.gameObject);
            GameManager.Instance.SetFuel(currentFuel);
            
        }
        else if (other.tag == "Damage")
        {
            Destroy(other.gameObject);
            damageHealth(damageValue);
            Instantiate(explotionPrefab, other.transform.position, Quaternion.identity);
        }
    }
    private void damageHealth(float health)
    {
        if (currentHealth > 0)
        {
            currentHealth -= health;
        }
        else
        {
            currentHealth = 0;
            Destroy(gameObject);
        }
    }
}
