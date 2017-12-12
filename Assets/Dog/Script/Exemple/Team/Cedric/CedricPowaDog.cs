using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CedricPowaDog : Dog
{
	#region Public Members

		public Rigidbody m_rigidbody;

	#endregion

	#region Public void
 public override void Bark(float volume, float frequence)
    {
        if(volume<0.5f && volume>0f)
            Debug.Log("Wouf, Wouff!");
        else if (volume > 0.5f && volume<1f)
            Debug.Log("WOUF wouf!");
        else if(volume>1)
            Debug.Log("WOUOUOUOUOUOUOUFHFHFFHFFF");
        else
            Debug.LogWarning("No Bark o_O");
    }

    public override void Jump(float heighCm)
    {
        //TODO Add the jump to the dog
        // Can be RigidBody
        // Transform
        // Animation
    	m_rigidbody.AddForce(heighCm * Vector3.up * 0.1f, ForceMode.Impulse);
    }

	#endregion

	#region System

		void Start ()
		{
			
		}
	
		void Update ()
		{
			
		}

	#endregion

	#region Tools Debug And Utility

	#endregion

	#region Private and Protected Members

	#endregion
}
