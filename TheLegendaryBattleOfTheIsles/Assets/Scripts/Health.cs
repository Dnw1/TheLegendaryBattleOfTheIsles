using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	[SerializeField]private float BaseHp;
	[SerializeField]private float EnemyHp;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	private void BaseHealth(){
		BaseHp = 10;
	}
	private void EnemyHealth(){
		EnemyHp = 2;
	}
}
/*public int startingHealth = 100;            // The amount of health the enemy starts the game with.
public int currentHealth;                   // The current health the enemy has.

CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
bool isDead;                                // Whether the enemy is dead.
bool isSinking;                             // Whether the enemy has started sinking through the floor.


void Awake ()
{
	// Setting up the references.
	capsuleCollider = GetComponent <CapsuleCollider> ();
	// Setting the current health when the enemy first spawns.
	currentHealth = startingHealth;
}
public void TakeDamage (int amount, Vector3 hitPoint)
{
	// If the enemy is dead...
	if(isDead){
		// ... no need to take damage so exit the function.
		return;
	}
	
	// Reduce the current health by the amount of damage sustained.
	currentHealth -= amount;
	// If the current health is less than or equal to zero...
	if(currentHealth <= 0)
	{
		// ... the enemy is dead.
		Death ();
	}
}


void Death ()
{
	// The enemy is dead.
	isDead = true;
}


public void StartSinking ()
{
	// Find and disable the Nav Mesh Agent.
	GetComponent <NavMeshAgent> ().enabled = false;
	
	// Find the rigidbody component and make it kinematic (since we use Translate to sink the enemy).
	GetComponent <Rigidbody> ().isKinematic = true;
	
	// The enemy should no sink.
	isSinking = true;
	
	// Increase the score by the enemy's score value.
	ScoreManager.score += scoreValue;
	
	// After 2 seconds destory the enemy.
	Destroy (gameObject, 2f);
}
}*/
