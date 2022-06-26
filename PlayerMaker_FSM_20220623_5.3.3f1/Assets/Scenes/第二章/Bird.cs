using UnityEngine;
using System.Collections;

public class Bird : MonoBehaviour {


    Rigidbody2D rgb2d;
    public PlayMakerFSM fsm;
    bool isGameOver = false;

    void Awake()
    {
        rgb2d = GetComponent<Rigidbody2D>();
        fsm = GetComponent<PlayMakerFSM>();
    }

    public	void AddForce (Vector2 force)
   {
        //消力
        rgb2d.velocity = new Vector2(rgb2d.velocity.x, 0f );
        rgb2d.AddForce( force);

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (isGameOver == true) return;
            isGameOver = true;
       
            fsm.SendEvent( "GameOver");
        

    }
}
