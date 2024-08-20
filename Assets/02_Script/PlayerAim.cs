using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    public void Aim()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.x = 10f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.y = transform.position.y;
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.green);
    }

    private void Shoot()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.x = 10f;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.y = transform.position.y;
        Debug.DrawRay(transform.position, mousePos - transform.position, Color.green);

        GameObject _bullet = Instantiate(bullet, transform.position, Quaternion.identity);
        _bullet.transform.LookAt(mousePos - transform.position);
    }
}
