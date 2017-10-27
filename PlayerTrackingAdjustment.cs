//This script adjusts the player's rig depending on whether VR is configured for roomscale or standing experiences. 

using UnityEngine;
using UnityEngine.VR;

public class PlayerTrackingAdjustment : MonoBehaviour 
{
	void Start () 
	{
		//Roomscale VR will track a player's actual height while playing. As such, we need to position the camera on
		//the ground and the player will be the correct height in the game
		if (UnityEngine.XR.XRDevice.GetTrackingSpaceType () == UnityEngine.XR.TrackingSpaceType.RoomScale)
		{
			//Log the tracking type and position the rig on the ground
			VRLog.Log ("Roomscale Tracking");
			transform.position = Vector3.zero;
		}
		else
			VRLog.Log ("Stationary Tracking");
	}
}
