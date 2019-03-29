using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Gameplay/Timed Self-Destruct")]
public class TimedSelfDestruct : MonoBehaviour
{
    public GameObject effect;

	// After this time, the object will be destroyed
	public float timeToDestruction;


	void Start ()
	{
		Invoke("DestroyMe", timeToDestruction);
	}


	// This function will destroy this object :(
	void DestroyMe()
	{
        if(effect != null)
        {
            Instantiate(effect, transform.position, transform.rotation);
        }

		Destroy(gameObject);

		// Bye bye!
	}
}
