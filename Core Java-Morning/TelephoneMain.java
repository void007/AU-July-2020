import java.io.*;
import java.util.*;

abstract class Telephone{

      abstract public void dial();
	   public void cut(){
		   System.out.println("You have cut the call");
	   }
	   public void hold(){
		   System.out.println("Your call has been put on hold");
	   }
	  abstract public void busy();
	  abstract public void receive();
	  abstract public void ringing();
	  
	  

}



class TelephoneExtend extends Telephone{
	static boolean oncall=false;
	static boolean wannacut=false;
	static boolean wannamerge=false;
	static boolean isunreachable=true;
	
	public void dial(){
		System.out.println("dialing the number");
	}
	
	public void ringing(){
		System.out.println("Phone is Ringing");
	}
	public void busy(){
		if(oncall){
			System.out.println("Dialed number is busy");
		}
	}
	
	public void receive(){
		if(oncall){
			talking();
		}
		else{
			oncall=true;
			System.out.println("Receive the call");
		}
		
	}
	
	public void talking(){
		System.out.println("DO you wanna cut the phone-1 or Merge the phone-2 or Put other on hold-3");
		Scanner scan = new Scanner(System.in);
        System.out.print("Enter your choice: ");
        int a= scan.nextInt();
		int f=0;
		while(f==0){
		if(a==1){
			wannacut=true;
			System.out.println("You have cut the other call");
			f=1;
		}
		else if(a==2){
			wannamerge=true;
			System.out.println("Woah!You are in a conference call");
			f=1;
		}
		else if(a==3){
			System.out.println("Putting first person on hold");
			f=1;
		}
		else{
			System.out.println("press the right key");
        a= scan.nextInt();
		}
		}
		
	}
	
	public void voicemail(){
		if(isunreachable){
			System.out.println("You are in voicemail..start speaking");
		}
		
	}
	
	public void getcallRecords(){
		System.out.println("Getting call records...");
	}
	
	public void checkVoiceMail(){
		if(isunreachable){
			System.out.println("You have some voicemail");
		}
		else{
			isunreachable=false;
			System.out.println("You have no voicemail");
		}
	}
	
	
	
	
}

public class TelephoneMain{
  public static void main(String args[]){
	  
	  Telephone t=new TelephoneExtend();
	  t.dial();
	  t.busy();
	  t.receive();
	  
	  Telephone t1=new TelephoneExtend();
	  t1.dial();
	  t1.busy();
	  t1.receive();
	  
	  
	  
  }


}