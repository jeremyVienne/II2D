using UnityEngine;
using System.Collections;
using UnityScript;

public class ThrowObject : MonoBehaviour
{
    public Rigidbody bullet  ;
    public readonly  Rigidbody clone;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {


            //clone = Instantiate(bullet , new Vector3(0,0,0), transform.rotation) as Rigidbody;
            bullet.MovePosition(new Vector3(0, 0, 0));
            bullet.velocity = transform.TransformDirection(Vector3.forward * 20);


        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.collider.name);
        GetComponent<ScoreSystem>().SetScore(5);
    }
}