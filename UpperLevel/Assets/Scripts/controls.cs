using System.Collections;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class controls : MonoBehaviour
{
    static Animator anim;
    public float speed = 1.0F;
    public float rotspeed = 100.0F;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotspeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if(translation != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("isJumping");
        }
    }
}
