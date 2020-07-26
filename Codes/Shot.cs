using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("box"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject, 0.25f);
            PlayerShot.pontos++;
        }

        if (collision.gameObject.tag.Equals("cily"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject, 0.25f);
            PlayerShot.pontos--;
        }
    }
}
