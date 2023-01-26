using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    // Start is called before the first frame update
    public float minspeed;
    public float maxspeed;
    float speed;
    public int damage;
    Player playerscript;

    public GameObject explosion;

    void Start()
    {
        speed=Random.Range(minspeed,maxspeed);
        playerscript=GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down*speed*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D hitObject)
    {
        if(hitObject.tag=="Player")
        {
            playerscript.TakeDamage(damage);
            Instantiate(explosion,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
        if(hitObject.tag=="Ground")
        {
            Instantiate(explosion,transform.position,Quaternion.identity);
            Destroy(gameObject);    
        }
    }
}
