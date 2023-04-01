using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rat : MonoBehaviour
{
    public GameObject splat;
    private Movement player;
    public float speed = 1;
    public float alert_distance = 5;
    public float despawn_distance = 5;
    public float kill_bonus = .1f;
    public float score_bonus = 300;
    public float direction_change_time = 2;
    private float direction_change_timer = 3;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponentInParent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (direction_change_timer > direction_change_time)
        {
            transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y, Random.Range(1, 359)));
            direction_change_timer = 0;
        }
        else
        {
            direction_change_timer += Time.deltaTime;
        }

        if (Vector2.Distance(player.gameObject.transform.position, transform.position) < alert_distance)
        {
            //run
            transform.position += transform.TransformDirection(Vector2.up * speed * Time.deltaTime);
        }
        else if (Vector2.Distance(player.gameObject.transform.position, transform.position) > despawn_distance)
        {
            player.gameObject.GetComponent<Rat_Spawner>().rats.Remove(gameObject);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Attack"))
        {
            if (player.stamina + kill_bonus >= 1)
            {
                player.stamina = 1;
            }
            else
            {
                player.stamina += kill_bonus;
            }
            player.gameObject.GetComponent<Rat_Spawner>().rats.Remove(gameObject);
            Instantiate(splat, transform.position, transform.rotation).SetActive(true);
            collision.gameObject.transform.parent.GetComponentInParent<AudioSource>().Play();
            player.gameObject.GetComponentInParent<Movement>().score += score_bonus;
            Destroy(gameObject);
        }
    }
}
