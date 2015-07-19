using UnityEngine;
using System.Collections;

public class bettyController : MonoBehaviour {

	public float speed;
	
	public Direction direction;
	
	public Animator bettyAnim;

	bool isBetty = false;
	
	// Use this for initialization
	void Start ()
	 {
		bettyAnim = GetComponent<Animator>();
		this.direction = Direction.EAST;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Movement ();
	}
	
	void Movement()
	{
		if(Input.GetKey (KeyCode.I))
		{
			transform.Translate(Vector2.up * 3f * Time.deltaTime);
		}

		if(Input.GetKey (KeyCode.J))
		{
			transform.Translate(-Vector2.right * 4f * Time.deltaTime);
			this.direction = Direction.WEST;

			if(isBetty)
			{
				bettyAnim.Play ("BettyWalkLeft");
			}
			else 
			{
				bettyAnim.Play ("BruceWalkLeft");
			}
		}
		
		else if(Input.GetKey (KeyCode.L))
		{
//			transform.eulerAngles = new Vector2(0, 180);
			transform.Translate (Vector2.right * 4f * Time.deltaTime);
			this.direction = Direction.EAST;

			if(isBetty)
			{
				bettyAnim.Play ("BettyWalkRight");
			}	
			else 
			{
				bettyAnim.Play ("BruceWalkRight");
			}
		}

			else if(Input.GetKeyDown (KeyCode.H))
			{
				if(isBetty)
				{
					if(this.direction == Direction.EAST)
					{
						bettyAnim.Play ("BettyPunchRight");
						
					}
					else 
					{
						bettyAnim.Play ("BettyPunchLeft");
					}
					//				BoxCollider2D collider = GetComponent<BoxCollider2D>();
					//				collider.size = 1;
				}
				else
				{
					if(this.direction == Direction.EAST)
					{
						bettyAnim.Play ("BrucePunchRight");
					}
					else {
						bettyAnim.Play ("BrucePunchLeft");
					}
				}
			}
			
			else if(Input.GetKeyDown(KeyCode.U))
			{
				if(isBetty)
				{
					if(this.direction == Direction.EAST)
					{
						bettyAnim.Play ("BettyKickRight");
					}
					else 
					{
						bettyAnim.Play ("BettyKickLeft");
					}
				}
				else
				{	
					if(this.direction == Direction.EAST)
					{
						bettyAnim.Play ("BruceKickRight");
					}
					else {
						bettyAnim.Play ("BruceKickLeft");
					}
				}
			}
	}
	
	public enum Direction
	{
		EAST, WEST
	}
}
