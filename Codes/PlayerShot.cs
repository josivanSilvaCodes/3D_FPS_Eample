using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    public static int pontos;
    public GameObject posarma;
    public LineRenderer laserline;
    GameObject _go;

    // Start is called before the first frame update
    void Start()
    {
        _go = Resources.Load("Sphere") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(posarma.transform.position,
                posarma.transform.forward, out hit, 100))
            {
                Debug.DrawRay(posarma.transform.position,
                posarma.transform.forward * 100, Color.red);

                Instantiate(_go, hit.point, Quaternion.identity);

                laserline.enabled = true;
                laserline.SetPosition(0, posarma.transform.position);
                laserline.SetPosition(1, hit.point);
            }           
        }
        else
        {
            laserline.enabled = false;
        }
    }
}
