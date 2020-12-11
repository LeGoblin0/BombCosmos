using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [Header("폭탄")]
    [Tooltip("폭탄 오브젝트")]
    public GameObject Boom;
    [Tooltip("폭탄 터질때 나오는 잔상")]
    public GameObject BoomDie;
    [Tooltip("폭탄 터지는 파워")]
    public float BoomPower = 10;


    public PlayerFoot plf;

    Rigidbody2D rig;
    Camera cam;
    Vector2 MousePosition;
    private void Start()
    {
        cam = Camera.main;
        rig = GetComponent<Rigidbody2D>();
    }


    public Text TestText;
    public void set()
    {

        Debug.Log(BoomPower = System.Int32.Parse(TestText.text));
    }

    public void End()
    {
        Application.Quit();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && plf.PutGround())//클릭=폭탄 터지고 던지고 
        {
            if (Boom.activeSelf==false)
            {
                MousePosition = Input.mousePosition;
                MousePosition = cam.ScreenToWorldPoint(MousePosition);
           
                Boom.transform.position = transform.position+ (new Vector3(MousePosition.x, MousePosition.y, transform.position.z) - transform.position).normalized * 2;
                Boom.transform.position = new Vector3(Boom.transform.position.x, Boom.transform.position.y, -1);
                Boom.SetActive(true);
                Invoke("BoomOFFF", 1);
            }
        }
    }
    void BoomOFFF()
    {
        Boom.SetActive(false);
        GameObject BoomDies = Instantiate(BoomDie);
        Destroy(BoomDies, 0.4f);
        rig.velocity = (transform.position - Boom.transform.position).normalized * BoomPower;
        BoomDies.transform.position = new Vector3(Boom.transform.position.x, Boom.transform.position.y, -1);
    }

}
