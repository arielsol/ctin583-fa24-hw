using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
Homework Problems

It is Barbie's Birthday and she is hosting a birthday party!
We are in a 2D World celebrating Barbie's Birthday and we are getting ready to break the pinata. 
First, we would like to position Barbie and the pinata correctly. 

Barbie is 5'9'' or 1.75 meters tall. 
She is standing 2 feet or 0.6 meters away from the her party pinata.
The party pinata is hanging 8.2 feet or 2.5 meters high from the ground.
Assume that the angles between the distance of the pinata to the ground and Barbie's distance to the pinata create a 90 degree angle. 

TODO: Problem 1: Barbie is holding a bat to swing at the pinata. What should be the magnitude the bat should swing at? Make sure the check for edge cases including:
        * Barbie has only three chances to swing at the pinata before it is the next player's turn
        * If Barbie runs out of turns, a message should display that Barbie's turn is over and it is the next player's turn

        The magnitude of the bat = the hypotenuse of the triangle with sides (distance between barbie and pinata)
        and (difference of height between barbie and pinata). 
        Using the pythagorean theorem, hypotenuse^2 = 0.6^2 + 0.75^2. The hypotenuse length is 0.9605 meters.
        I would round the magnitude of the bat up to 0.961 meters to ensure it collides with the pinata. 

        The general case of this solution is Mathf.Sqrt(Mathf.Pow(barbieToPinataDistance.x, 2) +  Mathf.Pow(pinataHeight - barbieHeight, 2))
*/ 
public class BarbieBirthday : MonoBehaviour
{
    // Transform for Barbie's party pinata
    [SerializeField] Transform pinata; 

    // The pinata's rotation along the X axis for the first successful hit (Quaternion)
    [SerializeField] Quaternion rotationX;

    // The pinata's rotation along the Y axis for the second successful hit (Quaternion)
    [SerializeField] Quaternion rotationY;

    // Particle System for the third successful hit
    [SerializeField] ParticleSystem candyExplosion;

    // Barbie's height is Barbie is 5'9'' or 1.75 meters tall
    private Vector2 barbieHeight;

    // Barbie is standing 2 feet or 0.6 meters away from the her party pinata
    private Vector2 barbieToPinataDistance;

    // The party pinata is hanging 8.2 feet or 2.5 meters high from the ground
    private Vector2 pinataHeight;

    // Update is called once per frame
    void Update()
    {
        /*
        TODO: Problem 2: Barbie can only make a valid swing when she is looking directly at the pinata. She cannot swing at other objects, players, and items. 
        Check to make sure that Barbie is facing directly at the pinata. 
        * Hint: The target should be the pinata
        * Hint: Make the object points towards the object. Look at returns a quaterion and takes in a vector
        
        [SerializeField] Transform barbie; // Transform for Barbie

        Vector3 directionNormalized = (pinata.position - barbie.position).normalized; // Vector from barbie to pinata
        Vector3 barbieDirection = barbie.forward; // Barbie's forward vector
        float threshold = 0.99f; // Margin of error for looking at pinata

        if (Vector3.Dot(barbieDirection, directionNormalized) > threshold) // Is barbie facing pinata?
        {
            if (Input.anyKeyDown) // Substitute for any player input
            {
                // Swing the Bat
                // Trigger event for bat swing
            }
        }
        
        */      
        Vector2 relativePosition = pinata.position - pinata.position; // = (0,0) ?

        /*
        TODO: Problem 3: Barbie swings her bat and the bat hits the pinata. The pinata is now rotating along the x axis.
        If Barbie hits the bat again, we want the pinata to spin along the x axis and the y axis. How do we get the correct overall rotation of the pinata?
            * Hint: Think about quaternions. Why and how should we multiply a quaternion by a vector (say with Quaternion.Euler) and save it as a temporary variable?
            * Example: result = Quaternion.Euler(0,rotation, 0) * result;
            * Hint: Check if two Quaternions are equal to each other. If they are, print out "[Names of Quaterions] are Equal". Else, print out "Quaternions are different"
            * Hint: How can we rotate our vector? Can we use Quaternion.Lerp and Quaternion.Slerp?

        [SerializeField] private float rotationSpeed = 1f;

        Quaternion previousRotation = pinata.rotation;

        // On bat swing event trigger:
            previousRotation = pinata.rotation;

            // Rotate on X axis
            Quaternion rotateX = pinata.rotation;
            rotateX *= Quaternion.Euler(rotationSpeed * Time.deltaTime, 0, 0);
            pinata.rotation *= Quaternion.Slerp(pinata.rotation, rotateX, Time.deltaTime);
            
            if (Quaternion.eulerAngles.x(previousRotation) != Quaternion.eulerAngles.x(pinata.rotation)) // Is the pinata rotating on the X axis?
            {
                // Rotate on Y axis
                Quaternion rotateY = pinata.rotation;
                rotateY *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
                pinata.rotation *= Quaternion.Slerp(pinata.rotation, rotateY, Time.deltaTime);
            }


        */
    }
}