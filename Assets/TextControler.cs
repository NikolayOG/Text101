using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextControler : MonoBehaviour 
{

	public Text text;
	private enum States {cell,mirror,sheets_0,lock_0,cell_mirror,cell_mirror_finish,lock_finish,sheets_1,lock_1,freedom};
	private States nextState;

	// Use this for initialization
	void Start ()
	 {
		//text.text="Hello World";
		nextState=States.cell;
	}
	
	// Update is called once per frame
	void Update () 
	{
		print (nextState);
		if(nextState==States.cell)
		{
			stateCell ();
		}
		else if(nextState==States.sheets_0)
		{
			stateSheets_0 ();
		}
		else if(nextState==States.mirror)
		{
			stateMirror ();
		}
		else if(nextState==States.cell_mirror)
		{
			stateCellMirror ();
		}
		else if(nextState==States.lock_0)
		{
			stateLock_0 ();
		}
		else if(nextState==States.sheets_1)
		{
			stateSheets_1 ();
		}
		else if(nextState==States.lock_1)
		{
			stateLock_1 ();
		}
		else if(nextState==States.cell_mirror_finish)
		{
			stateCellMirrorFinish ();
		}
		else if(nextState==States.lock_finish)
		{
			stateLockFinish ();
		}
		else if(nextState==States.freedom)
		{
			stateFreedom ();
		}
	}
	
	//What will happen in the cell
	void stateCell ()
	{
		text.text="One morning you woke up in a prison cell, without any single memory of" 
					+ " how you got there. Are you going to stay here as a convicted criminal? I don't" 
					+ " think so. If you want to escape there are some dirty sheets on the bed, a mirror" 
					+ " on the wall and the locked door. Good luck.\n\n"
					+ "Press S to view Sheets.\n"
					+ "Press M to view Mirror.\n" 
					+ "Press L to view Lock.";
					
		if (Input.GetKeyDown(KeyCode.S))
		{
			nextState=States.sheets_0;
		}
		else if (Input.GetKeyDown(KeyCode.M))
		{
			nextState=States.mirror;
		}
		else if (Input.GetKeyDown(KeyCode.L))
		{
			nextState=States.lock_0;
		}
	}
		
	//what will happen in the stateSheets_0
	void stateSheets_0 ()
	{
		text.text="That is disgusting you drunk freak, how could you have slept on those sheets." 
				+ " Surely it is time someone to change them.\n\n" 
				+ "Press R to Return to roaming your cell.";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			nextState=States.cell;
		}
	} 
	
	//what will happen in the stateMirror
	void stateMirror ()
	{
		text.text="You look at your reflextion and notice a huge tattoo on your forehead, after you." 
				+ " shake off you read what is written... 'KUR' . Furiously you hit the mirror and"
				+ " and break it into small pieces. Luckily you find a hidden old note.\n\n" 
				+ "Press R to Return to roaming your cell.\n"
				+ "Press T to Take the note.";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			nextState=States.cell;
		}
		else if (Input.GetKeyDown(KeyCode.T))
		{
			nextState=States.cell_mirror;
		}
	}
	 
	void stateLock_0 ()
	{
		text.text="This is one of these eight numbers combination locks. having a little bit of math." 
				+ " skills you find out that there are 100000000 combinations and you are not sober"
				+ " enought to try all of them.\n\n" 
				+ "Press R to Return to roaming your cell.";
		
		if (Input.GetKeyDown(KeyCode.R))
		{
			nextState=States.cell;
		}
	}
	
	void stateCellMirror ()
	{
		text.text="You open the old piece of paper and read the following.\n\n"
				+ "'The first four numbers are 4973. You will find the other part of the code under your"
				+ " bed's mattress.\n\n"
				+ "Press B to view your Bed.\n"
				+ "Press L to view Lock.";
				
		if(Input.GetKeyDown(KeyCode.B))
		{
			nextState=States.sheets_1;
		}
		else if(Input.GetKeyDown(KeyCode.L))
		{
			nextState=States.lock_1;
		}
	}
	
	void stateSheets_1 ()
	{
		text.text="After you turned backward your bed's mattress you read the following word.\n\n"
				+ "The other four numbers are 1583. Good luck after passing over this door."
				+ " THIS IS JUST THE BEGGING.\n\n"
				+ "Press R to Return to the cell.";
				
		if(Input.GetKeyDown(KeyCode.R))
		{
			nextState=States.cell_mirror_finish;
		}
	}
	
	void stateLock_1 ()
	{
		text.text="You need the whole combination to open the door. Find the other part and come back.\n\n"
				+ "Press R to Return to the cell.";
			
		if(Input.GetKeyDown(KeyCode.R))
		{
			nextState=States.cell_mirror;
		}
	}
	
	void stateCellMirrorFinish ()
	{
		text.text="Well Done! Now you have the whole combination - 49731583.\n\n"
				+ "Press L to go to the Lock.";
						
		if(Input.GetKeyDown(KeyCode.L))
		{
			nextState=States.lock_finish;
		}
	}
	
	void stateLockFinish ()
	{
		text.text="Now the final moment... Click,Click,Click.\n\n"
				+ "Press O to Open the door.";
						
		if(Input.GetKeyDown(KeyCode.O))
		{
			nextState=States.freedom;
		}		
	}
	
	void stateFreedom ()
	{
		text.text="Congratulation my drunk friend. Good luck because this is just beginig.\n\n"
			+ "Press Enter to Start Again.";
		
		if(Input.GetKeyDown(KeyCode.Return))
		{
			nextState=States.cell;
		}		
	}
	
}
