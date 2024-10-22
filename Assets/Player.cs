using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();

        Vector3 moveVelocity = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.D))
        {
            moveVelocity += new Vector3(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveVelocity += new Vector3(-speed, 0, 0);
        }

        rb2d.velocity = moveVelocity;
    }

    public void Kill()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
