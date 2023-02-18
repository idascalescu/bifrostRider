using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour
{
	[SerializeField]
	Vector3 shootTarget;

	[SerializeField]
	GameObject collisionExplosion;

	[SerializeField]
	float speed;
	
	// Update is called once per frame
	void Update()
	{
		float step = speed * Time.deltaTime;

		if (shootTarget != null)
		{
			if (transform.position == shootTarget)
			{
				Explode();
				return;
			}
			transform.position = Vector3.MoveTowards(transform.position, shootTarget, step);
		}
	}
	public void setTarget(Vector3 target)
	{
		shootTarget = target;
	}

	void Explode()
	{
		if (collisionExplosion != null)
		{
			GameObject explosion = (GameObject)Instantiate(collisionExplosion, transform.position, transform.rotation);
			Destroy(gameObject);
			Destroy(explosion, 1.0f);
		}
	}
}
