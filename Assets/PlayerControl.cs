using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed;

	public Direction direction;

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		this.direction = Direction.EAST;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Movement ();
	}

	void Movement()
	{
		if(Input.GetKey (KeyCode.D))
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
			this.direction = Direction.EAST;
			anim.Play ("WalkRight");
		}
		
		else if(Input.GetKey (KeyCode.A))
		{
			transform.Translate (-Vector2.right * 4f * Time.deltaTime);
			this.direction = Direction.WEST;
			anim.Play ("WalkRight");
			transform.eulerAngles = new Vector2(0, 180);
		}

		else 
			{
				if(this.direction == Direction.EAST)
					{
						anim.Play("idle");
					}
				else anim.Play ("idleLeft");
			}	
	
	}
	
	public enum Direction
	{
		EAST, WEST
	}
	

}
