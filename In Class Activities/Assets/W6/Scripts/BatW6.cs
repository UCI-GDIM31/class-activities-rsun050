using UnityEngine;
using UnityEngine.UIElements;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
	[SerializeField] float speed;
	[SerializeField] Transform target_transform;

	void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, target_transform.position, speed * Time.deltaTime);
	}

	public void ChasePlayer()
	{
		enabled = true;
	}
	
	public void StopChasingPlayer()
	{
		enabled = false;
	}
}
