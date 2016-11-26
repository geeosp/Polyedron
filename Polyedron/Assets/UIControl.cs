using UnityEngine;
using System.Collections;

public class UIControl : MonoBehaviour {
    /* essa classe é so de teste, ela vai precisar ser modificada, suas funcoes dvem ser integradas no projeto
     * por exemplo, as fncones do PlayerAnimation provavelmente vao ficar pro playerControl
     * 
     * 
     * 
     */
    public PlayerAnimation player;
	
	public void NextTransform()
    {
        player.nextTransform();

    }
    public void PreviousTransform()
    {
        player.previousTransform();
    }
    public void DoAction (){
        player.doAction();
    }


}
