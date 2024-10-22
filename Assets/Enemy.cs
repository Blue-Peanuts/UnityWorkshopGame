using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public int health = 3;
    void FixedUpdate()
    {
        Player player = FindObjectOfType<Player>();
        GameObject playerGameObject = player.gameObject;
        Vector3 playerPosition = playerGameObject.transform.position;

        Vector3 vectorToPlayer = playerPosition - transform.position;

        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = vectorToPlayer.normalized * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        if (player != null)
        {
            player.Kill();
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
