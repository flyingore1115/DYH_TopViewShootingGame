using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anemy : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }


}
