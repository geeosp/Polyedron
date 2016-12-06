using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class PlayerControl : MonoBehaviour {

	public float force = 100;
	public Rigidbody2D rb;
	public bool jump = true;
    string[] forms = new string[] {
            "circle",
            "triangle",
            "square"
    };
    int actualForm = 0;
    Animator anim;
    // Update is called once per frame

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }
    void Update () {
        if (Input.GetKeyDown(KeyCode.D))
        {
            nextTransform();

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            previousTransform();

        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            doAction();
        }


        if (jump && Input.GetButton ("Jump")) {
			Jump ();
			jump = false;
		}
	}
    public void nextTransform()
    {
        int nextForm = (actualForm + 1) % forms.Length;
        anim.Play(forms[actualForm] + "-" + forms[nextForm]);
        this.actualForm = nextForm;

    }
    public void previousTransform()
    {
        int nextForm = (forms.Length + actualForm - 1) % forms.Length;
        anim.Play(forms[actualForm] + "-" + forms[nextForm]);
        this.actualForm = nextForm;

    }
    public void doAction()
    {
        anim.Play(forms[actualForm] + "-action");
        switch (actualForm)
        {
            case 0: //circle


                break;

            case 1: //triangle


                break;

            case 2: //square



                break;


        }



    }

  




    void Jump() {
		GetComponent<Rigidbody2D>().AddForce(new Vector3(0, force, 0), ForceMode2D.Force); 
	}

	void OnCollisionEnter2D(Collision2D other) {
			jump = true;
	}
}
