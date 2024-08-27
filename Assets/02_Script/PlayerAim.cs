using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{ 
    public Vector3 screenPos;
    public Vector3 worldPos;
    public LayerMask layersOnHit;
    public Transform aimPoint;
    public GameObject prefab_bullet;

    private void Update()
    {
        Aim();
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    private void Aim()
    {
        screenPos = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(screenPos);

        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100, layersOnHit))
        {
            worldPos = hitInfo.point;
            worldPos.y = transform.position.y;
        }
        aimPoint.transform.position = worldPos;
    }
    private void Shoot()
    {
        GameObject _obj = Instantiate(prefab_bullet, transform.position, Quaternion.identity);
        _obj.transform.LookAt(worldPos);
    }
}
