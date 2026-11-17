using UnityEngine;


public class MoveLeft : MonoBehaviour
{
   private int currentSpeed;
   private Vector3 startPos;
   private float repeatWidth;
   private Rigidbody rigidbody;


   void Start()
   {
       rigidbody = GetComponent<Rigidbody>();
       startPos = transform.position;
       repeatWidth = (GetComponent<BoxCollider>().size.x * transform.localScale.x) / 3; 
   }


   // Update is called once per frame
   void FixedUpdate()
   {
       currentSpeed = GameManager.Instance.speed;
       MoveToTheLeft();
       DeleteOutOfScene();
       MoveToStart();
   }


   // Moves the attached GameObject left in the scene
   private void MoveToTheLeft()
   {
       if(!GameManager.Instance.gameOver)
       {
           //transform.Translate(Vector3.left * Time.deltaTime * currentSpeed);
           rigidbody.linearVelocity = Vector3.left * currentSpeed;
       }
   }


   // Removes any Obstacle tagged game object if it falls below ground level.
   private void DeleteOutOfScene()
   {
       if (gameObject.tag == "Obstacle" && transform.position.y < 0)
       {
           Destroy(gameObject);
       }
   }


   private void MoveToStart()
   {
       if(gameObject.tag == "Background" && transform.position.x < startPos.x - repeatWidth)
       {
           transform.position = startPos;
       }
   }
}
