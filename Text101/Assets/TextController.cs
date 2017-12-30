using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TextController : MonoBehaviour {

    public Text gameText;

    private enum States { cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom, nothing};

    private States myState;
    
    // Use this for initialization
	void Start () {
        myState = States.cell;		
	}
	
	// Update is called once per frame
	void Update () {
        print(myState);
        if (myState == States.cell)
        {
            state_cell();
        } else if (myState == States.sheets_0) {
            state_sheets_0();
        } else if (myState == States.lock_0) {
          state_lock_0();
        } else if (myState == States.lock_1) {
            state_lock_1();
        } else if (myState == States.sheets_1) {
            state_sheets_1();
        } else if (myState == States.mirror) {
            state_mirror();
        } else if (myState == States.cell_mirror) {
            state_cell_mirror();
        } else if (myState == States.freedom) {
            state_freedom();
        } else if (myState == States.nothing) {
            state_nothing();
        }        
	}

    void state_cell()
    {
        gameText.text =     "You've been wrongfully sentenced to prison and you are desperate " +
                            "to escape. You look around and clearly understand that staying in " +
                            "this prison is only goign to lead to your own death, whether it be by your own hands " +
                            "or someone elses.\n\n" + "You notice that there are some dirty (S)heets on the bed, " +
                            "A (M)irror in the corner, and a the door is (L)ocked from the outside. Or you know, you could always decide to do (N)othing at all.";

        if(Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_0;
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            myState = States.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            myState = States.nothing;
        }
    }

    void state_sheets_0()
    {
        gameText.text =     "You walk over to glance at the sheets, they are disgusting. " +
                            "You are absolutely disgusted in the fact that you sleep in these things " +
                            "it's probably you change them in the near future. You half-ass in making your cot " +
                            "and decide it would probably be best to (R)eturn to roaming your cell. "; 
                            

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_lock_0()
    {
        gameText.text =     "You walk over to the lock on the cell. You can tell it's one of those push button locks, " +
                            "you're careful in ensuring that you don't touch any of the buttons, but you think to yourself " +
                            "'if only I had some way to see what the buttons were!' You decide to (R)eturn to looking around your cell.";
        if(Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }


    }

    void state_mirror()
    {
        gameText.text =     "You notice something glinting in the light and decide to walk over to it. After closer inspection, " +
                            "you notice that it's a piece of a mirror that had broken off from the wall. Thinking this may be of some " +
                            "use to you later, you decide to hold on to it for a minute and (R)eturn to browsing around you cell.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }


    }

    void state_cell_mirror()
    {
        gameText.text =     "Now with the mirror in your hand you decide to look around you cell some more. Nothing has really changed " +
                            "except for the fact that you now have a mirror in your hand. You notice the (S)heets on the bed and take " +
                            "another glance at the (L)ock on the cell.";
        if (Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_1;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sheets_1;
        }


    }
    void state_lock_1()
    {
        gameText.text =     "You walk over to the lock on the cell, this time with the mirror in hand. You extend your hands through " +
                            "the cell bars and use the mirror to inspect the keypad in hopes of recent finger prints. You notice some wear " +
                            "on some of the keys and decide to hit the same buttons. An audible thunk is heard as the lock drops to the ground. " +
                            "The cell door creeks over and you decide to take your (F)reedom";

        if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.freedom;
        }


    }

    void state_sheets_1()
    {
        gameText.text =     "You walk over to the sheets on the bed..they are still disgusting...you don't understand " +
                            "what having a mirror in your hand would do to change that so you decide to (R)eturn to looking around the cell";
                            

        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell_mirror;
        }


    }

    void state_freedom()
    {
        gameText.text =     "You push open the door and decide to take your first steps towards freedom. You become so anxious  " +
                            "you burst into a sprint. Tears of joy start to leak from your eyes and you can only hope to return back to your normal life. " +
                            "Suddenly a hard thud comes to the back of your head and loud screaming as a group of guards gather around you and start to beat the " +
                            "everloving shit out of you.\n\nTHIS IS PRISON BOY...DID YOU REALLY THINK YOU WERE GOING TO BREAK OUT WITH A...... MIRROR!? REALLY KID??\n" +
                            "All you really did was get time added to your sentence....Good job kid...\n\n===========END============";
       


    }

    void state_nothing()
    {
        gameText.text =     "You decide to sit your happy ass on your dirty bed and do nothing and serve your time...honestly probably the best choice. " +
                            "Five years go by and you are freed after one of your family members has a lawyer look into your case. \nYou grab your things and " +
                            "and go home. \n\n-----THE END-----";
                            
        

    }

}
