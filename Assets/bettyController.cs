using UnityEngine;
using System.Collections;

public class bettyController : MonoBehaviour {

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
		if(Input.GetKey (KeyCode.J))
		{
			transform.Translate(Vector2.right * 4f * Time.deltaTime);
			this.direction = Direction.EAST;
			anim.Play ("BettyWalkRight");
		}
		
		else if(Input.GetKey (KeyCode.L))
		{
			transform.eulerAngles = new Vector2(0, 180);
			transform.Translate (-Vector2.right * 4f * Time.deltaTime);
			this.direction = Direction.WEST;
			anim.Play ("BettyWalkRight");
		}
		
		else 
		{
			if(this.direction == Direction.EAST)
			{
				anim.Play("BettyIdleRight");
			}
			else anim.Play ("BettyIdleLeft");
		}	
		
	}
	
	public enum Direction
	{
		EAST, WEST
	}
}
