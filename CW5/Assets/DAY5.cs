using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.scenemanagment;

public class DAY5 : MonoBehaviour
{
    public transform Maxpos;
    public transform Minpos;
    AudioSource src;
    public float inc = 3;
   
    void Start()
    {
        src = getComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move(); 
    }
    void move()
    {
       if (Inpot.GetKeydown(keycode.D))
        {
            transform.position = new vector3(Mathf.clamp(transform.position.x + inc, Minpos.position.x, Maxpos.position.x), transform.position.y, transform.position.z);
        }
       else if (Inpot.Getkeydown(keyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, Minpos.position.x, Maxpos.position.x), transform.position.y, transform.position.z);
        }
    }
   private void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            src.play();
            scenemanager.loadscene(0);
        }
    }

}


}
}
