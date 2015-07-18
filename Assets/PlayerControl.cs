using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

	public float speed;

	public Direction direction;

	public Animator anim;

	bool isJones = true;

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

		if(Input.GetKey (KeyCode.W))
		{
			transform.Translate(Vector2.up * 6f * Time.deltaTime);
		}

		if(Input.GetKey (KeyCode.D))
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
			this.direction = Direction.EAST;	

			if(isJones)
			{
				anim.Play ("WalkRight");
			}
			else
			{
				anim.Play ("OllieWalkRight");
			}

		}
		
		else if(Input.GetKey (KeyCode.A))
		{
			transform.Translate (-Vector2.right * 4f * Time.deltaTime);
			this.direction = Direction.WEST;

			if(isJones)
			{
				anim.Play ("WalkLeft");
			}
			else 
			{
				anim.Play("OllieWalkLeft");
			}
//			transform.eulerAngles = new Vector2(0, 180);
		}

		else if(Input.GetKeyDown (KeyCode.F))
		{
			if(isJones)
			{
				if(this.direction == Direction.EAST)
				{
					anim.Play ("PunchRight");
					
				}
				else 
					{
					anim.Play ("PunchLeft");
					}
//				BoxCollider2D collider = GetComponent<BoxCollider2D>();
//				collider.size = 1;
			}
			else
			{
				if(this.direction == Direction.EAST)
				{
					anim.Play ("OlliePunchRight");
				}
				else {
					anim.Play ("OlliePunchLeft");
				}
			}
		}
		
		else if(Input.GetKeyDown(KeyCode.E))
		{
			if(isJones)
			{
				if(this.direction == Direction.EAST)
				{
					anim.Play ("KickRight");
				}
				else 
				{
					anim.Play ("KickLeft");
				}
			}
			else
			{	
				if(this.direction == Direction.EAST)
				{
					anim.Play ("OllieKickRight");
				}
				else {
					anim.Play ("OllieKickLeft");
				}
			}
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		print ("this happened");
	}
	
	public enum Direction
	{
		EAST, WEST
	}
	

}
