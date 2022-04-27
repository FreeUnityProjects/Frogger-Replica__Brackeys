using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;
	private Vector2 inputVec;
	private float speed = 0.1f;
	public void OnMove(InputValue input)
	{
		inputVec = input.Get<Vector2>();
		// moveVec = new Vector3(inputVec.x, 0, inputVec.y);
	}


	void Update () {
		rb.MovePosition(rb.position + (speed * inputVec));

	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Car")
		{
			Debug.Log("WE LOST!");
			Score.CurrentScore = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
