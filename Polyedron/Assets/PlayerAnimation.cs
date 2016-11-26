using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour {

	string [] forms = new string[] {
			"circle", 
		"triangle",
		"square"
	};
	int actualForm = 0;
	Animator anim;






	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown (KeyCode.D)) {
            nextTransform();

        } else if (Input.GetKeyDown (KeyCode.S)) {
            previousTransform();

        } else if (Input.GetKeyDown (KeyCode.A)) {
            doAction();
		}
	}
    public void nextTransform()
    {
        int nextForm = (actualForm + 1) % forms.Length;
        anim.Play(forms[actualForm] + "-"+ forms[nextForm]);
        this.actualForm = nextForm;

    }
    public void previousTransform()
    {
        int nextForm = (forms.Length+actualForm - 1) % forms.Length;
        anim.Play(forms[actualForm] + "-" + forms[nextForm]);
        this.actualForm = nextForm;

    }
    public void doAction()
    {
        anim.Play(forms[actualForm] + "-action");
    }

}
