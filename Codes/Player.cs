using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator anim;
    public GameObject posarma;
    public LineRenderer laserLineRenderer;
    GameObject _go;
    public static int pontos = 0;
    void Start(){
        anim = GetComponent<Animator>();
        _go = Resources.Load("Sphere") as GameObject;
    }
    void Update()
    {
        RaycastHit hit;             
        if (Input.GetMouseButtonDown(0)){
            AnimFire();
            if (Physics.Raycast(posarma.transform.position,
                           posarma.transform.forward,
                           out hit, 100))
            {
                Debug.DrawRay(posarma.transform.position,
                               posarma.transform.forward * 100, Color.red);

                Instantiate(_go, hit.point, Quaternion.identity);

                laserLineRenderer.enabled = true;

                laserLineRenderer.SetPosition(0, posarma.transform.position);
                laserLineRenderer.SetPosition(1, hit.point);
            }
            else{   laserLineRenderer.enabled = false; }
            Invoke("AnimIdle", 0.30f);
        }

        if (Input.GetMouseButtonDown(1)){
            AnimLoad();
            Invoke("AnimIdle", 0.30f);
        }
    }
    void AnimIdle(){
        anim.SetBool("idle", true);
        anim.SetBool("fire", false);    anim.SetBool("load", false);
        laserLineRenderer.enabled = false;
    }
    void AnimFire(){        
        anim.SetBool("fire", true);
        anim.SetBool("load", false); anim.SetBool("idle", false);
    }
    void AnimLoad(){
        anim.SetBool("load", true);
        anim.SetBool("fire", false); anim.SetBool("idle", false);
    }
}
